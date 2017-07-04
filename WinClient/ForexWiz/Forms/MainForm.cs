using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using DevComponents.DotNetBar;
using System.Deployment;
using LeoStudio.ForexWiz.Parser;
using LeoStudio.ForexWiz.Entity;
using System.Reflection;

namespace LeoStudio.ForexWiz.Forms
{
    public delegate void SetNotifyIconDelegate(long loop);
    public delegate void SetNotifyIconShowBalloonDelegate(ParseResult pr);
    public partial class MainForm : Office2007RibbonForm
    {
        int balloonTimeout = 10;

        public int BalloonTimeout
        {
            get { return balloonTimeout; }
            set { balloonTimeout = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            this.comboBoxEx_news.SelectedIndex = 0;
            this.comboBoxEx_event.SelectedIndex = 0;
            this.comboBoxEx_tech.SelectedIndex = 0;
            this.integerInput_balloon.Value = balloonTimeout;

            this.groupPanel_eurusd.Visible = this.checkBoxX_price.Checked;
            this.groupPanel_gbpusd.Visible = this.checkBoxX_price.Checked;
            this.groupPanel_audusd.Visible = this.checkBoxX_price.Checked;
            this.groupPanel_usdchf.Visible = this.checkBoxX_price.Checked;
            this.groupPanel_usdjpy.Visible = this.checkBoxX_price.Checked;
            this.groupPanel_usdcad.Visible = this.checkBoxX_price.Checked;

            Version ver = this.GetType().Assembly.GetName().Version;
            this.Text = System.Reflection.Assembly.GetEntryAssembly().GetName().Name + " " + ver.Major + "." + ver.Minor;
            this.labelX_Name.Text = this.Text;
            this.notifyIcon.Text = this.Text;

            Screen[] screens = Screen.AllScreens;
            Screen screen = screens[0];//获取屏幕变量
            this.Location = new Point(screen.WorkingArea.Width - this.ClientSize.Width - 8, screen.WorkingArea.Height - this.ClientSize.Height - 28);
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowBalloon(ParseResult pr)
        {
            if (this.labelX_looptime.InvokeRequired)
            {
                SetNotifyIconShowBalloonDelegate d = new SetNotifyIconShowBalloonDelegate(ShowBalloon);
                this.Invoke(d, new object[] { pr });
            }
            else
            {
                notifyIcon.ShowBalloonTip(balloonTimeout * 1000, pr.Type + " " + pr.Title, "\n" + pr.Content, ToolTipIcon.None);
            }
        }

        public void PrintLoopTime(long i)
        {
            if (this.labelX_looptime.InvokeRequired)
            {
                SetNotifyIconDelegate d = new SetNotifyIconDelegate(PrintLoopTime);
                this.Invoke(d, new object[] { i });
            }
            else
            {
                this.labelX_looptime.Text = i.ToString();
                //notifyIcon.Text = "DailyFX Loop=" + i.ToString();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("真的要退出程序么？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                this.notifyIcon.Visible = false;
                System.Environment.Exit(0);
                Application.ExitThread();
                this.Close();
                Application.Exit();
            }
        }

        private void 设置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ribbonControl1.SelectedRibbonTabItem = ribbonTabItem_Alert;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void integerInput_balloon_ValueChanged(object sender, EventArgs e)
        {
            this.balloonTimeout = this.integerInput_balloon.Value;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ribbonControl1.SelectedRibbonTabItem = ribbonTabItem_About;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void 价格提醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ribbonControl1.SelectedRibbonTabItem = ribbonTabItem_Content;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            e.Cancel = true;
        }

        private void buttonX_sendmail_Click(object sender, EventArgs e)
        {
            //if (textBoxX_youemail.Text == "")
            //{
            //    MessageBoxEx.Show("请输入您的邮箱地址方便与你联系", "请输入邮箱地址", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.textBoxX_youemail.Focus();
            //    return;
            //}
            //else if (!textBoxX_youemail.Text.Contains("@"))
            //{
            //    MessageBoxEx.Show("请输入正确邮箱地址", "请输入正确邮箱地址", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.textBoxX_youemail.Focus();
            //    return;
            //}
            //if (this.textBoxX_mailcontent.Text == "")
            //{
            //    MessageBoxEx.Show("请输入内容", "请输入内容", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.textBoxX_mailcontent.Focus();
            //    return;
            //}

            //try
            //{
            //    Email.SendMail(textBoxX_youemail.Text,textBoxX_youemail.Text, textBoxX_mailcontent.Text);
            //    MessageBoxEx.Show("邮件发送成功", "发送成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBoxEx.Show(ex.Message, "邮件发送失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.textBoxX_mailcontent.Focus();
            //    return;
            //}
        }


        private void buttonX_Contact_Click(object sender, EventArgs e)
        {
            ContactForm cf = new ContactForm();
            cf.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Type att = typeof(AssemblyTrademarkAttribute);
            object[] r = this.GetType().Assembly.GetCustomAttributes(att, false);
            AssemblyTrademarkAttribute aa = (AssemblyTrademarkAttribute)r[0];
            System.Diagnostics.Process.Start(aa.Trademark);
        }

    }
}
