/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-02
 * 时间: 15:12
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormSF
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox textBoxCustomerName;
		private System.Windows.Forms.TextBox textBoxPeriodNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPerson;
		private System.Windows.Forms.Button buttonQuit;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxCustomerName = new System.Windows.Forms.TextBox();
			this.textBoxPeriodNo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPerson = new System.Windows.Forms.TextBox();
			this.buttonQuit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "缴费对象：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "当前待收费项：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(954, 261);
			this.dataGridView1.TabIndex = 4;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(556, 15);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(105, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "确认收费";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
			// 
			// textBoxCustomerName
			// 
			this.textBoxCustomerName.Location = new System.Drawing.Point(72, 16);
			this.textBoxCustomerName.Name = "textBoxCustomerName";
			this.textBoxCustomerName.ReadOnly = true;
			this.textBoxCustomerName.Size = new System.Drawing.Size(100, 21);
			this.textBoxCustomerName.TabIndex = 0;
			// 
			// textBoxPeriodNo
			// 
			this.textBoxPeriodNo.Location = new System.Drawing.Point(264, 16);
			this.textBoxPeriodNo.Name = "textBoxPeriodNo";
			this.textBoxPeriodNo.ReadOnly = true;
			this.textBoxPeriodNo.Size = new System.Drawing.Size(100, 21);
			this.textBoxPeriodNo.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(203, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "收费周期：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(385, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "收款人：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxPerson
			// 
			this.textBoxPerson.Location = new System.Drawing.Point(435, 16);
			this.textBoxPerson.Name = "textBoxPerson";
			this.textBoxPerson.Size = new System.Drawing.Size(100, 21);
			this.textBoxPerson.TabIndex = 2;
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(891, 14);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 23);
			this.buttonQuit.TabIndex = 5;
			this.buttonQuit.Text = "退出";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.ButtonQuitClick);
			// 
			// FormSF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 358);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.textBoxPerson);
			this.Controls.Add(this.textBoxPeriodNo);
			this.Controls.Add(this.textBoxCustomerName);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "FormSF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "收费";
			this.Load += new System.EventHandler(this.FormSFLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
