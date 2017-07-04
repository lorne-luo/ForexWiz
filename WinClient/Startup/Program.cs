using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LeoStudio.Autoupdater;
using System.Net;
using System.Xml;
using System.Reflection;
using LeoStudio.Startup;

namespace Startup
{
    static class Program
    {
        static LeoStudio.ForexWiz.Main main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //先更新
            Update();
            main = new LeoStudio.ForexWiz.Main(); //Application.Run(new MainForm());
        }

        private static void Update()
        {
            bool bHasError = false;
            AssemblyInfo<LeoStudio.ForexWiz.Main> infoClass = new AssemblyInfo<LeoStudio.ForexWiz.Main>();

            IAutoUpdater autoUpdater = new LeoStudio.Autoupdater.AutoUpdater(infoClass.Title);
            try
            {
                autoUpdater.Update();
            }
            catch (WebException exp)
            {
                MessageBox.Show("Can not find the specified resource");
                bHasError = true;
            }
            catch (XmlException exp)
            {
                bHasError = true;
                MessageBox.Show("Download the upgrade file error");
            }
            catch (NotSupportedException exp)
            {
                bHasError = true;
                MessageBox.Show("Upgrade address configuration error");
            }
            catch (ArgumentException exp)
            {
                bHasError = true;
                MessageBox.Show("Download the upgrade file error");
            }
            catch (Exception exp)
            {
                bHasError = true;
                MessageBox.Show("An error occurred during the upgrade process");
            }
            finally
            {
                if (bHasError == true)
                {
                    try
                    {
                        //autoUpdater.RollBack();
                    }
                    catch (Exception)
                    {
                        //Log the message to your file or database
                    }
                }
            }
        }
    }
}
