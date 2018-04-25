/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 20:08
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
	/// Description of FormRates.
	/// </summary>
	public partial class FormRates : Form
	{
		private ArrayList l_RateClass = new ArrayList();
		private ArrayList l_RateUnit = new ArrayList();
		private DataSet ds1 = new DataSet();
		
		public FormRates()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FormRatesLoad(object sender, EventArgs e)
		{
			l_RateClass.Add("周期性收费");
			l_RateClass.Add("临时性收费");
			l_RateClass.Add("押金类收费");
			l_RateClass.Add("表计量收费");
			
			l_RateUnit.Add("建筑面积");
			l_RateUnit.Add("套内面积");
			l_RateUnit.Add("公摊面积");
			l_RateUnit.Add("人口数");
			l_RateUnit.Add("设定金额");
			l_RateUnit.Add("度");
			l_RateUnit.Add("吨");
			
			comboBoxRateClass.DataSource = l_RateClass;
			comboBoxRateUnit.DataSource = l_RateUnit;
			
			//调整panel的高度
			panel2.Visible = false;
			panel1.Height = panel1.Height + panel2.Height + 10;
			
			FillDataGridView1();
		}
		
		void FillDataGridView1()
		{
			ds1 = BLL.RatesBLL.GetAllRates();
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
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			//调整panel的高度
			panel2.Visible = true;
			panel1.Height = panel1.Height - panel2.Height - 10;
			
			buttonAdd.Enabled = false;
			buttonModify.Enabled = false;
			buttonDel.Enabled = false;
			新收费项ToolStripMenuItem.Enabled = false;
			修改收费项ToolStripMenuItem.Enabled = false;
			删除收费项ToolStripMenuItem.Enabled = false;
			
			textBoxRateID.Text = "";
			//设定第一个输入的焦点
			textBoxRateName.Focus();
		}
		void ButtonCancelClick(object sender, EventArgs e)
		{
			//调整panel的高度
			panel2.Visible = false;
			panel1.Height = panel1.Height + panel2.Height + 10;
			
			buttonAdd.Enabled = true;
			buttonModify.Enabled = true;
			buttonDel.Enabled = true;
			新收费项ToolStripMenuItem.Enabled = true;
			修改收费项ToolStripMenuItem.Enabled = true;
			删除收费项ToolStripMenuItem.Enabled = true;
		}
		void ButtonCloseClick(object sender, EventArgs e)
		{
			//关闭窗口
			((MainForm)(this.ParentForm)).Page_Close(this);
            this.Close();
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			
			//保存前先检查必须输入项
			if(CheckInputOK())
			{
				Rates tNew = new Rates();
				//通过判断textBoxRateID是否空来判断是新增还是修改
				if(textBoxRateID.Text == string.Empty)
				{
					//新增
					tNew.RateName = textBoxRateName.Text;
					if(textBoxRateBrief.Text == string.Empty)
					{
						tNew.RateBrief = null;
					}
					else
					{
						tNew.RateBrief = textBoxRateBrief.Text;
					}
					tNew.RateClass = comboBoxRateClass.Text;
					tNew.RateUnit = comboBoxRateUnit.Text;
					if(textBoxRateValue.Text == string.Empty)
					{
						tNew.RateValue = 0.0m;
					}
					else
					{
						tNew.RateValue = Convert.ToDecimal(textBoxRateValue.Text);
					}
					BLL.RatesBLL.AddRates(tNew);
					
					//清空部分数据
					textBoxRateName.Text = "";
					textBoxRateBrief.Text = "";
					textBoxRateValue.Text = "";
					FillDataGridView1();
				}
				else
				{
					//修改
					tNew.RateID = Convert.ToInt32(textBoxRateID.Text);
					tNew.RateName = textBoxRateName.Text;
					if(textBoxRateBrief.Text == string.Empty)
					{
						tNew.RateBrief = null;
					}
					else
					{
						tNew.RateBrief = textBoxRateBrief.Text;
					}
					tNew.RateClass = comboBoxRateClass.Text;
					tNew.RateUnit = comboBoxRateUnit.Text;
					if(textBoxRateValue.Text == string.Empty)
					{
						tNew.RateValue = 0.0m;
					}
					else
					{
						tNew.RateValue = Convert.ToDecimal(textBoxRateValue.Text);
					}
					BLL.RatesBLL.UpdateRates(tNew);
					
					//清空部分数据
					textBoxRateName.Text = "";
					textBoxRateBrief.Text = "";
					textBoxRateValue.Text = "";
					FillDataGridView1();
				}
			}
			else
			{
				return;
			}
			//调整panel的高度
			panel2.Visible = false;
			panel1.Height = panel1.Height + panel2.Height + 10;
			
			buttonAdd.Enabled = true;
			buttonModify.Enabled = true;
			buttonDel.Enabled = true;
			新收费项ToolStripMenuItem.Enabled = true;
			修改收费项ToolStripMenuItem.Enabled = true;
			删除收费项ToolStripMenuItem.Enabled = true;
		}
		
		private bool CheckInputOK()
		{
			if(textBoxRateName.Text == string.Empty)
			{
				MessageBox.Show("收费项目名称必须输入！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;				
			}
			return true;
		}

		void TextBoxRateValueTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxRateValue.Text;
			if(tStr == "")
				return;
			pattern = @"(^[0-9]+$)|(^[0-9]+.([0-9])*?$)";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxRateValue.Text = textBoxRateValue.Text.Substring(0,textBoxRateValue.Text.Length-1);
				textBoxRateValue.Select(textBoxRateValue.Text.Length,0);
				return;
			}
		}
		void ButtonModifyClick(object sender, EventArgs e)
		{
			if(!panel2.Visible)
			{
				//调整panel的高度
				panel2.Visible = true;
				panel1.Height = panel1.Height - panel2.Height - 10;
			}
				
			//修改
			if(dataGridView1.CurrentRow != null)
			{
				int i_RateID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RateID"].Value.ToString());
				Rates tRate = BLL.RatesBLL.GetRate(i_RateID);
				textBoxRateID.Text = tRate.RateID.ToString();
				textBoxRateName.Text = tRate.RateName;
				textBoxRateValue.Text = tRate.RateValue.ToString();
				comboBoxRateClass.Text = tRate.RateClass;
				comboBoxRateUnit.Text = tRate.RateUnit;
				textBoxRateBrief.Text = tRate.RateBrief;				
				
				//设定第一个输入的焦点
				textBoxRateName.Focus();
			}
		}
		void ButtonDelClick(object sender, EventArgs e)
		{
			//删除
			if(dataGridView1.CurrentRow != null)
			{
				DialogResult result;
				int i_RateID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RateID"].Value.ToString());
				string s_RateName = dataGridView1.CurrentRow.Cells["RateName"].Value.ToString();

                result = MessageBox.Show("您确认删除当前选中的【" + s_RateName + "】收费项吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                	try
                	{
	                    // 删除指定的收费项
	                    BLL.RatesBLL.DelRate(i_RateID);
	                    FillDataGridView1();	                   
						return;
                	}                    
                	catch(Exception e1)
                    {
                        MessageBox.Show(e1.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                
			}
		}
		void 新收费项ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonAddClick(null,null);
		}
		void 修改收费项ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonModifyClick(null,null);
		}
		void 删除收费项ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonDelClick(null,null);
		}
		
		
	}
}
