/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-29
 * 时间: 20:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormMeters
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonModify;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxMeterSelfUse;
		private System.Windows.Forms.CheckBox checkBoxMeterSharing;
		private System.Windows.Forms.CheckBox checkBoxMeterUsing;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxWyID;
		private System.Windows.Forms.ComboBox comboBoxRateID;
		private System.Windows.Forms.ComboBox comboBoxMeterClass;
		private WGSF.ComboBoxTreeView comboBoxTreeViewMeterPID;
		private System.Windows.Forms.TextBox textBoxMeterMaxNumber;
		private System.Windows.Forms.TextBox textBoxMeterMulti;
		private System.Windows.Forms.TextBox textBoxMeterName;
		private System.Windows.Forms.TextBox textBoxMeterID;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 新计量表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 修改计量表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除计量表ToolStripMenuItem;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeters));
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.新计量表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改计量表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除计量表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.comboBoxWyID = new System.Windows.Forms.ComboBox();
			this.comboBoxRateID = new System.Windows.Forms.ComboBox();
			this.comboBoxMeterClass = new System.Windows.Forms.ComboBox();
			this.comboBoxTreeViewMeterPID = new WGSF.ComboBoxTreeView();
			this.textBoxMeterMaxNumber = new System.Windows.Forms.TextBox();
			this.textBoxMeterMulti = new System.Windows.Forms.TextBox();
			this.textBoxMeterName = new System.Windows.Forms.TextBox();
			this.textBoxMeterID = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxMeterSelfUse = new System.Windows.Forms.CheckBox();
			this.checkBoxMeterSharing = new System.Windows.Forms.CheckBox();
			this.checkBoxMeterUsing = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.treeView1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Controls.Add(this.buttonDel);
			this.panel1.Controls.Add(this.buttonModify);
			this.panel1.Controls.Add(this.buttonNew);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(467, 344);
			this.panel1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.ItemHeight = 32;
			this.treeView1.Location = new System.Drawing.Point(4, 4);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.ShowNodeToolTips = true;
			this.treeView1.Size = new System.Drawing.Size(460, 303);
			this.treeView1.TabIndex = 4;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.新计量表ToolStripMenuItem,
			this.修改计量表ToolStripMenuItem,
			this.删除计量表ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
			// 
			// 新计量表ToolStripMenuItem
			// 
			this.新计量表ToolStripMenuItem.Name = "新计量表ToolStripMenuItem";
			this.新计量表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.新计量表ToolStripMenuItem.Text = "新计量表";
			this.新计量表ToolStripMenuItem.Click += new System.EventHandler(this.新计量表ToolStripMenuItemClick);
			// 
			// 修改计量表ToolStripMenuItem
			// 
			this.修改计量表ToolStripMenuItem.Name = "修改计量表ToolStripMenuItem";
			this.修改计量表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.修改计量表ToolStripMenuItem.Text = "修改计量表";
			this.修改计量表ToolStripMenuItem.Click += new System.EventHandler(this.修改计量表ToolStripMenuItemClick);
			// 
			// 删除计量表ToolStripMenuItem
			// 
			this.删除计量表ToolStripMenuItem.Name = "删除计量表ToolStripMenuItem";
			this.删除计量表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.删除计量表ToolStripMenuItem.Text = "删除计量表";
			this.删除计量表ToolStripMenuItem.Click += new System.EventHandler(this.删除计量表ToolStripMenuItemClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "无表类.png");
			this.imageList1.Images.SetKeyName(1, "水表（使用中）.png");
			this.imageList1.Images.SetKeyName(2, "水表（未使用）.png");
			this.imageList1.Images.SetKeyName(3, "电表（使用中）.png");
			this.imageList1.Images.SetKeyName(4, "电表（未使用）.png");
			this.imageList1.Images.SetKeyName(5, "气表（使用中）.png");
			this.imageList1.Images.SetKeyName(6, "气表（未使用）.png");
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(389, 313);
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
			this.buttonDel.Location = new System.Drawing.Point(166, 313);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(75, 23);
			this.buttonDel.TabIndex = 2;
			this.buttonDel.Text = "删除计量表";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.ButtonDelClick);
			// 
			// buttonModify
			// 
			this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonModify.Location = new System.Drawing.Point(85, 313);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(75, 23);
			this.buttonModify.TabIndex = 1;
			this.buttonModify.Text = "修改计量表";
			this.buttonModify.UseVisualStyleBackColor = true;
			this.buttonModify.Click += new System.EventHandler(this.ButtonModifyClick);
			// 
			// buttonNew
			// 
			this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonNew.Location = new System.Drawing.Point(4, 313);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(75, 23);
			this.buttonNew.TabIndex = 0;
			this.buttonNew.Text = "新计量表";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.ButtonNewClick);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.comboBoxWyID);
			this.panel2.Controls.Add(this.comboBoxRateID);
			this.panel2.Controls.Add(this.comboBoxMeterClass);
			this.panel2.Controls.Add(this.comboBoxTreeViewMeterPID);
			this.panel2.Controls.Add(this.textBoxMeterMaxNumber);
			this.panel2.Controls.Add(this.textBoxMeterMulti);
			this.panel2.Controls.Add(this.textBoxMeterName);
			this.panel2.Controls.Add(this.textBoxMeterID);
			this.panel2.Controls.Add(this.buttonCancel);
			this.panel2.Controls.Add(this.buttonSave);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(485, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(239, 344);
			this.panel2.TabIndex = 0;
			// 
			// comboBoxWyID
			// 
			this.comboBoxWyID.FormattingEnabled = true;
			this.comboBoxWyID.Location = new System.Drawing.Point(70, 276);
			this.comboBoxWyID.Name = "comboBoxWyID";
			this.comboBoxWyID.Size = new System.Drawing.Size(166, 20);
			this.comboBoxWyID.TabIndex = 7;
			// 
			// comboBoxRateID
			// 
			this.comboBoxRateID.FormattingEnabled = true;
			this.comboBoxRateID.Location = new System.Drawing.Point(70, 248);
			this.comboBoxRateID.Name = "comboBoxRateID";
			this.comboBoxRateID.Size = new System.Drawing.Size(166, 20);
			this.comboBoxRateID.TabIndex = 6;
			// 
			// comboBoxMeterClass
			// 
			this.comboBoxMeterClass.FormattingEnabled = true;
			this.comboBoxMeterClass.Items.AddRange(new object[] {
			"水表",
			"电表",
			"气表"});
			this.comboBoxMeterClass.Location = new System.Drawing.Point(70, 91);
			this.comboBoxMeterClass.Name = "comboBoxMeterClass";
			this.comboBoxMeterClass.Size = new System.Drawing.Size(166, 20);
			this.comboBoxMeterClass.TabIndex = 3;
			// 
			// comboBoxTreeViewMeterPID
			// 
			this.comboBoxTreeViewMeterPID.FormattingEnabled = true;
			this.comboBoxTreeViewMeterPID.Location = new System.Drawing.Point(70, 33);
			this.comboBoxTreeViewMeterPID.Name = "comboBoxTreeViewMeterPID";
			this.comboBoxTreeViewMeterPID.Size = new System.Drawing.Size(166, 20);
			this.comboBoxTreeViewMeterPID.TabIndex = 1;
			// 
			// textBoxMeterMaxNumber
			// 
			this.textBoxMeterMaxNumber.Location = new System.Drawing.Point(70, 220);
			this.textBoxMeterMaxNumber.Name = "textBoxMeterMaxNumber";
			this.textBoxMeterMaxNumber.Size = new System.Drawing.Size(166, 21);
			this.textBoxMeterMaxNumber.TabIndex = 5;
			this.textBoxMeterMaxNumber.TextChanged += new System.EventHandler(this.TextBoxMeterMaxNumberTextChanged);
			// 
			// textBoxMeterMulti
			// 
			this.textBoxMeterMulti.Location = new System.Drawing.Point(70, 192);
			this.textBoxMeterMulti.Name = "textBoxMeterMulti";
			this.textBoxMeterMulti.Size = new System.Drawing.Size(166, 21);
			this.textBoxMeterMulti.TabIndex = 4;
			this.textBoxMeterMulti.TextChanged += new System.EventHandler(this.TextBoxMeterMultiTextChanged);
			// 
			// textBoxMeterName
			// 
			this.textBoxMeterName.Location = new System.Drawing.Point(70, 62);
			this.textBoxMeterName.Name = "textBoxMeterName";
			this.textBoxMeterName.Size = new System.Drawing.Size(166, 21);
			this.textBoxMeterName.TabIndex = 2;
			// 
			// textBoxMeterID
			// 
			this.textBoxMeterID.Location = new System.Drawing.Point(70, 4);
			this.textBoxMeterID.Name = "textBoxMeterID";
			this.textBoxMeterID.ReadOnly = true;
			this.textBoxMeterID.Size = new System.Drawing.Size(166, 21);
			this.textBoxMeterID.TabIndex = 0;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Location = new System.Drawing.Point(161, 313);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Location = new System.Drawing.Point(80, 313);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 8;
			this.buttonSave.Text = "保存";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxMeterSelfUse);
			this.groupBox1.Controls.Add(this.checkBoxMeterSharing);
			this.groupBox1.Controls.Add(this.checkBoxMeterUsing);
			this.groupBox1.Location = new System.Drawing.Point(3, 115);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(233, 61);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// checkBoxMeterSelfUse
			// 
			this.checkBoxMeterSelfUse.Location = new System.Drawing.Point(7, 35);
			this.checkBoxMeterSelfUse.Name = "checkBoxMeterSelfUse";
			this.checkBoxMeterSelfUse.Size = new System.Drawing.Size(104, 24);
			this.checkBoxMeterSelfUse.TabIndex = 2;
			this.checkBoxMeterSelfUse.Text = "下级表未全";
			this.checkBoxMeterSelfUse.UseVisualStyleBackColor = true;
			// 
			// checkBoxMeterSharing
			// 
			this.checkBoxMeterSharing.Location = new System.Drawing.Point(123, 10);
			this.checkBoxMeterSharing.Name = "checkBoxMeterSharing";
			this.checkBoxMeterSharing.Size = new System.Drawing.Size(104, 24);
			this.checkBoxMeterSharing.TabIndex = 1;
			this.checkBoxMeterSharing.Text = "分摊量计费";
			this.checkBoxMeterSharing.UseVisualStyleBackColor = true;
			// 
			// checkBoxMeterUsing
			// 
			this.checkBoxMeterUsing.Location = new System.Drawing.Point(7, 10);
			this.checkBoxMeterUsing.Name = "checkBoxMeterUsing";
			this.checkBoxMeterUsing.Size = new System.Drawing.Size(104, 24);
			this.checkBoxMeterUsing.TabIndex = 0;
			this.checkBoxMeterUsing.Text = "使用中";
			this.checkBoxMeterUsing.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "表名：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "最大计数：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(3, 275);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "属于物业：";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(3, 247);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "费率：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "倍率：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "表类：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "上级表号：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "表号：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormMeters
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 368);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormMeters";
			this.Text = "计量表";
			this.Load += new System.EventHandler(this.FormMetersLoad);
			this.panel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
