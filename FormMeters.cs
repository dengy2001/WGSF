/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-29
 * 时间: 20:35
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
	/// Description of FormMeters.
	/// </summary>
	public partial class FormMeters : Form
	{
		private DataSet ds1 = new DataSet();
		private DataSet ds2 = new DataSet();
		private DataSet ds3 = new DataSet();
		
		public FormMeters()
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
			新计量表ToolStripMenuItem.Enabled = false;
			修改计量表ToolStripMenuItem.Enabled = false;
			删除计量表ToolStripMenuItem.Enabled = false;
			
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			
			if(treeView1.SelectedNode != null)
			{
				comboBoxTreeViewMeterPID.Tag = treeView1.SelectedNode.Tag;
				comboBoxTreeViewMeterPID.Text = treeView1.SelectedNode.Text;
			}
			
			textBoxMeterID.Text = "";
		}
		void ButtonModifyClick(object sender, EventArgs e)
		{
			//修改
			buttonNew.Enabled = false;
			buttonModify.Enabled = false;
			buttonDel.Enabled = false;
			新计量表ToolStripMenuItem.Enabled = false;
			修改计量表ToolStripMenuItem.Enabled = false;
			删除计量表ToolStripMenuItem.Enabled = false;
			
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			if(treeView1.SelectedNode != null)
			{
				Meters tModify = new Meters();
				Meters tPModify = new Meters();
				tModify = BLL.MetersBLL.GetMeter(Convert.ToInt32(treeView1.SelectedNode.Tag.ToString()));
				textBoxMeterID.Text = tModify.MeterID.ToString();
				if(tModify.MeterPID != null)
				{
					tPModify = BLL.MetersBLL.GetMeter(Convert.ToInt32(tModify.MeterPID.ToString()));
					comboBoxTreeViewMeterPID.Tag = tModify.MeterPID.ToString();
					comboBoxTreeViewMeterPID.Text = tPModify.MeterName;
				}
				else
				{
					comboBoxTreeViewMeterPID.Text = "";
				}
				textBoxMeterName.Text = tModify.MeterName;
				comboBoxMeterClass.Text = tModify.MeterClass;
				if(tModify.MeterUsing == 1)
				{
					checkBoxMeterUsing.Checked = true;
				}
				else
				{
					checkBoxMeterUsing.Checked = false;
				}
				if(tModify.MeterCanSharing == 1)
				{
					checkBoxMeterSharing.Checked = true;
				}
				else
				{
					checkBoxMeterSharing.Checked = false;
				}
				if(tModify.MeterSelfUse == 1)
				{
					checkBoxMeterSelfUse.Checked = true;
				}
				else
				{
					checkBoxMeterSelfUse.Checked = false;
				}
				textBoxMeterMulti.Text = tModify.MeterMulti.ToString();
				textBoxMeterMaxNumber.Text = tModify.MeterMaxNumber.ToString();
				if(tModify.RateID != null)
				{
					Rates tRate = new Rates();
					tRate = BLL.RatesBLL.GetRate(Convert.ToInt32(tModify.RateID.ToString()));
					comboBoxRateID.Tag = tModify.RateID;
					comboBoxRateID.Text = tRate.RateName;
				}
				if(tModify.WyID != null)
				{
					WyInfos tWy = new WyInfos();
					tWy = BLL.WyInfosBLL.GetWyInfo(Convert.ToInt32(tModify.WyID.ToString()));
					comboBoxWyID.Tag = tModify.WyID;
					comboBoxWyID.Text = tWy.WyName;
				}
				
				
			}
		}
		void ButtonCancelClick(object sender, EventArgs e)
		{
			//取消
			buttonNew.Enabled = true;
			buttonModify.Enabled = true;
			buttonDel.Enabled = true;
			新计量表ToolStripMenuItem.Enabled = true;
			修改计量表ToolStripMenuItem.Enabled = true;
			删除计量表ToolStripMenuItem.Enabled = true;
			
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			//保存操作
			if(CheckInputOK())
			{
				if(textBoxMeterID.Text == string.Empty)
				{
					//新增
					Meters tNew = new Meters();
					if(comboBoxTreeViewMeterPID.Text == string.Empty)
					{
						tNew.MeterPID = null;
					}
					else
					{
						tNew.MeterPID = Int32.Parse(comboBoxTreeViewMeterPID.Tag.ToString());
					}
					tNew.MeterName = textBoxMeterName.Text;
					if(comboBoxMeterClass.Text == string.Empty)
					{
						tNew.MeterClass = null;
					}
					else
					{
						tNew.MeterClass = comboBoxMeterClass.Text;
					}
					if(checkBoxMeterUsing.Checked)
					{
						tNew.MeterUsing = 1;
					}
					else
					{
						tNew.MeterUsing = 0;
					}
					if(checkBoxMeterSharing.Checked)
					{
						tNew.MeterCanSharing = 1;
					}
					else
					{
						tNew.MeterCanSharing = 0;
					}
					if(checkBoxMeterSelfUse.Checked)
					{
						tNew.MeterSelfUse = 1;
					}
					else
					{
						tNew.MeterSelfUse = 0;
					}
					tNew.MeterMulti = Convert.ToInt32(textBoxMeterMulti.Text);
					if(textBoxMeterMaxNumber.Text == string.Empty)
					{
						tNew.MeterMaxNumber = null;
					}
					else
					{
						tNew.MeterMaxNumber = Convert.ToInt32(textBoxMeterMaxNumber.Text);
					}
					if(comboBoxRateID.Text == string.Empty)
					{
						tNew.RateID = null;
					}
					else
					{
						tNew.RateID = Convert.ToInt32(comboBoxRateID.SelectedValue.ToString());
					}
					if(comboBoxWyID.Text == string.Empty)
					{
						tNew.WyID = null;
					}
					else
					{
						tNew.WyID = Convert.ToInt32(comboBoxWyID.SelectedValue.ToString());
					}
					BLL.MetersBLL.AddMeter(tNew);
					
				}
				else
				{
					//修改
					Meters tNew = new Meters();
					tNew.MeterID = Convert.ToInt32(textBoxMeterID.Text);
					if(comboBoxTreeViewMeterPID.Text == string.Empty)
					{
						tNew.MeterPID = null;
					}
					else
					{
						tNew.MeterPID = Int32.Parse(comboBoxTreeViewMeterPID.Tag.ToString());
					}
					tNew.MeterName = textBoxMeterName.Text;
					if(comboBoxMeterClass.Text == string.Empty)
					{
						tNew.MeterClass = null;
					}
					else
					{
						tNew.MeterClass = comboBoxMeterClass.Text;
					}
					if(checkBoxMeterUsing.Checked)
					{
						tNew.MeterUsing = 1;
					}
					else
					{
						tNew.MeterUsing = 0;
					}
					if(checkBoxMeterSharing.Checked)
					{
						tNew.MeterCanSharing = 1;
					}
					else
					{
						tNew.MeterCanSharing = 0;
					}
					if(checkBoxMeterSelfUse.Checked)
					{
						tNew.MeterSelfUse = 1;
					}
					else
					{
						tNew.MeterSelfUse = 0;
					}
					tNew.MeterMulti = Convert.ToInt32(textBoxMeterMulti.Text);
					if(textBoxMeterMaxNumber.Text == string.Empty)
					{
						tNew.MeterMaxNumber = null;
					}
					else
					{
						tNew.MeterMaxNumber = Convert.ToInt32(textBoxMeterMaxNumber.Text);
					}
					if(comboBoxRateID.Text == string.Empty)
					{
						tNew.RateID = null;
					}
					else
					{
						tNew.RateID = Convert.ToInt32(comboBoxRateID.SelectedValue.ToString());
					}
					if(comboBoxWyID.Text == string.Empty)
					{
						tNew.WyID = null;
					}
					else
					{
						tNew.WyID = Convert.ToInt32(comboBoxWyID.SelectedValue.ToString());
					}
					BLL.MetersBLL.UpdateMeter(tNew);
					
				}
				
				FillTrees();
				ClearContent();
				//改按钮状态
				buttonNew.Enabled = true;
				buttonModify.Enabled = true;
				buttonDel.Enabled = true;
				新计量表ToolStripMenuItem.Enabled = true;
				修改计量表ToolStripMenuItem.Enabled = true;
				删除计量表ToolStripMenuItem.Enabled = true;
				
				buttonSave.Enabled = false;
				buttonCancel.Enabled = false;
				
				
			}
		}
		
		private void ClearContent()
		{
			//将输入的信息清空便于重新输入
			textBoxMeterID.Text = "";
			textBoxMeterName.Text = "";
			comboBoxMeterClass.Text = "";
			comboBoxTreeViewMeterPID.Text = "";
			checkBoxMeterUsing.Checked = false;
			checkBoxMeterSharing.Checked = false;
			checkBoxMeterSelfUse.Checked = false;
			textBoxMeterMulti.Text = "";
			textBoxMeterMaxNumber.Text = "";
			comboBoxRateID.Text = "";
			comboBoxWyID.Text = "";
		}
		
		private bool CheckInputOK()
		{
			if(textBoxMeterName.Text == string.Empty)
			{
				MessageBox.Show("计量表名称必须输入！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;				
			}
			if(textBoxMeterMulti.Text == string.Empty)
			{
				MessageBox.Show("计量表倍率必须输入！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;				
			}
			return true;
		}
		void TextBoxMeterMultiTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxMeterMulti.Text;
			if(tStr == "")
				return;
			pattern = @"^[0-9]*$";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxMeterMulti.Text = textBoxMeterMulti.Text.Substring(0,textBoxMeterMulti.Text.Length-1);
				textBoxMeterMulti.Select(textBoxMeterMulti.Text.Length,0);
				return;
			}
		}
		void TextBoxMeterMaxNumberTextChanged(object sender, EventArgs e)
		{
			Regex reg;
			string tStr;	
			string pattern;
			
			tStr = textBoxMeterMaxNumber.Text;
			if(tStr == "")
				return;
			pattern = @"^[0-9]*$";
			reg = new Regex(pattern);
			if(! reg.IsMatch(tStr))
			{
				textBoxMeterMaxNumber.Text = textBoxMeterMaxNumber.Text.Substring(0,textBoxMeterMaxNumber.Text.Length-1);
				textBoxMeterMaxNumber.Select(textBoxMeterMaxNumber.Text.Length,0);
				return;
			}
		}
		
		
		 //填充树
        private  void NodeAdd(TreeView tree, DataTable dT)
        {
        	//先将根节点添加进来
        	DataRow[] drs;
        	drs = dT.Select("MeterPID is NULL");
            for (int i = 0; i < drs.Length; i++)
            {
                TreeNode newNode = new TreeNode();
                newNode.Tag = drs[i]["MeterID"].ToString();
                newNode.Text = drs[i]["MeterName"].ToString();
                string sMeterClass = drs[i]["MeterClass"].ToString();
                string sMeterUsing = drs[i]["MeterUsing"].ToString();
                //设定图标号
                if(sMeterClass == "水表")
                {
                	if(sMeterUsing == "1")
                	{
                		newNode.ImageIndex = 1;
                		newNode.SelectedImageIndex = 1;
                	}
                	else
                	{
                		newNode.ImageIndex = 2;
                		newNode.SelectedImageIndex = 2;
                	}
                }
                else if(sMeterClass == "电表")
                {
                	if(sMeterUsing == "1")
                	{
                		newNode.ImageIndex = 3;
                		newNode.SelectedImageIndex = 3;
                	}
                	else
                	{
                		newNode.ImageIndex = 4;
                		newNode.SelectedImageIndex = 4;
                	}
                }
                else if(sMeterClass == "气表")
                {
                	if(sMeterUsing == "1")
                	{
                		newNode.ImageIndex = 5;
                		newNode.SelectedImageIndex = 5;
                	}
                	else
                	{
                		newNode.ImageIndex = 6;
                		newNode.SelectedImageIndex = 6;
                	}
                }
                else
                {
                	//没选表类
                	newNode.ImageIndex = 0;
                	newNode.SelectedImageIndex = 0;
                	
                }
                string s_Tip = "";
                s_Tip = "收费项:【" + drs[i]["RateID"].ToString() +"】,物业:【" + drs[i]["WyID"].ToString() + "】";
                newNode.ToolTipText = s_Tip;
                tree.Nodes.Add(newNode);
                //将该节点的所有下级节点加进来
                AddSubNodes(newNode,dT);
             }
            
        }
        
        private void AddSubNodes(TreeNode tCurNode, DataTable dT)
        {
        	DataRow[] drs;
        	drs = dT.Select("MeterPID = " + tCurNode.Tag);
            for (int i = 0; i < drs.Length; i++)
            {
            	TreeNode childNode = new TreeNode();
            	childNode.Tag = drs[i]["MeterID"].ToString();
            	childNode.Text = drs[i]["MeterName"].ToString();
            	string sMeterClass = drs[i]["MeterClass"].ToString();
                string sMeterUsing = drs[i]["MeterUsing"].ToString();
                //设定图标号
                if(sMeterClass == "水表")
                {
                	if(sMeterUsing == "1")
                	{
                		childNode.ImageIndex = 1;
                		childNode.SelectedImageIndex = 1;
                	}
                	else
                	{
                		childNode.ImageIndex = 2;
                		childNode.SelectedImageIndex = 2;
                	}
                }
                else if(sMeterClass == "电表")
                {
                	if(sMeterUsing == "1")
                	{
                		childNode.ImageIndex = 3;
                		childNode.SelectedImageIndex = 3;
                	}
                	else
                	{
                		childNode.ImageIndex = 4;
                		childNode.SelectedImageIndex = 4;
                	}
                }
                else if(sMeterClass == "气表")
                {
                	if(sMeterUsing == "1")
                	{
                		childNode.ImageIndex = 5;
                		childNode.SelectedImageIndex = 5;
                	}
                	else
                	{
                		childNode.ImageIndex = 6;
                		childNode.SelectedImageIndex = 6;
                	}
                }
                else
                {
                	//没选表类
                	childNode.ImageIndex = 0;
                	childNode.SelectedImageIndex = 0;
                }
                string s_Tip = "";
                s_Tip = "收费项:【" + drs[i]["RateID"].ToString() +"】,物业:【" + drs[i]["WyID"].ToString() + "】";
                childNode.ToolTipText = s_Tip;
            	tCurNode.Nodes.Add(childNode);
            	AddSubNodes(childNode,dT);
            }
        }

        
		void FormMetersLoad(object sender, EventArgs e)
		{
			FillTrees();
			
			//填充费率下拉框
			ds2 = BLL.RatesBLL.GetAllMeterRates();
			comboBoxRateID.DataSource = ds2.Tables[0];
			comboBoxRateID.ValueMember = "RateID";
			comboBoxRateID.DisplayMember = "RateName";
			
			//填充物业下拉框
			ds3 = BLL.WyInfosBLL.GetAllWyInfos();
			comboBoxWyID.DataSource = ds3.Tables[0];
			comboBoxWyID.ValueMember = "WyID";
			comboBoxWyID.DisplayMember = "WyName";
		}
		
		void FillTrees()
		{
			ds1 = BLL.MetersBLL.GetAllMeters();
			treeView1.Nodes.Clear();
			comboBoxTreeViewMeterPID.TreeView.Nodes.Clear();
			NodeAdd(comboBoxTreeViewMeterPID.TreeView,ds1.Tables[0]);
			NodeAdd(treeView1,ds1.Tables[0]);
		
		}
		void ButtonDelClick(object sender, EventArgs e)
		{
			//删除计量表
			if(treeView1.SelectedNode != null)
			{
				DialogResult result;
				int i_MeterID = Convert.ToInt32(treeView1.SelectedNode.Tag.ToString());
				string s_MeterName = treeView1.SelectedNode.Text;

                result = MessageBox.Show("您确认删除当前选中的【" + s_MeterName + "】计量表吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                	try
                	{
	                    // 删除指定的计量表
	                    BLL.MetersBLL.DelMeter(i_MeterID);
	                    FillTrees();
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
		void 新计量表ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonNewClick(null,null);
		}
		void 修改计量表ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonModifyClick(null,null);
		}
		void 删除计量表ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ButtonDelClick(null,null);
		}
		
		
		
		
	}
}
