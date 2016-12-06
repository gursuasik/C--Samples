using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PictureBox_GetSetPixel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.ProgressBar progressBar1;
  internal System.Windows.Forms.Button button1;
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
   this.button2 = new System.Windows.Forms.Button();
   this.progressBar1 = new System.Windows.Forms.ProgressBar();
   this.button1 = new System.Windows.Forms.Button();
   this.pictureBox2 = new System.Windows.Forms.PictureBox();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(136, 172);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(152, 48);
   this.button2.TabIndex = 14;
   this.button2.Text = "Emboss Efekti Uygula";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // progressBar1
   // 
   this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.progressBar1.Location = new System.Drawing.Point(0, 231);
   this.progressBar1.Name = "progressBar1";
   this.progressBar1.Size = new System.Drawing.Size(632, 23);
   this.progressBar1.TabIndex = 13;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 172);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(112, 48);
   this.button1.TabIndex = 12;
   this.button1.Text = "Negatif Görüntü";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // pictureBox2
   // 
   this.pictureBox2.Location = new System.Drawing.Point(320, 4);
   this.pictureBox2.Name = "pictureBox2";
   this.pictureBox2.Size = new System.Drawing.Size(304, 152);
   this.pictureBox2.TabIndex = 11;
   this.pictureBox2.TabStop = false;
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(8, 4);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(304, 152);
   this.pictureBox1.TabIndex = 10;
   this.pictureBox1.TabStop = false;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(632, 254);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.progressBar1,
                                                              this.button1,
                                                              this.pictureBox2,
                                                              this.pictureBox1});
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
   progressBar1.Visible = true;
   int i, j;
   Color r;
   Bitmap bmp = new Bitmap(pictureBox1.Image);
   progressBar1.Maximum = bmp.Width * bmp.Height;
   for (i = 0; i <= bmp.Width - 1 ; i++)
   {
    for (j = 0; j<= bmp.Height - 1;j++)
    {
     r = bmp.GetPixel(i, j);//i,j noktasýnýn rengini öðren
     //Alpha kanalý hariç diðer kanallarýn tersini al
     r = Color.FromArgb(r.A, (byte) ~r.R, (byte)~r.G, (byte)~r.B);
     bmp.SetPixel(i, j, r);//ayný noktaya tekrar koy
     if ((i % 10) == 0)//her on satýrda bir göstergeyi güncelle
     {
      progressBar1.Value = i * bmp.Height + j;
      Application.DoEvents();
     }
    }
    pictureBox2.Image = bmp;
   }
   progressBar1.Visible = false;
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   progressBar1.Visible = true;
   int i, j; 
   Color renk1, renk2, renk3;
   Bitmap bmp = new Bitmap(pictureBox1.Image);
   int r, g, b;
   progressBar1.Maximum = bmp.Width * bmp.Height;
   for (i = 0 ; i<=bmp.Width - 2 ; i++)
   {
    for (j = 0 ; j<=bmp.Height - 2 ; j++)
    {
     renk1 = bmp.GetPixel(i, j); //i,j noktasýnýn rengini öðren
     renk2 = bmp.GetPixel(i + 1, j + 1); //sonraki noktanýn rengini öðren
     r = Math.Abs((int)(renk1.R) - renk2.R) + 128;
     if (r > 255) r = 255;
     g = Math.Abs((int)(renk1.G) - renk2.G) + 128;
     if (g > 255) g = 255;
     b = Math.Abs((int)(renk1.B) - renk2.B) + 128;
     if (b > 255) b = 255;
     renk3 = Color.FromArgb(r, g, b);
     bmp.SetPixel(i, j, renk3);  //ayný noktaya tekrar koy
     if ((i % 10) == 0) //her on satýrda bir göstergeyi güncelle
     {
      progressBar1.Value = i * bmp.Height + j;
      Application.DoEvents();
     }
    }
    pictureBox2.Image = bmp;
   }
   progressBar1.Visible = false;
  }
	}
}
