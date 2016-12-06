using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Hesap_Makinesi
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.Label label1;
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
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(221, 56);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(65, 23);
   this.button4.TabIndex = 15;
   this.button4.Text = "Böl";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(149, 56);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(65, 23);
   this.button3.TabIndex = 14;
   this.button3.Text = "Çarp";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(77, 56);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(65, 23);
   this.button2.TabIndex = 13;
   this.button2.Text = "Çýkar";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(5, 56);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(65, 23);
   this.button1.TabIndex = 12;
   this.button1.Text = "Topla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(98, 32);
   this.label2.Name = "label2";
   this.label2.TabIndex = 11;
   this.label2.Text = "Label2";
   this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // label1
   // 
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.label1.Location = new System.Drawing.Point(114, 8);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(64, 23);
   this.label1.TabIndex = 10;
   this.label1.Text = "Label1";
   this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(186, 8);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 9;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(10, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 8;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 94);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.label2,
                                                              this.label1,
                                                              this.textBox2,
                                                              this.textBox1});
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
   double sayý1,sayý2,sonuç;
   sayý1=Convert.ToDouble(textBox1.Text); 
   sayý2=Convert.ToDouble(textBox2.Text);
   sonuç=sayý1+sayý2;
   label2.Text = sonuç.ToString();
   label1.Text="+";
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   double sayý1,sayý2,sonuç;
   sayý1=Convert.ToDouble(textBox1.Text); 
   sayý2=Convert.ToDouble(textBox2.Text);
   sonuç=sayý1-sayý2;
   label2.Text = sonuç.ToString();
   label1.Text="-";
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   double sayý1,sayý2,sonuç;
   sayý1=Convert.ToDouble(textBox1.Text); 
   sayý2=Convert.ToDouble(textBox2.Text);
   sonuç=sayý1*sayý2;
   label2.Text = sonuç.ToString();
   label1.Text="*";
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   double sayý1,sayý2,sonuç;
   sayý1=Convert.ToDouble(textBox1.Text); 
   sayý2=Convert.ToDouble(textBox2.Text);
   sonuç=sayý1/sayý2;
   label2.Text = sonuç.ToString();
   label1.Text="/";
  }
 }
}
