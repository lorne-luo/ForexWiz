using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace LeoStudio.ForexWiz.Parser
{


    internal abstract class IHtmlParser
    {
        protected string url;
        protected HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
        protected List<string> XPathList = new List<string>();
        protected ParseResult result = new ParseResult();

        protected string Type;

        private bool enabled = true;
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        protected int interval;
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
        private DateTime nextCheckTime;
        public DateTime NextCheckTime
        {
            get { return nextCheckTime; }
            set { nextCheckTime = value; }
        }

        private NotifyType nt;

        public NotifyType NotifyType
        {
            get { return nt; }
            set { nt = value; }
        }

        public string GetUrl()
        {
            return url;
        }
        public void SetUrl(string u)
        {
            url = u;
        }
        //ctor
        public IHtmlParser()
        {
            //公共默认参数
            nt = NotifyType.Balloon;
            this.interval = 90;
        }

        public abstract ParseResult Parse();


        public void DocReload()
        {
            htmlDoc.LoadHtml(HttpUtility.Get(url));
        }

        public HtmlNode SelectSingleNode(string xpath)
        {
            HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode(xpath);
            if (node == null) throw new Exception(xpath);
            return node;
        }
        public HtmlNodeCollection SelectNodes(string xpath)
        {
            HtmlNodeCollection nodeList = htmlDoc.DocumentNode.SelectNodes(xpath);
            if (nodeList == null) throw new Exception(xpath);
            return nodeList;
        }

        protected virtual void SetNextCheckTime()
        {
            nextCheckTime = DateTime.Now.AddSeconds(interval);
        }

        protected DateTime Str2Time(string t)
        {
            string[] s = new string[2];
            try
            {
                s = t.Split(':');
                return DateTime.Today.AddHours(Convert.ToInt32(s[0])).AddMinutes(Convert.ToInt32(s[1]));
            }
            catch (Exception)
            {
                return DateTime.Now.AddHours(-1);
            }
        }
    }

    internal struct ParserParam
    {
        public string url;
        public List<string> XPathList;
    }

    public struct ParseResult
    {
        public string Time;
        public string Type;
        public string Title;
        public string Content;
        public NotifyType NotifyType;
        public string link;
        public string linktext;

        public ParseResult(string type)
            : this()
        {
            this.Type = type;
        }
        public ParseResult(string time, string type, string title, string content, NotifyType n)
            : this()
        {
            this.Time = time;
            this.Type = type;
            this.Title = title;
            this.Content = content;
            this.NotifyType = n;
        }
    }

    public enum NotifyType
    {
        None = 1,
        Balloon = 2,
        Window = 4,
        MessageBox = 8,
        Email = 16,
        Log = 32
    }

    public struct AlertItem
    {
        public DateTime Time;
        public ParseResult Content;
        public AlertItem(DateTime time, ParseResult content)
        {
            Time = time;
            Content = content;
        }
    }
}
