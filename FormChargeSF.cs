/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-04
 * 时间: 10:00
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
	/// Description of FormChargeSF.
	/// </summary>
	public partial class FormChargeSF : Form
	{
		private DataSet ds1 = new DataSet();		//缴费对象
		private DataSet ds2 = new DataSet();		//
		private DataSet ds3 = new DataSet();		//可用周期
		
		public FormChargeSF()
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
			//关闭窗口
			((MainForm)(this.ParentForm)).Page_Close(this);
            this.Close();
		}
		void FormChargeSFLoad(object sender, EventArgs e)
		{
			//填充缴费对象下拉列表
			ds1 = BLL.ChargeBLL.GetCustomersCanSF();
			ds3 = BLL.ChargeBLL.GetAllPeriodNoFromCharge();
			comboBoxPeriodNo.DataSource = ds3.Tables[0];
			comboBoxPeriodNo.DisplayMember = "PeriodNo";
			comboBoxPeriodNo.ValueMember = "PeriodNo";
			
			comboBoxCustomer.DataSource = ds1.Tables[0];
			comboBoxCustomer.DisplayMember = "CustomerName";
			comboBoxCustomer.ValueMember = "CustomerID";
			
			ComboBoxCustomerSelectedIndexChanged(null,null);
		}
		
		void FillDataGridView(DataGridView dv,int i_CustomerID)
		{
			if(checkBoxDisp.Checked)
			{
				ds2 = BLL.ChargeBLL.GetCanSFAll(i_CustomerID,comboBoxPeriodNo.Text);
			}
			else
			{
				ds2 = BLL.ChargeBLL.GetCanSF(i_CustomerID,comboBoxPeriodNo.Text);
			}
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
		void ComboBoxCustomerSelectedIndexChanged(object sender, EventArgs e)
		{
			//选择变化，将当前指定的缴费对象所有还需要完成收费手续的项列示出来
			if(comboBoxCustomer.SelectedValue == null)
			{
				return;
			}
			if(comboBoxCustomer.SelectedValue.GetType() == typeof(System.Int32) || comboBoxCustomer.SelectedValue.GetType() == typeof(System.Int64))
			{
				
				//刷新显示
				FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
				
				Recal();
			}
		}
		
		void Recal()
		{
			//计算合计结果
				
			int iCount = 0;
			decimal dTotal = 0.0m;
			DataRow[] drs;
			drs = ds2.Tables[0].Select("1=1");
			for (int i = 0; i < drs.Length; i++)
            {
				iCount++;
				dTotal += Convert.ToDecimal(drs[i]["ChargeYS"]);
			}
			dTotal = Math.Round(dTotal,2);
			
			labelCalResult.Text = "共 " + iCount.ToString() + " 项收费，合计 " + dTotal.ToString() + " 元。";
		}
		
		void 暂缓收费ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				int i_CDNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CDNo"].Value.ToString());
				ChargeDetail tCharge = BLL.ChargeBLL.GetChargeDetail(i_CDNo);
				tCharge.ChargeStatus = "暂未收";
				BLL.ChargeBLL.UpdateChargeDetail(tCharge);
				FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
				Recal();
			}
		}
		void 免收ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				int i_CDNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CDNo"].Value.ToString());
				ChargeDetail tCharge = BLL.ChargeBLL.GetChargeDetail(i_CDNo);
				tCharge.ChargeStatus = "免收";
				BLL.ChargeBLL.UpdateChargeDetail(tCharge);
				FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
				Recal();
			}
		}
		void 取消暂缓ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				if(dataGridView1.CurrentRow.Cells["ChargeStatus"].Value.ToString() != "暂未收")
				{
					return;
				}
				int i_CDNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CDNo"].Value.ToString());
				ChargeDetail tCharge = BLL.ChargeBLL.GetChargeDetail(i_CDNo);
				if(dataGridView1.CurrentRow.Cells["ChargeName"].Value.ToString() == "增加收费")
				{
					tCharge.ChargeStatus = "增加收费";
				}
				else
				{
					tCharge.ChargeStatus = "已计费";
				}
				BLL.ChargeBLL.UpdateChargeDetail(tCharge);
				FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
				Recal();
			}
		}
		void 取消免收ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				int i_CDNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CDNo"].Value.ToString());
				if(dataGridView1.CurrentRow.Cells["ChargeStatus"].Value.ToString() != "免收")
				{
					return;
				}
				ChargeDetail tCharge = BLL.ChargeBLL.GetChargeDetail(i_CDNo);
				if(dataGridView1.CurrentRow.Cells["ChargeName"].Value.ToString() == "增加收费")
				{
					tCharge.ChargeStatus = "增加收费";
				}
				else
				{
					tCharge.ChargeStatus = "已计费";
				}
				BLL.ChargeBLL.UpdateChargeDetail(tCharge);
				FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
				Recal();
			}
		}
		void CheckBoxDispCheckedChanged(object sender, EventArgs e)
		{
			ComboBoxCustomerSelectedIndexChanged(null,null);
		}
		
		void ButtonNewClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				FormChargeAdd tForm = new FormChargeAdd();
				tForm.i_CDNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CDNo"].Value.ToString());
				tForm.ShowDialog();
			}
			FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
			Recal();
		}
		
		void 删除ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				int i_CDNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CDNo"].Value.ToString());
				if(dataGridView1.CurrentRow.Cells["ChargeName"].Value.ToString()=="增加收费")
				{
					BLL.ChargeBLL.DelChargeDetail(i_CDNo);
				}
				
			}
			FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
			Recal();
		}
		void ButtonSFClick(object sender, EventArgs e)
		{
			if(comboBoxCustomer.SelectedValue != null)
			{
				FormSF tForm = new FormSF();
				tForm.i_CustomerID = Convert.ToInt32(comboBoxCustomer.SelectedValue);
				tForm.s_CustomerName = comboBoxCustomer.Text;
				tForm.s_PeriodNo = comboBoxPeriodNo.Text;
				tForm.ShowDialog();				
				
				//刷新本收费对象
				FormChargeSFLoad(null,null);
			}
		}
		void ComboBoxPeriodNoSelectedIndexChanged(object sender, EventArgs e)
		{
			//选择变化，将当前指定的缴费对象所有还需要完成收费手续的项列示出来
			if(comboBoxCustomer.SelectedValue == null)
			{
				return;
			}
			if(comboBoxCustomer.SelectedValue.GetType() == typeof(System.Int32) || comboBoxCustomer.SelectedValue.GetType() == typeof(System.Int64))
			{
				
				//刷新显示
				FillDataGridView(dataGridView1,Convert.ToInt32(comboBoxCustomer.SelectedValue));
				
				Recal();
			}
		}
		
		
		
		
	}
}
