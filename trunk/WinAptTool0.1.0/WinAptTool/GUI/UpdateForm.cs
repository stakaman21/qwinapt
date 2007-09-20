using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using WinApt.Common;

namespace WinApt.Client.GUI
{
    public partial class UpdateForm : Form
    {
        private string url;
        public UpdateForm(string url)
        {
            InitializeComponent();
            this.url = url;
        }

        private void UpdateForm_Shown(object sender, EventArgs e)
        {
            if (!WinAptLib.DownloadDbFile(url, this.proBar))
            {
                MessageBox.Show(string.Format(MainForm.LocRM.GetString("strSplashLabelDownloadError"),url));
            }
            Close();
        }

    }
}