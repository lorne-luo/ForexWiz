using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeoStudio;
using HtmlAgilityPack;
using LeoStudio.Entity;
using System.Net;
using System.IO;
using System.Xml;
using LeoStudio.ForexWiz;

namespace LeoStudio.ForexWiz.Parser
{
    class DailyFX_Calendar : IHtmlParser
    {
        string todayCalendar;
        NotifyType alertNotifyType = NotifyType.Balloon;

        public DailyFX_Calendar()
            : base()
        {
            this.url = "http://leandro.132.china123.net/forex/calendar.php";
            this.NotifyType = NotifyType.Window;
            this.Type = "今日财经日历";
            result.Type = this.Type;
            this.XPathList.Add("./html/body/div[@id='container']/div[@id='content']/div[@id='contentLeft']/div[@class='listtable']/table");
            this.XPathList.Add("./html/body/div[@id='container']/div[@id='content']/div[@id='contentLeft']/div[@class='listtable-2tables bottom15']/table[1]/tr[2]/td[1]/div[1]/table[1]/tr");
        }

        public override ParseResult Parse()
        {
            string strRet = "";
            try
            {
                string timestr = "";
                string titlestr = "";
                string contentstr = "";

                strRet = HttpUtility.Get("http://leandro.132.china123.net/forex/calendar_htm.php");

                result = new ParseResult(this.Type);
                htmlDoc.LoadHtml(strRet);

                HtmlNode node = SelectSingleNode(XPathList[0]);
                HtmlNodeCollection event_list = node.SelectNodes("./tr");
                for (int i = 0; i < event_list.Count; i++)
                {
                    if (i == 0) continue;
                    if (event_list[i].SelectNodes("./td").Count > 1)
                    {
                        timestr = event_list[i].SelectSingleNode("./td[2]").InnerText;
                        titlestr = event_list[i].SelectSingleNode("./td[3]").InnerText;
                        contentstr = event_list[i].SelectSingleNode("./td[4]").InnerText;
                        result.Title = event_list[i].SelectSingleNode("./td[1]").InnerText;
                        result.Content += timestr + " " + titlestr + " " + contentstr + "\n";
                        if (timestr != "" && timestr.Contains(":"))
                        {
                            DateTime d = Str2Time(timestr);
                            if (DateTime.Now < d)//还未到提醒时间
                            {
                                AlertItem ai = new AlertItem(Str2Time(timestr),
                                    new ParseResult(timestr, this.Type, titlestr, contentstr, alertNotifyType));
                                Main.AlertList.Add(ai);
                            }
                        }
                    }
                }

                strRet = HttpUtility.GetDailyFxXml(this.url);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(strRet);
                XmlNodeList data_list = xmlDoc.DocumentElement.SelectNodes("./calendar");

                string datastr = "";
                for (int i = 0; i < data_list.Count; i++)
                {
                    result.Title = data_list[i].SelectSingleNode("./date[1]").InnerText;
                    string important = data_list[i].SelectSingleNode("./importance[1]").InnerText;
                    if (important == "H")
                    {
                        timestr = data_list[i].SelectSingleNode("./time[1]").InnerText;
                        timestr = timestr.Substring(0, timestr.Length - 3);
                        titlestr = data_list[i].SelectSingleNode("./location[1]").InnerText +
                            data_list[i].SelectSingleNode("./period[1]").InnerText +
                            data_list[i].SelectSingleNode("./event[1]").InnerText;
                        contentstr = titlestr + " 高\n前期:" + data_list[i].SelectSingleNode("./before[1]").InnerText +
                            " 预期:" + data_list[i].SelectSingleNode("./after[1]").InnerText;
                        if (timestr != "" && timestr.Contains(":"))
                        {
                            DateTime d = Str2Time(timestr);
                            if (DateTime.Now < d)//还未到提醒时间
                            {
                                AlertItem ai = new AlertItem(d, new ParseResult(timestr, this.Type, titlestr, contentstr, alertNotifyType));
                                Main.AlertList.Add(ai);
                            }
                        }
                        datastr += timestr + " " + titlestr + "\n";
                    }
                }

                if (result.Content != null && result.Content != "" && datastr != "")
                    result.Content += "--------------------\n" + datastr;
                else if (result.Content == null || result.Content == "")
                    result.Content = datastr;
                if (result.Content == null || result.Content == "")
                {
                    result.Content = "今日无财经事件和重要基本面消息";
                    result.NotifyType = this.NotifyType;
                }
                else
                {
                    //result.Title = result.Time;
                    todayCalendar = result.Content;
                    result.NotifyType = this.NotifyType;
                }
            }
            catch (Exception e)
            {
                result.Time = "";
                result.Title = "Error";
                result.Content = e.Message + "\n" + strRet;
                result.NotifyType = NotifyType.None;
            }
            SetNextCheckTime();
            return result;

        }



        protected override void SetNextCheckTime()
        {
            //每天8:45
            NextCheckTime = DateTime.Today.AddDays(1).AddHours(8).AddMinutes(45);
        }
    }


}
