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

namespace LeoStudio.Autoupdater
{
    public class ConstFile
    {
        public const string TEMPFOLDERNAME = "temp";
        public const string CONFIGFILEKEY = "config_";
        public const string FILENAME = "AutoUpdater.config";
        public const string ROOLBACKFILE = "KnightsWarrior.exe";
        public const string MESSAGETITLE = "AutoUpdate Program";
        public const string CANCELORNOT = "KnightsWarrior Update is in progress. Do you really want to cancel?";
        public const string APPLYTHEUPDATE = "Program need to restart to apply the update,Please click OK to restart the program!";
        public const string NOTNETWORK = "KnightsWarrior.exe update is unsuccessful. KnightsWarrior.exe will now restart. Please try to update again.";
        public static string APPLICATION_NAME;
        public static string WEBSITE;
    }
}
