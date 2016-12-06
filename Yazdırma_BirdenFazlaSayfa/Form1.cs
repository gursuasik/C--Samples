using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Yazdýrma_BirdenFazlaSayfa
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  internal System.Windows.Forms.PageSetupDialog pageSetupDialog1;
  internal System.Drawing.Printing.PrintDocument printDocument1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
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
   this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
   this.printDocument1 = new System.Drawing.Printing.PrintDocument();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // printPreviewDialog1
   // 
   this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.printPreviewDialog1.Enabled = true;
   this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
   this.printPreviewDialog1.Location = new System.Drawing.Point(289, 6);
   this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.Name = "PrintPreviewDialog1";
   this.printPreviewDialog1.Opacity = 1;
   this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.printPreviewDialog1.Visible = false;
   // 
   // printDocument1
   // 
   this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(72, 88);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(112, 23);
   this.button3.TabIndex = 5;
   this.button3.Text = "Sayfa Ayarý";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(72, 64);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(112, 23);
   this.button2.TabIndex = 4;
   this.button2.Text = "Baský Önizleme";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(72, 40);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(112, 23);
   this.button1.TabIndex = 3;
   this.button1.Text = "Yazdýr";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(256, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
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
   printPreviewDialog1.Document = printDocument1;
   printPreviewDialog1.ShowDialog();
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
   if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
    printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
  }
 
  int sayý=1;
  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
   int sayfa_yüksekliði;
   System.Drawing.Printing.PageSettings p;
   p=printDocument1.DefaultPageSettings;
   sayfa_yüksekliði = p.PaperSize.Height - p.Margins.Top - p.Margins.Bottom;
   Font fnt = new Font("Tahoma", 12, FontStyle.Regular);
   int satýr_yüksekliði;
   satýr_yüksekliði = (int) e.Graphics.MeasureString("1", fnt).Height;
   int max_satýr;
   max_satýr = sayfa_yüksekliði / satýr_yüksekliði;
   int i, satýr_no=0 ;
   for (i = sayý ; i<= sayý + max_satýr-1 ; i++)
   {
    if (i > 1000)
    {
     e.HasMorePages = false;
     sayý = 1; //Bir sonraki yazdýrmada baþtan baþlamasý için
     return;
    }
    e.Graphics.DrawString(i.ToString() + ". satýr", fnt, 
     new SolidBrush(Color.Black), 
     printDocument1.DefaultPageSettings.Margins.Left, 
     printDocument1.DefaultPageSettings.Margins.Top + 
     satýr_no * satýr_yüksekliði);
    satýr_no += 1;
   }
   sayý = i; //Diðer sayfada kaldýðý sayýdan devam et
   //1000 satýra ulaþmadýysa bir sayfa daha var
   if (i < 1000) 
    e.HasMorePages = true;
  }
	}
}
