using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HataYakalama
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button12;
  internal System.Windows.Forms.Button button11;
  internal System.Windows.Forms.Button button10;
  internal System.Windows.Forms.Button button9;
  internal System.Windows.Forms.Button button8;
  internal System.Windows.Forms.Button button7;
  internal System.Windows.Forms.Button button6;
  internal System.Windows.Forms.Button button5;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.button12 = new System.Windows.Forms.Button();
   this.button11 = new System.Windows.Forms.Button();
   this.button10 = new System.Windows.Forms.Button();
   this.button9 = new System.Windows.Forms.Button();
   this.button8 = new System.Windows.Forms.Button();
   this.button7 = new System.Windows.Forms.Button();
   this.button6 = new System.Windows.Forms.Button();
   this.button5 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button12
   // 
   this.button12.Location = new System.Drawing.Point(280, 128);
   this.button12.Name = "button12";
   this.button12.TabIndex = 34;
   this.button12.Text = "e Üzeri";
   // 
   // button11
   // 
   this.button11.Location = new System.Drawing.Point(192, 128);
   this.button11.Name = "button11";
   this.button11.TabIndex = 33;
   this.button11.Text = "Üst";
   // 
   // button10
   // 
   this.button10.Location = new System.Drawing.Point(104, 128);
   this.button10.Name = "button10";
   this.button10.TabIndex = 32;
   this.button10.Text = "Kök";
   // 
   // button9
   // 
   this.button9.Location = new System.Drawing.Point(16, 128);
   this.button9.Name = "button9";
   this.button9.TabIndex = 31;
   this.button9.Text = "Ln";
   // 
   // button8
   // 
   this.button8.Location = new System.Drawing.Point(280, 96);
   this.button8.Name = "button8";
   this.button8.TabIndex = 30;
   this.button8.Text = "Tan";
   // 
   // button7
   // 
   this.button7.Location = new System.Drawing.Point(192, 96);
   this.button7.Name = "button7";
   this.button7.TabIndex = 29;
   this.button7.Text = "Cos";
   // 
   // button6
   // 
   this.button6.Location = new System.Drawing.Point(104, 96);
   this.button6.Name = "button6";
   this.button6.TabIndex = 28;
   this.button6.Text = "Sin";
   // 
   // button5
   // 
   this.button5.Location = new System.Drawing.Point(16, 96);
   this.button5.Name = "button5";
   this.button5.TabIndex = 27;
   this.button5.Text = "Log";
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(280, 64);
   this.button4.Name = "button4";
   this.button4.TabIndex = 26;
   this.button4.Text = "/";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(192, 64);
   this.button3.Name = "button3";
   this.button3.TabIndex = 25;
   this.button3.Text = "*";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(104, 64);
   this.button2.Name = "button2";
   this.button2.TabIndex = 24;
   this.button2.Text = "-";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 64);
   this.button1.Name = "button1";
   this.button1.TabIndex = 23;
   this.button1.Text = "+";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(16, 40);
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(336, 20);
   this.textBox3.TabIndex = 22;
   this.textBox3.Text = "textBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(248, 8);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 21;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(72, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 20;
   this.textBox1.Text = "textBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(184, 8);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 19;
   this.Label2.Text = "2.Sayý";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 18;
   this.Label1.Text = "1.Sayý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(368, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button12,
                                                              this.button11,
                                                              this.button10,
                                                              this.button9,
                                                              this.button8,
                                                              this.button7,
                                                              this.button6,
                                                              this.button5,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label2,
                                                              this.Label1});
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Olaylarý birleþtir
   button2.Click += new EventHandler(button1_Click);
   button3.Click += new EventHandler(button1_Click);
   button4.Click += new EventHandler(button1_Click);
   button5.Click += new EventHandler(button1_Click);
   button6.Click += new EventHandler(button1_Click);
   button7.Click += new EventHandler(button1_Click);
   button8.Click += new EventHandler(button1_Click);
   button9.Click += new EventHandler(button1_Click);
   button10.Click += new EventHandler(button1_Click);
   button11.Click += new EventHandler(button1_Click);
   button12.Click += new EventHandler(button1_Click);
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   decimal sonuç=0, sayý1=0, sayý2=0;
   try
   {
    sayý1 = decimal.Parse(textBox1.Text);
    sayý2 = decimal.Parse(textBox2.Text);
    switch((sender as Button).Text)
    {
     case "+"   : sonuç = sayý1 + sayý2;break;
     case "*"   : sonuç = sayý1 * sayý2;break;
     case "/"   : sonuç = sayý1 / sayý2;break;
     case "-"   : sonuç = sayý1 - sayý2;break;
     case "Log" : sonuç = (decimal) Math.Log10((double) sayý1);break;
     case "Ln"  : sonuç = (decimal) Math.Log((double) sayý1);break;
     case "Sin" : sonuç = (decimal) Math.Sin((double) sayý1);break;
     case "Cos" : sonuç = (decimal) Math.Cos((double) sayý1);break;
     case "Tan" : sonuç = (decimal) Math.Tan((double) sayý1);break;
     case "Kök" : sonuç = (decimal) Math.Pow((double) sayý1,(double) (1 / sayý2));break;
     case "Üst" : sonuç = (decimal) Math.Pow((double) sayý1 , (double) sayý2);break;
     case "e Üzeri" : sonuç = (decimal) Math.Exp((double) sayý1);break;
    }
    textBox3.Text = sonuç.ToString();
   }
   catch(System.DivideByZeroException hata)
   {
    MessageBox.Show("Sýfýra bölmeye çalýþýyorsun.\r\n" + hata.Message);
   }
   catch(System.OverflowException hata) 
   {
    if (sayý1 < 0)
     MessageBox.Show("Negatif sayýyla bu iþlemi yapamazsýnýz.\r\n" +
      hata.Message);
    else
     MessageBox.Show("Sayýlar çok büyük\r\n" + hata.Message);
   }
   catch(System.FormatException hata)
   {
    MessageBox.Show("Sayý girmediniz.\r\n" + hata.Message);
   }
   catch(Exception hata)
   {
    MessageBox.Show("Bilinmeyen bir hata oluþtu.\r\n" + hata.Message);
   }
  }
  
 }
}

