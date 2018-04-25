/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 10:47
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
	/// Description of FormAddWyRate.
	/// </summary>
	public partial class FormAddWyRate : Form
	{
		
		private DataSet ds1 = new DataSet();
		public int i_WyID;
		public FormAddWyRate()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FillDataGridView1()
		{
			ds1 = BLL.RatesBLL.GetAllNotMeterRates();
			dataGridView1.DataSource = ds1.Tables[0];
			SetGridView1Header();
		}
		
		void SetGridView1Header()
		{
			dataGridView1.AutoGenerateColumns = false;	
			//dataGridViewProjects.ColumnCount = 3;
			//dataGridView1.ReadOnly = true;
			//dataGridView1.AllowUserToAddRows = false;
			//dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.Columns[0].HeaderText = "收费项ID";
			dataGridView1.Columns[0].Name = "RateID";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[0].DataPropertyName = "RateID";
            
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[1].HeaderText = "收费项目";
            dataGridView1.Columns[1].Name = "RateName";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].DataPropertyName = "RateName";
            
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[2].HeaderText = "收费单位";
            dataGridView1.Columns[2].Name = "RateUnit";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DataPropertyName = "RateUnit";
            
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].HeaderText = "数值";
            dataGridView1.Columns[3].Name = "RateValue";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].DataPropertyName = "RateValue";
            
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "收费类别";
            dataGridView1.Columns[4].Name = "RateClass";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DataPropertyName = "RateClass";
            
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[5].HeaderText = "说明";
            dataGridView1.Columns[5].Name = "RateBrief";
            dataGridView1.Columns[5].Width = dataGridView1.Width - 43 - 530;
            dataGridView1.Columns[5].DataPropertyName = "RateBrief";
            
            //不显示出来的列
//            dataGridView1.Columns[6].Visible = false;
//            dataGridView1.Columns[6].Name = "GoodsID";
//            dataGridView1.Columns[6].DataPropertyName = "GoodsID";
//            
//            dataGridView1.Columns[7].Visible = false;
//            dataGridView1.Columns[7].Name = "GoodsTypeID";
//            dataGridView1.Columns[7].DataPropertyName = "GoodsTypeID";
            
            
            //隐藏不需要的
            foreach(DataGridViewColumn c in dataGridView1.Columns)
            {
            	if(c.Index>5)
            	{
            		c.Visible = false;
            	}
            }
           
		}
		void FormAddWyRateLoad(object sender, EventArgs e)
		{
			FillDataGridView1();
		}
		void ButtonCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void ButtonSaveAddClick(object sender, EventArgs e)
		{
			//保存数据
			DataGridViewSelectedRowCollection dsc = dataGridView1.SelectedRows;
			foreach (DataGridViewRow row in dsc) 
			{ 			
			    string ss = row.Cells["RateID"].Value + "\n"; 
			    int i_RateID = Convert.ToInt32(row.Cells["RateID"].Value.ToString());
			    WyRates tNew = new WyRates();
			    tNew.RateID = i_RateID;
			    tNew.WyID = i_WyID;
			    BLL.WyInfosBLL.AddWyRate(tNew);
			}
			this.Close();			
		}
		
		
		
		
	}
}
