using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using LeoStudio.Forms;
using System.Threading;
using LeoStudio;
using LeoStudio.Autoupdater;
using System.Xml;
using System.Net;
using LeoStudio.Entity;
using LeoStudio.ForexWiz.Forms;
using LeoStudio.ForexWiz.Parser;
using LeoStudio.ForexWiz.Entity;
using DevComponents.DotNetBar;

namespace LeoStudio.ForexWiz
{
    public class Main
    {
        private MainForm mainForm;
        public ReportMsg rm = new ReportMsg();

        private List<IHtmlParser> ParserList = new List<IHtmlParser>();
        public static List<AlertItem> AlertList = new List<AlertItem>();

        private System.Timers.Timer taskTimer = new System.Timers.Timer();
        private System.Timers.Timer alertTimer = new System.Timers.Timer();
        private int alertOffset = 3;//提醒提前分钟数
        private int loopInterval = 90;//循环间隔秒数
        private long loopTime;

        private QueueSequence<ParseResult> queue = new QueueSequence<ParseResult>(5);
        private User user = new User();

        DailyFX_News news = new DailyFX_News();
        DailyFX_Price price = new DailyFX_Price();
        DailyFX_Tech tech = new DailyFX_Tech();
        DailyFX_Calendar calendar = new DailyFX_Calendar();

        public Main()
        {
            if (!Login())
            {
                MessageBoxEx.Show("连接失败", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Environment.Exit(0);
                Application.ExitThread();
                Application.Exit();
            }

            ParserList.Add(price);
            ParserList.Add(calendar);
            ParserList.Add(tech);
            ParserList.Add(news);
            //ParserList.Add(new Waihuihandan());
            //ParserList.Add(new QWeibo("zhiqianghj"));
            //ParserList.Add(new QWeibo("huayuan609"));

            mainForm = new MainForm();
            news.Enabled = mainForm.checkBoxX_news.Checked;
            tech.Enabled = mainForm.checkBoxX_tech.Checked;
            calendar.Enabled = mainForm.checkBoxX_event.Checked;
            price.Enabled = mainForm.checkBoxX_price.Checked;


            mainForm.Shown += new System.EventHandler(this.MainForm_FirstShown);
            mainForm.ribbonControl1.SelectedRibbonTabChanged += new System.EventHandler(this.ribbonControl1_SelectedRibbonTabChanged);
            mainForm.最近消息ToolStripMenuItem.Click += new System.EventHandler(this.最近消息ToolStripMenuItem_Click);
            mainForm.checkBoxX_news.CheckedChanged += new System.EventHandler(this.checkBoxX_news_CheckedChanged);
            mainForm.checkBoxX_tech.CheckedChanged += new System.EventHandler(this.checkBoxX_tech_CheckedChanged);
            mainForm.checkBoxX_price.CheckedChanged += new System.EventHandler(this.checkBoxX_price_CheckedChanged);
            mainForm.checkBoxX_event.CheckedChanged += new System.EventHandler(this.checkBoxX_event_CheckedChanged);
            mainForm.checkBoxX_eurusd.CheckedChanged += new System.EventHandler(this.checkBoxX_eurusd_CheckedChanged);
            mainForm.comboBoxEx_news.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx_news_SelectedIndexChanged);
            mainForm.comboBoxEx_event.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx_event_SelectedIndexChanged);
            mainForm.comboBoxEx_tech.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx_tech_SelectedIndexChanged);

