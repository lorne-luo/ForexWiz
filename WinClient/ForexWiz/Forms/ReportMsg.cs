using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DevComponents.DotNetBar;
using LeoStudio.ForexWiz.Parser;

namespace LeoStudio.Forms
{
    public partial class ReportMsg : Office2007Form
    {
        private Point point = new Point(0, 0);
        private string text;
        private SolidBrush textbrush = new SolidBrush(Color.FromArgb(40, 40, 40));
        private Font font = new Font("Arial", 9);
        private int heightMax, widthMax;
        private bool isShowAD = false;

        private int stayTime = 8;

        public int StayTime
        {
            get { return stayTime; }
            set { stayTime = value; }
        }

        public int WidthMax
        {
            set
            {
                widthMax = value;
            }
            get
            {
                return widthMax;
            }
        }

        public ReportMsg()
        {

            Thread.CurrentThread.ApartmentState = System.Threading.ApartmentState.STA;
            InitializeComponent();
            label_title.BackColor = Color.Transparent;
            label_title.ForeColor = Color.FromArgb(40, 40, 40);
            font = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size + 0.6f);
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Navigate("http://leandro.132.china123.net/forexwiz/ad.php");
        }

        private void ReportMsg_Load(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            Screen screen = screens[0];//获取屏幕变量
            this.Location = new Point(screen.WorkingArea.Width - this.Width - 3, screen.WorkingArea.Height - 30);

            this.timer1.Interval = 10;
            this.timer3.Interval = 10;
            this.timer2.Interval = stayTime * 1000;
        }

        [BrowsableAttribute(true)]
        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }

        public void ShowWindow(ParseResult pr)
        {
            Screen[] screens = Screen.AllScreens;
            Screen screen = screens[0];//获取屏幕变量
            this.Location = new Point(screen.WorkingArea.Width - this.Width - 3, screen.WorkingArea.Height - 30);
            this.Text = pr.Type + " " + pr.Title;
            text = "";
            if (pr.Time != null && pr.Time != "")
                text = "@" + pr.Time + "\n";
            text += pr.Content.Trim();
            this.richTextBox1.Text = text;

            int line = 0; 
            foreach (string l in this.richTextBox1.Lines)
            {
                line += this.richTextBox1.GetLineFromCharIndex(l.Length)+1;
            }
            // = this.richTextBox1.GetLineFromCharIndex(this.richTextBox1.Text.Length) + this.richTextBox1.Lines.Length - 1;
            //if (line == 0 && !string.IsNullOrEmpty(this.richTextBox1.Text)) line = 1;
            line--;
            if (line < 4 && isShowAD)
            {
                this.richTextBox1.Dock = DockStyle.Top;
                this.richTextBox1.Height = line * (this.richTextBox1.Font.Height + 2);
                this.webBrowser1.Visible = true;
                //this.webBrowser1.Navigate("http://www.luotao.net/forexwiz/ad.php");
                this.heightMax = line * (this.richTextBox1.Font.Height + 2) + 25 + Convert.ToInt32(this.webBrowser1.DocumentTitle);
            }
            else
            {
                this.richTextBox1.Dock = DockStyle.Fill;
                this.webBrowser1.Visible = false;
                this.heightMax = line * (this.richTextBox1.Font.Height + 2) + 50;
            }
            this.Height = 10;

            this.Show();
            this.timer1.Enabled = true;
        }

        public void ShowList(List<ParseResult> prList)
        {
            this.Text = "";
            text = "";

            foreach (ParseResult item in prList)
            {
                text += item.Type + " " + item.Title + " " + item.Time + "\n";
                text += item.Content + "\n\n\n";
            }
        }
         
        private void ScrollUp()
        {
            if (Height < heightMax)
            {
                this.Show();
                this.Height += 5;
                this.Location = new Point(this.Location.X, this.Location.Y - 5);
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer2.Enabled = true;
            }
        }

        private void ScrollDown()
        {
            //Height低于27就-不下去了
            if (Height < 28)
            {
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;
                if (this.webBrowser1.Visible)
                {
                    this.webBrowser1.Navigate("http://www.luotao.net/forexwiz/ad.php");
                }
                this.Hide();
            }
            else
            {
                this.Height -= 9;
                this.Location = new Point(this.Location.X, this.Location.Y + 9);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ScrollUp();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = true;
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            ScrollDown();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void ReportMsg_FormClosing(object sender, FormClosingEventArgs e)
        {
            ScrollDown();
            e.Cancel = true;
        }
    }
}