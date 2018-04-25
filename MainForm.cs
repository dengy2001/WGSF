/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 17:03
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WGSF
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public int tabpages = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			//显示导航页
            FormGuide tForm = new FormGuide();
            tForm.TopLevel = false;  //设置为非顶级窗体
            tForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            tForm.Dock = System.Windows.Forms.DockStyle.Fill;//设置样式是否填充整个panel
            tabControlWithClose1.TabPages[tabpages++].Controls.Add(tForm);//添加窗体
            tForm.Show();//窗体运行
		}
		
		public void Control_Add(Form tform)
        {
            if (TabPageExist(tform))
            {
                return;
            }

            tform.TopLevel = false;  //设置为非顶级窗体
            tform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            tform.Dock = System.Windows.Forms.DockStyle.Fill;//设置样式是否填充整个panel
            tabControlWithClose1.TabPages.Add(tform.Text);
            tabControlWithClose1.TabPages[tabControlWithClose1.TabPages.Count - 1].Controls.Add(tform);//添加窗体
            tform.Show();//窗体运行
            int i = tabpages - 1;
            tabControlWithClose1.SelectedTab = tabControlWithClose1.TabPages[tabControlWithClose1.TabPages.Count - 1];
        }

        private bool TabPageExist(Form tform)
        {
            bool tflag = false;
            foreach (TabPage tb in tabControlWithClose1.TabPages)
            {
                if (tb.Text == tform.Text)
                {
                    tflag = true;
                    tabControlWithClose1.SelectedTab = tb;
                    break;
                }
            }
            return tflag;
        }

        //将已经关闭的页面tabpage也关闭
        public void Page_Close(Form tform)
        {
            foreach (TabPage tb in tabControlWithClose1.TabPages)
            {
                if (tb.Text == tform.Text)
                {
                    tb.Parent = null;
                    --tabpages;
                    break;
                }
            }
        }
		void 费率设置ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//设置费率
			FormRates tForm = new FormRates();
			Control_Add(tForm);
		}
		void 物业信息设置ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//设置费率
			FormWyInfos tForm = new FormWyInfos();
			Control_Add(tForm);
		}
		void 缴费对象设置ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//设置缴费对象
			FormCustomers tForm = new FormCustomers();
			Control_Add(tForm);
		}
		void 计量表设置ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//设置计量表
			FormMeters tForm = new FormMeters();
			Control_Add(tForm);
		}
		void 批量数据导入ToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormImport tf = new FormImport();
			tf.ShowDialog();
			
		}
		void 数据检测ToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormCheckData tf = new FormCheckData();
			tf.ShowDialog();
		}
		void 表读数录入ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//表读数
			FormMeterReading tForm = new FormMeterReading();
			Control_Add(tForm);
		}
		void 计费ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//计收费
			FormCharge tForm = new FormCharge();
			Control_Add(tForm);
		}
		void 收费ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//收费
			FormChargeSF tForm = new FormChargeSF();
			Control_Add(tForm);
		}
		void 历史收费ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//历史收费
			FormHisSF tForm = new FormHisSF();
			Control_Add(tForm);
		}
        
        
	}
}
