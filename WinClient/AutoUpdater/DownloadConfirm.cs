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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Diagnostics;

namespace LeoStudio.Autoupdater
{
    public partial class DownloadConfirm : Office2007Form
    {
        #region The private fields
        List<DownloadFileInfo> downloadFileList = null;
        #endregion

        #region The constructor of DownloadConfirm
        public DownloadConfirm(List<DownloadFileInfo> downloadfileList)
        {
            InitializeComponent();
            this.label_title.Text = ConstFile.APPLICATION_NAME + " 下列文件需要更新...";
            downloadFileList = downloadfileList;
        }
        #endregion

        #region The private method
        private void OnLoad(object sender, EventArgs e)
        {
            foreach (DownloadFileInfo file in this.downloadFileList)
            {
                this.itemPanel1.Items.Add(new ButtonItem(file.RelativePath, file.RelativePath));
            }

            this.Activate();
            this.Focus();
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Process.Start(ConstFile.WEBSITE);
            System.Environment.Exit(0);
            Application.ExitThread();
            this.Close();
            Application.Exit();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
            Application.ExitThread();
            this.Close();
            Application.Exit();
        }

    }
}