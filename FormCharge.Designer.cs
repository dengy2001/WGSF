/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-02
 * 时间: 13:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormCharge
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonJFAll;
		private System.Windows.Forms.Button buttonJFSingle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxPeriodNo;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelCalResult;
		private System.Windows.Forms.Button buttonPrintJF;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 暂缓收费ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 免收ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 取消暂缓ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 取消免收ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.Button buttonSCJF;
		private System.Windows.Forms.ToolStripMenuItem 删除错误计费ToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonJFAll = new System.Windows.Forms.Button();
			this.buttonJFSingle = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.labelStatus = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.暂缓收费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.免收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.取消暂缓ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.取消免收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.textBoxPeriodNo = new System.Windows.Forms.TextBox();
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.labelCalResult = new System.Windows.Forms.Label();
			this.buttonPrintJF = new System.Windows.Forms.Button();
			this.buttonSCJF = new System.Windows.Forms.Button();
			this.删除错误计费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "计费周期：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonJFAll
			// 
			this.buttonJFAll.Location = new System.Drawing.Point(505, 21);
			this.buttonJFAll.Name = "buttonJFAll";
			this.buttonJFAll.Size = new System.Drawing.Size(75, 23);
			this.buttonJFAll.TabIndex = 3;
			this.buttonJFAll.Text = "全部计费";
			this.buttonJFAll.UseVisualStyleBackColor = true;
			this.buttonJFAll.Click += new System.EventHandler(this.ButtonJFAllClick);
			// 
			// buttonJFSingle
			// 
			this.buttonJFSingle.Location = new System.Drawing.Point(424, 21);
			this.buttonJFSingle.Name = "buttonJFSingle";
			this.buttonJFSingle.Size = new System.Drawing.Size(75, 23);
			this.buttonJFSingle.TabIndex = 2;
			this.buttonJFSingle.Text = "单独计费";
			this.buttonJFSingle.UseVisualStyleBackColor = true;
			this.buttonJFSingle.Click += new System.EventHandler(this.ButtonJFSingleClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(214, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "缴费对象：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelStatus
			// 
			this.labelStatus.ForeColor = System.Drawing.Color.Red;
			this.labelStatus.Location = new System.Drawing.Point(12, 49);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(654, 23);
			this.labelStatus.TabIndex = 0;
			this.labelStatus.Text = "当前状态：【就绪】";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 75);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(861, 157);
			this.dataGridView1.TabIndex = 7;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.暂缓收费ToolStripMenuItem,
			this.免收ToolStripMenuItem,
			this.toolStripMenuItem1,
			this.取消暂缓ToolStripMenuItem,
			this.取消免收ToolStripMenuItem,
			this.toolStripMenuItem2,
			this.删除错误计费ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 148);
			// 
			// 暂缓收费ToolStripMenuItem
			// 
			this.暂缓收费ToolStripMenuItem.Name = "暂缓收费ToolStripMenuItem";
			this.暂缓收费ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.暂缓收费ToolStripMenuItem.Text = "暂缓收费";
			this.暂缓收费ToolStripMenuItem.Click += new System.EventHandler(this.暂缓收费ToolStripMenuItemClick);
			// 
			// 免收ToolStripMenuItem
			// 
			this.免收ToolStripMenuItem.Name = "免收ToolStripMenuItem";
			this.免收ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.免收ToolStripMenuItem.Text = "免收";
			this.免收ToolStripMenuItem.Click += new System.EventHandler(this.免收ToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// 取消暂缓ToolStripMenuItem
			// 
			this.取消暂缓ToolStripMenuItem.Name = "取消暂缓ToolStripMenuItem";
			this.取消暂缓ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.取消暂缓ToolStripMenuItem.Text = "取消暂未收";
			this.取消暂缓ToolStripMenuItem.Click += new System.EventHandler(this.取消暂缓ToolStripMenuItemClick);
			// 
			// 取消免收ToolStripMenuItem
			// 
			this.取消免收ToolStripMenuItem.Name = "取消免收ToolStripMenuItem";
			this.取消免收ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.取消免收ToolStripMenuItem.Text = "取消免收";
			this.取消免收ToolStripMenuItem.Click += new System.EventHandler(this.取消免收ToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
			// 
			// textBoxPeriodNo
			// 
			this.textBoxPeriodNo.Location = new System.Drawing.Point(78, 22);
			this.textBoxPeriodNo.Name = "textBoxPeriodNo";
			this.textBoxPeriodNo.Size = new System.Drawing.Size(94, 21);
			this.textBoxPeriodNo.TabIndex = 0;
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(281, 22);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(121, 20);
			this.comboBoxCustomer.TabIndex = 1;
			this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCustomerSelectedIndexChanged);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonQuit.Location = new System.Drawing.Point(798, 21);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 23);
			this.buttonQuit.TabIndex = 4;
			this.buttonQuit.Text = "退出";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.ButtonQuitClick);
			// 
			// labelCalResult
			// 
			this.labelCalResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCalResult.ForeColor = System.Drawing.Color.Red;
			this.labelCalResult.Location = new System.Drawing.Point(12, 235);
			this.labelCalResult.Name = "labelCalResult";
			this.labelCalResult.Size = new System.Drawing.Size(326, 23);
			this.labelCalResult.TabIndex = 0;
			this.labelCalResult.Text = "共 0 项收费，合计 0 元。";
			this.labelCalResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonPrintJF
			// 
			this.buttonPrintJF.Location = new System.Drawing.Point(699, 21);
			this.buttonPrintJF.Name = "buttonPrintJF";
			this.buttonPrintJF.Size = new System.Drawing.Size(75, 23);
			this.buttonPrintJF.TabIndex = 3;
			this.buttonPrintJF.Text = "打印计费单";
			this.buttonPrintJF.UseVisualStyleBackColor = true;
			this.buttonPrintJF.Click += new System.EventHandler(this.ButtonPrintJFClick);
			// 
			// buttonSCJF
			// 
			this.buttonSCJF.Location = new System.Drawing.Point(609, 21);
			this.buttonSCJF.Name = "buttonSCJF";
			this.buttonSCJF.Size = new System.Drawing.Size(84, 23);
			this.buttonSCJF.TabIndex = 3;
			this.buttonSCJF.Text = "计费单生成";
			this.buttonSCJF.UseVisualStyleBackColor = true;
			this.buttonSCJF.Click += new System.EventHandler(this.ButtonSCJFClick);
			// 
			// 删除错误计费ToolStripMenuItem
			// 
			this.删除错误计费ToolStripMenuItem.Name = "删除错误计费ToolStripMenuItem";
			this.删除错误计费ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.删除错误计费ToolStripMenuItem.Text = "删除错误计费";
			this.删除错误计费ToolStripMenuItem.Click += new System.EventHandler(this.删除错误计费ToolStripMenuItemClick);
			// 
			// FormCharge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 264);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.textBoxPeriodNo);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonJFSingle);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.buttonSCJF);
			this.Controls.Add(this.buttonPrintJF);
			this.Controls.Add(this.buttonJFAll);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelCalResult);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.label1);
			this.Name = "FormCharge";
			this.Text = "计费收费";
			this.Load += new System.EventHandler(this.FormChargeLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
