/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 20:08
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormRates
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
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ComboBox comboBoxRateUnit;
		private System.Windows.Forms.ComboBox comboBoxRateClass;
		private System.Windows.Forms.TextBox textBoxRateValue;
		private System.Windows.Forms.TextBox textBoxRateBrief;
		private System.Windows.Forms.TextBox textBoxRateName;
		private System.Windows.Forms.TextBox textBoxRateID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 新收费项ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 修改收费项ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除收费项ToolStripMenuItem;
		
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
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.新收费项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改收费项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除收费项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.comboBoxRateUnit = new System.Windows.Forms.ComboBox();
			this.comboBoxRateClass = new System.Windows.Forms.ComboBox();
			this.textBoxRateValue = new System.Windows.Forms.TextBox();
			this.textBoxRateBrief = new System.Windows.Forms.TextBox();
			this.textBoxRateName = new System.Windows.Forms.TextBox();
			this.textBoxRateID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
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
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Controls.Add(this.buttonDel);
			this.panel1.Controls.Add(this.buttonModify);
			this.panel1.Controls.Add(this.buttonAdd);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(666, 190);
			this.panel1.TabIndex = 0;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClose.Location = new System.Drawing.Point(293, 151);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "退出";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// buttonDel
			// 
			this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDel.Location = new System.Drawing.Point(165, 151);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(75, 23);
			this.buttonDel.TabIndex = 3;
			this.buttonDel.Text = "删除收费项";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.ButtonDelClick);
			// 
			// buttonModify
			// 
			this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonModify.Location = new System.Drawing.Point(84, 151);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(75, 23);
			this.buttonModify.TabIndex = 2;
			this.buttonModify.Text = "修改收费项";
			this.buttonModify.UseVisualStyleBackColor = true;
			this.buttonModify.Click += new System.EventHandler(this.ButtonModifyClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAdd.Location = new System.Drawing.Point(3, 151);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "新收费项";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
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
			this.dataGridView1.Size = new System.Drawing.Size(663, 142);
			this.dataGridView1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.新收费项ToolStripMenuItem,
			this.修改收费项ToolStripMenuItem,
			this.删除收费项ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
			// 
			// 新收费项ToolStripMenuItem
			// 
			this.新收费项ToolStripMenuItem.Name = "新收费项ToolStripMenuItem";
			this.新收费项ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.新收费项ToolStripMenuItem.Text = "新收费项";
			this.新收费项ToolStripMenuItem.Click += new System.EventHandler(this.新收费项ToolStripMenuItemClick);
			// 
			// 修改收费项ToolStripMenuItem
			// 
			this.修改收费项ToolStripMenuItem.Name = "修改收费项ToolStripMenuItem";
			this.修改收费项ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.修改收费项ToolStripMenuItem.Text = "修改收费项";
			this.修改收费项ToolStripMenuItem.Click += new System.EventHandler(this.修改收费项ToolStripMenuItemClick);
			// 
			// 删除收费项ToolStripMenuItem
			// 
			this.删除收费项ToolStripMenuItem.Name = "删除收费项ToolStripMenuItem";
			this.删除收费项ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.删除收费项ToolStripMenuItem.Text = "删除收费项";
			this.删除收费项ToolStripMenuItem.Click += new System.EventHandler(this.删除收费项ToolStripMenuItemClick);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.buttonCancel);
			this.panel2.Controls.Add(this.buttonSave);
			this.panel2.Controls.Add(this.comboBoxRateUnit);
			this.panel2.Controls.Add(this.comboBoxRateClass);
			this.panel2.Controls.Add(this.textBoxRateValue);
			this.panel2.Controls.Add(this.textBoxRateBrief);
			this.panel2.Controls.Add(this.textBoxRateName);
			this.panel2.Controls.Add(this.textBoxRateID);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 208);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(666, 121);
			this.panel2.TabIndex = 0;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(84, 95);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(3, 95);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "保存";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// comboBoxRateUnit
			// 
			this.comboBoxRateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRateUnit.FormattingEnabled = true;
			this.comboBoxRateUnit.Location = new System.Drawing.Point(293, 58);
			this.comboBoxRateUnit.Name = "comboBoxRateUnit";
			this.comboBoxRateUnit.Size = new System.Drawing.Size(132, 20);
			this.comboBoxRateUnit.TabIndex = 3;
			// 
			// comboBoxRateClass
			// 
			this.comboBoxRateClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRateClass.FormattingEnabled = true;
			this.comboBoxRateClass.Location = new System.Drawing.Point(72, 58);
			this.comboBoxRateClass.Name = "comboBoxRateClass";
			this.comboBoxRateClass.Size = new System.Drawing.Size(132, 20);
			this.comboBoxRateClass.TabIndex = 2;
			// 
			// textBoxRateValue
			// 
			this.textBoxRateValue.Location = new System.Drawing.Point(519, 58);
			this.textBoxRateValue.Name = "textBoxRateValue";
			this.textBoxRateValue.Size = new System.Drawing.Size(132, 21);
			this.textBoxRateValue.TabIndex = 4;
			this.textBoxRateValue.TextChanged += new System.EventHandler(this.TextBoxRateValueTextChanged);
			// 
			// textBoxRateBrief
			// 
			this.textBoxRateBrief.Location = new System.Drawing.Point(519, 14);
			this.textBoxRateBrief.Name = "textBoxRateBrief";
			this.textBoxRateBrief.Size = new System.Drawing.Size(132, 21);
			this.textBoxRateBrief.TabIndex = 1;
			// 
			// textBoxRateName
			// 
			this.textBoxRateName.Location = new System.Drawing.Point(293, 12);
			this.textBoxRateName.Name = "textBoxRateName";
			this.textBoxRateName.Size = new System.Drawing.Size(132, 21);
			this.textBoxRateName.TabIndex = 0;
			// 
			// textBoxRateID
			// 
			this.textBoxRateID.Location = new System.Drawing.Point(72, 12);
			this.textBoxRateID.Name = "textBoxRateID";
			this.textBoxRateID.ReadOnly = true;
			this.textBoxRateID.Size = new System.Drawing.Size(132, 21);
			this.textBoxRateID.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(446, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "收费项值：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(222, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "收费项单位：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "收费项类别：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(446, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "收费项描述：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(222, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "收费项名称：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "收费项ID：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormRates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 341);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormRates";
			this.Text = "收费项设置";
			this.Load += new System.EventHandler(this.FormRatesLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
