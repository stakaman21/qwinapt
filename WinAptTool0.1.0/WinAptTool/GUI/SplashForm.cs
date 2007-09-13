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
            this.lbSplash.Text = "Load file from " + MainForm.myCmdMgr.Config.updateUrl;
            lbSplash.Update();
            try
            {

                //
                //TODO: change test code
                //
                //StreamReader infile = File.OpenText("appinfodb.xml");
                //content = infile.ReadToEnd();
                content = WinAptLib.getPageContent(MainForm.myCmdMgr.Config.updateUrl);
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
            //load data from remote db.
            MainForm.myCmdMgr.InfoDB = (AppInfoDB)WinAptLib.ReadFromStream(typeof(AppInfoDB), content);

            for (int i = 0; i < MainForm.myCmdMgr.InfoDB.Items.Count; i++)
            {
                ((AppInfoBase)MainForm.myCmdMgr.InfoDB.Items[i]).setIndex(i);
            }

            this.lbSplash.Text = "Updating local AppInfo database...";
            lbSplash.Update();
            //compare with local data
            foreach (AppInfoBase item in MainForm.myCmdMgr.Config.Items)
            {
                int index = 0;
                //already contains, mark as needDownload
                if ((index = MainForm.myCmdMgr.InfoDB.Contains(item)) != -1)
                {
                    ((AppInfoBase)MainForm.myCmdMgr.InfoDB.Items[index]).setState(1);
                }
                //has older version, mark as needUpdate
                if ((index = MainForm.myCmdMgr.InfoDB.HasOldVersion(item)) != -1)
                {
                    ((AppInfoBase)MainForm.myCmdMgr.InfoDB.Items[index]).setState(2);
                    ((AppInfoBase)MainForm.myCmdMgr.InfoDB.Items[index]).version = ((AppInfoBase)item).version;
                }
            }
        }
    }
}