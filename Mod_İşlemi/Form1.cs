using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mod_Ýþlemi
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label1;
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
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.button1 = new System.Windows.Forms.Button();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 32);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(296, 199);
   this.listBox1.TabIndex = 7;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(200, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 23);
   this.button1.TabIndex = 6;
   this.button1.Text = "Banknotlarý Bul";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(72, 23);
   this.Label1.TabIndex = 5;
   this.Label1.Text = "Para Miktarý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(88, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 4;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(312, 238);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.listBox1,
                                                              this.button1,
                                                              this.Label1,
                                                              this.textBox1});
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   int para=0, adet=0;
   listBox1.Items.Clear();
   try
   {
    para = int.Parse(textBox1.Text);//Text kutusuna girilen parayý al
   }
   catch
   {
    MessageBox.Show("Geçersiz sayý girdiniz");
    return;
   }

   adet = (int)(para / 20000000);//kaç tane tam 20 milyon var
   listBox1.Items.Add(adet.ToString() + " tane 20.000.000 TL");
    para = para % 20000000;//kalaný bul

   adet = (int)(para / 10000000);//kaç tane tam 10 milyon var
   listBox1.Items.Add(adet.ToString() + " tane 10.000.000 TL");
   para = para % 10000000;//kalaný bul

   adet = (int)(para / 5000000);
   listBox1.Items.Add(adet.ToString() + " tane 5.000.000 TL");
   para = para % 5000000;

   adet = (int)(para / 1000000);
   listBox1.Items.Add(adet.ToString() + " tane 1.000.000 TL");
   para = para % 1000000;

   adet = (int)(para / 500000);
   listBox1.Items.Add(adet.ToString() + " tane 500.000 TL");
   para = para % 500000;

   adet = (int)(para / 250000);
   listBox1.Items.Add(adet.ToString() + " tane 250.000 TL");
   para = para % 250000;

   listBox1.Items.Add("Kalan " + para.ToString() + " TLnin banknot deðeri yok");
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   this.AcceptButton=button1;
  }
 }
}
