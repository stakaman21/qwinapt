/*
 * Created by SharpDevelop.
 * User: zhou
 * Date: 2007-8-28
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinApt
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		
		void MainFormLoad(object sender, EventArgs e)
		{
			//
			//TODO: load config files
			//
			
			//sample codes
		    ListViewItem item1 = new ListViewItem("item1",0);
		    // Place a check mark next to the item.
		    item1.Checked = true;
		    item1.SubItems.Add("test item 1");
		    item1.SubItems.Add("▲▲▲▲▲");
		    ListViewItem item2 = new ListViewItem("item2",1);
		    item2.SubItems.Add("test item 2");
		    item2.SubItems.Add("▲▲▲▲▲");
		    ListViewItem item3 = new ListViewItem("item3",0);
		    // Place a check mark next to the item.
		    item3.SubItems.Add("test item 3");
		    item3.SubItems.Add("▲▲▲▲▲");
		        // Create columns for the items and subitems.
			lvApps.Items.AddRange(new ListViewItem[]{item1,item2,item3});

		}

        private void lvCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
	}
}
