/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-30
 * 时间: 22:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormImport
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonImportCustomers;
		private System.Windows.Forms.Button buttonImportWyInfos;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		
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
			this.buttonImportCustomers = new System.Windows.Forms.Button();
			this.buttonImportWyInfos = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonImportCustomers
			// 
			this.buttonImportCustomers.Location = new System.Drawing.Point(38, 23);
			this.buttonImportCustomers.Name = "buttonImportCustomers";
			this.buttonImportCustomers.Size = new System.Drawing.Size(305, 23);
			this.buttonImportCustomers.TabIndex = 0;
			this.buttonImportCustomers.Text = "批量导入缴费信息";
			this.buttonImportCustomers.UseVisualStyleBackColor = true;
			this.buttonImportCustomers.Click += new System.EventHandler(this.ButtonImportCustomersClick);
			// 
			// buttonImportWyInfos
			// 
			this.buttonImportWyInfos.Location = new System.Drawing.Point(38, 52);
			this.buttonImportWyInfos.Name = "buttonImportWyInfos";
			this.buttonImportWyInfos.Size = new System.Drawing.Size(305, 23);
			this.buttonImportWyInfos.TabIndex = 0;
			this.buttonImportWyInfos.Text = "批量导入物业信息";
			this.buttonImportWyInfos.UseVisualStyleBackColor = true;
			this.buttonImportWyInfos.Click += new System.EventHandler(this.ButtonImportWyInfosClick);
			// 
			// textBox1
			// 
			this.textBox1.ForeColor = System.Drawing.Color.Red;
			this.textBox1.Location = new System.Drawing.Point(38, 81);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(305, 61);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "批量数据导入前必须按照约定要求准备好Excel文件；   批量导入的数据并不完整，还需要进行补充，慎用！！！";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(304, 245);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(196, 245);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "清空数据";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(38, 218);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(341, 21);
			this.textBox2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 192);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(341, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "请在下面的文本框中输入：【我确认要清空数据】以确认清空！";
			// 
			// FormImport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 289);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonImportWyInfos);
			this.Controls.Add(this.buttonImportCustomers);
			this.Name = "FormImport";
			this.Text = "数据批量导入";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
