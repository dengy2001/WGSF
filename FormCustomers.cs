/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-29
 * 时间: 17:12
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
	/// Description of FormCustomers.
	/// </summary>
	public partial class FormCustomers : Form
	{
		
		private DataSet ds1 = new DataSet();
		public FormCustomers()
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
		void ButtonNewClick(object sender, EventArgs e)
		{
			//新增
			buttonNew.Enabled = false;
			buttonModify.Enabled = false;
			buttonDel.Enabled = false;
			新缴费IDToolStripMenuItem.Enabled = false;
			修改缴费IDToolStripMenuItem.Enabled = false;
			删除缴费IDToolStripMenuItem.Enabled = false;
			
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}
		void ButtonModifyClick(object sender, EventArgs e)
		{
			//修改
			buttonNew.Enabled = false;
			buttonModify.Enabled = false;
			buttonDel.Enabled = false;
			新缴费IDToolStripMenuItem.Enabled = false;
			修改缴费IDToolStripMenuItem.Enabled = false;
			删除缴费IDToolStripMenuItem.Enabled = false;
			
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			
			//修改
			if(dataGridView1.CurrentRow != null)
			{
				int i_CustomerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString());
				Customers tWy = BLL.CustomersBLL.GetCustomer(i_CustomerID);
				textBoxCustomerID.Text = tWy.CustomerID.ToString();
				textBoxCutomerName.Text = tWy.CustomerName;
				textBoxCustomerLinkMan.Text = tWy.CustomerLinkMan;
				textBoxCustomerLinkDetail.Text = tWy.CustomerLinkDetail;
							
				
				//设定第一个输入的焦点
				textBoxCutomerName.Focus();
			}
		}
		void ButtonDelClick(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				DialogResult result;
				int i_CustomerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString());
				string s_CustomerName = dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();

                result = MessageBox.Show("您确认删除当前选中的【" + s_CustomerName + "】缴费对象吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                	try
                	{
	                    // 删除指定的缴费对象
	                    BLL.CustomersBLL.DelCustomer(i_CustomerID);
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
		
		void FillDataGridView1()
		{
			ds1 = BLL.CustomersBLL.GetAllCustomers();
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
			dataGridView1.Columns[0].HeaderText = "缴费ID";
			dataGridView1.Columns[0].Name = "CustomerID";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[0].DataPropertyName = "CustomerID";
            
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[1].HeaderText = "缴费名称";
            dataGridView1.Columns[1].Name = "CustomerName";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].DataPropertyName = "CustomerName";
            
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[2].HeaderText = "联系人";
            dataGridView1.Columns[2].Name = "CustomerLinkMan";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DataPropertyName = "CustomerLinkMan";
            
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].HeaderText = "备注";
            dataGridView1.Columns[3].Name = "CustomerLinkDetail";
            dataGridView1.Columns[3].Width = dataGridView1.Width - 43 - 330;
            dataGridView1.Columns[3].DataPropertyName = "CustomerLinkDetail";
            
           
            
            //不显示出来的列
//            dataGridView1.Columns[6].Visible = false;
//            dataGridView1.Columns[6].Name = "CustomerID";
//            dataGridView1.Columns[6].DataPropertyName = "CustomerID";
//            
//            dataGridView1.Columns[7].Visible = false;
//            dataGridView1.Columns[7].Name = "GoodsTypeID";
//            dataGridView1.Columns[7].DataPropertyName = "GoodsTypeID";
            
            
            //隐藏不需要的
            foreach(DataGridViewColumn c in dataGridView1.Columns)
            {
            	if(c.Index>3)
            	{
            		c.Visible = false;
            	}
            }
           
		}
		void FormCustomersLoad(object sender, EventArgs e)
		{
			FillDataGridView1();
		}
		
		private bool CheckInputOK()
		{
			if(textBoxCutomerName.Text == string.Empty)
			{
				MessageBox.Show("缴费名称必须输入！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;				
			}
			return true;
		}
		
		private void ClearContent()
		{
			//将输入的信息清空便于重新输入
			textBoxCustomerID.Text = "";
			textBoxCutomerName.Text = "";
			textBoxCustomerLinkMan.Text = "";
			textBoxCustomerLinkDetail.Text = "";
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			//保存			
			
			//保存前先检查必须输入项
			if(CheckInputOK())
			{
				if(textBoxCustomerID.Text == string.Empty)
				{
					Customers tNew = new Customers();
					tNew.CustomerName = textBoxCutomerName.Text;
					if(textBoxCustomerLinkMan.Text == string.Empty)
					{
						tNew.CustomerLinkMan = null;
					}
					else
					{
						tNew.CustomerLinkMan = textBoxCustomerLinkMan.Text;
					}
					if(textBoxCustomerLinkDetail.Text ==string.Empty)
					{
						tNew.CustomerLinkDetail = null;
					}
					else
					{
						tNew.CustomerLinkDetail = textBoxCustomerLinkDetail.Text;
					}
										
					BLL.CustomersBLL.AddCustomer(tNew);
				}
				else
				{
					Customers tNew = new Customers();
					tNew.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
					tNew.CustomerName = textBoxCutomerName.Text;
					if(textBoxCustomerLinkMan.Text == string.Empty)
					{
						tNew.CustomerLinkMan = null;
					}
					else
					{
						tNew.CustomerLinkMan = textBoxCustomerLinkMan.Text;
					}
					if(textBoxCustomerLinkDetail.Text ==string.Empty)
					{
						tNew.CustomerLinkDetail = null;
					}
					else
					{
						tNew.CustomerLinkDetail = textBoxCustomerLinkDetail.Text;
					}
					BLL.CustomersBLL.UpdateCustomer(tNew);
				}
				FillDataGridView1();
				ClearContent();
				//改按钮状态
				buttonNew.Enabled = true;
				buttonModify.Enabled = true;
				buttonDel.Enabled = true;
				新缴费IDToolStripMenuItem.Enabled = true;
				修改缴费IDToolStripMenuItem.Enabled = true;
				删除缴费IDToolStripMenuItem.Enabled = true;
				
				buttonSave.Enabled = false;
				buttonCancel.Enabled = false;
			}			
		}
		void ButtonCancelClick(object sender, EventArgs e)
		{
			//取消
			buttonNew.Enabled = true;
			buttonModify.Enabled = true;
			buttonDel.Enabled = true;
			新缴费IDToolStripMenuItem.Enabled = true;
			修改缴费IDToolStripMenuItem.Enabled = true;
			删除缴费IDToolStripMenuItem.Enabled = true;
			
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
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
	        BLL.CustomersBLL.FillCustomers(tds.Tables[0]);	        
            MessageBox.Show("数据导入完成！");
		}
		void 新缴费IDToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonNewClick(null,null);
		}
		void 修改缴费IDToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonModifyClick(null,null);
		}
		void 删除缴费IDToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonDelClick(null,null);
		}
		
		
	}
}
