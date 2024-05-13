/*
 * Created by SharpDevelop.
 * User: Admin-PC
 * Date: 13 May 2024
 * Time: 2:12 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace winforms_DeLosReyes
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(299, 199);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(75, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome User";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 202);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Welcome";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
