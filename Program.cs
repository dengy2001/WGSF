/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 15:06
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Windows.Forms;

namespace WGSF
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			FormDataBaseSelect tForm=new FormDataBaseSelect();
			DialogResult dr = tForm.ShowDialog();
			if(dr != DialogResult.OK)
			{
				Application.Exit();
				return;
			}
			
			Application.Run(new MainForm());
			
		}
		
	}
}
