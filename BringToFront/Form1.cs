using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BringToFront
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PictureBox pictureBox3;
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
   this.pictureBox3 = new System.Windows.Forms.PictureBox();
   this.pictureBox2 = new System.Windows.Forms.PictureBox();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // pictureBox3
   // 
   this.pictureBox3.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox3.Image")));
   this.pictureBox3.Location = new System.Drawing.Point(184, 160);
   this.pictureBox3.Name = "pictureBox3";
   this.pictureBox3.Size = new System.Drawing.Size(320, 200);
   this.pictureBox3.TabIndex = 14;
   this.pictureBox3.TabStop = false;
   // 
   // pictureBox2
   // 
   this.pictureBox2.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox2.Image")));
   this.pictureBox2.Location = new System.Drawing.Point(88, 96);
   this.pictureBox2.Name = "pictureBox2";
   this.pictureBox2.Size = new System.Drawing.Size(320, 200);
   this.pictureBox2.TabIndex = 13;
   this.pictureBox2.TabStop = false;
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(16, 16);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(320, 200);
   this.pictureBox1.TabIndex = 12;
   this.pictureBox1.TabStop = false;
   this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(512, 366);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox3,
                                                              this.pictureBox2,
                                                              this.pictureBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Olaylarý birleþtir
   pictureBox2.Click += new EventHandler(pictureBox1_Click);
   pictureBox3.Click += new EventHandler(pictureBox1_Click);
  }

  private void pictureBox1_Click(object sender, System.EventArgs e)
  {
   (sender as PictureBox).BringToFront();
  }
	}
}
