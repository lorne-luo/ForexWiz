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

namespace LeoStudio.Autoupdater
{
    public class RemoteFile
    {
        #region The private fields
        private string name = "";
        private string path = "";
        private string url = "";
        private string md5 = "";
        //private string url = "";
        //private string lastver = "";
        private long size = 0;
        private long timestamp = 0;
       // private bool needRestart = false;
        #endregion

        #region The public property
        public string Name { get { return name; } }
        public string Path { get { return path; } }
        public string Url { get { return url; } }
        public string Md5 { get { return md5; } }
        public long Timestamp { get { return timestamp; } }
        //public string Url { get { return url; } }
        //public string LastVer { get { return lastver; } }
        public long Size { get { return size; } }
        //public bool NeedRestart { get { return needRestart; } }
        #endregion

        #region The constructor of AutoUpdater
        public RemoteFile(XmlNode node)
        {
            this.name = node.Attributes["name"].Value;
            this.url = node.Attributes["url"].Value;
            this.path = node.Attributes["path"].Value;
            this.md5 = node.Attributes["md5"].Value;
            this.timestamp = Convert.ToInt64(node.Attributes["updatetime"].Value);
            this.size = Convert.ToInt64(node.Attributes["filesize"].Value);
            //this.needRestart = Convert.ToBoolean(node.Attributes["needRestart"].Value);
        }
        #endregion
    }
}
