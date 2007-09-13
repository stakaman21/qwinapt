/*
 * Created by SharpDevelop.
 * User: zhou
 * Date: 2007-8-28
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Windows.Forms;
using WinApt.Client.GUI;
using WinApt.Common;

namespace WinApt.Client
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class EntryPoint
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            SplashForm mySplash = new SplashForm();
            bool exitFlag = false;
            mySplash.Show();
            try
            {
                mySplash.InitApp();
            }
            catch (Exception e)
            {
                //build new config file.
                if (e.Message == "new")
                {
                    ChoseForm myChoseForm = new ChoseForm();
                    myChoseForm.ShowDialog(mySplash);
                    if (myChoseForm.DialogResult == DialogResult.OK)
                    {
                        myChoseForm.Config();
                        mySplash.InitApp();
                    }
                    myChoseForm.Close();
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
            }
            finally
            {
                mySplash.Close();
                exitFlag = false;
            }
            if (exitFlag)
                return;
            Application.Run(new MainForm());
		}
		
	}
}
