using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Domain_UpDown
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.DomainUpDown domainUpDown1;
  internal System.Windows.Forms.Label label1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.DomainUpDown domainUpDown2;
  internal System.Windows.Forms.Label label2;
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
   this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
   this.label2 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // domainUpDown1
   // 
   this.domainUpDown1.Location = new System.Drawing.Point(80, 8);
   this.domainUpDown1.Name = "domainUpDown1";
   this.domainUpDown1.Size = new System.Drawing.Size(112, 20);
   this.domainUpDown1.TabIndex = 22;
   this.domainUpDown1.Text = "domainUpDown1";
   this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(31, 13);
   this.label1.TabIndex = 21;
   this.label1.Text = "Renk";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 32);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(184, 64);
   this.textBox1.TabIndex = 20;
   this.textBox1.Text = "textBox1";
   // 
   // domainUpDown2
   // 
   this.domainUpDown2.Location = new System.Drawing.Point(80, 104);
   this.domainUpDown2.Name = "domainUpDown2";
   this.domainUpDown2.Size = new System.Drawing.Size(112, 20);
   this.domainUpDown2.TabIndex = 24;
   this.domainUpDown2.Text = "domainUpDown2";
   this.domainUpDown2.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(8, 104);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(31, 13);
   this.label2.TabIndex = 23;
   this.label2.Text = "Renk";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(200, 134);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.domainUpDown2,
                                                              this.label2,
                                                              this.domainUpDown1,
                                                              this.label1,
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   string[] renkler = {"Red", "Green", "Blue", "Black", "Brown"};
   domainUpDown1.Items.AddRange(renkler);
   domainUpDown1.Wrap = true; //Renkler bitince baþa dönsün

   string[] turkce_renkler = {"Kýrmýzý", "Yeþil", "Mavi", "Siyah", "Kahverengi"};
   domainUpDown2.Items.AddRange(turkce_renkler);
   domainUpDown2.Wrap = true; //Renkler bitince baþa dönsün
  }

  private void domainUpDown1_SelectedItemChanged(object sender, System.EventArgs e)
  {
   if (domainUpDown1.SelectedIndex >= 0)
    textBox1.BackColor = Color.FromName(domainUpDown1.SelectedItem.ToString());
  }

  private void domainUpDown2_SelectedItemChanged(object sender, System.EventArgs e)
  {
   if (domainUpDown2.SelectedIndex >= 0)
   {
    Color renk=Color.Black;
    string str;
    str = domainUpDown2.SelectedItem.ToString();
    switch(str)
    {
     case "Kýrmýzý" : renk = Color.Red;break;
     case "Mavi" : renk = Color.Blue;break;
     case "Yeþil" : renk = Color.Green;break;
     case "Siyah" : renk = Color.Black;break;
     case "Kahverengi" : renk = Color.Brown;break;
    }
    textBox1.BackColor = renk;
   }
  }
 }
}