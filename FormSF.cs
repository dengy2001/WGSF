/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-02
 * 时间: 15:12
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
	/// Description of FormSF.
	/// </summary>
	public partial class FormSF : Form
	{
		public int i_CustomerID;
		public string s_CustomerName;
		public string s_PeriodNo;
		private DataSet ds2 = new DataSet();
		
		public FormSF()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FormSFLoad(object sender, EventArgs e)
		{
			textBoxCustomerName.Text = s_CustomerName;
			textBoxPeriodNo.Text = s_PeriodNo;
			//刷新显示
			FillDataGridView(dataGridView1,i_CustomerID);
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
		
		void ButtonOKClick(object sender, EventArgs e)
		{
			if(CheckPeriod())
			{
				if(textBoxPerson.Text != string.Empty)
				{
					//将当前可缴费项更新成已收费
					int i_CFID = BLL.ChargeBLL.UpDateSFData(i_CustomerID,textBoxPeriodNo.Text,textBoxPerson.Text);
					MessageBox.Show("收费项已更新！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Close();
					//打印收费单
					//PrintSFD(i_CFID);
				}
				else
				{
					MessageBox.Show("收费人员必须填写！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("计费周期错误！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		void PrintSFD(int i_CFID)
		{
			DataSet tmpDs= BLL.ChargeBLL.GetSFDs(i_CFID);
			//
			FastReport.Report report1 = new FastReport.Report();
			report1.Load("Reports\\SFPrint.frx");

			DataSet FDataSet = new DataSet();
			DataTable table = new DataTable();
			table = tmpDs.Tables[0].Copy();
			table.TableName = "ChargeF";
			FDataSet.Tables.Add(table);		
			
			tmpDs = BLL.ChargeBLL.GetSFChargeDetail(i_CFID);
			table = tmpDs.Tables[0].Copy();
			table.TableName = "ChargeDetail";
			FDataSet.Tables.Add(table);	
			DataRelation dr  = new DataRelation("FK_1",FDataSet.Tables["ChargeF"].Columns["CFID"],FDataSet.Tables["ChargeDetail"].Columns["CFID"]);
			FDataSet.Relations.Add(dr);			
			
			report1.RegisterData(FDataSet);
			report1.Show();
			report1.Dispose();
		}
		
		void FillDataGridView(DataGridView dv,int i_CustomerID)
		{			
			ds2 = BLL.ChargeBLL.GetCanSFOK(i_CustomerID,s_PeriodNo);
			dv.DataSource = ds2.Tables[0];
			SetGridView1Header(dv);
		}
		
		void SetGridView1Header(DataGridView dv)
		{
			dv.AutoGenerateColumns = false;	
			//dv.ColumnCount = 3;
			dv.ReadOnly = true;
			//dv.AllowUserToAddRows = false;
			//dv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
            dv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[0].ReadOnly = true;
            dv.Columns[0].HeaderText = "CDNo";
			dv.Columns[0].Name = "CDNo";
            dv.Columns[0].Width = 40;
            dv.Columns[0].DataPropertyName = "CDNo";
            
            dv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[1].ReadOnly = true;
            dv.Columns[1].HeaderText = "计费周期";
            dv.Columns[1].Name = "PeriodNo";
            dv.Columns[1].Width = 100;
            dv.Columns[1].DataPropertyName = "PeriodNo";
            
            dv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[2].ReadOnly = true;
            dv.Columns[2].Visible = false;
            dv.Columns[2].HeaderText = "物业ID";
            dv.Columns[2].Name = "WyID";
            dv.Columns[2].Width = 100;
            dv.Columns[2].DataPropertyName = "WyID";
            
            dv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[3].ReadOnly = true;
            dv.Columns[3].HeaderText = "物业名称";
            dv.Columns[3].Name = "WyName";
            dv.Columns[3].Width = 80;
            dv.Columns[3].DataPropertyName = "WyName";
            
            dv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dv.Columns[4].ReadOnly = true;
            dv.Columns[4].HeaderText = "摘要";
            dv.Columns[4].Name = "Abstract";
            dv.Columns[4].Width = dv.Width - 43 - 780;
            dv.Columns[4].DataPropertyName = "Abstract";
            
            dv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[5].ReadOnly = true;
            dv.Columns[5].HeaderText = "计费状态";
            dv.Columns[5].Name = "ChargeStatus";
            dv.Columns[5].Width = 80;
            dv.Columns[5].DataPropertyName = "ChargeStatus";
            
            dv.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[6].ReadOnly = true;
            dv.Columns[6].HeaderText = "计费单位";
            dv.Columns[6].Name = "ChargeUnit";
            dv.Columns[6].Width = 80;
            dv.Columns[6].DataPropertyName = "ChargeUnit";
            
            dv.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[7].ReadOnly = true;
            dv.Columns[7].HeaderText = "数量";
            dv.Columns[7].Name = "ChargeNum";
            dv.Columns[7].Width = 100;
            dv.Columns[7].DataPropertyName = "ChargeNum";
            
            dv.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[8].ReadOnly = true;
            dv.Columns[8].HeaderText = "单价";
            dv.Columns[8].Name = "ChargePrice";
            dv.Columns[8].Width = 100;
            dv.Columns[8].DataPropertyName = "ChargePrice";
            
            dv.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[9].DefaultCellStyle.ForeColor = Color.Brown;
            dv.Columns[9].HeaderText = "金额";
            dv.Columns[9].Name = "ChargeYS";
            dv.Columns[9].Width = 100;
            dv.Columns[9].DataPropertyName = "ChargeYS";
            
            
            
            //不显示出来而又需要数据的列
            dv.Columns[10].Visible = false;
            dv.Columns[10].Name = "ChargeName";
            dv.Columns[10].DataPropertyName = "ChargeName";
//            
//            dv.Columns[7].Visible = false;
//            dv.Columns[7].Name = "GoodsTypeID";
//            dv.Columns[7].DataPropertyName = "GoodsTypeID";
            
            
            //隐藏不需要的
            foreach(DataGridViewColumn c in dv.Columns)
            {
            	if(c.Index>9)
            	{
            		c.Visible = false;
            	}
            }
           
		}
		void ButtonQuitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
	}
}
