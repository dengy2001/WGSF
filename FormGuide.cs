/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 17:00
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DomainModel;
using System.Data.OleDb;

namespace WGSF
{
	/// <summary>
	/// Description of FormGuide.
	/// </summary>
	public partial class FormGuide : Form
	{
		public FormGuide()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			DataSet ds;
	        string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" +
	                        "Extended Properties=Excel 8.0;" +
	                        "data source=" + "Pay.xls";
	        OleDbConnection myConn = new OleDbConnection(strCon);
	        string strCom = " SELECT * FROM [Sheet1$]";
	        myConn.Open();
	        OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
	        ds = new DataSet();
	        myCommand.Fill(ds);
	        
	        BLL.CustomersBLL.FillCustomers(ds.Tables[0]);
	        
            MessageBox.Show("好了，去卡卡那");
	        

		}
	}
}
