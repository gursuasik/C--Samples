using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TarihÝþlemleri
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.TextBox textBox6;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.TextBox textBox5;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.textBox6 = new System.Windows.Forms.TextBox();
   this.Label6 = new System.Windows.Forms.Label();
   this.textBox5 = new System.Windows.Forms.TextBox();
   this.Label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // textBox6
   // 
   this.textBox6.Location = new System.Drawing.Point(112, 128);
   this.textBox6.Name = "textBox6";
   this.textBox6.TabIndex = 34;
   this.textBox6.Text = "TextBox6";
   // 
   // Label6
   // 
   this.Label6.Location = new System.Drawing.Point(8, 128);
   this.Label6.Name = "Label6";
   this.Label6.TabIndex = 33;
   this.Label6.Text = "Toplam";
   // 
   // textBox5
   // 
   this.textBox5.Location = new System.Drawing.Point(112, 104);
   this.textBox5.Name = "textBox5";
   this.textBox5.TabIndex = 32;
   this.textBox5.Text = "TextBox5";
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(8, 104);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 31;
   this.Label5.Text = "Ceza";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 80);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 30;
   this.Label4.Text = "Ödendiði Tarih";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(112, 80);
   this.textBox4.Name = "textBox4";
   this.textBox4.TabIndex = 29;
   this.textBox4.Text = "TextBox4";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 28;
   this.Label3.Text = "Son Ödeme tarihi";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(112, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 27;
   this.textBox3.Text = "TextBox3";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(112, 160);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 26;
   this.button1.Text = "Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 25;
   this.textBox2.Text = "TextBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 24;
   this.Label2.Text = "Tutarý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 23;
   this.textBox1.Text = "TextBox1";
   // 
   // Label1
   // 
   this.Label1.AccessibleDescription = "";
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(72, 24);
   this.Label1.TabIndex = 22;
   this.Label1.Text = "Malzeme Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 190);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox6,
                                                              this.Label6,
                                                              this.textBox5,
                                                              this.Label5,
                                                              this.Label4,
                                                              this.textBox4,
                                                              this.Label3,
                                                              this.textBox3,
                                                              this.button1,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.Label1});
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
   DateTime son_ödeme_tarihi , ödendiði_tarih;
   long fiyat=0, fark=0, ceza=0;
   try
   {
    fiyat = long.Parse(textBox2.Text);
    son_ödeme_tarihi = DateTime.Parse(textBox3.Text);
    ödendiði_tarih = DateTime.Parse(textBox4.Text);
    fark =(long) (ödendiði_tarih.ToOADate() - son_ödeme_tarihi.ToOADate());
   }
   catch(Exception hata)
   {
    MessageBox.Show("Bilgiler hatalý yazýlmýþ." + hata.Message);
   }
   if (fark > 0)
   {
    ceza = fark * fiyat * 2 / 1000;
    textBox5.Text = ceza.ToString("#,#");
    textBox6.Text = (fiyat + ceza).ToString("#,#");
    MessageBox.Show(fark + " gün geç ödendi." +
     textBox5.Text + " TL ceza ödeyecek");
   }
   else
    if (fark == 0)
   {
    ceza = 0;
    textBox5.Text = "0";
    textBox6.Text = fiyat.ToString("#,#");
    MessageBox.Show("Tam gününde ödendi");
   }
   else
   {
    ceza = 5000000;
    textBox5.Text = ceza.ToString("#,#");
    textBox6.Text = (fiyat - ceza).ToString("#,#");
    MessageBox.Show(fark + " gün erken ödendi." +
     textBox5.Text + " TL indirimli ödeyecek");
   }
  }
 }
}

