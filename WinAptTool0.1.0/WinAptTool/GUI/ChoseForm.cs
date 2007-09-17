using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinApt.Client.GUI
{
    public partial class ChoseForm : Form
    {
        private string basePath = "";
        public ChoseForm()
        {
            InitializeComponent();
        }
        public void Config()
        {
            string local = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            //if not zh-CN or en-US, use english for default.
            if (local != "zh-CN" && local != "en-US")
            {
                local = "en-US";
            }
            string[] dirs = { "Internet", "Office", "Other", "Graphics", "System", "Media", "Program", "Accessories", "Games", "Accessibility","Education" };
            //
            //TODO: change here.
            //
            string updateUrl = "http://qwinapt.googlecode.com/files/appinfodb_" + local + ".zip";
            MainForm.myCmdMgr.Config = new AppInfoConfig(local, basePath, updateUrl);
            //create dires
            foreach (string str in dirs)
            {
                Directory.CreateDirectory(basePath + "\\" + str);
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            fdDlg.SelectedPath = Environment.CurrentDirectory;
            this.fdDlg.ShowDialog();
            
            basePath = fdDlg.SelectedPath;
            txtPath.Text = basePath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                btnBrowser_Click(sender,e);
            }
        }
    }
}