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
using System.IO;

namespace LeoStudio.Autoupdater
{
    public class DownloadFileInfo
    {
        #region The private fields
        string downloadUrl = string.Empty;
        string fullPath = string.Empty;
        string relativePath = string.Empty;

        
        //string lastver = string.Empty;
        long timestamp = 0;
        long size = 0;
        #endregion

        #region The public property
        public string DownloadUrl { get { return downloadUrl; } }
        public string FileFullName { get { return fullPath; } }
        public string FileName { get { return Path.GetFileName(fullPath); } }
        public string RelativePath{get { return relativePath; }}
        //public string LastVer { get { return lastver; } set { lastver = value; } }
        public long Timestamp { get { return timestamp; } set { timestamp = value; } }
        public long Size { get { return size; } }

        #endregion

        #region The constructor of DownloadFileInfo
        public DownloadFileInfo(string url, string fpath,string rpath, long time, long size)
        {
            this.downloadUrl = url;
            this.fullPath = fpath;
            this.relativePath = rpath;
            this.timestamp = time;
            this.size = size;
        }
        #endregion
    }
}
