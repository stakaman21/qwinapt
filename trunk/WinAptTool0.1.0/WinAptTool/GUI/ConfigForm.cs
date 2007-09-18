using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinApt.Common;

namespace WinApt.Client.GUI
{
    public partial class ConfigForm : Form
    {
        private MainForm fmMain;
        public ConfigForm(MainForm fmMain)
        {
            InitializeComponent();
            this.fmMain = fmMain;
            cbDbs.Text = MainForm.myCmdMgr.Config.local;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //
            //TODO: update db file
            //
            MainForm.myCmdMgr.Config.local = cbDbs.Text;
            MainForm.myCmdMgr.Config.updateUrl = txtUrl.Text;
            MainForm.myCmdMgr.Config.usingDB = WinAptLib.ConfigPath + "appinfodb_" + cbDbs.Text + ".xml";
            WinAptLib.WriteToFile(MainForm.myCmdMgr.Config, MainForm.configFile);
            btnOK.Enabled = false;
            fmMain.UpdateDB();
            btnOK.Enabled = true;
        }

        private void cbDbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //TODO: change db file.
            //
            string url = MainForm.myCmdMgr.Config.updateUrl;
            txtUrl.Text = url.Substring(0, url.Length - 9) + cbDbs.Text + ".zip";
        }
    }
}