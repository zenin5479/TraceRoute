namespace TraceRoute
{
   partial class ChooseIpForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.ButtonSelect = new System.Windows.Forms.Button();
         this.ListBoxIpAdresses = new System.Windows.Forms.ListBox();
         this.LabelSelect = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // ButtonSelect
         // 
         this.ButtonSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.ButtonSelect.Location = new System.Drawing.Point(275, 185);
         this.ButtonSelect.Name = "ButtonSelect";
         this.ButtonSelect.Size = new System.Drawing.Size(75, 23);
         this.ButtonSelect.TabIndex = 8;
         this.ButtonSelect.Text = "Выбрать";
         this.ButtonSelect.UseVisualStyleBackColor = true;
         this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
         // 
         // ListBoxIpAdresses
         // 
         this.ListBoxIpAdresses.FormattingEnabled = true;
         this.ListBoxIpAdresses.Location = new System.Drawing.Point(12, 45);
         this.ListBoxIpAdresses.Name = "ListBoxIpAdresses";
         this.ListBoxIpAdresses.Size = new System.Drawing.Size(338, 134);
         this.ListBoxIpAdresses.TabIndex = 7;
         this.ListBoxIpAdresses.SelectedIndexChanged += new System.EventHandler(this.ListBoxIpAdresses_SelectedIndexChanged);
         // 
         // LabelSelect
         // 
         this.LabelSelect.Location = new System.Drawing.Point(9, 9);
         this.LabelSelect.Name = "LabelSelect";
         this.LabelSelect.Size = new System.Drawing.Size(341, 33);
         this.LabelSelect.TabIndex = 6;
         this.LabelSelect.Text = "Для указанного имени хоста обнаружено несколько IP-адресов. Пожалуйста, выберите " +
    "один:";
         this.LabelSelect.Click += new System.EventHandler(this.LabelSelect_Click);
         // 
         // ChooseIpForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(362, 214);
         this.Controls.Add(this.ButtonSelect);
         this.Controls.Add(this.ListBoxIpAdresses);
         this.Controls.Add(this.LabelSelect);
         this.Name = "ChooseIpForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Выбор IP-адреса";
         this.Load += new System.EventHandler(this.ChooseIpForm_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button ButtonSelect;
      private System.Windows.Forms.ListBox ListBoxIpAdresses;
      private System.Windows.Forms.Label LabelSelect;
   }
}