            Application.Run(mainForm);
        }

        private void MainForm_FirstShown(object sender, EventArgs e)
        {
            //taskTimer_Elapsed(null, null);
            taskTimer.Interval = 1 * 1000;//启动后多久开始循环
            taskTimer.Elapsed += new ElapsedEventHandler(taskTimer_Elapsed);
            taskTimer.Start();

            alertTimer.Interval = 1 * 1000;
            alertTimer.Elapsed += new ElapsedEventHandler(alertTimer_Elapsed);
            //alertTimer.Start();
        }

        //监视
        void taskTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (DateTime.UtcNow.DayOfWeek == DayOfWeek.Saturday || DateTime.UtcNow.DayOfWeek == DayOfWeek.Sunday)
            {
                taskTimer.Interval = 3600 * 1000;
                taskTimer.Start();
                return;
            }
            taskTimer.Stop();
            if (price.Enabled)
            {
                CheckPrice();
            }
            foreach (IHtmlParser item in ParserList)
            {
                if (!item.Enabled) continue;

                if (DateTime.Now > item.NextCheckTime)
                {
                    ParseResult pr = item.Parse();

                    if (pr.NotifyType != NotifyType.None)
                    {
                        queue.InsertQueue(pr);
                    }
                    ShowAlert(pr);
                }
            }

            //提醒
            for (int i = 0; i < AlertList.Count; i++)
            {
                if (DateTime.Now > AlertList[i].Time.AddMinutes(0 - alertOffset))
                {
                    ParseResult p = new ParseResult(AlertList[i].Content.Time, "日历提醒", AlertList[i].Content.Time + "(" + alertOffset + "分钟后)", AlertList[i].Content.Content, AlertList[i].Content.NotifyType);
                    if (p.NotifyType != NotifyType.None)
                    {
                        queue.InsertQueue(p);
                    }

                    ShowAlert(p);
                    //删除过期提醒
                    AlertList.Remove(AlertList[i]);
                    i--;
                }
            }
            loopTime++;
            mainForm.PrintLoopTime(loopTime);
            taskTimer.Interval = loopInterval * 1000;
            taskTimer.Start();
        }

        //提醒
        void alertTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }

        public void SendMail(ParseResult pr, string sendTo)
        {
            try
            {
                Email.SendMail(sendTo, pr.Title, pr.Content);

            }
            catch (Exception e)
            {
                throw new Exception("邮件发送失败:" + e.Message);
            }
        }

        public void ShowMessageBox(ParseResult pr)
        {
            MessageBoxEx.Show(pr.Time + " " + pr.Title + "\n" + pr.Content, pr.Type, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ribbonControl1_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (mainForm.ribbonControl1.SelectedRibbonTabItem == mainForm.ribbonTabItem_Message)
            {
                最近消息ToolStripMenuItem_Click(null, null);
            }
        }

        private void 最近消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ParseResult> prList = this.queue.GetList();
            mainForm.rtb_message.Text = string.Empty;
            mainForm.rtb_message.Text = string.Empty;
            foreach (ParseResult item in prList)
            {
                if (item.NotifyType != 0 && item.NotifyType != NotifyType.None)
                {
                    mainForm.rtb_message.Text = item.Type + " " + item.Title + " " + item.Time + "\n" + item.Content + "\n\n======================================\n" + mainForm.rtb_message.Text;
                }
            }
            mainForm.ribbonControl1.SelectedRibbonTabItem = mainForm.ribbonTabItem_Message;
            mainForm.WindowState = FormWindowState.Normal;
            mainForm.ShowInTaskbar = true;
        }

        private void checkBoxX_tech_CheckedChanged(object sender, EventArgs e)
        {
            tech.Enabled = mainForm.checkBoxX_tech.Checked;
        }

        private void checkBoxX_news_CheckedChanged(object sender, EventArgs e)
        {
            news.Enabled = mainForm.checkBoxX_news.Checked;
        }

        private void checkBoxX_price_CheckedChanged(object sender, EventArgs e)
        {
            price.Enabled = mainForm.checkBoxX_price.Checked;
            mainForm.groupPanel_eurusd.Visible = mainForm.checkBoxX_price.Checked;
            mainForm.groupPanel_gbpusd.Visible = mainForm.checkBoxX_price.Checked;
            mainForm.groupPanel_audusd.Visible = mainForm.checkBoxX_price.Checked;
            mainForm.groupPanel_usdchf.Visible = mainForm.checkBoxX_price.Checked;
            mainForm.groupPanel_usdjpy.Visible = mainForm.checkBoxX_price.Checked;
            mainForm.groupPanel_usdcad.Visible = mainForm.checkBoxX_price.Checked;
        }

        private void checkBoxX_event_CheckedChanged(object sender, EventArgs e)
        {
            calendar.Enabled = mainForm.checkBoxX_event.Checked;
        }

        private void checkBoxX_eurusd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckPrice()
        {
            if (mainForm.checkBoxX_eurusd.Checked || mainForm.checkBoxX_gbpusd.Checked ||
                mainForm.checkBoxX_usdjpy.Checked || mainForm.checkBoxX_usdchf.Checked ||
                mainForm.checkBoxX_audusd.Checked || mainForm.checkBoxX_usdcad.Checked)
            {
                price.Parse();
                ParseResult pr = new ParseResult();
                pr.NotifyType = price.NotifyType;

                if (mainForm.checkBoxX_eurusd.Checked)
                {

                    price.CurrDict["EURUSD"].Exceed = (float)mainForm.doubleInput_eurup.Value;
                    price.CurrDict["EURUSD"].Breakdown = (float)mainForm.doubleInput_eurdown.Value;

                    if (price.CurrDict["EURUSD"].Exceed != 0f && price.CurrDict["EURUSD"].Price > price.CurrDict["EURUSD"].Exceed)
                    {
                        pr.Content += "EURUSD" + " 突破 " + price.CurrDict["EURUSD"].Exceed + "\n";
                        price.CurrDict["EURUSD"].Exceed = 0f;
                        mainForm.doubleInput_eurup.Value = 0;
                    }
                    if (price.CurrDict["EURUSD"].Breakdown != 0f && price.CurrDict["EURUSD"].Price < price.CurrDict["EURUSD"].Breakdown)
                    {
                        pr.Content += "EURUSD" + " 下破 " + price.CurrDict["EURUSD"].Breakdown + "\n";
                        price.CurrDict["EURUSD"].Breakdown = 0f;
                        mainForm.doubleInput_eurdown.Value = 0;
                    }
                }
                else
                {
                    price.CurrDict["EURUSD"].Exceed = 0f;
                    price.CurrDict["EURUSD"].Breakdown = 0f;
                    mainForm.doubleInput_eurup.Value = 0;
                    mainForm.doubleInput_eurdown.Value = 0;
                }
                if (mainForm.checkBoxX_gbpusd.Checked)
                {
                    price.CurrDict["GBPUSD"].Exceed = (float)mainForm.doubleInput_gbpup.Value;
                    price.CurrDict["GBPUSD"].Breakdown = (float)mainForm.doubleInput_gbpdown.Value;
                    if (price.CurrDict["GBPUSD"].Exceed != 0f && price.CurrDict["GBPUSD"].Price > price.CurrDict["GBPUSD"].Exceed)
                    {
                        pr.Content += "GBPUSD" + " 突破 " + price.CurrDict["GBPUSD"].Exceed + "\n";
                        price.CurrDict["GBPUSD"].Exceed = 0f;
                        mainForm.doubleInput_gbpup.Value = 0;
                    }
                    if (price.CurrDict["GBPUSD"].Breakdown != 0f && price.CurrDict["GBPUSD"].Price < price.CurrDict["GBPUSD"].Breakdown)
                    {
                        pr.Content += "GBPUSD" + " 下破 " + price.CurrDict["GBPUSD"].Breakdown + "\n";
                        price.CurrDict["GBPUSD"].Breakdown = 0f;
                        mainForm.doubleInput_gbpdown.Value = 0;
                    }
                }
                else
                {
                    price.CurrDict["GBPUSD"].Exceed = 0f;
                    price.CurrDict["GBPUSD"].Breakdown = 0f;
                    mainForm.doubleInput_gbpup.Value = 0;
                    mainForm.doubleInput_gbpdown.Value = 0;
                }
                if (mainForm.checkBoxX_usdjpy.Checked)
                {
                    price.CurrDict["USDJPY"].Exceed = (float)mainForm.doubleInput_usdjpyup.Value;
                    price.CurrDict["USDJPY"].Breakdown = (float)mainForm.doubleInput_usdjpydown.Value;
                    if (price.CurrDict["USDJPY"].Exceed != 0f && price.CurrDict["USDJPY"].Price > price.CurrDict["USDJPY"].Exceed)
                    {
                        pr.Content += "USDJPY" + " 突破 " + price.CurrDict["USDJPY"].Exceed + "\n";
                        price.CurrDict["USDJPY"].Exceed = 0f;
                        mainForm.doubleInput_usdjpyup.Value = 0;
                    }
                    if (price.CurrDict["USDJPY"].Breakdown != 0f && price.CurrDict["USDJPY"].Price < price.CurrDict["USDJPY"].Breakdown)
                    {
                        pr.Content += "USDJPY" + " 下破 " + price.CurrDict["USDJPY"].Breakdown + "\n";
                        price.CurrDict["USDJPY"].Breakdown = 0f;
                        mainForm.doubleInput_usdjpydown.Value = 0;
                    }
                }
                else
                {
                    price.CurrDict["USDJPY"].Exceed = 0f;
                    price.CurrDict["USDJPY"].Breakdown = 0f;
                    mainForm.doubleInput_usdjpydown.Value = 0;
                    mainForm.doubleInput_usdjpyup.Value = 0;
                }
                if (mainForm.checkBoxX_usdchf.Checked)
                {
                    price.CurrDict["USDCHF"].Exceed = (float)mainForm.doubleInput_usdchfup.Value;
                    price.CurrDict["USDCHF"].Breakdown = (float)mainForm.doubleInput_usdchfdown.Value;
                    if (price.CurrDict["USDCHF"].Exceed != 0f && price.CurrDict["USDCHF"].Price > price.CurrDict["USDCHF"].Exceed)
                    {
                        pr.Content += "USDCHF" + " 突破 " + price.CurrDict["USDCHF"].Exceed + "\n";
                        price.CurrDict["USDCHF"].Exceed = 0f;
                        mainForm.doubleInput_usdchfup.Value = 0;
                    }
                    if (price.CurrDict["USDCHF"].Breakdown != 0f && price.CurrDict["USDCHF"].Price < price.CurrDict["USDCHF"].Breakdown)
                    {
                        pr.Content += "USDCHF" + " 下破 " + price.CurrDict["USDCHF"].Breakdown + "\n";
                        price.CurrDict["USDCHF"].Breakdown = 0f;
                        mainForm.doubleInput_usdchfdown.Value = 0;
                    }
                }
                else
                {
                    price.CurrDict["USDCHF"].Exceed = 0f;
                    price.CurrDict["USDCHF"].Breakdown = 0f;
                    mainForm.doubleInput_usdchfup.Value = 0;
                    mainForm.doubleInput_usdchfdown.Value = 0;
                }
                if (mainForm.checkBoxX_audusd.Checked)
                {
                    price.CurrDict["AUDUSD"].Exceed = (float)mainForm.doubleInput_audusdup.Value;
                    price.CurrDict["AUDUSD"].Breakdown = (float)mainForm.doubleInput_audusddown.Value;
                    if (price.CurrDict["AUDUSD"].Exceed != 0f && price.CurrDict["AUDUSD"].Price > price.CurrDict["AUDUSD"].Exceed)
                    {
                        pr.Content += "AUDUSD" + " 突破 " + price.CurrDict["AUDUSD"].Exceed + "\n";
                        price.CurrDict["AUDUSD"].Exceed = 0f;
                        mainForm.doubleInput_audusdup.Value = 0;
                    }
                    if (price.CurrDict["AUDUSD"].Breakdown != 0f && price.CurrDict["AUDUSD"].Price < price.CurrDict["AUDUSD"].Breakdown)
                    {
                        pr.Content += "AUDUSD" + " 下破 " + price.CurrDict["AUDUSD"].Breakdown + "\n";
                        price.CurrDict["AUDUSD"].Breakdown = 0f;
                        mainForm.doubleInput_audusddown.Value = 0;
                    }
                }
                else
                {
                    price.CurrDict["AUDUSD"].Exceed = 0f;
                    price.CurrDict["AUDUSD"].Breakdown = 0f;
                    mainForm.doubleInput_audusdup.Value = 0;
                    mainForm.doubleInput_audusddown.Value = 0;
                }
                if (mainForm.checkBoxX_usdcad.Checked)
                {
                    price.CurrDict["USDCAD"].Exceed = (float)mainForm.doubleInput_usdcadup.Value;
                    price.CurrDict["USDCAD"].Breakdown = (float)mainForm.doubleInput_usdcaddown.Value;
                    if (price.CurrDict["USDCAD"].Exceed != 0f && price.CurrDict["USDCAD"].Price > price.CurrDict["USDCAD"].Exceed)
                    {
                        pr.Content += "USDCAD" + " 突破 " + price.CurrDict["USDCAD"].Exceed + "\n";
                        price.CurrDict["USDCAD"].Exceed = 0f;
                        mainForm.doubleInput_usdcadup.Value = 0;
                    }
                    if (price.CurrDict["USDCAD"].Breakdown != 0f && price.CurrDict["USDCAD"].Price < price.CurrDict["USDCAD"].Breakdown)
                    {
                        pr.Content += "USDCAD" + " 下破 " + price.CurrDict["USDCAD"].Breakdown + "\n";
                        price.CurrDict["USDCAD"].Breakdown = 0f;
                        mainForm.doubleInput_usdcaddown.Value = 0;
                    }
                }
                else
                {
                    price.CurrDict["USDCAD"].Exceed = 0f;
                    price.CurrDict["USDCAD"].Breakdown = 0f;
                    mainForm.doubleInput_usdcaddown.Value = 0;
                    mainForm.doubleInput_usdcadup.Value = 0;
                }

                if (!string.IsNullOrEmpty(pr.Title) || !string.IsNullOrEmpty(pr.Content))
                {
                    pr.Title = "价格提醒";
                    ShowAlert(pr);
                }
            }
        }

        private bool Login()
        {
            //success|id|message|website
            bool b;
            try
            {
                string u = "http://leandro.132.china123.net/dghelper/forexwizlogs/login/" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                string s = HttpUtility.GetGB2312(u);
                if (s.Contains('|'))
                {
                    s = s.Split('|')[0];
                    b = Convert.ToBoolean(s);
                }
                else
                    b = false;
            }
            catch (Exception)
            {
                b = false;
            }

            return b;
        }

        public void ShowAlert(ParseResult pr)
        {
            switch (pr.NotifyType)
            {
                case NotifyType.Balloon:
                    mainForm.ShowBalloon(pr);
                    Thread.Sleep(mainForm.BalloonTimeout * 1000);
                    break;
                case NotifyType.Window:
                    rm.StayTime = mainForm.integerInput_window.Value;
                    SetNotifyIconShowBalloonDelegate d = new SetNotifyIconShowBalloonDelegate(rm.ShowWindow);
                    mainForm.Invoke(d, new object[] { pr });
                    Thread.Sleep((rm.StayTime + 2) * 1000);
                    break;
                case NotifyType.MessageBox:
                    ShowMessageBox(pr);
                    break;
                case NotifyType.Email:
                    SendMail(pr, mainForm.textBoxX_email.Text);
                    break;
                default:

                    break;
            }
        }

        //改变提醒方式
        private void comboBoxEx_news_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainForm.comboBoxEx_news.SelectedIndex == 0)
            {
                news.NotifyType = (NotifyType)4;
            }
            else if (mainForm.comboBoxEx_news.SelectedIndex == 1)
            {
                news.NotifyType = (NotifyType)2;
            }
        }
        private void comboBoxEx_event_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainForm.comboBoxEx_news.SelectedIndex == 0)
            {
                calendar.NotifyType = (NotifyType)4;
            }
            else if (mainForm.comboBoxEx_news.SelectedIndex == 1)
            {
                calendar.NotifyType = (NotifyType)2;
            }
        }
        private void comboBoxEx_tech_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainForm.comboBoxEx_news.SelectedIndex == 0)
            {
                tech.NotifyType = (NotifyType)4;
            }
            else if (mainForm.comboBoxEx_news.SelectedIndex == 1)
            {
                tech.NotifyType = (NotifyType)2;
            }
        }
    }

}
