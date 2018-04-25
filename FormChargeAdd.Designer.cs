/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-04
 * 时间: 22:08
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormChargeAdd
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAbstract;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPeriodNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxChargePrice;
		private System.Windows.Forms.TextBox textBoxChargeNum;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxChargeUnit;
		
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
			this.textBoxAbstract = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPeriodNo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxChargePrice = new System.Windows.Forms.TextBox();
			this.textBoxChargeNum = new System.Windows.Forms.TextBox();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxChargeUnit = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "缴费摘要：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxAbstract
			// 
			this.textBoxAbstract.Location = new System.Drawing.Point(85, 10);
			this.textBoxAbstract.Name = "textBoxAbstract";
			this.textBoxAbstract.Size = new System.Drawing.Size(311, 21);
			this.textBoxAbstract.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "计费周期：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxPeriodNo
			// 
			this.textBoxPeriodNo.Location = new System.Drawing.Point(85, 49);
			this.textBoxPeriodNo.Name = "textBoxPeriodNo";
			this.textBoxPeriodNo.Size = new System.Drawing.Size(100, 21);
			this.textBoxPeriodNo.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "单价：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(228, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "数量：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxChargePrice
			// 
			this.textBoxChargePrice.Location = new System.Drawing.Point(85, 92);
			this.textBoxChargePrice.Name = "textBoxChargePrice";
			this.textBoxChargePrice.Size = new System.Drawing.Size(100, 21);
			this.textBoxChargePrice.TabIndex = 2;
			this.textBoxChargePrice.TextChanged += new System.EventHandler(this.TextBoxChargePriceTextChanged);
			// 
			// textBoxChargeNum
			// 
			this.textBoxChargeNum.Location = new System.Drawing.Point(296, 93);
			this.textBoxChargeNum.Name = "textBoxChargeNum";
			this.textBoxChargeNum.Size = new System.Drawing.Size(100, 21);
			this.textBoxChargeNum.TabIndex = 3;
			this.textBoxChargeNum.TextChanged += new System.EventHandler(this.TextBoxChargeNumTextChanged);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(321, 158);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 23);
			this.buttonQuit.TabIndex = 6;
			this.buttonQuit.Text = "退出";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.ButtonQuitClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(239, 158);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "保存";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(223, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "单位：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxChargeUnit
			// 
			this.textBoxChargeUnit.Location = new System.Drawing.Point(296, 51);
			this.textBoxChargeUnit.Name = "textBoxChargeUnit";
			this.textBoxChargeUnit.Size = new System.Drawing.Size(100, 21);
			this.textBoxChargeUnit.TabIndex = 2;
			// 
			// FormChargeAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 193);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.textBoxChargeNum);
			this.Controls.Add(this.textBoxChargeUnit);
			this.Controls.Add(this.textBoxChargePrice);
			this.Controls.Add(this.textBoxPeriodNo);
			this.Controls.Add(this.textBoxAbstract);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormChargeAdd";
			this.Text = "缴费增加";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
