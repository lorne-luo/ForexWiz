namespace LeoStudio.Autoupdater
{
    partial class DownloadProgress
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadProgress));
            this.label_current = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBarTotal = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.progressBarCurrent = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.labelCurrentItem = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_current.Location = new System.Drawing.Point(388, 9);
            this.label_current.Name = "label_current";
            this.label_current.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_current.Size = new System.Drawing.Size(0, 12);
            this.label_current.TabIndex = 0;
            this.label_current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 57);
            this.panel1.TabIndex = 3;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_title.Location = new System.Drawing.Point(24, 19);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(71, 12);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "正在更新...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 55);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelEx1);
            this.panel2.Controls.Add(this.progressBarTotal);
            this.panel2.Controls.Add(this.progressBarCurrent);
            this.panel2.Controls.Add(this.labelCurrentItem);
            this.panel2.Controls.Add(this.label_total);
            this.panel2.Controls.Add(this.label_current);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelCurrent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 147);
            this.panel2.TabIndex = 4;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.buttonOk);
            this.panelEx1.Controls.Add(this.linkLabel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 105);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(436, 42);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 10;
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOk.Location = new System.Drawing.Point(336, 11);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "取消更新";
            this.buttonOk.Click += new System.EventHandler(this.OnCancel);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(24, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "手动更新";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // progressBarTotal
            // 
            // 
            // 
            // 
            this.progressBarTotal.BackgroundStyle.Class = "";
            this.progressBarTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarTotal.Location = new System.Drawing.Point(26, 75);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(385, 19);
            this.progressBarTotal.TabIndex = 9;
            this.progressBarTotal.Text = "progressBarX1";
            // 
            // progressBarCurrent
            // 
            // 
            // 
            // 
            this.progressBarCurrent.BackgroundStyle.Class = "";
            this.progressBarCurrent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarCurrent.Location = new System.Drawing.Point(26, 27);
            this.progressBarCurrent.Name = "progressBarCurrent";
            this.progressBarCurrent.Size = new System.Drawing.Size(385, 19);
            this.progressBarCurrent.TabIndex = 8;
            this.progressBarCurrent.Text = "progressBarX1";
            // 
            // labelCurrentItem
            // 
            this.labelCurrentItem.AutoSize = true;
            this.labelCurrentItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCurrentItem.Location = new System.Drawing.Point(75, 9);
            this.labelCurrentItem.Name = "labelCurrentItem";
            this.labelCurrentItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCurrentItem.Size = new System.Drawing.Size(0, 12);
            this.labelCurrentItem.TabIndex = 7;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_total.Location = new System.Drawing.Point(388, 57);
            this.label_total.Name = "label_total";
            this.label_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_total.Size = new System.Drawing.Size(0, 12);
            this.label_total.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "总进度";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCurrent.Location = new System.Drawing.Point(26, 9);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(47, 12);
            this.labelCurrent.TabIndex = 3;
            this.labelCurrent.Text = "更新中:";
            // 
            // DownloadProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(436, 204);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正在更新";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label labelCurrentItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarTotal;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarCurrent;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label_title;
    }
}