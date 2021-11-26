/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 18/11/2021
 * Time: 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Imagenv2_
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.pic1 = new System.Windows.Forms.PictureBox();
			this.btn1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
			this.SuspendLayout();
			// 
			// pic1
			// 
			this.pic1.Location = new System.Drawing.Point(63, 34);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(157, 153);
			this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic1.TabIndex = 5;
			this.pic1.TabStop = false;
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(84, 205);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(105, 55);
			this.btn1.TabIndex = 6;
			this.btn1.Text = "Mostrar ";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 323);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.pic1);
			this.Name = "MainForm";
			this.Text = "Imagenv2}";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.PictureBox pic1;
	}
}
