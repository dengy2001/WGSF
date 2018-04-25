/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-29
 * 时间: 17:12
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormCustomers
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonModify;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCustomerLinkDetail;
		private System.Windows.Forms.TextBox textBoxCustomerLinkMan;
		private System.Windows.Forms.TextBox textBoxCutomerName;
		private System.Windows.Forms.TextBox textBoxCustomerID;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonImport;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 新缴费IDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 修改缴费IDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除缴费IDToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView2;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.buttonImport = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.新缴费IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改缴费IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除缴费IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxCustomerLinkDetail = new System.Windows.Forms.TextBox();
			this.textBoxCustomerLinkMan = new System.Windows.Forms.TextBox();
			this.textBoxCutomerName = new System.Windows.Forms.TextBox();
			this.textBoxCustomerID = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dataGridView2);
			this.panel1.Controls.Add(this.buttonImport);
			this.panel1.Controls.Add(this.buttonDel);
			this.panel1.Controls.Add(this.buttonModify);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Controls.Add(this.buttonNew);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 300);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(3, 210);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new System.Drawing.Size(446, 87);
			this.dataGridView2.TabIndex = 5;
			// 
			// buttonImport
			// 
			this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonImport.Location = new System.Drawing.Point(274, 181);
			this.buttonImport.Name = "buttonImport";
			this.buttonImport.Size = new System.Drawing.Size(89, 23);
			this.buttonImport.TabIndex = 3;
			this.buttonImport.Text = "导入缴费对象";
			this.buttonImport.UseVisualStyleBackColor = true;
			this.buttonImport.Visible = false;
			this.buttonImport.Click += new System.EventHandler(this.ButtonImportClick);
			// 
			// buttonDel
			// 
			this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDel.Location = new System.Drawing.Point(179, 181);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(89, 23);
			this.buttonDel.TabIndex = 3;
			this.buttonDel.Text = "删除缴费ID";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.ButtonDelClick);
			// 
			// buttonModify
			// 
			this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonModify.Location = new System.Drawing.Point(84, 181);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(89, 23);
			this.buttonModify.TabIndex = 2;
			this.buttonModify.Text = "修改缴费ID";
			this.buttonModify.UseVisualStyleBackColor = true;
			this.buttonModify.Click += new System.EventHandler(this.ButtonModifyClick);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(374, 181);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 4;
			this.buttonClose.Text = "退出";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// buttonNew
			// 
			this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonNew.Location = new System.Drawing.Point(3, 181);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(75, 23);
			this.buttonNew.TabIndex = 1;
			this.buttonNew.Text = "新缴费ID";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.ButtonNewClick);
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
			this.dataGridView1.Size = new System.Drawing.Size(446, 172);
			this.dataGridView1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.新缴费IDToolStripMenuItem,
			this.修改缴费IDToolStripMenuItem,
			this.删除缴费IDToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(138, 70);
			// 
			// 新缴费IDToolStripMenuItem
			// 
			this.新缴费IDToolStripMenuItem.Name = "新缴费IDToolStripMenuItem";
			this.新缴费IDToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.新缴费IDToolStripMenuItem.Text = "新缴费ID";
			this.新缴费IDToolStripMenuItem.Click += new System.EventHandler(this.新缴费IDToolStripMenuItemClick);
			// 
			// 修改缴费IDToolStripMenuItem
			// 
			this.修改缴费IDToolStripMenuItem.Name = "修改缴费IDToolStripMenuItem";
			this.修改缴费IDToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.修改缴费IDToolStripMenuItem.Text = "修改缴费ID";
			this.修改缴费IDToolStripMenuItem.Click += new System.EventHandler(this.修改缴费IDToolStripMenuItemClick);
			// 
			// 删除缴费IDToolStripMenuItem
			// 
			this.删除缴费IDToolStripMenuItem.Name = "删除缴费IDToolStripMenuItem";
			this.删除缴费IDToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.删除缴费IDToolStripMenuItem.Text = "删除缴费ID";
			this.删除缴费IDToolStripMenuItem.Click += new System.EventHandler(this.删除缴费IDToolStripMenuItemClick);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.textBoxCustomerLinkDetail);
			this.panel2.Controls.Add(this.textBoxCustomerLinkMan);
			this.panel2.Controls.Add(this.textBoxCutomerName);
			this.panel2.Controls.Add(this.textBoxCustomerID);
			this.panel2.Controls.Add(this.buttonCancel);
			this.panel2.Controls.Add(this.buttonSave);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(470, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 300);
			this.panel2.TabIndex = 0;
			// 
			// textBoxCustomerLinkDetail
			// 
			this.textBoxCustomerLinkDetail.Location = new System.Drawing.Point(80, 130);
			this.textBoxCustomerLinkDetail.Multiline = true;
			this.textBoxCustomerLinkDetail.Name = "textBoxCustomerLinkDetail";
			this.textBoxCustomerLinkDetail.Size = new System.Drawing.Size(167, 67);
			this.textBoxCustomerLinkDetail.TabIndex = 3;
			// 
			// textBoxCustomerLinkMan
			// 
			this.textBoxCustomerLinkMan.Location = new System.Drawing.Point(80, 91);
			this.textBoxCustomerLinkMan.Name = "textBoxCustomerLinkMan";
			this.textBoxCustomerLinkMan.Size = new System.Drawing.Size(167, 21);
			this.textBoxCustomerLinkMan.TabIndex = 2;
			// 
			// textBoxCutomerName
			// 
			this.textBoxCutomerName.Location = new System.Drawing.Point(80, 53);
			this.textBoxCutomerName.Name = "textBoxCutomerName";
			this.textBoxCutomerName.Size = new System.Drawing.Size(167, 21);
			this.textBoxCutomerName.TabIndex = 1;
			// 
			// textBoxCustomerID
			// 
			this.textBoxCustomerID.Location = new System.Drawing.Point(80, 15);
			this.textBoxCustomerID.Name = "textBoxCustomerID";
			this.textBoxCustomerID.ReadOnly = true;
			this.textBoxCustomerID.Size = new System.Drawing.Size(167, 21);
			this.textBoxCustomerID.TabIndex = 0;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Location = new System.Drawing.Point(97, 230);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Location = new System.Drawing.Point(16, 230);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "保存";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "备注：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "缴费联系人：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "缴费名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "缴费ID：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 324);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormCustomers";
			this.Text = "缴费对象信息";
			this.Load += new System.EventHandler(this.FormCustomersLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
