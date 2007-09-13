using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WinApt.Common;

namespace WinApt.Client.GUI
{
    public partial class SplashForm : Form
    {
        private string configFile = MainForm.configFile;
        public SplashForm()
        {
            InitializeComponent();
        }
        public void InitApp()
        {
            //
            //TODO: add init code before main form show.
            //

            this.lbSplash.Text = "Loading config file.";

            if (MainForm.myCmdMgr == null)
                MainForm.myCmdMgr = new CmdMgr();
            
            //if we already build one, no need to check the file.
            if (MainForm.myCmdMgr.Config == null)
            {
                //load config file
                if (File.Exists(configFile))
                {
                    MainForm.myCmdMgr.Config = (AppInfoConfig)WinAptLib.ReadFromFile(typeof(AppInfoConfig), configFile);
                }
                else
                {
                    //no config file, need to builder one
                    throw new Exception("new");
                }
            }
            //download update page.
            string content = "";
            this.lbSplash.Text = "Load DB file.";
            lbSplash.Update();
            try
            {
                string fileName = "appinfodb_" + MainForm.myCmdMgr.Config.local + ".xml";
                if (File.Exists(fileName))
                {
                    StreamReader infile = File.OpenText(fileName);
                    content = infile.ReadToEnd();
                    infile.Close();
                }
                else
                {
                    this.lbSplash.Text = "Download DB file.";
                    lbSplash.Update();
                    content = WinAptLib.getPageContent(MainForm.myCmdMgr.Config.updateUrl);
                    File.WriteAllText(fileName, content);
                }
            }
            catch (Exception e)
            {
                
                throw new Exception("Download  " + MainForm.myCmdMgr.Config.updateUrl + " wrong, check the network.");
            }
            finally
            {
                //save the config file, then quit program.
                WinAptLib.WriteToFile(MainForm.myCmdMgr.Config, configFile);
            }
            MainForm.myCmdMgr.UpdateAppDB(content);
        }
    }
}