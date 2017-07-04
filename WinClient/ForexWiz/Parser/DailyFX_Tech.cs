using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;


namespace LeoStudio.ForexWiz.Parser
{
    class DailyFX_Tech : IHtmlParser
    {
        private string lastTime;

        public DailyFX_Tech()
            : base()
        {
            this.Interval = 90;
            this.Type = "分析";
            this.url = "http://leandro.132.china123.net/forex/tech.php";
            this.NotifyType = NotifyType.Window;
        }

        public override ParseResult Parse()
        {
            string htmlstr = "";
            try
            {
                result = new ParseResult(this.Type);
                htmlstr = HttpUtility.Get(this.url);
                htmlDoc.LoadHtml(htmlstr);
                if (lastTime != SelectSingleNode("//div[@class='dateTime']").InnerText)
                {
                    result.Time = SelectSingleNode("//div[@class='dateTime']").InnerText;
                    lastTime = result.Time;
                    result.Title = SelectSingleNode("//div[@class='title']").InnerText;
                    result.Content = SelectSingleNode("//div[@class='content']").FirstChild.InnerText.Trim('\t');
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
                result.Content = e.Message + "\n" + htmlstr;
                result.NotifyType = NotifyType.None;
            }
            SetNextCheckTime();
            return result;
        }
    }
}
