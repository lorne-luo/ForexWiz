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
using System.Threading;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Xml;
using DevComponents.DotNetBar;

namespace LeoStudio.Autoupdater
{
    public partial class DownloadProgress : Office2007Form
    {
        #region The private fields
        private bool isFinished = false;
        private List<DownloadFileInfo> downloadFileList = null;
        private List<DownloadFileInfo> allFileList = null;
        private ManualResetEvent evtDownload = null;
        private ManualResetEvent evtPerDonwload = null;
        private WebClient clientDownload = null;
        string tempFolderPath = Path.Combine(CommonUnitity.SystemBinUrl, ConstFile.TEMPFOLDERNAME);
        #endregion

        #region The constructor of DownloadProgress
        public DownloadProgress(List<DownloadFileInfo> downloadFileListTemp)
        {
            InitializeComponent();
            this.label_title.Text = ConstFile.APPLICATION_NAME + " 正在更新...";

            this.downloadFileList = downloadFileListTemp;
            allFileList = new List<DownloadFileInfo>();
            foreach (DownloadFileInfo file in downloadFileListTemp)
            {
                allFileList.Add(file);
            }
        }
        #endregion

        #region The method and event
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFinished && DialogResult.No == MessageBoxEx.Show(ConstFile.CANCELORNOT, ConstFile.MESSAGETITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
                return;
            }
            else
            {
                if (clientDownload != null)
                    clientDownload.CancelAsync();

                evtDownload.Set();
                evtPerDonwload.Set();
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            if (!Directory.Exists(tempFolderPath))
            {
                Directory.CreateDirectory(tempFolderPath);
            }
            else
            {
                Directory.Delete(tempFolderPath, true);
                Directory.CreateDirectory(tempFolderPath);
            }
            evtDownload = new ManualResetEvent(true);
            evtDownload.Reset();
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.ProcDownload));
        }

        long total = 0;
        long nDownloadedTotal = 0;

        private void ProcDownload(object o)
        {
            evtPerDonwload = new ManualResetEvent(false);

            foreach (DownloadFileInfo file in this.downloadFileList)
            {
                total += file.Size;
            }
            try
            {
                while (!evtDownload.WaitOne(0, false))
                {
                    if (this.downloadFileList.Count == 0)
                        break;

                    DownloadFileInfo file = this.downloadFileList[0];

                    //Debug.WriteLine(String.Format("Start Download:{0}", file.FileName));

                    this.ShowCurrentDownloadFileName(file.RelativePath);

                    //Download
                    clientDownload = new WebClient();

                    //Added the function to support proxy
                    clientDownload.Proxy = System.Net.WebProxy.GetDefaultProxy();
                    clientDownload.Proxy.Credentials = CredentialCache.DefaultCredentials;
                    clientDownload.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    //End added

                    clientDownload.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                    {
                        try
                        {
                            this.SetProcessBar(e.ProgressPercentage, (int)((nDownloadedTotal + e.BytesReceived) * 100 / total));
                        }
                        catch
                        {
                            //log the error message,you can use the application's log code
                        }
                    };

                    clientDownload.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs e) =>
                    {
                        try
                        {
                            //DealWithDownloadErrors();
                            DownloadFileInfo dfile = e.UserState as DownloadFileInfo;
                            nDownloadedTotal += dfile.Size;
                            this.SetProcessBar(0, (int)(nDownloadedTotal * 100 / total));
                            evtPerDonwload.Set();
                        }
                        catch (Exception)
                        {
                            //log the error message,you can use the application's log code
                        }
                    };

                    evtPerDonwload.Reset();

                    //Download the folder file
                    string filePath = Path.Combine(CommonUnitity.SystemBinUrl, file.RelativePath);
                    filePath = Path.GetFullPath(filePath);
                    string filePathDir = Path.GetDirectoryName(filePath);

                    string tempFilePath = Path.Combine(CommonUnitity.SystemBinUrl, ConstFile.TEMPFOLDERNAME);
                    tempFilePath = Path.Combine(tempFilePath, file.RelativePath);
                    tempFilePath = Path.GetFullPath(tempFilePath);
                    string tempFileDir = Path.GetDirectoryName(tempFilePath);

                    if (!Directory.Exists(tempFileDir))
                    {
                        Directory.CreateDirectory(tempFileDir);
                    }
                    clientDownload.DownloadFileAsync(new Uri(file.DownloadUrl), tempFilePath, file);

                    //Wait for the download complete
                    evtPerDonwload.WaitOne();
                    clientDownload.Dispose();
                    clientDownload = null;
                    //Remove the downloaded files
                    this.downloadFileList.Remove(file);
                }
            }
            catch (Exception ex)
            {
                ShowErrorAndRestartApplication();
            }

            //When the files have not downloaded,return.
            if (downloadFileList.Count > 0)
            {
                return;
            }

            //Test network and deal with errors if there have 
            //DealWithDownloadErrors();

            //Debug.WriteLine("All Downloaded");
            foreach (DownloadFileInfo file in this.allFileList)
            {
                string tempPath = Path.Combine(tempFolderPath, file.RelativePath);
                string newPath = Path.Combine(CommonUnitity.SystemBinUrl, file.RelativePath);
                try
                {
                    FileInfo tempFile = new FileInfo(tempPath);
                    FileInfo newFile = new FileInfo(newPath);

                    if (!Directory.Exists(newFile.DirectoryName))
                    {
                        Directory.CreateDirectory(newFile.DirectoryName);
                    }
                    tempFile.CopyTo(newFile.FullName,true);

                    DirectoryInfo di = new DirectoryInfo(tempFolderPath);
                    di.Delete(true);
                    MessageBoxEx.Show("更新成功,点击OK运行", "更新成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    //log the error message,you can use the application's log code
                    continue;
                }

            }

            //After dealed with all files, clear the data
            this.allFileList.Clear();

            if (this.downloadFileList.Count == 0)
                Exit(true);
            else
                Exit(false);

            evtDownload.Set();
        }

        //To delete or move to old files
        void MoveFolderToOld(string oldPath, string newPath)
        {
            if (File.Exists(oldPath + ".old"))
                File.Delete(oldPath + ".old");
            if (File.Exists(oldPath))
                File.Move(oldPath, oldPath + ".old");
            File.Move(newPath, oldPath);
            //File.Delete(oldPath + ".old");
        }

        delegate void ShowCurrentDownloadFileNameCallBack(string name);
        private void ShowCurrentDownloadFileName(string name)
        {
            if (this.label_current.InvokeRequired)
            {
                ShowCurrentDownloadFileNameCallBack cb = new ShowCurrentDownloadFileNameCallBack(ShowCurrentDownloadFileName);
                this.Invoke(cb, new object[] { name });
            }
            else
            {
                this.labelCurrentItem.Text = name;
            }
        }

        delegate void SetProcessBarCallBack(int current, int total);
        private void SetProcessBar(int current, int total)
        {
            if (this.progressBarCurrent.InvokeRequired)
            {
                SetProcessBarCallBack cb = new SetProcessBarCallBack(SetProcessBar);
                this.Invoke(cb, new object[] { current, total });
            }
            else
            {
                this.progressBarCurrent.Value = current;
                this.progressBarTotal.Value = total;
                this.label_total.Text = total + "%";
                this.label_current.Text = current + "%";
            }
        }

        delegate void ExitCallBack(bool success);
        private void Exit(bool success)
        {
            if (this.InvokeRequired)
            {
                ExitCallBack cb = new ExitCallBack(Exit);
                this.Invoke(cb, new object[] { success });
            }
            else
            {
                this.isFinished = success;
                this.DialogResult = success ? DialogResult.OK : DialogResult.Cancel;
                this.Close();
            }
        }

        private void OnCancel(object sender, EventArgs e)
        {
            //bCancel = true;
            //evtDownload.Set();
            //evtPerDonwload.Set();
            ShowErrorAndRestartApplication();
        }

        private void DealWithDownloadErrors()
        {
            try
            {
                //Test Network is OK or not.
                //Config config = Config.LoadConfig(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConstFile.FILENAME));
                //WebClient client = new WebClient();
                //client.DownloadString(config.ConfigUrl);
            }
            catch (Exception)
            {
                //log the error message,you can use the application's log code
                ShowErrorAndRestartApplication();
            }
        }

        private void ShowErrorAndRestartApplication()
        {
            MessageBoxEx.Show(ConstFile.NOTNETWORK, ConstFile.MESSAGETITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CommonUnitity.RestartApplication();
        }

        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://leandro.132.china123.net/forexwiz/publisher/");
        }
    }
}