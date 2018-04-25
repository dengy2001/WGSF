/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-07
 * 时间: 9:43
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormHisSF
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFilter;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 回退到未收费状态ToolStripMenuItem;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonClose = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.回退到未收费状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(213, 222);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1SelectionChanged);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(503, 12);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "退出";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(337, 222);
			this.dataGridView2.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 53);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
			this.splitContainer1.Size = new System.Drawing.Size(566, 228);
			this.splitContainer1.SplitterDistance = 219;
			this.splitContainer1.TabIndex = 2;
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(12, 12);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(112, 23);
			this.buttonPrint.TabIndex = 3;
			this.buttonPrint.Text = "打印收费单";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.ButtonPrintClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(145, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "收费单过滤：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Location = new System.Drawing.Point(223, 13);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(230, 21);
			this.textBoxFilter.TabIndex = 6;
			this.textBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilterTextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.回退到未收费状态ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(173, 26);
			// 
			// 回退到未收费状态ToolStripMenuItem
			// 
			this.回退到未收费状态ToolStripMenuItem.Name = "回退到未收费状态ToolStripMenuItem";
			this.回退到未收费状态ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.回退到未收费状态ToolStripMenuItem.Text = "回退到未收费状态";
			this.回退到未收费状态ToolStripMenuItem.Click += new System.EventHandler(this.回退到未收费状态ToolStripMenuItemClick);
			// 
			// FormHisSF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 293);
			this.Controls.Add(this.textBoxFilter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.buttonClose);
			this.Name = "FormHisSF";
			this.Text = "历史收费单";
			this.Load += new System.EventHandler(this.FormHisSFLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
