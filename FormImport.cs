/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-30
 * 时间: 22:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using DomainModel;

namespace WGSF
{
	/// <summary>
	/// Description of FormImport.
	/// </summary>
	public partial class FormImport : Form
	{
		public FormImport()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonImportCustomersClick(object sender, EventArgs e)
		{
			//导入excel的数据
			DataSet tds;
			string fName ="";
			OpenFileDialog openFileDialog = new OpenFileDialog();
	        openFileDialog.Filter = "Excel2003文件|*.xls|Excel2007文件|*.xlsx";
	        if (openFileDialog.ShowDialog() == DialogResult.OK)
	        {	             
	             fName = openFileDialog.FileName;
	        }
	        else
	        {
	        	return;
	        }
	        string strCon;
	        
	        FileInfo file = new FileInfo(fName);
         	if (!file.Exists) { throw new Exception("文件不存在"); }
         	string extension = file.Extension;
	         switch (extension)
	         {
	             case ".xls":
	                 strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
	                 break;
	             case ".xlsx":
	                 strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
	                 break;
	             default:
	                 strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
	                 break;
	         }        
	        
	       
	        OleDbConnection myConn = new OleDbConnection(strCon);
	        string strCom = " SELECT * FROM [Sheet1$]";
	        myConn.Open();
	        OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
	        tds = new DataSet();
	        myCommand.Fill(tds);
	        if(tds.Tables[0].Rows.Count > 0)
	        {
		        BLL.CustomersBLL.FillCustomers(tds.Tables[0]);	       
	            MessageBox.Show("数据导入完成！");
	        }
	        else
	        {
	        	MessageBox.Show("没有数据导入！");
	        }
		}
		void ButtonImportWyInfosClick(object sender, EventArgs e)
		{
			//导入excel的数据
			DataSet tds;
			string fName ="";
			OpenFileDialog openFileDialog = new OpenFileDialog();
	        openFileDialog.Filter = "Excel文件|*.xls";
	        if (openFileDialog.ShowDialog() == DialogResult.OK)
	        {	             
	             fName = openFileDialog.FileName;
	        }
	        else
	        {
	        	return;
	        }
	        string strCon;
	        
	        FileInfo file = new FileInfo(fName);
         	if (!file.Exists) { throw new Exception("文件不存在"); }
         	string extension = file.Extension;
         	switch (extension)
         	{
         		case ".xls":
	                 strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
	                 break;
	            case ".xlsx":
	                 strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
	                 break;
	            default:
	                 strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
	                 break;
         	}
	        OleDbConnection myConn = new OleDbConnection(strCon);
	        string strCom = " SELECT * FROM [Sheet1$]";
	        myConn.Open();
	        OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
	        tds = new DataSet();
	        myCommand.Fill(tds);
	        if(tds.Tables[0].Rows.Count > 0)
	        {	        
		        BLL.WyInfosBLL.FillWyInfos(tds.Tables[0]);	        
		        MessageBox.Show("数据导入完成！");
	        }
	        else
	        {
	        	MessageBox.Show("没有数据导入！");
	        }
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//清空数据
			if(textBox2.Text == "我确认要清空数据")
			{
				DialogResult result;
				result = MessageBox.Show("您确认清空数据吗，数据将不可恢复！！！？", "清空再确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               	if (result == System.Windows.Forms.DialogResult.Yes)
                {
               		BLL.ComBLL.ClearData();
               	}
			}
			this.Close();
		}

	}
}
