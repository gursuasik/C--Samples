using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ARGB
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(488, 8);
   this.button1.Name = "button1";
   this.button1.TabIndex = 0;
   this.button1.Text = "�iz";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(568, 318);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.ResumeLayout(false);

  }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

  private void button1_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   //K�rm�z� dikd�rtgen
   g.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 0, 0)), 
    10, 10, 100, 100);
   //Ye�il dikd�rtgen
   g.FillRectangle(new SolidBrush(Color.FromArgb(100, 0, 255, 0)), 
    90, 80, 100, 100);
   //Mavi dikd�rtgen
   g.FillRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 255)), 
    170, 10, 100, 100);
   //Sar� dikd�rtgen
   g.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 0)), 
    10, 160, 100, 100);
   //Beyaz dikd�rtgen
   g.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 255)), 
    170, 160, 100, 100);
   g.Dispose();
  }
	}
}
