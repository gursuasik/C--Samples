using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_Ev
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PictureBox pictureBox2;
  internal System.Windows.Forms.PictureBox pictureBox1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.pictureBox2 = new System.Windows.Forms.PictureBox();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // pictureBox2
   // 
   this.pictureBox2.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox2.Image")));
   this.pictureBox2.Location = new System.Drawing.Point(328, 352);
   this.pictureBox2.Name = "pictureBox2";
   this.pictureBox2.Size = new System.Drawing.Size(184, 128);
   this.pictureBox2.TabIndex = 5;
   this.pictureBox2.TabStop = false;
   this.pictureBox2.Visible = false;
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(160, 352);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(160, 128);
   this.pictureBox1.TabIndex = 4;
   this.pictureBox1.TabStop = false;
   this.pictureBox1.Visible = false;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(672, 526);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox2,
                                                              this.pictureBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
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

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   Point[] tavan= new Point[3];
   tavan[0] = new Point(100, 100);
   tavan[1] = new Point(450, 100);
   tavan[2] = new Point(150, 150);
   e.Graphics.DrawImage(pictureBox2.Image, tavan);

   Point[] arka_çatý = new Point[3];
   arka_çatý[0] = new Point(125, 75);
   arka_çatý[1] = new Point(470, 75);
   arka_çatý[2] = new Point(60, 130);
   e.Graphics.DrawImage(pictureBox2.Image, arka_çatý);

   Point[] yan_duvar = new Point[3];
   yan_duvar[0] = new Point(100, 100);
   yan_duvar[1] = new Point(150, 150);
   yan_duvar[2] = new Point(100, 300);
   e.Graphics.DrawImage(pictureBox1.Image, yan_duvar);

   Point[] ön_duvar = new Point[3];
   ön_duvar[0] = new Point(150, 150);
   ön_duvar[1] = new Point(500, 150);
   ön_duvar[2] = new Point(150, 350);
   e.Graphics.DrawImage(pictureBox1.Image, ön_duvar);

   Point[] ön_çatý = new Point[3];
   ön_çatý[0] = new Point(125, 75);
   ön_çatý[1] = new Point(160, 180);
   ön_çatý[2] = new Point(500, 75);
   e.Graphics.DrawImage(pictureBox1.Image, ön_çatý);
  }
	}
}
