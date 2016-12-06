using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace KaydýrmaOperatörleri
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Button button1;
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
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(0, 10);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(120, 23);
   this.label1.TabIndex = 0;
   this.label1.Text = "Onluk düzendeki sayý:";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(0, 40);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(128, 23);
   this.label2.TabIndex = 1;
   this.label2.Text = "Ýkilik düzendeki karþýlýðý:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(104, 20);
   this.textBox1.TabIndex = 2;
   this.textBox1.Text = "textBox1";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(120, 40);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(152, 23);
   this.label3.TabIndex = 3;
   this.label3.Text = "label3";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(226, 7);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(46, 23);
   this.button1.TabIndex = 4;
   this.button1.Text = "Çevir";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(280, 70);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.label3,
                                                              this.textBox1,
                                                              this.label2,
                                                              this.label1});
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
   int i,x;
   try
   {
    x=int.Parse(textBox1.Text);
   }
   catch
   {
    MessageBox.Show("Geçersiz sayý");
    return;
   }
   label3.Text="";
   for (i=0;i<=15;i++)
    label3.Text=((x >> i) & 1).ToString()+ label3.Text;
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Entere basýlýnca Çevir düðmesi aktif olsun
   this.AcceptButton=button1;
  }
 }
}
