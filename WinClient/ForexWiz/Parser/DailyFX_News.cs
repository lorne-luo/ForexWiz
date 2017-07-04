using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeoStudio;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Xml;

namespace LeoStudio.ForexWiz.Parser
{
    class DailyFX_News : IHtmlParser
    {
        private string lastTime;

        public DailyFX_News()
            : base()
        {
            this.Interval = 90;
            this.Type = "新闻";
            result.Type = this.Type;
            this.NotifyType = NotifyType.Window;
            this.url = "http://leandro.132.china123.net/forex/news.php";
            this.XPathList.Add("./news[1]");
        }

        public DailyFX_News(string u)
            : this()
        {
            this.url = u;
        }

        public override ParseResult Parse()
        {
            string strRet = "";
            try
            {
                //string u = url + StringUtility.GetUnixTimeStamp();
                strRet = HttpUtility.GetDailyFxXml(this.url);

                result = new ParseResult(this.Type);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(strRet);
                XmlNode news = xmlDoc.DocumentElement.SelectSingleNode("./news[1]");


                if (news.SelectSingleNode("./time[1]").InnerText != lastTime)
                {
                    result.Time = news.SelectSingleNode("./time[1]").InnerText;
                    lastTime = result.Time;
                    result.Time = result.Time.Substring(0, result.Time.Length - 3);
                    result.Title = news.SelectSingleNode("./title[1]").InnerText;
                    result.Content = news.SelectSingleNode("./detail[1]").InnerText;
                    result.NotifyType = this.NotifyType;
                }
                else
                {
                    result.NotifyType = NotifyType.None;
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

    }
}
