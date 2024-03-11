using NetUtils;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TraceRoute
{
   public partial class IpTraceForm : Form
   {
      private const int FixedColumnsCount = 3;
      private readonly IPRouteTracer _tracer;

      public IpTraceForm()
      {
         InitializeComponent();
         _tracer = new IPRouteTracer(null, (int)NumericUpDownInterval.Value, (int)NumericUpDownRetries.Value, (int)NumericUpDownPingsPerHop.Value, (int)NumericUpDownBufferSize.Value);
         _tracer.OnTraceStarted += Tracer_OnTraceStart;
         _tracer.OnTraceCompleted += Tracer_OnTraceCompleted;
         _tracer.OnHopSuccess += Tracer_OnHopSuccess;
         _tracer.OnHopPing += Tracer_OnHopPing;
         _tracer.OnHopFail += Tracer_OnHopFail;
         AddColumn();
      }

      private ListViewItem FindListViewItem(IPRouteHop hop)
      {
         foreach (object obj in ListViewRouteList.Items)
         {
            ListViewItem listViewItem = (ListViewItem)obj;
            if (listViewItem.Tag == hop)
            {
               return listViewItem;
            }
         }
         return null;
      }

      private void EnableSettings(bool enable)
      {
         TextBoxGoalTracking.Enabled = NumericUpDownInterval.Enabled = NumericUpDownRetries.Enabled = NumericUpDownPingsPerHop.Enabled = NumericUpDownBufferSize.Enabled = enable;
         ButtonTrace.Text = enable ? "Следующий" : "Остановка";
      }

      private void AddColumn()
      {
         ColumnHeader columnHeader = new ColumnHeader
         {
            Text = (ListViewRouteList.Columns.Count + 1 - 3).ToString(),
            DisplayIndex = ListViewRouteList.Columns.Count,
            Width = 50,
            TextAlign = HorizontalAlignment.Right
         };
         ListViewRouteList.Columns.Add(columnHeader);
      }

      private void Tracer_OnTraceStart(IPRouteTracer tracer)
      {
         if (InvokeRequired)
         {
            BeginInvoke(new IPRouteTracer.StartTraceDelegate(Tracer_OnTraceStart), tracer);
            return;
         }
         foreach (object obj in ListViewRouteList.Items)
         {
            ((IPRouteHop)((ListViewItem)obj).Tag).OnHostNameAvailable -= Hop_OnHostNameAvailable;
         }
         ListViewRouteList.Items.Clear();
         EnableSettings(false);
      }

      private void Tracer_OnTraceCompleted(IPRouteTracer tracer, IPRouteTracer.TraceStatus status)
      {
         if (InvokeRequired)
         {
            BeginInvoke(new IPRouteTracer.TraceCompletedDelegate(Tracer_OnTraceCompleted), tracer, status);
            return;
         }
         EnableSettings(true);
         LabelStatus.Text = string.Concat("Статус: Отслеживание до [", tracer.Target, "] ", IPRouteTracer.TraceStatusNames[(int)status]);
      }

      private void Tracer_OnHopSuccess(IPRouteTracer tracer, IPRouteHop hop)
      {
         if (InvokeRequired)
         {
            BeginInvoke(new IPRouteTracer.HopDelegate(Tracer_OnHopSuccess), tracer, hop);
            return;
         }
         ListViewItem listViewItem = new ListViewItem(hop.Hop.ToString())
         {
            Tag = hop
         };
         listViewItem.SubItems.Add(hop.Address.ToString());
         listViewItem.SubItems.Add("");
         ListViewRouteList.Items.Add(listViewItem);
         hop.OnHostNameAvailable += Hop_OnHostNameAvailable;
         listViewItem.SubItems[2].Text = hop.HostName;
         LabelStatus.Text = string.Concat("Статус: Прыжок ", hop.Hop, " [", hop.Address, "] успешный");
      }

      private void Hop_OnHostNameAvailable(IPRouteHop hop)
      {
         if (InvokeRequired)
         {
            BeginInvoke(new IPRouteHop.HostNameAvailableDelegate(Hop_OnHostNameAvailable), hop);
            return;
         }
         ListViewItem listViewItem = FindListViewItem(hop);
         if (listViewItem != null)
         {
            listViewItem.SubItems[2].Text = hop.HostName;
         }
      }

      private void Tracer_OnHopPing(IPRouteTracer tracer, IPRouteHop hop)
      {
         if (InvokeRequired)
         {
            BeginInvoke(new IPRouteTracer.HopDelegate(Tracer_OnHopPing), tracer, hop);
            return;
         }
         ListViewItem listViewItem = FindListViewItem(hop);
         long num = hop.ResponseTimes[hop.PingsCompleted - 1];
         listViewItem.SubItems.Add((num < 0L) ? "*" : (num + " ms"));
      }

      private void Tracer_OnHopFail(IPRouteTracer tracer, int hop, int retry, IPAddress address, IPStatus status)
      {
         if (InvokeRequired)
         {
            BeginInvoke(new IPRouteTracer.HopFailDelegate(Tracer_OnHopFail), tracer, hop, retry, address, status);
            return;
         }
         LabelStatus.Text = string.Concat("Статус: Прыжок ", hop, " не удалось. Ответ от [", address, "]: \"", status.ToString(), "\". Повторить попытку: ", retry, ".");
      }

      private void SpnTimeout_ValueChanged(object sender, EventArgs e) { _tracer.Timeout = (int)NumericUpDownInterval.Value; }

      private void SpnBufferSize_ValueChanged(object sender, EventArgs e) { _tracer.PingBufferSize = (int)NumericUpDownBufferSize.Value; }

      private void SpnPingsPerHop_ValueChanged(object sender, EventArgs e)
      {
         _tracer.PingsPerHop = (int)NumericUpDownPingsPerHop.Value;

         int columns = _tracer.PingsPerHop + FixedColumnsCount;

         for (int i = ListViewRouteList.Columns.Count - 1; i >= columns; i--)
            ListViewRouteList.Columns.RemoveAt(i);

         for (int i = ListViewRouteList.Columns.Count; i < columns; i++)
            AddColumn();
      }

      private void SpnRetries_ValueChanged(object sender, EventArgs e) { _tracer.HopRetries = (int)NumericUpDownRetries.Value; }

      private void ButtonTrace_Click(object sender, EventArgs e)
      {
         if (_tracer.Active)
         {
            _tracer.Stop(false);
            return;
         }
         try
         {
            IPHostEntry hostEntry = Dns.GetHostEntry(TextBoxGoalTracking.Text);
            if (hostEntry.AddressList.Length > 1)
            {
               ChooseIpForm chooseIpForm = new ChooseIpForm();
               if (chooseIpForm.ShowDialog(this, hostEntry.AddressList) == DialogResult.OK)
               {
                  _tracer.Target = chooseIpForm.SelectedIpAddress;
               }
            }
            else
            {
               _tracer.Target = hostEntry.AddressList[0];
            }
            _tracer.Start();
         }
         catch (SocketException)
         {
            MessageBox.Show(this, @"Не удается разрешить имя хоста", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
         }
         catch
         {
            MessageBox.Show(this, @"Не удается разобрать имя хоста или IP-адрес", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
         }
      }

      private void IpTraceForm_Load(object sender, EventArgs e)
      {

      }
   }
}