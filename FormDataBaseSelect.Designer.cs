/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-18
 * 时间: 12:16
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WGSF
{
	partial class FormDataBaseSelect
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonEnter;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonRemove;
		
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
			this.buttonEnter = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonEnter
			// 
			this.buttonEnter.Location = new System.Drawing.Point(415, 34);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(75, 23);
			this.buttonEnter.TabIndex = 0;
			this.buttonEnter.Text = "进入帐套";
			this.buttonEnter.UseVisualStyleBackColor = true;
			this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.ItemHeight = 12;
			this.comboBox1.Location = new System.Drawing.Point(13, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(396, 20);
			this.comboBox1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.buttonAdd);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(589, 88);
			this.panel1.TabIndex = 2;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(496, 56);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "增加帐套";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Navy;
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.buttonRemove);
			this.panel2.Controls.Add(this.buttonEnter);
			this.panel2.Location = new System.Drawing.Point(0, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(589, 97);
			this.panel2.TabIndex = 2;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(496, 34);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonRemove.TabIndex = 0;
			this.buttonRemove.Text = "移除帐套";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.ButtonRemoveClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.panel3.Location = new System.Drawing.Point(0, 178);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(589, 98);
			this.panel3.TabIndex = 2;
			// 
			// FormDataBaseSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 273);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormDataBaseSelect";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "帐套管理";
			this.Load += new System.EventHandler(this.FormDataBaseSelectLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
