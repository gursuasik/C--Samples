using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Error_Provider
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.ErrorProvider errorProvider1;
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
   this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // errorProvider1
   // 
   this.errorProvider1.DataMember = null;
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(120, 64);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 11;
   this.textBox3.Text = "textBox3";
   this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(120, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 10;
   this.textBox2.Text = "textBox2";
   this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 9;
   this.textBox1.Text = "textBox1";
   this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 64);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 8;
   this.Label3.Text = "Sýnav Notu";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 7;
   this.Label2.Text = "Doðum Tarihi";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 6;
   this.Label1.Text = "Adý Soyadý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(256, 94);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.textBox3});
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

  private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
  {
   //Adý soyadý içinde boþluk yoksa
   if (textBox1.Text.IndexOf(" ") < 0)
    errorProvider1.SetError(textBox1, "Soyadý girilmemiþ");
   else
    errorProvider1.SetError(textBox1, "");
  }

  private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
  {
   try
   {
    DateTime.Parse(textBox2.Text);
    errorProvider1.SetError(textBox2, "");
   }
   catch   //Geçerli tarih deðilse
   {
    errorProvider1.SetError(textBox2, "Tarih Geçersiz");
   }
  }

  private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
  {
   try
   {
    //Sýnav notu 0-100 arasý deðilse
    if (int.Parse(textBox3.Text) < 0 || int.Parse(textBox3.Text) > 100)
     errorProvider1.SetError(textBox3, "Sýnav Notu 0-100 arasý olmalýdýr");
    else
     errorProvider1.SetError(textBox3, "");
   }
   catch
   {
    errorProvider1.SetError(textBox3, "Geçersiz sayý");
   }
  }
 }
}
