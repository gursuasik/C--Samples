using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ResetColor
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox TextBox4;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.TextBox TextBox1;
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
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.TextBox4 = new System.Windows.Forms.TextBox();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(160, 64);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(96, 23);
   this.button2.TabIndex = 11;
   this.button2.Text = "Orjinal Renkler";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(160, 32);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 10;
   this.button1.Text = "Renk Deðiþ";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // TextBox4
   // 
   this.TextBox4.Location = new System.Drawing.Point(16, 120);
   this.TextBox4.Name = "TextBox4";
   this.TextBox4.TabIndex = 9;
   this.TextBox4.Text = "TextBox4";
   // 
   // TextBox3
   // 
   this.TextBox3.Location = new System.Drawing.Point(16, 88);
   this.TextBox3.Name = "TextBox3";
   this.TextBox3.TabIndex = 8;
   this.TextBox3.Text = "TextBox3";
   // 
   // TextBox2
   // 
   this.TextBox2.Location = new System.Drawing.Point(16, 56);
   this.TextBox2.Name = "TextBox2";
   this.TextBox2.TabIndex = 7;
   this.TextBox2.Text = "TextBox2";
   // 
   // TextBox1
   // 
   this.TextBox1.Location = new System.Drawing.Point(16, 24);
   this.TextBox1.Name = "TextBox1";
   this.TextBox1.TabIndex = 6;
   this.TextBox1.Text = "TextBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.TextBox4,
                                                              this.TextBox3,
                                                              this.TextBox2,
                                                              this.TextBox1});
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
   Random r = new Random();
   foreach (Control i in this.Controls)
   {
    if (i.GetType().Name == "TextBox")
    {
     i.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
     i.ForeColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
    }
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   foreach (Control i in this.Controls)
   {
    if (i.GetType().Name == "TextBox")
    {
     i.ResetBackColor();
     i.ResetForeColor();
    }
   }
  }
 }
}