using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Web.Script.Serialization;
using System.Security.Cryptography;

namespace LeoStudio
{
    public delegate void HttpUtilityEventHandler(string text, ConMsgType type);

    public class HttpUtility
    {
        public static event HttpUtilityEventHandler HttpSended;

        private static CookieContainer cookies = new CookieContainer();

        public static CookieContainer Cookies
        {
            get { return cookies; }
            set { cookies = value; }
        }

        public static int retry = 0;

        /// <summary>
        /// get方法
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static string Get(string strUrl)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strUrl);
                req.Method = "Get";
                req.Timeout = 10000;
                req.AllowAutoRedirect = true;
                req.Accept = "*/*";
                req.Referer = "http://www.dailyfx.com.hk";
                req.KeepAlive = true;
                req.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; CMDTDF; staticlogin:product=cboxf2010&act=login&info=ZmlsZW5hbWU9UG93ZXJXb3JkMjAxME94Zl9VbHRpbWF0ZS5leGUmbWFjPUQ3RjMzRThBNkY2NzRBNEFCQjY2RjZCMjc1QkYxQjZFJnBhc3Nwb3J0PSZ2ZXJzaW9uPTIwMTAuNC44LjYuMTAmY3Jhc2h0eXBlPTE=&verify=90982fa9d579900924c31e6cd12ca90d; staticlogin:product=cboxf2010&act=login&info=ZmlsZW5hbWU9UG93ZXJXb3JkMjAxME94Zl9VbHRpbWF0ZS5leGUmbWFjPUQ3RjMzRThBNkY2NzRBNEFCQjY2RjZCMjc1QkYxQjZFJnBhc3Nwb3J0PSZ2ZXJzaW9uPTIwMTAuNC44LjYuMTAmY3Jhc2h0eXBlPTA=&verify=84d2d6238a70b19e7e8ca2d66fe49477; .NET4.0C)";
                req.CookieContainer = Cookies;
                req.Headers.Add("Accept-Language", "zh-cn");
                req.Headers.Add("Accept-Encoding", "");

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream ReceiveStream = res.GetResponseStream();
                StreamReader sr = new StreamReader(ReceiveStream, Encoding.GetEncoding("utf-8"));
                string strRet = sr.ReadToEnd();

                //if (!strRet.StartsWith("<"))
                //    strRet = "";

                Thread.Sleep(100);
                //Report("HttpGet:" + strUrl, ConMsgType.Debug);
                retry = 0;
                return strRet;
            }
            catch (Exception e)
            {
                //Report("重连次数:" + retry.ToString(), ConMsgType.Debug);
                //Report("连接错误:" + e.Message, ConMsgType.Normal);
                //Report("重连次数:" + retry.ToString(), ConMsgType.Debug);
                if (retry < 3)
                {
                    //Report("重新尝试连接...", ConMsgType.Normal);
                    Thread.Sleep(5000);
                    retry++;
                    return Get(strUrl);
                }
                else
                {
                    Report("连续3次重连失败，程序将放弃尝试，请检查网络是否畅通", ConMsgType.Normal);
                    retry = 0;
                    return "";
                }
            }
            finally
            {

            }
        }

        public static string GetDailyFxXml(string strUrl)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strUrl);
                req.Method = "Get";
                req.Timeout = 10000;
                req.AllowAutoRedirect = true;
                req.Accept = "application/xml, text/xml, */*";
                req.Referer = "http://www.dailyfx.com.hk";
                req.KeepAlive = true;
                req.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; CMDTDF; staticlogin:product=cboxf2010&act=login&info=ZmlsZW5hbWU9UG93ZXJXb3JkMjAxME94Zl9VbHRpbWF0ZS5leGUmbWFjPUQ3RjMzRThBNkY2NzRBNEFCQjY2RjZCMjc1QkYxQjZFJnBhc3Nwb3J0PSZ2ZXJzaW9uPTIwMTAuNC44LjYuMTAmY3Jhc2h0eXBlPTE=&verify=90982fa9d579900924c31e6cd12ca90d; staticlogin:product=cboxf2010&act=login&info=ZmlsZW5hbWU9UG93ZXJXb3JkMjAxME94Zl9VbHRpbWF0ZS5leGUmbWFjPUQ3RjMzRThBNkY2NzRBNEFCQjY2RjZCMjc1QkYxQjZFJnBhc3Nwb3J0PSZ2ZXJzaW9uPTIwMTAuNC44LjYuMTAmY3Jhc2h0eXBlPTA=&verify=84d2d6238a70b19e7e8ca2d66fe49477; .NET4.0C)";
                //req.CookieContainer = Cookies;

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream ReceiveStream = res.GetResponseStream();
                StreamReader sr = new StreamReader(ReceiveStream, Encoding.GetEncoding("gb2312"));
                string strRet = sr.ReadToEnd();

                Thread.Sleep(100);
                //Report("HttpGet:" + strUrl, ConMsgType.Debug);
                retry = 0;
                return strRet;
            }
            catch (Exception e)
            {
                //Report("重连次数:" + retry.ToString(), ConMsgType.Debug);
                //Report("连接错误:" + e.Message, ConMsgType.Normal);
                //Report("重连次数:" + retry.ToString(), ConMsgType.Debug);
                if (retry < 3)
                {
                    //Report("重新尝试连接...", ConMsgType.Normal);
                    Thread.Sleep(5000);
                    retry++;
                    return Get(strUrl);
                }
                else
                {
                    Report("连续3次重连失败，程序将放弃尝试，请检查网络是否畅通", ConMsgType.Normal);
                    retry = 0;
                    return "";
                }
            }
            finally
            {

            }
        }

        private static void Report(string text, ConMsgType type)
        {
            if (HttpSended != null)
            {
                HttpSended(text, type);
            }
        }

        /// <summary>
        /// post方法
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Post(string url, string querystring)
        {
            try
            {
                string s = url + "?" + querystring;
                //传中文必须用utf8
                Encoding utf8 = Encoding.GetEncoding("utf-8");
                byte[] unicodeBytes = utf8.GetBytes(querystring);

                //byte[] data = ASCIIEncoding.ASCII.GetBytes(querystring);

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                querystring = querystring.Replace(" ", "%20");
                req.Method = "POST";
                req.Timeout = 10000;
                req.ContentType = "application/x-www-form-urlencoded";
                req.AllowAutoRedirect = false;
                //req.CookieContainer = Cookies;

                req.ContentLength = unicodeBytes.Length;
                Stream newStream = req.GetRequestStream();
                // Send the data.
                newStream.Write(unicodeBytes, 0, unicodeBytes.Length);
                newStream.Close();

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream ReceiveStream = res.GetResponseStream();
                StreamReader sr = new StreamReader(ReceiveStream, Encoding.GetEncoding("utf-8"));
                string strRet = sr.ReadToEnd();

                Thread.Sleep(100);
                //Report("HttpPost:" + url + "?" + querystring, ConMsgType.Debug);
                retry = 0;
                return strRet;
            }
            catch (Exception e)
            {
                //Report("重连次数:" + retry.ToString(), ConMsgType.Debug);
                //Report("连接错误:" + e.Message, ConMsgType.Normal);
                //Report("重连次数:" + retry.ToString(), ConMsgType.Debug);
                if (retry < 3)
                {
                    //Report("重新尝试连接...", ConMsgType.Normal);
                    Thread.Sleep(5000);
                    return Post(url, querystring);
                }
                else
                {
                    Report("连续3次重连失败，程序将放弃尝试，请检查网络是否畅通", ConMsgType.Normal);
                    retry = 0;
                    return "";
                }
            }
        }

        /// <summary>
        /// Down远程文件存为本地文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filePath"></param>
        public static void Download(string url, string filePath)
        {
            WebRequest request = WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream Fstr = response.GetResponseStream();
            StreamReader sr = new StreamReader(Fstr);
            string str = sr.ReadToEnd();
            StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8);
            sw.Write(str);
            sw.Flush();
            sw.Close();
        }

        public static string GetGB2312(string strUrl)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strUrl);
                req.Method = "Get";
                req.Timeout = 30000;
                //req.KeepAlive = true;
                //req.ContentType = "application/x-www-form-urlencoded";
                req.AllowAutoRedirect = true;
                req.CookieContainer = Cookies;
                //req.Referer = "http://s47.dg.mop.com/main.do";

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                //Thread.Sleep(200);
                Stream ReceiveStream = res.GetResponseStream();
                StreamReader sr = new StreamReader(ReceiveStream, Encoding.GetEncoding("gb2312"));
                string strRet = sr.ReadToEnd();

                Thread.Sleep(200);
                return strRet;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {

            }
        }

    }
}
