/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 17:00
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormGuide
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(508, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "测试";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(77, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "1.基础信息设置";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(77, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "2.抄计量表";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(77, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "3.表计算";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(77, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "4.计费";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(77, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "5.收费";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(12, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "常规处理流程如下：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormGuide
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 261);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "FormGuide";
			this.Text = "FormGuide";
			this.ResumeLayout(false);

		}
	}
}
