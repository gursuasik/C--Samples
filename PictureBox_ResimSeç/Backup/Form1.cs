using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PictureBox_ResimSeç
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
   this.button3.Text = "10 Derece Saða Çevir";
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
   this.button1.Text = "Resim Yükle";
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
 Rectangle seçili_alan = new Rectangle(0, 0, 0, 0);

  private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {
    seçili_alan.X = e.X;
    seçili_alan.Y = e.Y;
    seçili_alan.Width = 0;
    seçili_alan.Height = 0;
    //Formun baþlýðýnda seçili bölgeyi göster
    this.Text = seçili_alan.X.ToString() + "," + 
                seçili_alan.Y.ToString() + "," + 
                seçili_alan.Width.ToString() + "," +
                seçili_alan.Height.ToString();
    pictureBox1.Invalidate(); //Paint olayýný çaðýrýr
   }
  }

  private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {
    seçili_alan.Width = Math.Abs(seçili_alan.Left - e.X);
    seçili_alan.Height = Math.Abs(seçili_alan.Top - e.Y);
    //Formun baþlýðýnda seçili bölgeyi göster
    this.Text = seçili_alan.X.ToString() + "," + seçili_alan.Y.ToString() + "," + 
     seçili_alan.Width.ToString() + "," + seçili_alan.Height.ToString();
    pictureBox1.Invalidate(); //Paint olayýný çaðýrýr
   }
  }

  private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   //Seçili alana kýrmýzý çerçeve çiz
   e.Graphics.DrawRectangle(new Pen(Color.Red), seçili_alan);
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   openFileDialog1.Filter = "Resim  Dosyalarý|" + 
    "*.bmp;*.jpg;*.gif;*.tif;*.png";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    try
    {
     pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
    }
    catch
    {
     MessageBox.Show(openFileDialog1.FileName + " geçerli resim dosyasý deðil");
    }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   if ((seçili_alan.Height == 0) || (seçili_alan.Width == 0))
   {
    MessageBox.Show("Seçili alan yok");
    return;
   }
   if (pictureBox1.Image==null)
   {
    MessageBox.Show("Resim yok");
    return;
   }

   //Seçili alan büyüklüðünde bir Bitmap oluþtur
   Bitmap resim = new Bitmap(seçili_alan.Width, seçili_alan.Height);
   //Bu Bitmap için grafik nesnesi oluþtur
   Graphics gr = Graphics.FromImage(resim);
   //Picture Box içindeki resmi yeni resmin 0,0 noktasýna çiz
   gr.DrawImage(pictureBox1.Image, 0, 0, seçili_alan, GraphicsUnit.Pixel);
   //Yeni resmi pictureBox içine ata
   pictureBox1.Image = resim;
   gr.Dispose();
   //Seçili alaný kaldýr
   seçili_alan.X = 0;
   seçili_alan.Y = 0;
   seçili_alan.Width = 0;
   seçili_alan.Height = 0;
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   if ((seçili_alan.Height == 0) || (seçili_alan.Width == 0))
   {
    MessageBox.Show("Seçili alan yok");
    return;
   }
   if (pictureBox1.Image==null)
   {
    MessageBox.Show("Resim yok");
    return;
   }
   //Seçili alan büyüklüðünde bir Bitmap oluþtur
   Bitmap resim = new Bitmap(seçili_alan.Width, seçili_alan.Height);
   //Bu Bitmap için grafik nesnesi oluþtur
   Graphics gr = Graphics.FromImage(resim);
   //10 derece çevir
   gr.RotateTransform(10);
   //Seçili alanýn 0,0 noktasý etrafýnda çevir
   gr.TranslateTransform(0, 0, System.Drawing.Drawing2D.MatrixOrder.Append);
   //Picture Box içindeki resmi yeni resmin 0,0 noktasýna çiz
   gr.DrawImage(pictureBox1.Image, 0, 0, seçili_alan, GraphicsUnit.Pixel);
   //Yeni resmi pictureBox içine çiz
   Graphics g ;
   g = pictureBox1.CreateGraphics();
   //çevrilmiþ resmi seçili bölgenin üzerine çiz
   g.DrawImage(resim, seçili_alan);
   gr.Dispose();
   g.Dispose();
  }
  
 }
}
