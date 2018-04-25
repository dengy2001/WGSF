/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-28
 * 时间: 16:43
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
	/// Description of FormWyInfos.
	/// </summary>
	public partial class FormWyInfos : Form
	{
		private DataSet ds1 = new DataSet();		//用于物业信息
		private DataSet ds2 = new DataSet();		//用于缴费对象
		private DataSet ds3 = new DataSet();		//用于物业对于的缴费项
		
		public FormWyInfos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBoxJZAreaTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxJZArea.Text;
			if(tStr == "")
				return;
			pattern = @"(^[0-9]+$)|(^[0-9]+.([0-9])*?$)";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxJZArea.Text = textBoxJZArea.Text.Substring(0,textBoxJZArea.Text.Length-1);
				textBoxJZArea.Select(textBoxJZArea.Text.Length,0);
				return;
			}
		}
		void TextBoxTNAreaTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxTNArea.Text;
			if(tStr == "")
				return;
			pattern = @"(^[0-9]+$)|(^[0-9]+.([0-9])*?$)";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxTNArea.Text = textBoxTNArea.Text.Substring(0,textBoxTNArea.Text.Length-1);
				textBoxTNArea.Select(textBoxTNArea.Text.Length,0);
				return;
			}
		}
		void TextBoxGTAreaTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxGTArea.Text;
			if(tStr == "")
				return;
			pattern = @"(^[0-9]+$)|(^[0-9]+.([0-9])*?$)";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxGTArea.Text = textBoxGTArea.Text.Substring(0,textBoxGTArea.Text.Length-1);
				textBoxGTArea.Select(textBoxGTArea.Text.Length,0);
				return;
			}
		}
		void TextBoxUNIT_NoTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxUNIT_No.Text;
			if(tStr == "")
				return;
			pattern = @"^[0-9]*$";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxUNIT_No.Text = textBoxUNIT_No.Text.Substring(0,textBoxUNIT_No.Text.Length-1);
				textBoxUNIT_No.Select(textBoxUNIT_No.Text.Length,0);
				return;
			}
		}
		void TextBoxFLOOR_NoTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxFLOOR_No.Text;
			if(tStr == "")
				return;
			pattern = @"^[0-9]*$";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxFLOOR_No.Text = textBoxFLOOR_No.Text.Substring(0,textBoxFLOOR_No.Text.Length-1);
				textBoxFLOOR_No.Select(textBoxFLOOR_No.Text.Length,0);
				return;
			}
		}
		void TextBoxROOM_NoTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxROOM_No.Text;
			if(tStr == "")
				return;
			pattern = @"^[0-9]*$";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxROOM_No.Text = textBoxROOM_No.Text.Substring(0,textBoxROOM_No.Text.Length-1);
				textBoxROOM_No.Select(textBoxROOM_No.Text.Length,0);
				return;
			}
		}
		void ButtonCloseClick(object sender, EventArgs e)
		{
			//关闭窗口
			((MainForm)(this.ParentForm)).Page_Close(this);
            this.Close();
		}
		void ButtonNewClick(object sender, EventArgs e)
		{
			//新增
			buttonNew.Enabled = false;
			buttonModify.Enabled = false;
			buttonDel.Enabled = false;
			新增物业ToolStripMenuItem.Enabled = false;
			修改物业ToolStripMenuItem.Enabled = false;
			删除物业ToolStripMenuItem.Enabled = false;
			
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			
			
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			//保存
			
			
			//保存前先检查必须输入项
			if(CheckInputOK())
			{
				if(textBoxWyID.Text == string.Empty)
				{
					WyInfos tNew = new WyInfos();
					tNew.WyName = textBoxWyName.Text;
					if(textBoxOwnerName.Text == string.Empty)
					{
						tNew.OwnerName = null;
					}
					else
					{
						tNew.OwnerName = textBoxOwnerName.Text;
					}
					if(comboBoxCustomerID.Text ==string.Empty)
					{
						tNew.CustomerID = null;
					}
					else
					{
						tNew.CustomerID = Convert.ToInt32(comboBoxCustomerID.SelectedValue.ToString());
					}
					if(textBoxJZArea.Text == string.Empty)
					{
						tNew.JZArea = null;
					}
					else
					{
						tNew.JZArea = Convert.ToDecimal(textBoxJZArea.Text);
					}
					if(textBoxTNArea.Text == string.Empty)
					{
						tNew.TNArea = null;
					}
					else
					{
						tNew.TNArea = Convert.ToDecimal(textBoxTNArea.Text);
					}
					if(textBoxGTArea.Text == string.Empty)
					{
						tNew.GTArea = null;
					}
					else
					{
						tNew.GTArea = Convert.ToDecimal(textBoxGTArea.Text);
					}
					if(textBoxUNIT_No.Text == string.Empty)
					{
						tNew.UNIT_No = null;
					}
					else
					{
						tNew.UNIT_No = Convert.ToInt32(textBoxUNIT_No.Text);
					}
					if(textBoxFLOOR_No.Text == string.Empty)
					{
						tNew.FLOOR_No = null;
					}
					else
					{
						tNew.FLOOR_No = Convert.ToInt32(textBoxFLOOR_No.Text);
					}
					if(textBoxROOM_No.Text == string.Empty)
					{
						tNew.ROOM_No = null;
					}
					else
					{
						tNew.ROOM_No = Convert.ToInt32(textBoxROOM_No.Text);
					}
					if(textBoxOwnerDetail.Text == string.Empty)
					{
						tNew.OwnerDetail = null;
					}
					else
					{
						tNew.OwnerDetail = textBoxOwnerDetail.Text;
					}
					
					BLL.WyInfosBLL.AddWyInfos(tNew);
				}
				else
				{
					WyInfos tNew = new WyInfos();
					tNew.WyID = Convert.ToInt32(textBoxWyID.Text);
					tNew.WyName = textBoxWyName.Text;
					if(textBoxOwnerName.Text == string.Empty)
					{
						tNew.OwnerName = null;
					}
					else
					{
						tNew.OwnerName = textBoxOwnerName.Text;
					}
					if(comboBoxCustomerID.Text ==string.Empty)
					{
						tNew.CustomerID = null;
					}
					else
					{
						tNew.CustomerID = Convert.ToInt32(comboBoxCustomerID.SelectedValue.ToString());
					}
					if(textBoxJZArea.Text == string.Empty)
					{
						tNew.JZArea = null;
					}
					else
					{
						tNew.JZArea = Convert.ToDecimal(textBoxJZArea.Text);
					}
					if(textBoxTNArea.Text == string.Empty)
					{
						tNew.TNArea = null;
					}
					else
					{
						tNew.TNArea = Convert.ToDecimal(textBoxTNArea.Text);
					}
					if(textBoxGTArea.Text == string.Empty)
					{
						tNew.GTArea = null;
					}
					else
					{
						tNew.GTArea = Convert.ToDecimal(textBoxGTArea.Text);
					}
					if(textBoxUNIT_No.Text == string.Empty)
					{
						tNew.UNIT_No = null;
					}
					else
					{
						tNew.UNIT_No = Convert.ToInt32(textBoxUNIT_No.Text);
					}
					if(textBoxFLOOR_No.Text == string.Empty)
					{
						tNew.FLOOR_No = null;
					}
					else
					{
						tNew.FLOOR_No = Convert.ToInt32(textBoxFLOOR_No.Text);
					}
					if(textBoxROOM_No.Text == string.Empty)
					{
						tNew.ROOM_No = null;
					}
					else
					{
						tNew.ROOM_No = Convert.ToInt32(textBoxROOM_No.Text);
					}
					if(textBoxOwnerDetail.Text == string.Empty)
					{
						tNew.OwnerDetail = null;
					}
					else
					{
						tNew.OwnerDetail = textBoxOwnerDetail.Text;
					}
					BLL.WyInfosBLL.UpdateWyInfos(tNew);
				}
				FillDataGridView1();
				ClearContent();
				//改按钮状态
				buttonNew.Enabled = true;
				buttonModify.Enabled = true;
				buttonDel.Enabled = true;
				新增物业ToolStripMenuItem.Enabled = true;
				修改物业ToolStripMenuItem.Enabled = true;
				删除物业ToolStripMenuItem.Enabled = true;
				
				buttonSave.Enabled = false;
				buttonCancel.Enabled = false;
			}			
			
		}
		
		private void ClearContent()
		{
			//将输入的信息清空便于重新输入
			textBoxWyID.Text = "";
			textBoxWyName.Text = "";
			textBoxOwnerName.Text = "";
			comboBoxCustomerID.Text = "";
			textBoxJZArea.Text = "";
			textBoxTNArea.Text = "";
			textBoxGTArea.Text = "";
			textBoxUNIT_No.Text = "";
			textBoxFLOOR_No.Text = "";
			textBoxROOM_No.Text = "";
			textBoxOwnerDetail.Text = "";
		}
		
		private bool CheckInputOK()
		{
			if(textBoxWyName.Text == string.Empty)
			{
				MessageBox.Show("物业名称必须输入！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;				
			}
			return true;
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			//取消
			buttonNew.Enabled = true;
			buttonModify.Enabled = true;
			buttonDel.Enabled = true;
			新增物业ToolStripMenuItem.Enabled = true;
			修改物业ToolStripMenuItem.Enabled = true;
			删除物业ToolStripMenuItem.Enabled = true;
			
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
		}
		void ButtonModifyClick(object sender, EventArgs e)
		{
			//修改
			buttonNew.Enabled = false;
			buttonModify.Enabled = false;
			buttonDel.Enabled = false;
			新增物业ToolStripMenuItem.Enabled = false;
			修改物业ToolStripMenuItem.Enabled = false;
			删除物业ToolStripMenuItem.Enabled = false;
			
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			
			//修改
			if(dataGridView1.CurrentRow != null)
			{
				int i_WyID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["WyID"].Value.ToString());
				WyInfos tWy = BLL.WyInfosBLL.GetWyInfo(i_WyID);
				textBoxWyID.Text = tWy.WyID.ToString();
				textBoxWyName.Text = tWy.WyName;
				textBoxOwnerName.Text = tWy.OwnerName;
				if(tWy.CustomerID != null)
				{
					comboBoxCustomerID.SelectedValue = tWy.CustomerID;
				}
				textBoxJZArea.Text = tWy.JZArea.ToString();
				textBoxTNArea.Text = tWy.TNArea.ToString();
				textBoxGTArea.Text = tWy.GTArea.ToString();
				textBoxUNIT_No.Text = tWy.UNIT_No.ToString();
				textBoxFLOOR_No.Text = tWy.FLOOR_No.ToString();
				textBoxROOM_No.Text = tWy.ROOM_No.ToString();
				textBoxOwnerDetail.Text = tWy.OwnerDetail;
			
				
				//设定第一个输入的焦点
				textBoxWyName.Focus();
			}
		}
		
		void FillDataGridView1()
		{
			ds1 = BLL.WyInfosBLL.GetAllWyInfos();
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
			dataGridView1.Columns[0].HeaderText = "物业ID";
			dataGridView1.Columns[0].Name = "WyID";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[0].DataPropertyName = "WyID";
            
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[1].HeaderText = "物业名称";
            dataGridView1.Columns[1].Name = "WyName";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].DataPropertyName = "WyName";
            
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[2].HeaderText = "业主姓名";
            dataGridView1.Columns[2].Name = "OwnerName";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DataPropertyName = "OwnerName";
            
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].HeaderText = "建筑面积";
            dataGridView1.Columns[3].Name = "JZArea";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].DataPropertyName = "JZArea";
            
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "套内面积";
            dataGridView1.Columns[4].Name = "TNArea";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DataPropertyName = "TNArea";
            
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[5].HeaderText = "业主详情";
            dataGridView1.Columns[5].Name = "OwnerDetail";
            dataGridView1.Columns[5].Width = dataGridView1.Width - 43 - 530;
            dataGridView1.Columns[5].DataPropertyName = "OwnerDetail";
            
            //不显示出来的列
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[6].Name = "CustomerID";
            dataGridView1.Columns[6].DataPropertyName = "CustomerID";
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
		void FormWyInfosLoad(object sender, EventArgs e)
		{
			FillDataGridView1();
			//填充缴费对象下拉列表
			ds2 = BLL.CustomersBLL.GetAllCustomers();
			comboBoxCustomerID.DataSource = ds2.Tables[0];
			comboBoxCustomerID.DisplayMember = "CustomerName";
			comboBoxCustomerID.ValueMember = "CustomerID";
		}
		void ButtonDelClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				DialogResult result;
				int i_WyID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["WyID"].Value.ToString());
				string s_WyName = dataGridView1.CurrentRow.Cells["WyName"].Value.ToString();

                result = MessageBox.Show("您确认删除当前选中的【" + s_WyName + "】物业吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                	try
                	{
	                    // 删除指定的物业
	                    BLL.WyInfosBLL.DelWyInfo(i_WyID);
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
		void ButtonImportClick(object sender, EventArgs e)
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
	        string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" +
	                        "Extended Properties=Excel 8.0;" +
	                        "data source=" + fName;
	        OleDbConnection myConn = new OleDbConnection(strCon);
	        string strCom = " SELECT * FROM [Sheet1$]";
	        myConn.Open();
	        OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
	        tds = new DataSet();
	        myCommand.Fill(tds);	        
	        BLL.WyInfosBLL.FillWyInfos(tds.Tables[0]);	        
            MessageBox.Show("数据导入完成！");
		}
		void 新增物业ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonNewClick(null,null);
		}
		void 修改物业ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonModifyClick(null,null);
		}
		void 删除物业ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonDelClick(null,null);
		}
		void 增加收费项ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//增加物业的收费项
			if(dataGridView1.CurrentRow != null)
			{
				int i_WyID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["WyID"].Value.ToString());
				//将i_WyID传到添加物业收费项中
				FormAddWyRate tForm = new FormAddWyRate();
				tForm.i_WyID = i_WyID;
				tForm.ShowDialog();
			}
			DataGridView1SelectionChanged(null,null);
		}
		void DataGridView1SelectionChanged(object sender, EventArgs e)
		{
			//选择的物业变了，把该物业有的缴费信息更新显示。
			if(dataGridView1.CurrentRow != null)
			{
				int i_WyID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["WyID"].Value.ToString());
				FillDataGridView2(i_WyID);
			}
			
		}
		
		void FillDataGridView2(int i_WyID)
		{
			ds3 = BLL.WyInfosBLL.GetAllWyRates(i_WyID);
			dataGridView2.DataSource = ds3.Tables[0];
			SetGridView2Header();
		}
		
		void SetGridView2Header()
		{
			dataGridView2.AutoGenerateColumns = false;	
			//dataGridViewProjects.ColumnCount = 3;
			//dataGridView1.ReadOnly = true;
			//dataGridView1.AllowUserToAddRows = false;
			//dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
            dataGridView2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView2.Columns[0].HeaderText = "序号";
			dataGridView2.Columns[0].Name = "WyRateID";
            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[0].DataPropertyName = "WyRateID";
            
            dataGridView2.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[1].HeaderText = "物业ID";
            dataGridView2.Columns[1].Name = "WyID";
            dataGridView2.Columns[1].Width = 80;
            dataGridView2.Columns[1].DataPropertyName = "WyID";
            
            dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[2].ReadOnly = true;
            dataGridView2.Columns[2].HeaderText = "说明";
            dataGridView2.Columns[2].Name = "Brief";
            dataGridView2.Columns[2].Width = dataGridView2.Width - 43 -640;
            dataGridView2.Columns[2].DataPropertyName = "Brief";
            
            dataGridView2.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[3].HeaderText = "收费项ID";
            dataGridView2.Columns[3].Name = "RateID";
            dataGridView2.Columns[3].Width = 80;
            dataGridView2.Columns[3].DataPropertyName = "RateID";
            
            dataGridView2.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[4].HeaderText = "收费项名称";
            dataGridView2.Columns[4].Name = "RateName";
            dataGridView2.Columns[4].Width = 120;
            dataGridView2.Columns[4].DataPropertyName = "RateName";
            
            dataGridView2.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView2.Columns[5].ReadOnly = true;
            dataGridView2.Columns[5].HeaderText = "收费项类别";
            dataGridView2.Columns[5].Name = "RateClass";
            dataGridView2.Columns[5].Width = 100;
            dataGridView2.Columns[5].DataPropertyName = "RateClass";
            
            dataGridView2.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView2.Columns[6].HeaderText = "单位";
            dataGridView2.Columns[6].Name = "RateUnit";
            dataGridView2.Columns[6].Width = 100;
            dataGridView2.Columns[6].DataPropertyName = "RateUnit";
            
            dataGridView2.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView2.Columns[7].HeaderText = "值";
            dataGridView2.Columns[7].Name = "RateValue";
            dataGridView2.Columns[7].Width = 80;
            dataGridView2.Columns[7].DataPropertyName = "RateValue";
            
            //不显示出来的列
//            dataGridView1.Columns[6].Visible = false;
//            dataGridView1.Columns[6].Name = "CustomerID";
//            dataGridView1.Columns[6].DataPropertyName = "CustomerID";
//            
//            dataGridView1.Columns[7].Visible = false;
//            dataGridView1.Columns[7].Name = "GoodsTypeID";
//            dataGridView1.Columns[7].DataPropertyName = "GoodsTypeID";
            
            
            //隐藏不需要的
            foreach(DataGridViewColumn c in dataGridView2.Columns)
            {
            	if(c.Index>7)
            	{
            		c.Visible = false;
            	}
            }
           
		}
		void 删除收费项ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//删除选择的WyRates
			if(dataGridView1.CurrentRow != null)
			{
				DialogResult result;
				int i_WyRateID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["WyRateID"].Value.ToString());
				int i_WyID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["WyID"].Value.ToString());
				
				BLL.WyInfosBLL.DelWyRate(i_WyRateID);
				
				FillDataGridView2(i_WyID);

			}
		}
		
		
	}
}
