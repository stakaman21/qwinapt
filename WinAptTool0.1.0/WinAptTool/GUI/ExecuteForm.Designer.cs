namespace WinApt.Client.GUI
{
    partial class ExecuteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecuteForm));
            this.lbAction = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnCancal = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAction
            // 
            resources.ApplyResources(this.lbAction, "lbAction");
            this.lbAction.Name = "lbAction";
            // 
            // txtConsole
            // 
            resources.ApplyResources(this.txtConsole, "txtConsole");
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            // 
            // btnCancal
            // 
            resources.ApplyResources(this.btnCancal, "btnCancal");
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.UseVisualStyleBackColor = true;
            this.btnCancal.Click += new System.EventHandler(this.btnCancal_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ExecuteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lbAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExecuteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnCancal;
        private System.Windows.Forms.Button btnOK;
    }
}