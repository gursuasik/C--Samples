using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Yazd�rma_Listeyi_Yazd�r
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PageSetupDialog pageSetupDialog1;
  internal System.Windows.Forms.Button button5;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ListBox listBox3;
  internal System.Windows.Forms.ListBox listBox2;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Drawing.Printing.PrintDocument printDocument1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
  private System.Windows.Forms.PrintDialog printDialog1;
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
   this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
   this.button5 = new System.Windows.Forms.Button();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.listBox3 = new System.Windows.Forms.ListBox();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.printDocument1 = new System.Drawing.Printing.PrintDocument();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.printDialog1 = new System.Windows.Forms.PrintDialog();
   this.SuspendLayout();
   // 
   // button5
   // 
   this.button5.Location = new System.Drawing.Point(96, 192);
   this.button5.Name = "button5";
   this.button5.Size = new System.Drawing.Size(272, 23);
   this.button5.TabIndex = 31;
   this.button5.Text = "Rasgele 100 eleman ekle";
   this.button5.Click += new System.EventHandler(this.button5_Click);
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(96, 168);
   this.textBox4.Name = "textBox4";
   this.textBox4.Size = new System.Drawing.Size(272, 20);
   this.textBox4.TabIndex = 30;
   this.textBox4.Text = "TextBox4";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(16, 168);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(80, 23);
   this.Label4.TabIndex = 29;
   this.Label4.Text = "Rapor Ba�l���:";
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(376, 128);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(104, 23);
   this.button4.TabIndex = 28;
   this.button4.Text = "Sayfa Yap�s�";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(376, 96);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(104, 23);
   this.button3.TabIndex = 27;
   this.button3.Text = "Bask� �nizleme";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(376, 64);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(104, 23);
   this.button2.TabIndex = 26;
   this.button2.Text = "Yazd�r";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(376, 32);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 23);
   this.button1.TabIndex = 25;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // listBox3
   // 
   this.listBox3.Location = new System.Drawing.Point(264, 64);
   this.listBox3.Name = "listBox3";
   this.listBox3.Size = new System.Drawing.Size(104, 95);
   this.listBox3.TabIndex = 24;
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(152, 64);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(104, 95);
   this.listBox2.TabIndex = 23;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(16, 64);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(128, 95);
   this.listBox1.TabIndex = 22;
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(264, 32);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 21;
   this.textBox3.Text = "TextBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(152, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 20;
   this.textBox2.Text = "TextBox2";
   this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
   // 
   // PrintPreviewDialog1
   // 
   this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.PrintPreviewDialog1.Enabled = true;
   this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
   this.PrintPreviewDialog1.Location = new System.Drawing.Point(10, 26);
   this.PrintPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
   this.PrintPreviewDialog1.Opacity = 1;
   this.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.PrintPreviewDialog1.Visible = false;
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(272, 8);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(48, 23);
   this.Label3.TabIndex = 19;
   this.Label3.Text = "Sonu�";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(152, 8);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 18;
   this.Label2.Text = "S�nav Notu";
   // 
   // printDocument1
   // 
   this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 17;
   this.Label1.Text = "��rencinin Ad�";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(16, 32);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(128, 20);
   this.textBox1.TabIndex = 16;
   this.textBox1.Text = "TextBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(488, 222);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox4,
                                                              this.Label4,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.listBox3,
                                                              this.listBox2,
                                                              this.listBox1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.textBox1,
                                                              this.button5});
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
   listBox1.Items.Add(textBox1.Text);
   listBox2.Items.Add(textBox2.Text);
   listBox3.Items.Add(textBox3.Text);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   printDialog1.Document = printDocument1;
   printDialog1.AllowSomePages = true;
   printDialog1.PrinterSettings.MinimumPage = 1;
   printDialog1.PrinterSettings.FromPage = 1;
   printDialog1.PrinterSettings.ToPage = 1;
   if (printDialog1.ShowDialog() == DialogResult.OK)
    printDocument1.Print();
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   printPreviewDialog1.Document = printDocument1;
   printPreviewDialog1.ShowDialog();
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
   if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
    printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
  }

  private void textBox2_TextChanged(object sender, System.EventArgs e)
  {
   try
   {
    if (int.Parse(textBox2.Text) >= 50)
     textBox3.Text = "Ge�ti";
    else
     textBox3.Text = "Kald�";
   }
   catch
   { 
    textBox3.Text="Not hatal�";
   }
  }

  private void button5_Click(object sender, System.EventArgs e)
  {
   int i;
   string[] isimler= {"Ali", "Veli", "Ahmet", "Mehmet", "Ay�e", 
                      "Fatma", "Mustafa", "Hasan", "H�seyin", "Muhammet"};
   int s�nav;
   Random r = new Random();
   for (i = 1 ; i<= 100 ; i++)
   {
    listBox1.Items.Add(i.ToString() + " " + isimler[r.Next(9)]);
    s�nav = r.Next(100);
    listBox2.Items.Add(s�nav);
    if (s�nav >= 50)
     listBox3.Items.Add("Ge�ti");
    else
     listBox3.Items.Add("Kald�");
   }
  }

  int yazd�r�lan_eleman_no = 0;
  Boolean ilk_sayfa = true;
  int yaz�lan_sayfa_say�s�=0;
  int yaz�lacak_sayfa_say�s�=0;

  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
   int x, y;

   if (ilk_sayfa)
   {
    yaz�lan_sayfa_say�s� = 0;
    if (printDocument1.PrinterSettings.PrintRange == 
     System.Drawing.Printing.PrintRange.SomePages)
    {
     yazd�r�lan_eleman_no = yaz�yor_gibi_yap(e, 
      printDocument1.PrinterSettings.FromPage - 1);
     yaz�lacak_sayfa_say�s� = printDocument1.PrinterSettings.ToPage - 
      printDocument1.PrinterSettings.FromPage + 1;
    }
    else
    {
     yaz�lacak_sayfa_say�s� = 1000000;
     yazd�r�lan_eleman_no = 0;
    }
   }
  ilk_sayfa = false;

   System.Drawing.Printing.PageSettings p;
   int sat�r_y�ksekli�i;
   int sayfa_y�ksekli�i;
   p=printDocument1.DefaultPageSettings;
   sayfa_y�ksekli�i = p.PaperSize.Height-p.Margins.Top-p.Margins.Bottom;
   int sayfa_geni�li�i;
   sayfa_geni�li�i = p.PaperSize.Width-p.Margins.Left-p.Margins.Right;

   x = p.Margins.Left + 2;
   y = p.Margins.Top;

   StringFormat ortala = new StringFormat();
   ortala.Alignment = StringAlignment.Center;
   StringFormat sa�a_yasla = new StringFormat();
   sa�a_yasla.Alignment = StringAlignment.Far;

   Font ana_ba�l�k_fontu = new Font("Tahoma", 20, FontStyle.Regular);
   sat�r_y�ksekli�i =(int) e.Graphics.MeasureString("x", 
    ana_ba�l�k_fontu).Height;
   e.Graphics.DrawString(textBox4.Text, ana_ba�l�k_fontu, 
    new SolidBrush(Color.Red), 
    p.PaperSize.Width / 2, y, ortala);
   y += sat�r_y�ksekli�i;

   int tablo_ba�lang�c�;
   tablo_ba�lang�c� = y;

   Font ba�l�k_fontu = new Font("Tahoma", 12, FontStyle.Bold);
   sat�r_y�ksekli�i = (int)e.Graphics.MeasureString("x", ba�l�k_fontu).Height;

   e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
    p.Margins.Left, y, 
    p.PaperSize.Width - p.Margins.Right, y);
   e.Graphics.DrawString("��rencinin ad�", ba�l�k_fontu, 
    new SolidBrush(Color.Red), x, y);
   e.Graphics.DrawString("S�nav Notu", ba�l�k_fontu, 
    new SolidBrush(Color.Red), 
    x + sayfa_geni�li�i / 3, y);
   e.Graphics.DrawString("Sonu�", ba�l�k_fontu, 
    new SolidBrush(Color.Red), 
    x + 2 * sayfa_geni�li�i / 3, y);
   y += sat�r_y�ksekli�i + 2;

   e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
    p.Margins.Left, y, 
    p.PaperSize.Width - p.Margins.Right, y);

   Font liste_fontu = new Font("Tahoma", 12, FontStyle.Regular);
   sat�r_y�ksekli�i = (int)e.Graphics.MeasureString("x", liste_fontu).Height;

   while (yazd�r�lan_eleman_no < listBox1.Items.Count)
   {
    e.Graphics.DrawString(listBox1.Items[yazd�r�lan_eleman_no].ToString(), 
     liste_fontu, new SolidBrush(Color.Red), 
     x, y);
    e.Graphics.DrawString(listBox2.Items[yazd�r�lan_eleman_no].ToString(), 
     liste_fontu, new SolidBrush(Color.Red), 
     x + sayfa_geni�li�i / 3 + 50, y, sa�a_yasla);
    e.Graphics.DrawString(listBox3.Items[yazd�r�lan_eleman_no].ToString(), 
     liste_fontu, new SolidBrush(Color.Red), 
     x + 2 * sayfa_geni�li�i / 3, y);
    y += sat�r_y�ksekli�i + 2;
    e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
     p.Margins.Left, y, 
     p.PaperSize.Width - p.Margins.Right, y);

    yazd�r�lan_eleman_no += 1;

    //Sonraki sat�r sayfaya s��mayacaksa yeni sayfaya ge�
    if ((y + sat�r_y�ksekli�i) > (p.PaperSize.Height - p.Margins.Bottom))
    {
     yaz�lan_sayfa_say�s� += 1;
     if (yaz�lan_sayfa_say�s� < yaz�lacak_sayfa_say�s�)
      e.HasMorePages = true;
     else
     {
      e.HasMorePages = false;
      ilk_sayfa = true;
      yaz�lan_sayfa_say�s� = 0;
      yazd�r�lan_eleman_no = 0; //Bir sonraki sefer ba�tan ba�lamas� i�in
     }
     break;
    }
   }
   if (yazd�r�lan_eleman_no >= listBox1.Items.Count)
   {
    e.HasMorePages = false;
    ilk_sayfa = true;
    yaz�lan_sayfa_say�s� = 0;
    yazd�r�lan_eleman_no = 0;; //Bir sonraki sefer ba�tan ba�lamas� i�in
   }
   e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
    p.Margins.Left, tablo_ba�lang�c�, 
    p.Margins.Left, y);
   e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
    p.Margins.Left + sayfa_geni�li�i / 3 - 2, tablo_ba�lang�c�, 
    p.Margins.Left + sayfa_geni�li�i / 3 - 2, y);
   e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
    p.Margins.Left + 2 * sayfa_geni�li�i / 3 - 2, tablo_ba�lang�c�, 
    p.Margins.Left + 2 * sayfa_geni�li�i / 3 - 2, y);
   e.Graphics.DrawLine(new Pen(Color.Blue, 2), 
    p.PaperSize.Width - p.Margins.Right, tablo_ba�lang�c�, 
    p.PaperSize.Width - p.Margins.Right, y);
  }

  public int yaz�yor_gibi_yap(System.Drawing.Printing.PrintPageEventArgs e , int son_sayfa) 
  {
   int sayfa_no;
   int x, y;
   for (sayfa_no = 1 ; sayfa_no<= son_sayfa ; sayfa_no++)
   {
    System.Drawing.Printing.PageSettings p;
    int sat�r_y�ksekli�i;
    int sayfa_y�ksekli�i;
    p=printDocument1.DefaultPageSettings;
    sayfa_y�ksekli�i = p.PaperSize.Height-p.Margins.Top-p.Margins.Bottom;
    int sayfa_geni�li�i;
    sayfa_geni�li�i = p.PaperSize.Width-p.Margins.Left-p.Margins.Right;

    x = p.Margins.Left + 2;
    y = p.Margins.Top;

    StringFormat ortala = new StringFormat();
    ortala.Alignment = StringAlignment.Center;
    StringFormat sa�a_yasla = new StringFormat();
    sa�a_yasla.Alignment = StringAlignment.Far;

    Font ana_ba�l�k_fontu = new Font("Tahoma", 20, FontStyle.Regular);
    sat�r_y�ksekli�i =(int) e.Graphics.MeasureString("x", 
     ana_ba�l�k_fontu).Height;
   
    y += sat�r_y�ksekli�i;

    int tablo_ba�lang�c�;
    tablo_ba�lang�c� = y;

    Font ba�l�k_fontu = new Font("Tahoma", 12, FontStyle.Bold);
    sat�r_y�ksekli�i = (int)e.Graphics.MeasureString("x", ba�l�k_fontu).Height;

    y += sat�r_y�ksekli�i + 2;

    Font liste_fontu = new Font("Tahoma", 12, FontStyle.Regular);
    sat�r_y�ksekli�i = (int)e.Graphics.MeasureString("x", liste_fontu).Height;

    while (yazd�r�lan_eleman_no < listBox1.Items.Count)
    {
     y += sat�r_y�ksekli�i + 2;

     yazd�r�lan_eleman_no += 1;

     //Sonraki sat�r sayfaya s��mayacaksa yeni sayfaya ge�
     if ((y + sat�r_y�ksekli�i) > (p.PaperSize.Height - p.Margins.Bottom))
     {
      e.HasMorePages = true;
      break;
     }
    }
    if (yazd�r�lan_eleman_no >= listBox1.Items.Count)
    {
     yazd�r�lan_eleman_no = listBox1.Items.Count ;
     }
   }
   return yazd�r�lan_eleman_no;
  }
	}
}
