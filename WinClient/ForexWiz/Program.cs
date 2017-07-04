using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LeoStudio.Entity;
using System.Diagnostics;
using Microsoft.Build.Tasks.Deployment.ManifestUtilities;
using System.Reflection;

namespace LeoStudio.ForexWiz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MessageBoxEx.Show(System.Reflection.Assembly.GetExecutingAssembly().Location);
            FileVersionInfo appVersion = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            string pathAndFileName = Process.GetCurrentProcess().MainModule.FileName;
            Version appVersion2 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            AssemblyManifest m = new AssemblyManifest();
            m.SourcePath = "ForexWiz.exe.manifest";
            m.UpdateFileInfo();
            m.Validate();
            System.Reflection.Assembly aaaaaaa= System.Reflection.Assembly.GetExecutingAssembly();
            AssemblyName[] annnn = aaaaaaa.GetReferencedAssemblies();


            new Main(); //Application.Run(new MainForm());
        }

        //private void UpdateApplication()
        //{
        //    if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
        //    {
        //        ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
        //        ad.CheckForUpdateCompleted += new CheckForUpdateCompletedEventHandler(ad_CheckForUpdateCompleted);
        //        ad.CheckForUpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_CheckForUpdateProgressChanged);

        //        ad.CheckForUpdateAsync();
        //    }
        //}    

    }
}
