using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Yazdýrma_MetinResim
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.PageSetupDialog pageSetupDialog1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.Button button2;
  internal System.Drawing.Printing.PrintDocument printDocument1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  internal System.Windows.Forms.Label Label1;
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
   this.button4 = new System.Windows.Forms.Button();
   this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
   this.button3 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.button2 = new System.Windows.Forms.Button();
   this.printDocument1 = new System.Drawing.Printing.PrintDocument();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.Label5 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(285, 200);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(120, 23);
   this.button4.TabIndex = 25;
   this.button4.Text = "Resim Seç";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(181, 200);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(104, 23);
   this.button3.TabIndex = 24;
   this.button3.Text = "Baský Önizleme";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(13, 200);
   this.button1.Name = "button1";
   this.button1.TabIndex = 22;
   this.button1.Text = "Yazdýr";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(101, 200);
   this.button2.Name = "button2";
   this.button2.TabIndex = 23;
   this.button2.Text = "Sayfa Ayarý";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // printDocument1
   // 
   this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(280, 40);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(128, 152);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 21;
   this.pictureBox1.TabStop = false;
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(280, 16);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 20;
   this.Label5.Text = "Fotoðrafý";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(112, 88);
   this.textBox3.Multiline = true;
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(144, 104);
   this.textBox3.TabIndex = 19;
   this.textBox3.Text = "TextBox3";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(16, 88);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 18;
   this.Label4.Text = "Adresi";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 64);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(144, 20);
   this.textBox2.TabIndex = 17;
   this.textBox2.Text = "TextBox2";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(16, 64);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 16;
   this.Label3.Text = "Telefon Numarasý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 40);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(144, 20);
   this.textBox1.TabIndex = 15;
   this.textBox1.Text = "TextBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(16, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 14;
   this.Label2.Text = "Personelin Adý";
   // 
   // printPreviewDialog1
   // 
   this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.printPreviewDialog1.Enabled = true;
   this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
   this.printPreviewDialog1.Location = new System.Drawing.Point(423, 28);
   this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.Name = "PrintPreviewDialog1";
   this.printPreviewDialog1.Opacity = 1;
   this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.printPreviewDialog1.Visible = false;
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 13;
   this.Label1.Text = "Personel Bilgileri:";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(416, 230);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.button2,
                                                              this.pictureBox1,
                                                              this.Label5,
                                                              this.textBox3,
                                                              this.Label4,
                                                              this.textBox2,
                                                              this.Label3,
                                                              this.textBox1,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.button4,
                                                              this.button3});
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
   printDocument1.Print();
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
   if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
    printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   printPreviewDialog1.Document = printDocument1;
   printPreviewDialog1.ShowDialog();
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   openFileDialog1.Filter = "Resim  Dosyalarý|" + 
    "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
  }

  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
   float x1, x2, x3, y, y2=0;
   Font etiket_fontu = new Font("Tahoma", 12, FontStyle.Bold);
   Font yazý_fontu = new Font("Tahoma", 12, FontStyle.Regular);
   Font baþlýk_fontu = new Font("Tahoma", 20, FontStyle.Bold);
   string metin;
   System.Drawing.Printing.PageSettings p;
   p=printDocument1.DefaultPageSettings;

   x1 = p.Margins.Left;
   metin = "Telefon numarasý:";
   x2 = x1 + e.Graphics.MeasureString(metin, etiket_fontu).Width;
   x3 = x2 + 200;
   y = p.Margins.Top;

   metin = "Personel Bilgileri:";
   e.Graphics.DrawString(metin, baþlýk_fontu, Brushes.Black, x1, y);
   y += e.Graphics.MeasureString(metin, baþlýk_fontu).Height;

   e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
    x1, y, p.PaperSize.Width - p.Margins.Left, y);
   y += 2;

   metin = "Adý Soyadý:";
   e.Graphics.DrawString(metin, etiket_fontu, Brushes.Black, x1, y);
   metin = textBox1.Text;
   e.Graphics.DrawString(metin, yazý_fontu, Brushes.Black, x2, y);

   metin = "Fotoðrafý:";
   e.Graphics.DrawString(metin, etiket_fontu, Brushes.Black, x3, y);
   y += e.Graphics.MeasureString(metin, etiket_fontu).Height;

   metin = "Telefon numarasý:";
   e.Graphics.DrawString(metin, etiket_fontu, Brushes.Black, x1, y);
   metin = textBox2.Text;
   e.Graphics.DrawString(metin, yazý_fontu, Brushes.Black, x2, y);
   try
   {
    e.Graphics.DrawImage(pictureBox1.Image, x3, y, 150, 150);
    y2 = y + 150;
   }
   catch
   {
    metin = "Resim yazdýrýlamadý";
    e.Graphics.DrawString(metin, yazý_fontu, Brushes.Blue, x3, y);
   }
   y += e.Graphics.MeasureString(metin, etiket_fontu).Height;

   metin = "Adresi:";
   e.Graphics.DrawString(metin, etiket_fontu, Brushes.Black, x1, y);
   metin = textBox3.Text;
   e.Graphics.DrawString(metin, yazý_fontu, Brushes.Black, 
    new RectangleF(x2, y, x3 - x2, p.PaperSize.Height));
   y += e.Graphics.MeasureString(metin, etiket_fontu).Height;
   if (y2 > y)
    e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
     x1, y2, p.PaperSize.Width - p.Margins.Left, y2);
   else
    e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
     x1, y, p.PaperSize.Width - p.Margins.Left, y);
  }
 }
}
