/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-07
 * 时间: 9:43
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
	/// Description of FormHisSF.
	/// </summary>
	public partial class FormHisSF : Form
	{
		private DataSet ds1 = new DataSet();
		private DataSet ds2 = new DataSet();
		public FormHisSF()
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
			//关闭窗口
			((MainForm)(this.ParentForm)).Page_Close(this);
            this.Close();
		}
		
		private DataTable GetNewDataTable(DataTable dt, string condition,string sortstr)
        {
            DataTable newdt = new DataTable();
            newdt = dt.Clone();
            DataRow[] dr = dt.Select(condition,sortstr);
            for (int i = 0; i < dr.Length; i++)
            {
                newdt.ImportRow((DataRow)dr[i]);
            }
            return newdt;//返回的查询结果
        } 
		
		void FillDataGridView1(DataGridView dv)
		{
			
			string s_in = textBoxFilter.Text;			
			string s_condition ;
			if(s_in.Length>0)
			{
				s_condition = "PeriodNo Like '%" + s_in + "%' OR CustomerName Like '%" + s_in + "%'";
			}
			else
			{
				s_condition = "1=1";
			}
			dv.DataSource = GetNewDataTable(ds1.Tables[0],s_condition,"CFID desc");
			SetGridView1Header1(dv);
		}
		
		void FillDataGridView2(DataGridView dv,int i_CFID)
		{
			ds2 = BLL.ChargeBLL.GetSFChargeDetail(i_CFID);
			dv.DataSource = ds2.Tables[0];
			SetGridView1Header2(dv);
		}
		
		void SetGridView1Header1(DataGridView dv)
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
            dv.Columns[0].HeaderText = "收费单号";
			dv.Columns[0].Name = "CFID";
            dv.Columns[0].Width = 80;
            dv.Columns[0].DataPropertyName = "CFID";
            
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
            dv.Columns[2].HeaderText = "缴费对象";
            dv.Columns[2].Name = "CustomerName";
            dv.Columns[2].Width = 120;
            dv.Columns[2].DataPropertyName = "CustomerName";
            
            dv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[3].ReadOnly = true;
            dv.Columns[3].HeaderText = "缴费金额";
            dv.Columns[3].Name = "ChargeTotal";
            dv.Columns[3].Width = 100;
            dv.Columns[3].DataPropertyName = "ChargeTotal";            
      
            
            
            
            //不显示出来而又需要数据的列
//            dv.Columns[10].Visible = false;
//            dv.Columns[10].Name = "ChargeName";
//            dv.Columns[10].DataPropertyName = "ChargeName";
//            
//            dv.Columns[7].Visible = false;
//            dv.Columns[7].Name = "GoodsTypeID";
//            dv.Columns[7].DataPropertyName = "GoodsTypeID";
            
            
            //隐藏不需要的
            foreach(DataGridViewColumn c in dv.Columns)
            {
            	if(c.Index>3)
            	{
            		c.Visible = false;
            	}
            }
           
		}
		
		
		
		void SetGridView1Header2(DataGridView dv)
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
            dv.Columns[3].Visible = false;
            dv.Columns[3].HeaderText = "物业名称";
            dv.Columns[3].Name = "WyName";
            dv.Columns[3].Width = 80;
            dv.Columns[3].DataPropertyName = "WyName";
            
            dv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dv.Columns[4].ReadOnly = true;
            dv.Columns[4].HeaderText = "摘要";
            dv.Columns[4].Name = "Abstract";
            dv.Columns[4].Width = 150;
            dv.Columns[4].DataPropertyName = "Abstract";
            
            dv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[5].ReadOnly = true;
            dv.Columns[2].Visible = false;
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
//            dv.Columns[10].Visible = false;
//            dv.Columns[10].Name = "ChargeName";
//            dv.Columns[10].DataPropertyName = "ChargeName";
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
		void FormHisSFLoad(object sender, EventArgs e)
		{
			ds1 = BLL.ChargeBLL.GetSFDs();			
			FillDataGridView1(dataGridView1);
			
		}
		void TextBoxFilterTextChanged(object sender, EventArgs e)
		{
			FillDataGridView1(dataGridView1);
		}
		void DataGridView1SelectionChanged(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				string s_CFID = dataGridView1.CurrentRow.Cells["CFID"].Value.ToString();
				int i_CFID ;
				try
				{
					i_CFID = Convert.ToInt32(s_CFID);
				}
				catch(Exception e1)
				{
					return;
				}
				FillDataGridView2(dataGridView2,i_CFID);
			}
		}
		void ButtonPrintClick(object sender, EventArgs e)
		{
			string s_CFIDs = "";
			foreach(DataGridViewRow drs in dataGridView1.SelectedRows)
			{
				s_CFIDs += drs.Cells["CFID"].Value.ToString();
				s_CFIDs += ",";
			}
			
			if(s_CFIDs != "")
			{
				s_CFIDs = s_CFIDs.Substring(0,s_CFIDs.Length - 1);
				s_CFIDs = "(" + s_CFIDs + ")";
			}
			else
			{
				s_CFIDs = "(0)";
			}
				
			DataSet tmpDs= BLL.ChargeBLL.GetSFDs(s_CFIDs);
			//
			FastReport.Report report1 = new FastReport.Report();
			report1.Load("Reports\\SFPrint.frx");

			DataSet FDataSet = new DataSet();
			DataTable table = new DataTable();
			table = tmpDs.Tables[0].Copy();
			table.TableName = "ChargeF";
			FDataSet.Tables.Add(table);		
			
			tmpDs = BLL.ChargeBLL.GetSFChargeDetail(s_CFIDs);
			if(ds2.Tables.Count == 0)
			{
				return;
			}
			table = tmpDs.Tables[0].Copy();
			table.TableName = "ChargeDetail";
			FDataSet.Tables.Add(table);	
			DataRelation dr  = new DataRelation("FK_1",FDataSet.Tables["ChargeF"].Columns["CFID"],FDataSet.Tables["ChargeDetail"].Columns["CFID"]);
			FDataSet.Relations.Add(dr);			
			
			report1.RegisterData(FDataSet);
			report1.Show();
			report1.Dispose();
		}
		void 回退到未收费状态ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//当前选择项回退到未收费状态
			string s_CFIDs = "";
			foreach(DataGridViewRow drs in dataGridView1.SelectedRows)
			{
				s_CFIDs += drs.Cells["CFID"].Value.ToString();
				s_CFIDs += ",";
			}
			
			if(s_CFIDs != "")
			{
				s_CFIDs = s_CFIDs.Substring(0,s_CFIDs.Length - 1);
				s_CFIDs = "(" + s_CFIDs + ")";
			}
			else
			{
				s_CFIDs = "(0)";
			}

			BLL.ChargeBLL.BackStatus(s_CFIDs);
			ds1 = BLL.ChargeBLL.GetSFDs();			
			FillDataGridView1(dataGridView1);
		}
		
		
		
		
	}
}
