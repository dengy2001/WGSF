/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 21:13
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormMeterReading
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPeriodNo;
		private System.Windows.Forms.Button buttonSerarch;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonProduce;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Button buttonCal;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPeriodNo = new System.Windows.Forms.TextBox();
			this.buttonSerarch = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonProduce = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.buttonCal = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 102);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(656, 229);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellEndEdit);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1CellFormatting);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "计量周期（形如201603）：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxPeriodNo
			// 
			this.textBoxPeriodNo.Location = new System.Drawing.Point(163, 28);
			this.textBoxPeriodNo.Name = "textBoxPeriodNo";
			this.textBoxPeriodNo.Size = new System.Drawing.Size(78, 21);
			this.textBoxPeriodNo.TabIndex = 2;
			// 
			// buttonSerarch
			// 
			this.buttonSerarch.Location = new System.Drawing.Point(258, 27);
			this.buttonSerarch.Name = "buttonSerarch";
			this.buttonSerarch.Size = new System.Drawing.Size(75, 23);
			this.buttonSerarch.TabIndex = 3;
			this.buttonSerarch.Text = "查询";
			this.buttonSerarch.UseVisualStyleBackColor = true;
			this.buttonSerarch.Click += new System.EventHandler(this.ButtonSerarchClick);
			// 
			// buttonDel
			// 
			this.buttonDel.Location = new System.Drawing.Point(339, 27);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(75, 23);
			this.buttonDel.TabIndex = 3;
			this.buttonDel.Text = "删除";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.ButtonDelClick);
			// 
			// buttonProduce
			// 
			this.buttonProduce.Location = new System.Drawing.Point(420, 27);
			this.buttonProduce.Name = "buttonProduce";
			this.buttonProduce.Size = new System.Drawing.Size(75, 23);
			this.buttonProduce.TabIndex = 3;
			this.buttonProduce.Text = "生成";
			this.buttonProduce.UseVisualStyleBackColor = true;
			this.buttonProduce.Click += new System.EventHandler(this.ButtonProduceClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(564, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "注意：删除只能删除还未生成收费记录的计量周期数据。";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(564, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "      生成在用表的抄表空白数据，以便完成止数的输入。如果重复生成，不会清除已经输入的表止数。";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(501, 335);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "保存";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(593, 335);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "退出";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// labelStatus
			// 
			this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelStatus.ForeColor = System.Drawing.Color.Blue;
			this.labelStatus.Location = new System.Drawing.Point(575, 28);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(93, 23);
			this.labelStatus.TabIndex = 1;
			this.labelStatus.Text = "【就绪】";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCal
			// 
			this.buttonCal.Location = new System.Drawing.Point(501, 26);
			this.buttonCal.Name = "buttonCal";
			this.buttonCal.Size = new System.Drawing.Size(75, 23);
			this.buttonCal.TabIndex = 3;
			this.buttonCal.Text = "计算";
			this.buttonCal.UseVisualStyleBackColor = true;
			this.buttonCal.Click += new System.EventHandler(this.ButtonCalClick);
			// 
			// FormMeterReading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 370);
			this.Controls.Add(this.buttonCal);
			this.Controls.Add(this.buttonProduce);
			this.Controls.Add(this.buttonDel);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonSerarch);
			this.Controls.Add(this.textBoxPeriodNo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormMeterReading";
			this.Text = "计量表读数记录";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
