using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Visible
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.GroupBox groupBox1;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.TextBox textBox5;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
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
   this.Label2 = new System.Windows.Forms.Label();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.textBox5 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label5 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(24, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 13;
   this.Label2.Text = "Yaþýnýz";
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.textBox4,
                                                                        this.textBox5,
                                                                        this.Label4,
                                                                        this.Label5,
                                                                        this.Label3,
                                                                        this.textBox3});
   this.groupBox1.Location = new System.Drawing.Point(8, 64);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(264, 104);
   this.groupBox1.TabIndex = 15;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Askerlikle Ýlgili Sorular";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(152, 48);
   this.textBox4.Name = "textBox4";
   this.textBox4.TabIndex = 7;
   this.textBox4.Text = "textBox4";
   // 
   // textBox5
   // 
   this.textBox5.Location = new System.Drawing.Point(152, 72);
   this.textBox5.Name = "textBox5";
   this.textBox5.TabIndex = 9;
   this.textBox5.Text = "textBox5";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(16, 48);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 6;
   this.Label4.Text = "Nerede Yaptýnýz";
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(16, 72);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 8;
   this.Label5.Text = "Rütbeniz";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(16, 24);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(128, 23);
   this.Label3.TabIndex = 4;
   this.Label3.Text = "Askerliði Yaptýðýnýz Tarih";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(152, 24);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 5;
   this.textBox3.Text = "textBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(152, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(112, 20);
   this.textBox2.TabIndex = 14;
   this.textBox2.Text = "textBox2";
   this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(152, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(112, 20);
   this.textBox1.TabIndex = 12;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(24, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(56, 23);
   this.Label1.TabIndex = 11;
   this.Label1.Text = "Adýnýz";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(280, 174);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label2,
                                                              this.groupBox1,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.groupBox1.ResumeLayout(false);
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
   groupBox1.Visible = false;
   this.Height = textBox2.Top + textBox2.Height + 40;
  }

  private void textBox2_TextChanged(object sender, System.EventArgs e)
  {
   try
   {
    if (int.Parse(textBox2.Text) > 20)//Büyükse göster
    {
     groupBox1.Visible = true;
     this.Height = groupBox1.Top + groupBox1.Height + 40;
    }
    else //Küçükse gizle
    {
     groupBox1.Visible = false;
     this.Height = textBox2.Top + textBox2.Height + 40;
    }
    this.Text = "";
   }
   catch
   {
    this.Text = "Yaþýnýz hatalý girildi";
   }
  }
 }
}
