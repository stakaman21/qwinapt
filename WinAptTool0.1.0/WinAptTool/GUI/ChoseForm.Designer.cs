namespace WinApt.Client.GUI
{
    partial class ChoseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoseForm));
            this.lbText = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fdDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AccessibleDescription = null;
            this.lbText.AccessibleName = null;
            resources.ApplyResources(this.lbText, "lbText");
            this.lbText.Font = null;
            this.lbText.Name = "lbText";
            // 
            // txtPath
            // 
            this.txtPath.AccessibleDescription = null;
            this.txtPath.AccessibleName = null;
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.BackgroundImage = null;
            this.txtPath.Font = null;
            this.txtPath.Name = "txtPath";
            // 
            // btnBrowser
            // 
            this.btnBrowser.AccessibleDescription = null;
            this.btnBrowser.AccessibleName = null;
            resources.ApplyResources(this.btnBrowser, "btnBrowser");
            this.btnBrowser.BackgroundImage = null;
            this.btnBrowser.Font = null;
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleDescription = null;
            this.btnOK.AccessibleName = null;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackgroundImage = null;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // fdDlg
            // 
            resources.ApplyResources(this.fdDlg, "fdDlg");
            // 
            // ChoseForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lbText);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = null;
            this.Name = "ChoseForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog fdDlg;
    }
}