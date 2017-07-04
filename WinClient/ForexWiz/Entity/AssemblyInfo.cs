using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace LeoStudio
{
    public class AssemblyInfo<T>
    {
        private Type myType;

        public AssemblyInfo()
        {
            myType = typeof(T);
        }

       
        public String AssemblyName
        {
            get
            {
                return myType.Assembly.GetName().Name.ToString();
            }
        }

        public String AssemblyFullName
        {
            get
            {
                return myType.Assembly.GetName().FullName.ToString();
            }
        }

        public String CodeBase
        {
            get
            {
                return myType.Assembly.CodeBase;
            }
        }

        public String Version
        {
            get
            {
                return myType.Assembly.GetName().Version.ToString();
            }
        }

        public String Copyright
        {
            get
            {
                Type att = typeof(AssemblyCopyrightAttribute);
                object[] r = myType.Assembly.GetCustomAttributes(att, false);
                AssemblyCopyrightAttribute copyattr = (AssemblyCopyrightAttribute)r[0];
                return copyattr.Copyright;
            }
        }

        public String Company
        {
            get
            {
                Type att = typeof(AssemblyCompanyAttribute);
                object[] r = myType.Assembly.GetCustomAttributes(att, false);
                AssemblyCompanyAttribute compattr = (AssemblyCompanyAttribute)r[0];
                return compattr.Company;
            }
        }

        public String Configration
        {
            get
            {
                Type att = typeof(AssemblyConfigurationAttribute);
                object[] r = myType.Assembly.GetCustomAttributes(att, false);
                AssemblyConfigurationAttribute configattr = (AssemblyConfigurationAttribute)r[0];
                return configattr.Configuration;
            }
        }

        public string TradeMark
        {
            get
            {
                Type att = typeof(AssemblyTrademarkAttribute);
                object[] r = myType.Assembly.GetCustomAttributes(att, false);
                AssemblyTrademarkAttribute aa = (AssemblyTrademarkAttribute)r[0];
                return aa.Trademark;
            }
        }

        public string Culture
        {
            get
            {
                Type att = typeof(AssemblyCultureAttribute);
                object[] a = myType.Assembly.GetCustomAttributes(att, false);
                if (a.Length > 0)
                {
                    AssemblyCultureAttribute aa = (AssemblyCultureAttribute)a[0];
                    return aa.Culture;
                }
                else
                {
                    return "No value";
                }
            }
        }

        public String Description
        {
            get
            {
                Type att = typeof(AssemblyDescriptionAttribute);
                object[] r = myType.Assembly.GetCustomAttributes(att, false);
                AssemblyDescriptionAttribute descattr = (AssemblyDescriptionAttribute)r[0];
                return descattr.Description;
            }
        }

        public String Product
        {
            get
            {
                Type att = typeof(AssemblyProductAttribute);
                object[] r = myType.Assembly.GetCustomAttributes(att, false);
                AssemblyProductAttribute prodattr = (AssemblyProductAttribute)r[0];
                return prodattr.Product;
            }
        }

        public String Title
        {
            get
            {
                Type att = typeof(AssemblyTitleAttribute);
                object[] r = myType.Assembly.GetCustomAttributes(att, false);
                AssemblyTitleAttribute titleattr = (AssemblyTitleAttribute)r[0];
                return titleattr.Title;
            }
        }
    }



}
