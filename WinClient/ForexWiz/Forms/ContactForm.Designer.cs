namespace LeoStudio.ForexWiz.Forms
{
    partial class ContactForm
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
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_youemail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX_sendmail = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX_mailcontent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // labelX21
            // 
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.Class = "";
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Location = new System.Drawing.Point(12, 7);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(63, 23);
            this.labelX21.TabIndex = 44;
            this.labelX21.Text = "你的邮箱";
            // 
            // textBoxX_youemail
            // 
            // 
            // 
            // 
            this.textBoxX_youemail.Border.Class = "TextBoxBorder";
            this.textBoxX_youemail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_youemail.Location = new System.Drawing.Point(76, 7);
            this.textBoxX_youemail.Name = "textBoxX_youemail";
            this.textBoxX_youemail.Size = new System.Drawing.Size(148, 21);
            this.textBoxX_youemail.TabIndex = 43;
            // 
            // buttonX_sendmail
            // 
            this.buttonX_sendmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_sendmail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_sendmail.Location = new System.Drawing.Point(230, 36);
            this.buttonX_sendmail.Name = "buttonX_sendmail";
            this.buttonX_sendmail.Size = new System.Drawing.Size(48, 63);
            this.buttonX_sendmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_sendmail.TabIndex = 42;
            this.buttonX_sendmail.Text = "OK";
            this.buttonX_sendmail.Click += new System.EventHandler(this.buttonX_sendmail_Click);
            // 
            // textBoxX_mailcontent
            // 
            // 
            // 
            // 
            this.textBoxX_mailcontent.Border.Class = "TextBoxBorder";
            this.textBoxX_mailcontent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_mailcontent.Location = new System.Drawing.Point(12, 36);
            this.textBoxX_mailcontent.Multiline = true;
            this.textBoxX_mailcontent.Name = "textBoxX_mailcontent";
            this.textBoxX_mailcontent.Size = new System.Drawing.Size(212, 63);
            this.textBoxX_mailcontent.TabIndex = 41;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 107);
            this.Controls.Add(this.labelX21);
            this.Controls.Add(this.textBoxX_youemail);
            this.Controls.Add(this.buttonX_sendmail);
            this.Controls.Add(this.textBoxX_mailcontent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报告BUG | 改进建议";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_youemail;
        private DevComponents.DotNetBar.ButtonX buttonX_sendmail;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_mailcontent;
    }
}