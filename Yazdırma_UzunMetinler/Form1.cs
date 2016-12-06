using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Yazdýrma_UzunMetinler
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button5;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.PageSetupDialog pageSetupDialog1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label1;
  internal System.Drawing.Printing.PrintDocument printDocument1;
  internal System.Windows.Forms.FontDialog fontDialog1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.button5 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.Label1 = new System.Windows.Forms.Label();
   this.printDocument1 = new System.Drawing.Printing.PrintDocument();
   this.fontDialog1 = new System.Windows.Forms.FontDialog();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button5
   // 
   this.button5.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button5.Location = new System.Drawing.Point(432, 168);
   this.button5.Name = "button5";
   this.button5.Size = new System.Drawing.Size(96, 23);
   this.button5.TabIndex = 13;
   this.button5.Text = "Yazý Tipi";
   this.button5.Click += new System.EventHandler(this.button5_Click);
   // 
   // button4
   // 
   this.button4.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button4.Location = new System.Drawing.Point(432, 136);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(96, 23);
   this.button4.TabIndex = 12;
   this.button4.Text = "Baský Önizleme";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // printPreviewDialog1
   // 
   this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.printPreviewDialog1.Enabled = true;
   this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
   this.printPreviewDialog1.Location = new System.Drawing.Point(116, 8);
   this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.Name = "PrintPreviewDialog1";
   this.printPreviewDialog1.Opacity = 1;
   this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.printPreviewDialog1.Visible = false;
   // 
   // button3
   // 
   this.button3.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button3.Location = new System.Drawing.Point(432, 104);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(96, 23);
   this.button3.TabIndex = 11;
   this.button3.Text = "Sayfa Özellikleri";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button2.Location = new System.Drawing.Point(432, 72);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(96, 23);
   this.button2.TabIndex = 10;
   this.button2.Text = "Yazdýr";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button1.Location = new System.Drawing.Point(432, 40);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 9;
   this.button1.Text = "Dosya Aç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 8;
   this.Label1.Text = "Yazdýrýlacak Bilgi";
   // 
   // printDocument1
   // 
   this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
   // 
   // textBox1
   // 
   this.textBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right);
   this.textBox1.Location = new System.Drawing.Point(8, 40);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(416, 304);
   this.textBox1.TabIndex = 7;
   this.textBox1.Text = "TextBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(544, 374);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.Label1,
                                                              this.textBox1,
                                                              this.button5,
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
   openFileDialog1.Filter = "Text Dosyalarý|*.TXT|" +
    "Bütün dosyalar|*.*";
   openFileDialog1.FilterIndex = 1;
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    textBox1.Text="";
    try
    {
     System.IO.TextReader dosya = System.IO.File.OpenText(openFileDialog1.FileName);
     string satýr;
     while((satýr = dosya.ReadLine())!= null)
      textBox1.Text+=satýr+"\r\n";
     dosya.Close();
    }
    catch
    {
     ;
    }
   }
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

  private void button5_Click(object sender, System.EventArgs e)
  {
   if (fontDialog1.ShowDialog() == DialogResult.OK)
    textBox1.Font = fontDialog1.Font;
  }

  int son_yazýlan_harf = 0;
  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
   Font fnt= textBox1.Font;
   int geniþlik, yükseklik;
   int satýr_sayýsý, harf_sayýsý;
   System.Drawing.Printing.PageSettings p;
   p=printDocument1.DefaultPageSettings;
   yükseklik = p.PaperSize.Height - p.Margins.Top - p.Margins.Bottom;
   geniþlik = p.PaperSize.Width - p.Margins.Left - p.Margins.Right;
   StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
   //sayfanýn iç kýsmý için dikdörtgen bir alan oluþtur
   RectangleF R = new RectangleF(p.Margins.Left, p.Margins.Top, 
    geniþlik, yükseklik);
   //bu alana kaç harf sýðýdýný bul
   e.Graphics.MeasureString(textBox1.Text.Substring(son_yazýlan_harf ), 
    fnt, new SizeF(geniþlik, yükseklik), fmt, out harf_sayýsý, out satýr_sayýsý);
   string metin;
   //son yazýlan harften itibaren al
   metin = textBox1.Text.Substring(son_yazýlan_harf , harf_sayýsý);
   //Bu dikdörtgen alana yazdýr
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Black), R, fmt);
   //sonraki seferde yazýlan harf kadar ilerden baþla
   son_yazýlan_harf = son_yazýlan_harf + harf_sayýsý;
   //Text kutusundaki bütün harfler yazdýrýlmadýysa
   if (son_yazýlan_harf < textBox1.Text.Length)
    e.HasMorePages = true; //Yine sayfa var
   else
   {
    e.HasMorePages = false; //Baþka sayfa yok
    son_yazýlan_harf = 0; //Sonraki seferde baþtan baþlamasý için
   }
  }
 }
}