/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 21:13
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
	/// Description of FormMeterReading.
	/// </summary>
	public partial class FormMeterReading : Form
	{
		private DataSet ds1 = new DataSet();		//放MeterReading
		public FormMeterReading()
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
		
		void FillDataGridView(DataGridView dv,string s_PeriodNo)
		{
			ds1 = BLL.MeterReadingBLL.GetPeriodMeterReading(s_PeriodNo);
			dv.DataSource = ds1.Tables[0];
			SetGridView1Header(dv);
		}
		
		void SetGridView1Header(DataGridView dv)
		{
			dv.AutoGenerateColumns = false;	
			//dv.ColumnCount = 3;
			//dv.ReadOnly = true;
			//dv.AllowUserToAddRows = false;
			//dv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			
            dv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dv.Columns[0].ReadOnly = true;
            dv.Columns[0].HeaderText = "RID";
			dv.Columns[0].Name = "RID";
            dv.Columns[0].Width = 40;
            dv.Columns[0].DataPropertyName = "RID";
            
            dv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[1].ReadOnly = true;
            dv.Columns[1].HeaderText = "表号";
            dv.Columns[1].Name = "MeterID";
            dv.Columns[1].Width = 40;
            dv.Columns[1].DataPropertyName = "MeterID";
            
            dv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[2].ReadOnly = true;
            dv.Columns[2].HeaderText = "表名";
            dv.Columns[2].Name = "MeterName";
            dv.Columns[2].Width = 100;
            dv.Columns[2].DataPropertyName = "MeterName";
            
            dv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[3].ReadOnly = true;
            dv.Columns[3].HeaderText = "父表号";
            dv.Columns[3].Name = "MeterPID";
            dv.Columns[3].Width = 80;
            dv.Columns[3].DataPropertyName = "MeterPID";
            
            dv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[4].ReadOnly = true;
            dv.Columns[4].Visible = false;
            dv.Columns[4].HeaderText = "父表名";
            dv.Columns[4].Name = "MeterPName";
            dv.Columns[4].Width = 100;
            dv.Columns[4].DataPropertyName = "MeterPName";
            
            dv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[5].ReadOnly = true;
            dv.Columns[5].HeaderText = "表类别";
            dv.Columns[5].Name = "MeterClass";
            dv.Columns[5].Width = 100;
            dv.Columns[5].DataPropertyName = "MeterClass";
            
            dv.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[6].ReadOnly = true;
            dv.Columns[6].HeaderText = "倍率";
            dv.Columns[6].Name = "MeterMulti";
            dv.Columns[6].Width = 40;
            dv.Columns[6].DataPropertyName = "MeterMulti";
            
            dv.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[7].ReadOnly = true;
            dv.Columns[7].HeaderText = "费率名";
            dv.Columns[7].Name = "RateName";
            dv.Columns[7].Width = 100;
            dv.Columns[7].DataPropertyName = "RateName";
            
            dv.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[8].ReadOnly = true;
            dv.Columns[8].HeaderText = "物业名";
            dv.Columns[8].Name = "WyName";
            dv.Columns[8].Width = 100;
            dv.Columns[8].DataPropertyName = "WyName";
            
            dv.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[9].DefaultCellStyle.ForeColor = Color.Brown;
            dv.Columns[9].HeaderText = "起数";
            dv.Columns[9].Name = "StartReading";
            dv.Columns[9].Width = 80;
            dv.Columns[9].DataPropertyName = "StartReading";
            
            dv.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[10].DefaultCellStyle.ForeColor = Color.Blue;
            dv.Columns[10].HeaderText = "止数";
            dv.Columns[10].Name = "EndReading";
            dv.Columns[10].Width = 80;
            dv.Columns[10].DataPropertyName = "EndReading";
            
            dv.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[11].DefaultCellStyle.ForeColor = Color.Blue;
            dv.Columns[11].HeaderText = "调整量";
            dv.Columns[11].Name = "AdjustNum";
            dv.Columns[11].Width = 80;
            dv.Columns[11].DataPropertyName = "AdjustNum";
        
            dv.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[12].ReadOnly = true;
            dv.Columns[12].HeaderText = "状态";
            dv.Columns[12].Name = "RStatus";
            dv.Columns[12].Width = 80;
            dv.Columns[12].DataPropertyName = "RStatus";
            
            dv.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[13].ReadOnly = true;
            dv.Columns[13].HeaderText = "计算量";
            dv.Columns[13].Name = "BeforeShareTotal";
            dv.Columns[13].Width = 80;
            dv.Columns[13].DataPropertyName = "BeforeShareTotal";
            
            dv.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[14].ReadOnly = true;
            dv.Columns[14].HeaderText = "分摊量";
            dv.Columns[14].Name = "ShareNum";
            dv.Columns[14].Width = 80;
            dv.Columns[14].DataPropertyName = "ShareNum";
            
            dv.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv.Columns[15].ReadOnly = true;
            dv.Columns[15].HeaderText = "实用量";
            dv.Columns[15].Name = "TotalNum";
            dv.Columns[15].Width = 80;
            dv.Columns[15].DataPropertyName = "TotalNum";
            
            //不显示出来而又需要数据的列
            dv.Columns[16].Visible = false;
            dv.Columns[16].Name = "RID";
            dv.Columns[16].DataPropertyName = "RID";
//            
//            dv.Columns[7].Visible = false;
//            dv.Columns[7].Name = "GoodsTypeID";
//            dv.Columns[7].DataPropertyName = "GoodsTypeID";
            
            
            //隐藏不需要的
            foreach(DataGridViewColumn c in dv.Columns)
            {
            	if(c.Index>15)
            	{
            		c.Visible = false;
            	}
            }
           
		}
		
		void ButtonSerarchClick(object sender, EventArgs e)
		{
			if(CheckPeriod())
			{
				FillDataGridView(dataGridView1,textBoxPeriodNo.Text);
			}
			else
			{
				MessageBox.Show("计量周期错误！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
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
		void ButtonProduceClick(object sender, EventArgs e)
		{
			//生成表计量记录空表
			if(CheckPeriod())
			{
				//
				BLL.MeterReadingBLL.ProduceMeterReading(textBoxPeriodNo.Text,labelStatus);
			}
			else
			{
				MessageBox.Show("计量周期错误！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			//更新表记录
			BLL.MeterReadingBLL.UpdateMeterReading(textBoxPeriodNo.Text,ds1.Tables[0],labelStatus);
		}
		void ButtonDelClick(object sender, EventArgs e)
		{
			//删除指定周期的计量数据
			if(CheckPeriod())
			{
				//
				DialogResult result;
				result = MessageBox.Show("您确认删除吗，已经输入的计量数据将不可恢复！！！？", "删除再确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               	if (result == System.Windows.Forms.DialogResult.Yes)
                {
               		BLL.MeterReadingBLL.DelMeterReading(textBoxPeriodNo.Text);
               	}
			}
			else
			{
				MessageBox.Show("计量周期错误！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		void ButtonCalClick(object sender, EventArgs e)
		{
			//计算指定周期的表的数据
			BLL.MeterReadingBLL.CalMeterReading(textBoxPeriodNo.Text,labelStatus);
		}
		void DataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
			//第9列是起数，10列止数，11列调整数,13列是计算量
			if(e.RowIndex>=0)
			{
				int i_RID=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
				MeterReading tMR = BLL.MeterReadingBLL.GetMeterReading(i_RID);
				tMR.StartReading = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
				tMR.EndReading = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
				tMR.AdjustNum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
				
				dataGridView1.Rows[e.RowIndex].Cells[13].Value = (tMR.EndReading - tMR.StartReading)*tMR.MeterMulti + tMR.AdjustNum;
				tMR.BeforeShareTotal = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
				BLL.MeterReadingBLL.UpdateMeterReading(tMR);
			}
		}
		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if(e.ColumnIndex == 13 && Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value)<0)
			{
				e.CellStyle.ForeColor = Color.Red;
				e.CellStyle.BackColor = Color.Yellow;
			}
		}

		
		
	}
}
