/*
 * Created by SharpDevelop.
 * User: zhou
 * Date: 2007-8-28
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WinApt.Client
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvCatalog = new System.Windows.Forms.ListView();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvApps = new System.Windows.Forms.ListView();
            this.colApps = new System.Windows.Forms.ColumnHeader();
            this.colVersion = new System.Windows.Forms.ColumnHeader();
            this.colPop = new System.Windows.Forms.ColumnHeader();
            this.cntxtMenuAppItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemExplore = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancal = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.cntxtMenuAppItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleDescription = null;
            this.splitContainer1.AccessibleName = null;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.BackgroundImage = null;
            this.splitContainer1.Font = null;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleDescription = null;
            this.splitContainer1.Panel1.AccessibleName = null;
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.BackgroundImage = null;
            this.splitContainer1.Panel1.Controls.Add(this.lvCatalog);
            this.splitContainer1.Panel1.Font = null;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleDescription = null;
            this.splitContainer1.Panel2.AccessibleName = null;
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.BackgroundImage = null;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Font = null;
            // 
            // lvCatalog
            // 
            this.lvCatalog.AccessibleDescription = null;
            this.lvCatalog.AccessibleName = null;
            resources.ApplyResources(this.lvCatalog, "lvCatalog");
            this.lvCatalog.BackgroundImage = null;
            this.lvCatalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCatalog.FullRowSelect = true;
            this.lvCatalog.HideSelection = false;
            this.lvCatalog.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items2"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items3"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items4"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items5"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items6"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items7"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items8"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items9"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items10"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvCatalog.Items11")))});
            this.lvCatalog.LargeImageList = this.imgList1;
            this.lvCatalog.MultiSelect = false;
            this.lvCatalog.Name = "lvCatalog";
            this.lvCatalog.SmallImageList = this.imgList1;
            this.lvCatalog.TileSize = new System.Drawing.Size(168, 29);
            this.lvCatalog.UseCompatibleStateImageBehavior = false;
            this.lvCatalog.View = System.Windows.Forms.View.Tile;
            this.lvCatalog.SelectedIndexChanged += new System.EventHandler(this.lvCatalog_SelectedIndexChanged);
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "all.png");
            this.imgList1.Images.SetKeyName(1, "internet.png");
            this.imgList1.Images.SetKeyName(2, "others.png");
            this.imgList1.Images.SetKeyName(3, "office.png");
            this.imgList1.Images.SetKeyName(4, "images.png");
            this.imgList1.Images.SetKeyName(5, "media.png");
            this.imgList1.Images.SetKeyName(6, "education.png");
            this.imgList1.Images.SetKeyName(7, "games.png");
            this.imgList1.Images.SetKeyName(8, "systems.png");
            this.imgList1.Images.SetKeyName(9, "programs.png");
            this.imgList1.Images.SetKeyName(10, "fuzhu.png");
            this.imgList1.Images.SetKeyName(11, "fujian.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.AccessibleDescription = null;
            this.splitContainer2.AccessibleName = null;
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.BackgroundImage = null;
            this.splitContainer2.Font = null;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AccessibleDescription = null;
            this.splitContainer2.Panel1.AccessibleName = null;
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.BackgroundImage = null;
            this.splitContainer2.Panel1.Controls.Add(this.lvApps);
            this.splitContainer2.Panel1.Font = null;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AccessibleDescription = null;
            this.splitContainer2.Panel2.AccessibleName = null;
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.BackgroundImage = null;
            this.splitContainer2.Panel2.Controls.Add(this.txtDesc);
            this.splitContainer2.Panel2.Font = null;
            // 
            // lvApps
            // 
            this.lvApps.AccessibleDescription = null;
            this.lvApps.AccessibleName = null;
            resources.ApplyResources(this.lvApps, "lvApps");
            this.lvApps.BackgroundImage = null;
            this.lvApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvApps.CheckBoxes = true;
            this.lvApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colApps,
            this.colVersion,
            this.colPop});
            this.lvApps.ContextMenuStrip = this.cntxtMenuAppItem;
            this.lvApps.FullRowSelect = true;
            this.lvApps.GridLines = true;
            this.lvApps.HideSelection = false;
            this.lvApps.MultiSelect = false;
            this.lvApps.Name = "lvApps";
            this.lvApps.SmallImageList = this.imgList1;
            this.lvApps.UseCompatibleStateImageBehavior = false;
            this.lvApps.View = System.Windows.Forms.View.Details;
            this.lvApps.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvApps_ItemChecked);
            this.lvApps.SelectedIndexChanged += new System.EventHandler(this.lvApps_SelectedIndexChanged);
            // 
            // colApps
            // 
            resources.ApplyResources(this.colApps, "colApps");
            // 
            // colVersion
            // 
            resources.ApplyResources(this.colVersion, "colVersion");
            // 
            // colPop
            // 
            resources.ApplyResources(this.colPop, "colPop");
            // 
            // cntxtMenuAppItem
            // 
            this.cntxtMenuAppItem.AccessibleDescription = null;
            this.cntxtMenuAppItem.AccessibleName = null;
            resources.ApplyResources(this.cntxtMenuAppItem, "cntxtMenuAppItem");
            this.cntxtMenuAppItem.BackgroundImage = null;
            this.cntxtMenuAppItem.Font = null;
            this.cntxtMenuAppItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExplore,
            this.MenuItemOpen});
            this.cntxtMenuAppItem.Name = "cntxtMenuAppItem";
            this.cntxtMenuAppItem.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtMenuAppItem_Opening);
            // 
            // MenuItemExplore
            // 
            this.MenuItemExplore.AccessibleDescription = null;
            this.MenuItemExplore.AccessibleName = null;
            resources.ApplyResources(this.MenuItemExplore, "MenuItemExplore");
            this.MenuItemExplore.BackgroundImage = null;
            this.MenuItemExplore.Name = "MenuItemExplore";
            this.MenuItemExplore.ShortcutKeyDisplayString = null;
            this.MenuItemExplore.Click += new System.EventHandler(this.MenuItemExplore_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.AccessibleDescription = null;
            this.MenuItemOpen.AccessibleName = null;
            resources.ApplyResources(this.MenuItemOpen, "MenuItemOpen");
            this.MenuItemOpen.BackgroundImage = null;
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.ShortcutKeyDisplayString = null;
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.AccessibleDescription = null;
            this.txtDesc.AccessibleName = null;
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.BackgroundImage = null;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = null;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtDesc_LinkClicked);
            // 
            // lbType
            // 
            this.lbType.AccessibleDescription = null;
            this.lbType.AccessibleName = null;
            resources.ApplyResources(this.lbType, "lbType");
            this.lbType.Name = "lbType";
            // 
            // cbTypes
            // 
            this.cbTypes.AccessibleDescription = null;
            this.cbTypes.AccessibleName = null;
            resources.ApplyResources(this.cbTypes, "cbTypes");
            this.cbTypes.BackgroundImage = null;
            this.cbTypes.Font = null;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = null;
            this.txtSearch.AccessibleName = null;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BackgroundImage = null;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = null;
            this.txtSearch.Name = "txtSearch";
            // 
            // btnHelp
            // 
            this.btnHelp.AccessibleDescription = null;
            this.btnHelp.AccessibleName = null;
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.BackgroundImage = null;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.AccessibleDescription = null;
            this.btnProperty.AccessibleName = null;
            resources.ApplyResources(this.btnProperty, "btnProperty");
            this.btnProperty.BackgroundImage = null;
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnApply
            // 
            this.btnApply.AccessibleDescription = null;
            this.btnApply.AccessibleName = null;
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.BackgroundImage = null;
            this.btnApply.Name = "btnApply";
            this.btnApply.TabStop = false;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancal
            // 
            this.btnCancal.AccessibleDescription = null;
            this.btnCancal.AccessibleName = null;
            resources.ApplyResources(this.btnCancal, "btnCancal");
            this.btnCancal.BackgroundImage = null;
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.TabStop = false;
            this.btnCancal.UseVisualStyleBackColor = true;
            this.btnCancal.Click += new System.EventHandler(this.btnCancal_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleDescription = null;
            this.btnOK.AccessibleName = null;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackgroundImage = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleDescription = null;
            this.btnUpdate.AccessibleName = null;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackgroundImage = null;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleDescription = null;
            this.btnSearch.AccessibleName = null;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackgroundImage = null;
            this.btnSearch.Font = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.lbType);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.cntxtMenuAppItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ColumnHeader colVersion;
		private System.Windows.Forms.ColumnHeader colPop;
		private System.Windows.Forms.ColumnHeader colApps;
		private System.Windows.Forms.ListView lvCatalog;
		private System.Windows.Forms.RichTextBox txtDesc;
		private System.Windows.Forms.ListView lvApps;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancal;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnProperty;
		private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuAppItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExplore;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
	}
}
