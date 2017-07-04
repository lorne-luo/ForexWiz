using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QWeiboSDK;
using System.Xml;

namespace LeoStudio.ForexWiz.Parser
{
    class QWeibo : IHtmlParser
    {
        private string appKey = "6997b6f65d434ccc94017a29555b0067";
        private string appSecret = "fc9da57202dd679414d869e8e6cb4912";
        private string accessKey = "40bc04da8c6d443ea5780e3b4b3ee2dc";
        private string accessSecret = "30e7df05901c3e33460925b97f15cac3";
        private string userName;
        private string lastTime;

        public QWeibo(string u)
            : base()
        {
            this.url = "http://open.t.qq.com/api/statuses/user_timeline";
            this.userName = u;
            this.Interval = 120;
            this.Type = "微博";
            result.Type = this.Type;
            this.NotifyType = NotifyType.Window;
        }

        public override ParseResult Parse()
        {
            string post = "";
            try
            {
                result = new ParseResult(this.Type);
                List<Parameter> parameters = new List<Parameter>();
                OauthKey oauthKey = new OauthKey();
                oauthKey.customKey = appKey;
                oauthKey.customSecrect = appSecret;
                oauthKey.tokenKey = accessKey;
                oauthKey.tokenSecrect = accessSecret;

                List<string> arryName = new List<string>();
                List<string> arryValue = new List<string>();
                arryName.Add("name");
                arryValue.Add(this.userName);
                arryName.Add("format");
                arryValue.Add("xml");
                arryName.Add("pageflag");
                arryValue.Add("0");
                arryName.Add("reqnum");
                arryValue.Add("1");
                arryName.Add("pagetime");
                arryValue.Add("0");

                for (int i = 0; i < arryName.Count; i++)
                {
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Byte[] encodedBytes = utf8.GetBytes(arryValue[i]);
                    string content = utf8.GetString(encodedBytes);
                    parameters.Add(new Parameter(arryName[i], content));
                }
                QWeiboRequest request = new QWeiboRequest();
                post = request.SyncRequest(this.url, "GET", oauthKey, parameters, new List<Parameter>());
                byte[] temp = Encoding.GetEncoding(65001).GetBytes(post);
                byte[] temp1 = Encoding.Convert(Encoding.GetEncoding(65001), Encoding.Default, temp);
                post = Encoding.Default.GetString(temp1);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(post);
                if (xmlDoc.DocumentElement.SelectSingleNode("./msg[1]").InnerText == "access rate limit")
                {
                    this.NextCheckTime = DateTime.Now.AddSeconds(10 * interval);
                    throw new Exception("access rate limit");
                }
                if (lastTime != xmlDoc.DocumentElement.SelectSingleNode("./data[1]/info[1]/timestamp[1]").InnerText)
                {
                    lastTime = xmlDoc.DocumentElement.SelectSingleNode("./data[1]/info[1]/timestamp[1]").InnerText;
                    DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                    long lTime = long.Parse(lastTime + "0000000");
                    TimeSpan toNow = new TimeSpan(lTime);
                    DateTime dtResult = dtStart.Add(toNow);
                    result.Time = dtResult.ToShortTimeString();

                    result.Title = xmlDoc.DocumentElement.SelectSingleNode("./data[1]/info[1]/nick[1]").InnerText;// +"(" + this.userName + ")";
                    result.Content = xmlDoc.DocumentElement.SelectSingleNode("./data[1]/info[1]/origtext[1]").InnerText;
                    result.NotifyType = this.NotifyType;
                }
                else
                {
                    result.NotifyType = NotifyType.None;
                }
                SetNextCheckTime();
            }
            catch (Exception e)
            {
                result.Time = "";
                result.Title = this.url + ":Error";
                result.Content = e.Message + "\n" + post;
                result.NotifyType = this.NotifyType;
            }
            return result;
        }

    }
}
