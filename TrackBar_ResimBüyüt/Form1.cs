using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TrackBar_ResimBüyüt
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TrackBar trackBar1;
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
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.Label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.trackBar1 = new System.Windows.Forms.TrackBar();
   ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
   this.SuspendLayout();
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(88, 96);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(94, 164);
   this.pictureBox1.TabIndex = 13;
   this.pictureBox1.TabStop = false;
   // 
   // Label5
   // 
   this.Label5.AutoSize = true;
   this.Label5.Location = new System.Drawing.Point(248, 64);
   this.Label5.Name = "Label5";
   this.Label5.Size = new System.Drawing.Size(16, 13);
   this.Label5.TabIndex = 12;
   this.Label5.Text = "4x";
   // 
   // Label4
   // 
   this.Label4.AutoSize = true;
   this.Label4.Location = new System.Drawing.Point(192, 64);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(16, 13);
   this.Label4.TabIndex = 11;
   this.Label4.Text = "2x";
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(136, 64);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(16, 13);
   this.Label3.TabIndex = 10;
   this.Label3.Text = "1x";
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(80, 64);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(26, 13);
   this.Label2.TabIndex = 9;
   this.Label2.Text = "0,5x";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(24, 64);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(32, 13);
   this.Label1.TabIndex = 8;
   this.Label1.Text = "0,25x";
   // 
   // trackBar1
   // 
   this.trackBar1.LargeChange = 1;
   this.trackBar1.Location = new System.Drawing.Point(16, 16);
   this.trackBar1.Maximum = 4;
   this.trackBar1.Name = "trackBar1";
   this.trackBar1.Size = new System.Drawing.Size(256, 45);
   this.trackBar1.TabIndex = 7;
   this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(280, 286);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox1,
                                                              this.Label5,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.trackBar1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
   pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
   trackBar1.Value = 2;
  }

  private void trackBar1_Scroll(object sender, System.EventArgs e)
  {
   double[] katsayilar = {0.25, 0.5, 1, 2, 4};
   pictureBox1.Width  = (int) (pictureBox1.Image.Width * 
    katsayilar[trackBar1.Value]);
   pictureBox1.Height = (int) (pictureBox1.Image.Height * 
    katsayilar[trackBar1.Value]);
  }
	}
}
