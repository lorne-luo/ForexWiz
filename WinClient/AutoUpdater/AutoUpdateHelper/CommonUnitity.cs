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
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace LeoStudio.Autoupdater
{
    class CommonUnitity
    {
        public static string SystemBinUrl = AppDomain.CurrentDomain.BaseDirectory;

        public static void RestartApplication()
        {
            Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }

        public static string GetFolderUrl(DownloadFileInfo file)
        {
            string folderPathUrl = string.Empty;
            //int folderPathPoint = file.DownloadUrl.IndexOf("/", 15) + 1;
            //string filepathstring = file.DownloadUrl.Substring(folderPathPoint);
            //int folderPathPoint1 = filepathstring.IndexOf("/");
            //string filepathstring1 = filepathstring.Substring(folderPathPoint1 + 1);
            //if (filepathstring1.IndexOf("/") != -1)
            //{
            //    string[] ExeGroup = filepathstring1.Split('/');
            //    for (int i = 0; i < ExeGroup.Length - 1; i++)
            //    {
            //        folderPathUrl += "\\" + ExeGroup[i];
            //    }
            //    folderPathUrl = Path.Combine(SystemBinUrl, ConstFile.TEMPFOLDERNAME);
            //    folderPathUrl = Path.Combine(folderPathUrl, file.RelativePath);
            //    folderPathUrl = Path.GetDirectoryName(folderPathUrl);
            //    if (!Directory.Exists(folderPathUrl))
            //    {
            //        Directory.CreateDirectory(folderPathUrl);
            //    }
            //}
            folderPathUrl = Path.Combine(SystemBinUrl, ConstFile.TEMPFOLDERNAME);
            folderPathUrl = Path.Combine(folderPathUrl, file.RelativePath);
            folderPathUrl = Path.GetDirectoryName(folderPathUrl);
            if (!Directory.Exists(folderPathUrl))
            {
                Directory.CreateDirectory(folderPathUrl);
            }

            return folderPathUrl;
        }

        public static void DeleteDir(string dir)
        {
            File.Delete(dir);
        }
    }
}
