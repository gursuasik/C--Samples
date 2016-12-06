using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PictureBox_ResimSe�
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
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
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.SuspendLayout();
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(248, 8);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(128, 23);
   this.button3.TabIndex = 7;
   this.button3.Text = "10 Derece Sa�a �evir";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(136, 8);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(104, 23);
   this.button2.TabIndex = 6;
   this.button2.Text = "Kes";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 23);
   this.button1.TabIndex = 5;
   this.button1.Text = "Resim Y�kle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(8, 40);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(456, 264);
   this.pictureBox1.TabIndex = 4;
   this.pictureBox1.TabStop = false;
   this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
   this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
   this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(464, 302);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.pictureBox1,
                                                              this.button3});
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
 Rectangle se�ili_alan = new Rectangle(0, 0, 0, 0);

  private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {
    se�ili_alan.X = e.X;
    se�ili_alan.Y = e.Y;
    se�ili_alan.Width = 0;
    se�ili_alan.Height = 0;
    //Formun ba�l���nda se�ili b�lgeyi g�ster
    this.Text = se�ili_alan.X.ToString() + "," + 
                se�ili_alan.Y.ToString() + "," + 
                se�ili_alan.Width.ToString() + "," +
                se�ili_alan.Height.ToString();
    pictureBox1.Invalidate(); //Paint olay�n� �a��r�r
   }
  }

  private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {
    se�ili_alan.Width = Math.Abs(se�ili_alan.Left - e.X);
    se�ili_alan.Height = Math.Abs(se�ili_alan.Top - e.Y);
    //Formun ba�l���nda se�ili b�lgeyi g�ster
    this.Text = se�ili_alan.X.ToString() + "," + se�ili_alan.Y.ToString() + "," + 
     se�ili_alan.Width.ToString() + "," + se�ili_alan.Height.ToString();
    pictureBox1.Invalidate(); //Paint olay�n� �a��r�r
   }
  }

  private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   //Se�ili alana k�rm�z� �er�eve �iz
   e.Graphics.DrawRectangle(new Pen(Color.Red), se�ili_alan);
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   openFileDialog1.Filter = "Resim  Dosyalar�|" + 
    "*.bmp;*.jpg;*.gif;*.tif;*.png";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    try
    {
     pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
    }
    catch
    {
     MessageBox.Show(openFileDialog1.FileName + " ge�erli resim dosyas� de�il");
    }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   if ((se�ili_alan.Height == 0) || (se�ili_alan.Width == 0))
   {
    MessageBox.Show("Se�ili alan yok");
    return;
   }
   if (pictureBox1.Image==null)
   {
    MessageBox.Show("Resim yok");
    return;
   }

   //Se�ili alan b�y�kl���nde bir Bitmap olu�tur
   Bitmap resim = new Bitmap(se�ili_alan.Width, se�ili_alan.Height);
   //Bu Bitmap i�in grafik nesnesi olu�tur
   Graphics gr = Graphics.FromImage(resim);
   //Picture Box i�indeki resmi yeni resmin 0,0 noktas�na �iz
   gr.DrawImage(pictureBox1.Image, 0, 0, se�ili_alan, GraphicsUnit.Pixel);
   //Yeni resmi pictureBox i�ine ata
   pictureBox1.Image = resim;
   gr.Dispose();
   //Se�ili alan� kald�r
   se�ili_alan.X = 0;
   se�ili_alan.Y = 0;
   se�ili_alan.Width = 0;
   se�ili_alan.Height = 0;
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   if ((se�ili_alan.Height == 0) || (se�ili_alan.Width == 0))
   {
    MessageBox.Show("Se�ili alan yok");
    return;
   }
   if (pictureBox1.Image==null)
   {
    MessageBox.Show("Resim yok");
    return;
   }
   //Se�ili alan b�y�kl���nde bir Bitmap olu�tur
   Bitmap resim = new Bitmap(se�ili_alan.Width, se�ili_alan.Height);
   //Bu Bitmap i�in grafik nesnesi olu�tur
   Graphics gr = Graphics.FromImage(resim);
   //10 derece �evir
   gr.RotateTransform(10);
   //Se�ili alan�n 0,0 noktas� etraf�nda �evir
   gr.TranslateTransform(0, 0, System.Drawing.Drawing2D.MatrixOrder.Append);
   //Picture Box i�indeki resmi yeni resmin 0,0 noktas�na �iz
   gr.DrawImage(pictureBox1.Image, 0, 0, se�ili_alan, GraphicsUnit.Pixel);
   //Yeni resmi pictureBox i�ine �iz
   Graphics g ;
   g = pictureBox1.CreateGraphics();
   //�evrilmi� resmi se�ili b�lgenin �zerine �iz
   g.DrawImage(resim, se�ili_alan);
   gr.Dispose();
   g.Dispose();
  }
  
 }
}
