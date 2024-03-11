namespace TraceRoute
{
   partial class IpTraceForm
   {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         this.ListViewRouteList = new System.Windows.Forms.ListView();
         this.Hop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.IPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.HostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.LabelStatus = new System.Windows.Forms.Label();
         this.LabelRepeatedTransition = new System.Windows.Forms.Label();
         this.LabelSignalsJump = new System.Windows.Forms.Label();
         this.NumericUpDownRetries = new System.Windows.Forms.NumericUpDown();
         this.NumericUpDownPingsPerHop = new System.Windows.Forms.NumericUpDown();
         this.LabelInterval = new System.Windows.Forms.Label();
         this.LabelBufferSize = new System.Windows.Forms.Label();
         this.NumericUpDownBufferSize = new System.Windows.Forms.NumericUpDown();
         this.NumericUpDownInterval = new System.Windows.Forms.NumericUpDown();
         this.ButtonTrace = new System.Windows.Forms.Button();
         this.TextBoxGoalTracking = new System.Windows.Forms.TextBox();
         this.LabelGoalTracking = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRetries)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPingsPerHop)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBufferSize)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInterval)).BeginInit();
         this.SuspendLayout();
         // 
         // ListViewRouteList
         // 
         this.ListViewRouteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ListViewRouteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hop,
            this.IPAddress,
            this.HostName});
         this.ListViewRouteList.GridLines = true;
         this.ListViewRouteList.HideSelection = false;
         this.ListViewRouteList.Location = new System.Drawing.Point(12, 93);
         this.ListViewRouteList.MultiSelect = false;
         this.ListViewRouteList.Name = "ListViewRouteList";
         this.ListViewRouteList.Size = new System.Drawing.Size(433, 248);
         this.ListViewRouteList.TabIndex = 40;
         this.ListViewRouteList.UseCompatibleStateImageBehavior = false;
         this.ListViewRouteList.View = System.Windows.Forms.View.Details;
         // 
         // Hop
         // 
         this.Hop.Text = "№";
         this.Hop.Width = 32;
         // 
         // IPAddress
         // 
         this.IPAddress.Text = "IP адрес";
         this.IPAddress.Width = 120;
         // 
         // HostName
         // 
         this.HostName.Text = "Имя хоста";
         this.HostName.Width = 150;
         // 
         // LabelStatus
         // 
         this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.LabelStatus.AutoSize = true;
         this.LabelStatus.Location = new System.Drawing.Point(9, 344);
         this.LabelStatus.Name = "LabelStatus";
         this.LabelStatus.Size = new System.Drawing.Size(182, 13);
         this.LabelStatus.TabIndex = 39;
         this.LabelStatus.Text = "Статус: Трассировка не запущена";
         // 
         // LabelRepeatedTransition
         // 
         this.LabelRepeatedTransition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.LabelRepeatedTransition.AutoSize = true;
         this.LabelRepeatedTransition.Location = new System.Drawing.Point(172, 69);
         this.LabelRepeatedTransition.Name = "LabelRepeatedTransition";
         this.LabelRepeatedTransition.Size = new System.Drawing.Size(172, 13);
         this.LabelRepeatedTransition.TabIndex = 36;
         this.LabelRepeatedTransition.Text = "Повторные попытки за переход:";
         // 
         // LabelSignalsJump
         // 
         this.LabelSignalsJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.LabelSignalsJump.AutoSize = true;
         this.LabelSignalsJump.Location = new System.Drawing.Point(232, 43);
         this.LabelSignalsJump.Name = "LabelSignalsJump";
         this.LabelSignalsJump.Size = new System.Drawing.Size(112, 13);
         this.LabelSignalsJump.TabIndex = 34;
         this.LabelSignalsJump.Text = "Сигналы за прыжок:";
         // 
         // NumericUpDownRetries
         // 
         this.NumericUpDownRetries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.NumericUpDownRetries.Location = new System.Drawing.Point(350, 67);
         this.NumericUpDownRetries.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
         this.NumericUpDownRetries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.NumericUpDownRetries.Name = "NumericUpDownRetries";
         this.NumericUpDownRetries.Size = new System.Drawing.Size(56, 20);
         this.NumericUpDownRetries.TabIndex = 37;
         this.NumericUpDownRetries.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
         this.NumericUpDownRetries.ValueChanged += new System.EventHandler(this.SpnRetries_ValueChanged);
         // 
         // NumericUpDownPingsPerHop
         // 
         this.NumericUpDownPingsPerHop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.NumericUpDownPingsPerHop.Location = new System.Drawing.Point(350, 41);
         this.NumericUpDownPingsPerHop.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
         this.NumericUpDownPingsPerHop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.NumericUpDownPingsPerHop.Name = "NumericUpDownPingsPerHop";
         this.NumericUpDownPingsPerHop.Size = new System.Drawing.Size(56, 20);
         this.NumericUpDownPingsPerHop.TabIndex = 35;
         this.NumericUpDownPingsPerHop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.NumericUpDownPingsPerHop.ValueChanged += new System.EventHandler(this.SpnPingsPerHop_ValueChanged);
         // 
         // LabelInterval
         // 
         this.LabelInterval.AutoSize = true;
         this.LabelInterval.Location = new System.Drawing.Point(9, 43);
         this.LabelInterval.Name = "LabelInterval";
         this.LabelInterval.Size = new System.Drawing.Size(59, 13);
         this.LabelInterval.TabIndex = 30;
         this.LabelInterval.Text = "Интервал:";
         // 
         // LabelBufferSize
         // 
         this.LabelBufferSize.AutoSize = true;
         this.LabelBufferSize.Location = new System.Drawing.Point(9, 69);
         this.LabelBufferSize.Name = "LabelBufferSize";
         this.LabelBufferSize.Size = new System.Drawing.Size(89, 13);
         this.LabelBufferSize.TabIndex = 32;
         this.LabelBufferSize.Text = "Размер буфера:";
         // 
         // NumericUpDownBufferSize
         // 
         this.NumericUpDownBufferSize.Location = new System.Drawing.Point(104, 67);
         this.NumericUpDownBufferSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
         this.NumericUpDownBufferSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.NumericUpDownBufferSize.Name = "NumericUpDownBufferSize";
         this.NumericUpDownBufferSize.Size = new System.Drawing.Size(60, 20);
         this.NumericUpDownBufferSize.TabIndex = 33;
         this.NumericUpDownBufferSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
         this.NumericUpDownBufferSize.ValueChanged += new System.EventHandler(this.SpnBufferSize_ValueChanged);
         // 
         // NumericUpDownInterval
         // 
         this.NumericUpDownInterval.Location = new System.Drawing.Point(74, 41);
         this.NumericUpDownInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.NumericUpDownInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.NumericUpDownInterval.Name = "NumericUpDownInterval";
         this.NumericUpDownInterval.Size = new System.Drawing.Size(90, 20);
         this.NumericUpDownInterval.TabIndex = 31;
         this.NumericUpDownInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this.NumericUpDownInterval.ValueChanged += new System.EventHandler(this.SpnTimeout_ValueChanged);
         // 
         // ButtonTrace
         // 
         this.ButtonTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ButtonTrace.Location = new System.Drawing.Point(350, 12);
         this.ButtonTrace.Name = "ButtonTrace";
         this.ButtonTrace.Size = new System.Drawing.Size(95, 23);
         this.ButtonTrace.TabIndex = 38;
         this.ButtonTrace.Text = "Трассировать";
         this.ButtonTrace.UseVisualStyleBackColor = true;
         this.ButtonTrace.Click += new System.EventHandler(this.ButtonTrace_Click);
         // 
         // TextBoxGoalTracking
         // 
         this.TextBoxGoalTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.TextBoxGoalTracking.Location = new System.Drawing.Point(127, 14);
         this.TextBoxGoalTracking.Name = "TextBoxGoalTracking";
         this.TextBoxGoalTracking.Size = new System.Drawing.Size(217, 20);
         this.TextBoxGoalTracking.TabIndex = 29;
         this.TextBoxGoalTracking.Text = "www.google.ru";
         // 
         // LabelGoalTracking
         // 
         this.LabelGoalTracking.AutoSize = true;
         this.LabelGoalTracking.Location = new System.Drawing.Point(9, 17);
         this.LabelGoalTracking.Name = "LabelGoalTracking";
         this.LabelGoalTracking.Size = new System.Drawing.Size(112, 13);
         this.LabelGoalTracking.TabIndex = 28;
         this.LabelGoalTracking.Text = "Отслеживание цели:";
         // 
         // IpTraceForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(457, 366);
         this.Controls.Add(this.ListViewRouteList);
         this.Controls.Add(this.LabelStatus);
         this.Controls.Add(this.LabelRepeatedTransition);
         this.Controls.Add(this.LabelSignalsJump);
         this.Controls.Add(this.NumericUpDownRetries);
         this.Controls.Add(this.NumericUpDownPingsPerHop);
         this.Controls.Add(this.LabelInterval);
         this.Controls.Add(this.LabelBufferSize);
         this.Controls.Add(this.NumericUpDownBufferSize);
         this.Controls.Add(this.NumericUpDownInterval);
         this.Controls.Add(this.ButtonTrace);
         this.Controls.Add(this.TextBoxGoalTracking);
         this.Controls.Add(this.LabelGoalTracking);
         this.Name = "IpTraceForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "TraceRoute";
         this.Load += new System.EventHandler(this.IpTraceForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRetries)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPingsPerHop)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBufferSize)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInterval)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListView ListViewRouteList;
      private System.Windows.Forms.ColumnHeader Hop;
      private System.Windows.Forms.ColumnHeader IPAddress;
      private System.Windows.Forms.ColumnHeader HostName;
      private System.Windows.Forms.Label LabelStatus;
      private System.Windows.Forms.Label LabelRepeatedTransition;
      private System.Windows.Forms.Label LabelSignalsJump;
      private System.Windows.Forms.NumericUpDown NumericUpDownRetries;
      private System.Windows.Forms.NumericUpDown NumericUpDownPingsPerHop;
      private System.Windows.Forms.Label LabelInterval;
      private System.Windows.Forms.Label LabelBufferSize;
      private System.Windows.Forms.NumericUpDown NumericUpDownBufferSize;
      private System.Windows.Forms.NumericUpDown NumericUpDownInterval;
      private System.Windows.Forms.Button ButtonTrace;
      private System.Windows.Forms.TextBox TextBoxGoalTracking;
      private System.Windows.Forms.Label LabelGoalTracking;
   }
}

