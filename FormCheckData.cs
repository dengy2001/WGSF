/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 15:06
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DomainModel;

using System.Collections;
using System.Text.RegularExpressions;

namespace WGSF
{
	/// <summary>
	/// Description of FormCheckData.
	/// </summary>
	public partial class FormCheckData : Form
	{
		public FormCheckData()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void ButtonCheckNowClick(object sender, EventArgs e)
		{
			textBoxResult.Text = "";
			//检查数据输入的正确性与完整性
			//1.物业没有对应缴费对象的
			labelStatus.Text = "检查中：开始检查物业与缴费对象的对应关系.......";
			DataSet ds = new DataSet();
			ds = BLL.WyInfosBLL.GetNoCustomerWyInfos();
			labelStatus.Text = "检查中：数据库查询成功.......";
			textBoxResult.Text += "以下物业未对应缴费对象：" + System.Environment.NewLine;
			textBoxResult.Text += "============================================" + System.Environment.NewLine;
			Application.DoEvents();
			int i = 0;
			int iCount = ds.Tables[0].Rows.Count;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				i++;
				textBoxResult.Text += row["WyName"].ToString() + "【" + row["WyID"].ToString() + "】" + System.Environment.NewLine;
				labelStatus.Text = "检查中：数据" + i.ToString() + "/" + iCount.ToString();
				Application.DoEvents();
			}			
			textBoxResult.Text += "--------------------------------------------" + System.Environment.NewLine;
			textBoxResult.Text += System.Environment.NewLine;
			//2.计量表没有对应物业的
			ds = BLL.MetersBLL.GetNoWyIDMeters();
			labelStatus.Text = "检查中：数据库查询成功.......";
			textBoxResult.Text += "以下计量表缺对应物业：" + System.Environment.NewLine;
			textBoxResult.Text += "============================================" + System.Environment.NewLine;
			Application.DoEvents();
			i = 0;
			iCount = ds.Tables[0].Rows.Count;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				i++;
				textBoxResult.Text += row["MeterName"].ToString() + "【" + row["MeterID"].ToString() + "】" + System.Environment.NewLine;
				labelStatus.Text = "检查中：数据" + i.ToString() + "/" + iCount.ToString();
				Application.DoEvents();
			}			
			textBoxResult.Text += "--------------------------------------------" + System.Environment.NewLine;
			textBoxResult.Text += System.Environment.NewLine;
			//3.计量表没有对应收费项的
			ds = BLL.MetersBLL.GetNoRateIDMeters();
			labelStatus.Text = "检查中：数据库查询成功.......";
			textBoxResult.Text += "以下计量表缺收费项：" + System.Environment.NewLine;
			textBoxResult.Text += "============================================" + System.Environment.NewLine;
			Application.DoEvents();
			i = 0;
			iCount = ds.Tables[0].Rows.Count;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				i++;
				textBoxResult.Text += row["MeterName"].ToString() + "【" + row["MeterID"].ToString() + "】" + System.Environment.NewLine;
				labelStatus.Text = "检查中：数据" + i.ToString() + "/" + iCount.ToString();
				Application.DoEvents();
			}			
			textBoxResult.Text += "--------------------------------------------" + System.Environment.NewLine;
			textBoxResult.Text += System.Environment.NewLine;
			
			//4.物业收费项重复的
			ds = BLL.WyInfosBLL.GetDupWyInfos();
			labelStatus.Text = "检查中：数据库查询成功.......";
			textBoxResult.Text += "以下物业收费项有重复：" + System.Environment.NewLine;
			textBoxResult.Text += "============================================" + System.Environment.NewLine;
			Application.DoEvents();
			i = 0;
			iCount = ds.Tables[0].Rows.Count;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				i++;
				textBoxResult.Text += row["WyName"].ToString() + "【" + row["WyID"].ToString() + "】" + "【" + row["RateID"].ToString() + "】" + System.Environment.NewLine;
				labelStatus.Text = "检查中：数据" + i.ToString() + "/" + iCount.ToString();
				Application.DoEvents();
			}			
			textBoxResult.Text += "--------------------------------------------" + System.Environment.NewLine;
			textBoxResult.Text += System.Environment.NewLine;
			

			labelStatus.Text = "检查完成！";
		}
	}
}
