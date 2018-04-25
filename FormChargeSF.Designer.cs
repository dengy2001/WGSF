/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-04
 * 时间: 10:00
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormChargeSF
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBoxCustomer;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelCalResult;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.CheckBox checkBoxDisp;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 暂缓收费ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 免收ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 取消暂缓ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 取消免收ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
		private System.Windows.Forms.Button buttonSF;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxPeriodNo;
		
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
			this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.暂缓收费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.免收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.取消暂缓ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.取消免收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.labelCalResult = new System.Windows.Forms.Label();
			this.buttonNew = new System.Windows.Forms.Button();
			this.checkBoxDisp = new System.Windows.Forms.CheckBox();
			this.buttonSF = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxPeriodNo = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxCustomer
			// 
			this.comboBoxCustomer.FormattingEnabled = true;
			this.comboBoxCustomer.Location = new System.Drawing.Point(254, 10);
			this.comboBoxCustomer.Name = "comboBoxCustomer";
			this.comboBoxCustomer.Size = new System.Drawing.Size(121, 20);
			this.comboBoxCustomer.TabIndex = 11;
			this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCustomerSelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 77);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(786, 154);
			this.dataGridView1.TabIndex = 13;
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
			this.删除ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(137, 126);
			// 
			// 暂缓收费ToolStripMenuItem
			// 
			this.暂缓收费ToolStripMenuItem.Name = "暂缓收费ToolStripMenuItem";
			this.暂缓收费ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.暂缓收费ToolStripMenuItem.Text = "暂缓收费";
			this.暂缓收费ToolStripMenuItem.Click += new System.EventHandler(this.暂缓收费ToolStripMenuItemClick);
			// 
			// 免收ToolStripMenuItem
			// 
			this.免收ToolStripMenuItem.Name = "免收ToolStripMenuItem";
			this.免收ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.免收ToolStripMenuItem.Text = "免收";
			this.免收ToolStripMenuItem.Click += new System.EventHandler(this.免收ToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
			// 
			// 取消暂缓ToolStripMenuItem
			// 
			this.取消暂缓ToolStripMenuItem.Name = "取消暂缓ToolStripMenuItem";
			this.取消暂缓ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.取消暂缓ToolStripMenuItem.Text = "取消暂未收";
			this.取消暂缓ToolStripMenuItem.Click += new System.EventHandler(this.取消暂缓ToolStripMenuItemClick);
			// 
			// 取消免收ToolStripMenuItem
			// 
			this.取消免收ToolStripMenuItem.Name = "取消免收ToolStripMenuItem";
			this.取消免收ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.取消免收ToolStripMenuItem.Text = "取消免收";
			this.取消免收ToolStripMenuItem.Click += new System.EventHandler(this.取消免收ToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 6);
			// 
			// 删除ToolStripMenuItem
			// 
			this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
			this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.删除ToolStripMenuItem.Text = "删除";
			this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItemClick);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonQuit.Location = new System.Drawing.Point(723, 9);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 23);
			this.buttonQuit.TabIndex = 12;
			this.buttonQuit.Text = "退出";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.ButtonQuitClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(192, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "缴费对象：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCalResult
			// 
			this.labelCalResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCalResult.ForeColor = System.Drawing.Color.Red;
			this.labelCalResult.Location = new System.Drawing.Point(12, 234);
			this.labelCalResult.Name = "labelCalResult";
			this.labelCalResult.Size = new System.Drawing.Size(326, 23);
			this.labelCalResult.TabIndex = 9;
			this.labelCalResult.Text = "共 0 项收费，合计 0 元。";
			this.labelCalResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(14, 48);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(75, 23);
			this.buttonNew.TabIndex = 14;
			this.buttonNew.Text = "增加缴费";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.ButtonNewClick);
			// 
			// checkBoxDisp
			// 
			this.checkBoxDisp.Checked = true;
			this.checkBoxDisp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDisp.Location = new System.Drawing.Point(417, 8);
			this.checkBoxDisp.Name = "checkBoxDisp";
			this.checkBoxDisp.Size = new System.Drawing.Size(140, 24);
			this.checkBoxDisp.TabIndex = 15;
			this.checkBoxDisp.Text = "显示免收及暂未收";
			this.checkBoxDisp.UseVisualStyleBackColor = true;
			this.checkBoxDisp.CheckedChanged += new System.EventHandler(this.CheckBoxDispCheckedChanged);
			// 
			// buttonSF
			// 
			this.buttonSF.Location = new System.Drawing.Point(563, 9);
			this.buttonSF.Name = "buttonSF";
			this.buttonSF.Size = new System.Drawing.Size(89, 23);
			this.buttonSF.TabIndex = 16;
			this.buttonSF.Text = "收费";
			this.buttonSF.UseVisualStyleBackColor = true;
			this.buttonSF.Click += new System.EventHandler(this.ButtonSFClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "缴费周期：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxPeriodNo
			// 
			this.comboBoxPeriodNo.FormattingEnabled = true;
			this.comboBoxPeriodNo.Location = new System.Drawing.Point(77, 10);
			this.comboBoxPeriodNo.Name = "comboBoxPeriodNo";
			this.comboBoxPeriodNo.Size = new System.Drawing.Size(80, 20);
			this.comboBoxPeriodNo.TabIndex = 17;
			this.comboBoxPeriodNo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPeriodNoSelectedIndexChanged);
			// 
			// FormChargeSF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 266);
			this.Controls.Add(this.comboBoxPeriodNo);
			this.Controls.Add(this.buttonSF);
			this.Controls.Add(this.checkBoxDisp);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.comboBoxCustomer);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelCalResult);
			this.Name = "FormChargeSF";
			this.Text = "收费";
			this.Load += new System.EventHandler(this.FormChargeSFLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
