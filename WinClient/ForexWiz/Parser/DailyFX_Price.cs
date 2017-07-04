using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeoStudio;
using LeoStudio.Entity;
using System.Xml;

namespace LeoStudio.ForexWiz.Parser
{
    class DailyFX_Price : IHtmlParser
    {
        public Dictionary<string, SymbolInfo> CurrDict = new Dictionary<string, SymbolInfo>();


        public DailyFX_Price()
            : base()
        {
            CurrDict.Add("EURUSD", new SymbolInfo());
            CurrDict.Add("GBPUSD", new SymbolInfo());
            CurrDict.Add("USDJPY", new SymbolInfo());
            CurrDict.Add("USDCHF", new SymbolInfo());
            CurrDict.Add("AUDUSD", new SymbolInfo());
            CurrDict.Add("USDCAD", new SymbolInfo());
            CurrDict.Add("NZDUSD", new SymbolInfo());

            this.Interval = 65;
            this.Type = "汇价";
            result.Type = this.Type;
            this.NotifyType = NotifyType.Window;
            this.url = "http://leandro.132.china123.net/forex/price.php";
        }

        public override ParseResult Parse()
        {
            string xmlstr = "";
            try
            {
                result = new ParseResult(this.Type);

                XmlDocument xmlDoc = new XmlDocument();
                xmlstr = HttpUtility.GetDailyFxXml(this.url+"?type=cvs");
                xmlDoc.LoadXml(xmlstr);

                List<string> keys = CurrDict.Keys.ToList();
                foreach (string key in keys)
                {
                    float p = float.Parse(xmlDoc.DocumentElement.SelectSingleNode("//Rate[@Symbol='" + key + "']/Bid[1]").InnerText)
                        + float.Parse(xmlDoc.DocumentElement.SelectSingleNode("//Rate[@Symbol='" + key + "']/Ask[1]").InnerText);
                    CurrDict[key].Price = p / 2;
                    if (CurrDict[key].Exceed != 0f && CurrDict[key].Price > CurrDict[key].Exceed)
                    {
                        result.Content += key + " 突破 " + CurrDict[key].Exceed + "\n";
                        CurrDict[key].Exceed = 0f;
                    }
                    if (CurrDict[key].Breakdown != 0f && CurrDict[key].Price < CurrDict[key].Breakdown)
                    {
                        result.Content += key + " 下破 " + CurrDict[key].Breakdown + "\n";
                        CurrDict[key].Breakdown = 0f;
                    }
                }
                if (result.Content != null)
                {
                    result.Time = DateTime.Now.ToShortTimeString();
                    result.NotifyType = this.NotifyType;
                }
                else
                {
                    //float y = 6.5f;
                    //string s = string.Format("{0:0.00}", y);
                    result.NotifyType = NotifyType.None;
                }
            }
            catch (Exception e)
            {
                result.Time = "";
                result.Title = "Error";
                result.Content = e.Message + "\n" + xmlstr;
                result.NotifyType = NotifyType.None;
            }
            SetNextCheckTime();
            return result;
        }
    }


    public class SymbolInfo
    {
        public float Price;
        public float Exceed;
        public float Breakdown;

    }
}
