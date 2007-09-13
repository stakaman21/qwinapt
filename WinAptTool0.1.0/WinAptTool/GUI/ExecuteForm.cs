using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinApt.Common;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WinApt.Client.GUI
{
    public partial class ExecuteForm : Form
    {

        delegate void SetLabelCallback(string text);
        delegate void SetTextCallback(string text);
        delegate void SetOKCallback();
        private bool _stop = false;
        private bool needStart = false;
        private CmdMgr cmdMgr = null;
        private Thread t = null;
        public ExecuteForm(CmdMgr cmdMgr)
        {
            InitializeComponent();
            this.cmdMgr = cmdMgr;
            lbAction.Text = "We will take follow changes:";
            if (cmdMgr.SelectItems.Count > 0)
            {
                needStart = true;
                txtConsole.Text = "We are going to download:\n";
                foreach (object item in cmdMgr.SelectItems)
                {
                    AppInfoBase it = (AppInfoBase)cmdMgr.InfoDB.Items[(int)item];
                    txtConsole.AppendText(it.url + "\n");
                }
                txtConsole.AppendText("\n\n");
            }
            if (cmdMgr.DelectItems.Count > 0)
            {
                needStart = true;
                txtConsole.AppendText("We are going to delete:\n");
                foreach (object item in cmdMgr.DelectItems)
                {
                    AppInfoBase it = (AppInfoBase)cmdMgr.InfoDB.Items[(int)item];
                    string filename = it.url;
                    filename = filename.Substring(filename.LastIndexOf('/') + 1);
                    string cmd = cmdMgr.Config.basePath + @"\" + it.catalog + @"\" + filename;
                    txtConsole.AppendText(cmd + "\n");
                }
            }

        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            if (_stop || t == null)
            {
                CancalChange(true);
                Close();
            }
            if(!_stop)
                txtConsole.AppendText("User Cancal...");
            _stop = true;
        }
        public void Execute()
        {
            for (int i = 0; i < cmdMgr.SelectItems.Count; i++)
            {
                if (_stop)
                    break;
                string newStr = string.Format("We are downloading {0}/{1}", i, cmdMgr.SelectItems.Count);
                UpdateLabel(newStr);
                AppInfoBase it = (AppInfoBase)cmdMgr.InfoDB.Items[(int)cmdMgr.SelectItems[i]];
                string cmd = "-O " + cmdMgr.GetFilePath((int)cmdMgr.SelectItems[i]) + " " + it.url;
                if (ExecuteCmd(cmd))
                    cmdMgr.Config.Items.Add(cmdMgr.InfoDB.Items[(int)cmdMgr.SelectItems[i]]);
            }
            for (int i = 0; i < cmdMgr.DelectItems.Count; i++)
            {
                if (_stop)
                    break;
                UpdateLabel("Deleting files.");
                string cmd = cmdMgr.GetFilePath((int)cmdMgr.DelectItems[i]);
                //no exception if file doesnot exists.
                File.Delete(cmd);
                cmdMgr.Config.Items.Remove(cmdMgr.InfoDB.Items[(int)cmdMgr.DelectItems[i]]);
            }
            UpdateText("Done.");
            CancalChange(_stop);
            WinAptLib.WriteToFile(cmdMgr.Config, MainForm.configFile);
            _stop = true;
            SetOKEnable();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // if thread stopped or not start, quit
            if (_stop || !needStart)
                Close();
            else
            {
                btnOK.Enabled = false;
                txtConsole.Clear();
                t = new Thread(new ThreadStart(Execute));
                t.Start();
            }
        }
        #region delegate
        private void UpdateLabel(string text)
        {
            if (this.lbAction.InvokeRequired)
            {
                SetLabelCallback d = new SetLabelCallback(UpdateLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbAction.Text = text;
            }
        }
        private void UpdateText(string text)
        {
            if (this.txtConsole.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                txtConsole.AppendText(text + "\n");
            }
        }
        private void SetOKEnable()
        {
            if (this.btnOK.InvokeRequired)
            {
                SetOKCallback d = new SetOKCallback(SetOKEnable);
                this.Invoke(d);
            }
            else
            {
                btnOK.Enabled = true;
            }
        }
        #endregion
        public bool ExecuteCmd(string param)
        {
            ProcessStartInfo start = new ProcessStartInfo("wget.exe");
            //set params
            start.Arguments = param;
            //no dos window
            start.CreateNoWindow = true;
            //start.RedirectStandardOutput = true;//
            start.RedirectStandardInput = true;//
            start.RedirectStandardError = true;
            start.UseShellExecute = false;
            Process p = Process.Start(start);
            //get output stream
            StreamReader reader = p.StandardError;
            //StreamReader rdOutput = p.StandardOutput;
            //one line per time
            string errLine = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                UpdateText(errLine);
                errLine = reader.ReadLine();
                if (_stop)
                    break;
            }
            if (_stop)
            {
                p.Kill();
                UpdateText("Waiting for cancal..."); 
            }
            else
                p.WaitForExit();
            p.Close();
            reader.Close();
            return !_stop;
        }
        private void CancalChange(bool flag)
        {
            if (flag)
            {
                foreach (int i in cmdMgr.SelectItems)
                {
                    AppInfoBase item = (AppInfoBase)cmdMgr.InfoDB.Items[i];
                    item.setState(0);
                }
                
                foreach (int i in cmdMgr.DelectItems)
                {
                    AppInfoBase item = (AppInfoBase)cmdMgr.InfoDB.Items[i];
                    item.setState(1);
                }
            }
            cmdMgr.SelectItems.Clear();
            cmdMgr.DelectItems.Clear();
        }
    }
}