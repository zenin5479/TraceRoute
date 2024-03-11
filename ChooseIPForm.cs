using System;
using System.Net;
using System.Windows.Forms;

namespace TraceRoute
{
   public partial class ChooseIpForm : Form
   {
      public ChooseIpForm()
      {
         InitializeComponent();
      }

      public IPAddress SelectedIpAddress
      {
         get
         {
            if (ListBoxIpAdresses.SelectedItem == null)
            {
               return null;
            }
            return (IPAddress)ListBoxIpAdresses.SelectedItem;
         }
      }

      public DialogResult ShowDialog(Form parent, IPAddress[] addresses)
      {
         foreach (IPAddress item in addresses)
         {
            ListBoxIpAdresses.Items.Add(item);
         }
         ListBoxIpAdresses.SelectedIndex = 0;
         return ShowDialog(parent);
      }

      private void ChooseIpForm_Load(object sender, EventArgs e)
      {

      }

      private void ButtonSelect_Click(object sender, EventArgs e)
      {

      }

      private void ListBoxIpAdresses_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void LabelSelect_Click(object sender, EventArgs e)
      {

      }
   }
}
