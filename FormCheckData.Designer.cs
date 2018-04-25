/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 15:06
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormCheckData
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonCheckNow;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.TextBox textBoxResult;
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
			this.buttonCheckNow = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonCheckNow
			// 
			this.buttonCheckNow.Location = new System.Drawing.Point(12, 12);
			this.buttonCheckNow.Name = "buttonCheckNow";
			this.buttonCheckNow.Size = new System.Drawing.Size(153, 23);
			this.buttonCheckNow.TabIndex = 0;
			this.buttonCheckNow.Text = "开始检查数据";
			this.buttonCheckNow.UseVisualStyleBackColor = true;
			this.buttonCheckNow.Click += new System.EventHandler(this.ButtonCheckNowClick);
			// 
			// labelStatus
			// 
			this.labelStatus.Location = new System.Drawing.Point(12, 39);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(465, 23);
			this.labelStatus.TabIndex = 1;
			this.labelStatus.Text = "还未开始检查！";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(12, 65);
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxResult.Size = new System.Drawing.Size(462, 250);
			this.textBoxResult.TabIndex = 2;
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(399, 13);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "退出";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// FormCheckData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 327);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.buttonCheckNow);
			this.Name = "FormCheckData";
			this.Text = "检查数据";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
