using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace LeoStudio.ForexWiz.Parser
{
    class Waihuihandan : IHtmlParser
    {
        private string lastTime;

        public Waihuihandan()
            : base()
        {
            this.Interval = 600;
            this.Type = "掌亿";
            result.Type = this.Type;
            this.NotifyType = NotifyType.Window;
            this.url = "http://www.waihuihandan.cn";
        }

        public override ParseResult Parse()
        {
            string htmlstr = "";
            try
            {
                result = new ParseResult(this.Type);
                htmlstr = HttpUtility.Get(this.url);
                htmlDoc.LoadHtml(htmlstr);
                string lastposttime = SelectSingleNode("//div[@class='PostHead']/span[@class='submitted'][1]").InnerText;
                int start = lastposttime.IndexOf("发布时间: ");
                lastposttime = lastposttime.Substring(start + 5, lastposttime.Length - start - 5).Trim();

                if (lastTime != lastposttime)
                {
                    result.Time = lastposttime;
                    lastTime = result.Time;
                    result.Title = lastposttime;
                    result.Content = SelectSingleNode("//div[@class='PostHead']/h1[1]").InnerText;
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
                result.NotifyType = this.NotifyType;
            }
            SetNextCheckTime();
            return result;
        }


    }
}
