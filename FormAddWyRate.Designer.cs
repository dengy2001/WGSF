/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 10:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormAddWyRate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSaveAdd;
		private System.Windows.Forms.Button buttonClose;
		
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
			this.buttonSaveAdd = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
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
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(782, 255);
			this.dataGridView1.TabIndex = 0;
			// 
			// buttonSaveAdd
			// 
			this.buttonSaveAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAdd.Location = new System.Drawing.Point(638, 273);
			this.buttonSaveAdd.Name = "buttonSaveAdd";
			this.buttonSaveAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveAdd.TabIndex = 1;
			this.buttonSaveAdd.Text = "保存增加";
			this.buttonSaveAdd.UseVisualStyleBackColor = true;
			this.buttonSaveAdd.Click += new System.EventHandler(this.ButtonSaveAddClick);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(719, 273);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "退出";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// FormAddWyRate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 308);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonSaveAdd);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormAddWyRate";
			this.Text = "添加物业的收费项";
			this.Load += new System.EventHandler(this.FormAddWyRateLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
