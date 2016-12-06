using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Yazdýrma_Resim
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Drawing.Printing.PrintDocument printDocument1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.PageSetupDialog pageSetupDialog1;
  internal System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  internal System.Windows.Forms.Button button1;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.CheckBox checkBox2;
  private System.Windows.Forms.CheckBox checkBox1;
  private System.Windows.Forms.Button button3;
  private System.Windows.Forms.Button button4;
  private System.Windows.Forms.Button button2;
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
   this.printDocument1 = new System.Drawing.Printing.PrintDocument();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
   this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.button1 = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.checkBox2 = new System.Windows.Forms.CheckBox();
   this.checkBox1 = new System.Windows.Forms.CheckBox();
   this.button3 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // printDocument1
   // 
   this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
   // 
   // printPreviewDialog1
   // 
   this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.printPreviewDialog1.Enabled = true;
   this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
   this.printPreviewDialog1.Location = new System.Drawing.Point(115, 4);
   this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.Name = "PrintPreviewDialog1";
   this.printPreviewDialog1.Opacity = 1;
   this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.printPreviewDialog1.Visible = false;
   // 
   // button1
   // 
   this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button1.Location = new System.Drawing.Point(272, 11);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 23);
   this.button1.TabIndex = 15;
   this.button1.Text = "Resim Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(0, 7);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(248, 240);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 14;
   this.pictureBox1.TabStop = false;
   // 
   // checkBox2
   // 
   this.checkBox2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.checkBox2.Location = new System.Drawing.Point(256, 179);
   this.checkBox2.Name = "checkBox2";
   this.checkBox2.Size = new System.Drawing.Size(144, 24);
   this.checkBox2.TabIndex = 20;
   this.checkBox2.Text = "Resmi Sayfada Ortala";
   // 
   // checkBox1
   // 
   this.checkBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.checkBox1.Location = new System.Drawing.Point(256, 155);
   this.checkBox1.Name = "checkBox1";
   this.checkBox1.Size = new System.Drawing.Size(136, 24);
   this.checkBox1.TabIndex = 19;
   this.checkBox1.Text = "Resmi Sayfaya Sýðdýr";
   // 
   // button3
   // 
   this.button3.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button3.Location = new System.Drawing.Point(272, 75);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(104, 23);
   this.button3.TabIndex = 17;
   this.button3.Text = "Sayfa Ayarý";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button4
   // 
   this.button4.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button4.Location = new System.Drawing.Point(272, 115);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(104, 23);
   this.button4.TabIndex = 18;
   this.button4.Text = "Baský Önizleme";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button2
   // 
   this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button2.Location = new System.Drawing.Point(272, 43);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(104, 23);
   this.button2.TabIndex = 16;
   this.button2.Text = "Yazdýr";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(384, 254);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.pictureBox1,
                                                              this.checkBox2,
                                                              this.checkBox1,
                                                              this.button3,
                                                              this.button4,
                                                              this.button2});
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
   openFileDialog1.Filter = "Resim  Dosyalarý|" + 
    "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   printDocument1.Print();
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
   if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
    printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   printPreviewDialog1.Document = printDocument1;
   printPreviewDialog1.ShowDialog();
  }

  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
   int x, y;
   int geniþlik, yükseklik;
   System.Drawing.Printing.PageSettings p;
   p=printDocument1.DefaultPageSettings;

   x = p.Margins.Left;
   y = p.Margins.Top;
   geniþlik = pictureBox1.Image.Width;
   yükseklik = pictureBox1.Image.Height;
   if (checkBox1.Checked)
   {
    //sýðdýr iþaretli ise
    geniþlik = p.PaperSize.Width - p.Margins.Left - p.Margins.Right;
    yükseklik = p.PaperSize.Height - p.Margins.Top - p.Margins.Bottom;
   }
   if (checkBox2.Checked)
   {
    //ortala iþaretli ise
    x = p.Margins.Left + 
     ((p.PaperSize.Width - p.Margins.Left - p.Margins.Right) - 
     pictureBox1.Image.Width) / 2;
    y = p.Margins.Top + 
     ((p.PaperSize.Height - p.Margins.Top - p.Margins.Bottom) - 
     pictureBox1.Image.Height) / 2;
   }
   e.Graphics.DrawImage(pictureBox1.Image, x, y, geniþlik, yükseklik);
  }
	}
}
