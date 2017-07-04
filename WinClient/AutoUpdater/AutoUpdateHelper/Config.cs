/*****************************************************************
 * Copyright (C) Leo Studio Corporation. All rights reserved.
 * 
 * Author:   Leo 
 * Email:    luotao.net@gmail.com
 * Website:  http://www.luotao.net
 *
*****************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace LeoStudio.Autoupdater
{
    public class Config
    {
        #region The private fields

        private bool enabled = true;
        private bool requirement = true;
        private string configUrl = string.Empty;
        private string warehouseUrl = string.Empty;
        private string webSite = string.Empty;

        
        #endregion

        #region The public property
        [XmlElement("Enabled")]
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        [XmlElement("Requirement")]
        public bool Requirement
        {
            get { return requirement; }
            set { requirement = value; }
        }

        [XmlElement("WarehouseUrl")]
        public string WarehouseUrl
        {
            get { return warehouseUrl; }
            set { warehouseUrl = value; }
        }

        [XmlElement("ConfigUrl")]
        public string ConfigUrl
        {
            get { return configUrl; }
            set { configUrl = value; }
        }
        [XmlElement("WebSite")]
        public string WebSite
        {
            get { return webSite; }
            set { webSite = value; }
        }
        #endregion

        #region The public method
        public static Config LoadConfig(string file)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Config));
            StreamReader sr = new StreamReader(file);
            Config config = xs.Deserialize(sr) as Config;
            sr.Close();

            return config;
        }

        public void SaveConfig(string file)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Config));
            StreamWriter sw = new StreamWriter(file);
            xs.Serialize(sw, this);
            sw.Close();
        }
        #endregion
    }

}
