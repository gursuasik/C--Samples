using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Validating
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.TextBox textBox5;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
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
   this.textBox5 = new System.Windows.Forms.TextBox();
   this.Label5 = new System.Windows.Forms.Label();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // textBox5
   // 
   this.textBox5.Location = new System.Drawing.Point(112, 104);
   this.textBox5.Name = "textBox5";
   this.textBox5.TabIndex = 19;
   this.textBox5.Text = "textBox5";
   this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(8, 104);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 18;
   this.Label5.Text = "Telefon Numaranýz";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(112, 80);
   this.textBox4.Name = "textBox4";
   this.textBox4.TabIndex = 17;
   this.textBox4.Text = "textBox4";
   this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 80);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 16;
   this.Label4.Text = "Araç Plakanýz";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(112, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 15;
   this.textBox3.Text = "textBox3";
   this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 14;
   this.textBox2.Text = "textBox2";
   this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 13;
   this.textBox1.Text = "textBox1";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 12;
   this.Label3.Text = "Mail Adresiniz";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 11;
   this.Label2.Text = "Sýnav Notunuz";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 10;
   this.Label1.Text = "Adýnýz";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(216, 134);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox5,
                                                              this.Label5,
                                                              this.textBox4,
                                                              this.Label4,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label3,
                                                              this.Label2,
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

  private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
  {
   try
   {
    if (int.Parse(textBox2.Text) < 0 || int.Parse(textBox2.Text) > 100)
    {
     MessageBox.Show("Sýnav notu 0-100 arasý olmalýdýr");
     e.Cancel = true;
     this.Text="";
    }
   }
   catch
   {
    this.Text="Sýnav notu geçersiz";
    e.Cancel = true;
   }
  }

  private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
  {
   int yer1, yer2=0;
   //Mail adresinde en azýndan bir nokta ve @ iþareti olmalý
   //Ýkinci harften itibaren @ ara
   yer1 = textBox3.Text.IndexOf("@",1);
   //@ ten sonra nokta ara
   if (yer1 >= 0)
    yer2 = textBox3.Text.IndexOf(".",yer1 + 1);
   //@ yoksa, nokta yoksa veya nokta sondaysa
   if (yer1 < 0 || yer2 < 0 || yer2 == textBox3.Text.Length-1)
   {
    MessageBox.Show("Mail adresiniz hatalý");
    e.Cancel = true;
   }
  }

  private void textBox4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
  {
   int yer1, yer2=0;
   //Ýlk boþluðu bul
   yer1 = textBox4.Text.IndexOf(" ");
   //Ýkinci boþluðu bul
   if (yer1 >= 0)
    yer2 = textBox4.Text.IndexOf(" ",yer1 + 1);
   //Uzunluk 9 deðilse, iki tane boþluk yoksa, boþluklardan biri sondaysa
   if (textBox4.Text.Length != 9 || yer1 < 0 || yer2 < 0 ||
    yer2 == textBox4.Text.Length-1)
   {
    MessageBox.Show("Plaka 34 HGH 07 þeklinde olmalýdýr");
    e.Cancel = true;
   }
  }

  private void textBox5_Validating(object sender, System.ComponentModel.CancelEventArgs e)
  {
   //Uzunluk 10 deðilse 
   if (textBox5.Text.Length != 10)
   {
    MessageBox.Show("Telefon 5321234567 þeklinde olmalýdýr");
    e.Cancel = true;
   }
  }
 }
}
