using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Script.Serialization;

namespace LeoStudio
{
    public class StringUtility
    {
        public static string GetCenterString(string data, string front, string end)
        {
            int i = data.IndexOf(front);
            int j = data.IndexOf(end);

            string data2 = data.Substring(i + front.Length, j - i - front.Length);

            return data2;
        }
        //返回第一个front后面的字符串
        public static string GetStringAfter(string data, string front)
        {
            int i = data.IndexOf(front) + front.Length;
            string result = data.Substring(i, data.Length - i);
            return result;
        }

        //返回第一个end前面的字符串
        public static string GetStringBefore(string data, string end)
        {
            if (null == data)
            {
                return null;
            }
            return data.Substring(0, data.IndexOf(end));
        }

        //返回以start开头的字符串
        public static string GetStringStartWith(string data, string start)
        {
            if (null == data || "" == data)
            {
                return null;
            }
            int i = data.IndexOf(start);
            return data.Substring(i, data.Length - i);
        }

        public static List<string> GetStringBetweenList(string data, string front, string end)
        {
            List<string> result = new List<string>();
            if (null == data || "" == data)
            {
                return result;
            }
            while (data.Contains(front))
            {
                data = GetStringAfter(data, front);
                int i = data.IndexOf(end);
                result.Add(data.Substring(0, i));
                data = data.Substring(i + end.Length, data.Length - i - end.Length);
            }
            return result;
        }

        public static string GetStringBetween(string data, string front, string end)
        {
            data = GetStringAfter(data, front);
            int i = data.IndexOf(end);
            if (-1 == i)
            {
                return "";
            }
            else
            {
                return data.Substring(0, i);
            }
        }

        public static string GetCoordStringFromInt(int x, int y)
        {
            string xstr = x == 0 ? "" : x.ToString();
            return xstr + y.ToString().PadLeft(3, '0');
        }

        /// <summary>
        /// 获得JSON OBJ
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static object GetJsonObj(string data)
        {
            if (data == null || data == "")
            {
                return null;
            }
            //object oa = null;
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, object> json = (Dictionary<string, object>)serializer.DeserializeObject(data);
            object value;
            if (json.TryGetValue("message", out value))
            {
                //string ss = value.GetType().ToString();
                //oa = (object[])value;
            }
            return value;
        }

        /// <summary>
        /// 通过OBJ
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Dictionary<string, object> GetDictionary(object obj)
        {
            Dictionary<string, object> retdic = null; ;
            try
            {
                retdic = (Dictionary<string, object>)obj;
                return retdic;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string SubToEnd(string src, string flag)
        {
            return src.Substring(src.IndexOf(flag));
        }

        public static int ContainCount(string input, string value, bool ignoreCase)
        {
            if (ignoreCase)
            {
                input = input.ToLower();
                value = value.ToLower();
            }

            int count = 0;

            for (int i = 0; (i = input.IndexOf(value, i)) >= 0; i++)
            {
                count++;
            }

            return count;
        }

        public static string GetUnixTimeStamp()
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            DateTime dtNow = DateTime.Parse(DateTime.Now.ToString());
            TimeSpan toNow = dtNow.Subtract(dtStart);
            string ts = toNow.Ticks.ToString();
            ts = ts.Substring(0, ts.Length - 7);
            return ts;
        }

        
    }
}
