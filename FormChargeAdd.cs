/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-04
 * 时间: 22:08
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using DomainModel;

using System.Collections;
using System.Text.RegularExpressions;

namespace WGSF
{
	/// <summary>
	/// Description of FormChargeAdd.
	/// </summary>
	public partial class FormChargeAdd : Form
	{
		public int i_CDNo;
		
		public FormChargeAdd()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonQuitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			//保存
			if(CheckPeriod())
			{
				ChargeDetail tNew = BLL.ChargeBLL.GetChargeDetail(i_CDNo);
				tNew.Abstract = textBoxAbstract.Text;
				tNew.PeriodNo = textBoxPeriodNo.Text;
				tNew.ChargeUnit = textBoxChargeUnit.Text;
				tNew.ChargePrice = Convert.ToDecimal(textBoxChargePrice.Text);
				tNew.ChargeNum = Convert.ToDecimal(textBoxChargeNum.Text);
				tNew.ChargeYS = tNew.ChargeNum * tNew.ChargePrice;
				tNew.ChargeStatus = "增加收费";
				tNew.ChargeName = "增加收费";
				tNew.ChargeDate = DateTime.Now;
				tNew.RID = null;
				tNew.WyRateID = null;
				
				BLL.ChargeBLL.AddChargeDetail(tNew);
			}
			else
			{
				MessageBox.Show("计费周期错误！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			this.Close();
		}
		
		bool CheckPeriod()
		{
			string pattern = @"(^\d{4}0[1-9]|^\d{4}1[0-2])";

			if(textBoxPeriodNo.Text.Length == 6 && DyMatch(textBoxPeriodNo.Text,pattern))
			{
				return true;
			}
			return false;
		}		
		bool DyMatch(string tStr,string pattern)
		{			
			Regex reg;
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{				
				return false;
			}
			else
			{
				return true;
			}
		}
		void TextBoxChargePriceTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxChargePrice.Text;
			if(tStr == "")
				return;
			pattern = @"(^[0-9]+$)|(^[0-9]+.([0-9])*?$)";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxChargePrice.Text = textBoxChargePrice.Text.Substring(0,textBoxChargePrice.Text.Length-1);
				textBoxChargePrice.Select(textBoxChargePrice.Text.Length,0);
				return;
			}
		}
		void TextBoxChargeNumTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxChargeNum.Text;
			if(tStr == "")
				return;
			pattern = @"(^[0-9]+$)|(^[0-9]+.([0-9])*?$)";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxChargeNum.Text = textBoxChargeNum.Text.Substring(0,textBoxChargeNum.Text.Length-1);
				textBoxChargeNum.Select(textBoxChargeNum.Text.Length,0);
				return;
			}
		}
		
		
	}
}
