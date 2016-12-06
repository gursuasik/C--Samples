using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CultureInfo_Liste
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  private System.Windows.Forms.ListBox listBox1;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label4;
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
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // listBox1
   // 
   this.listBox1.ColumnWidth = 250;
   this.listBox1.Location = new System.Drawing.Point(8, 64);
   this.listBox1.MultiColumn = true;
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(680, 238);
   this.listBox1.TabIndex = 5;
   this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(304, 304);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 4;
   this.button1.Text = "Kültürleri Listele";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(176, 23);
   this.label1.TabIndex = 6;
   this.label1.Text = "Seçili Kültüre Ait Tarih Formatý:";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(184, 8);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(208, 23);
   this.label2.TabIndex = 7;
   this.label2.Text = "label2";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(8, 32);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(176, 23);
   this.label3.TabIndex = 8;
   this.label3.Text = "Seçili Kültüre Ait Para Formatý:";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(184, 32);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(208, 23);
   this.label4.TabIndex = 9;
   this.label4.Text = "label4";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(696, 334);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.label3,
                                                              this.label2,
                                                              this.label1,
                                                              this.listBox1,
                                                              this.button1});
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
   System.Globalization.CultureInfo[] cultures; 
   cultures =System.Globalization.CultureInfo.GetCultures(
    System.Globalization.CultureTypes.AllCultures);
   foreach( System.Globalization.CultureInfo c in cultures)
    listBox1.Items.Add(c.Name + ", " + c.NativeName);
  }

  private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   try
   {
    this.Text="Seçili kültür:"+listBox1.Text;
    int i;
    i=listBox1.SelectedIndex;
    System.Globalization.CultureInfo k;
    k= new System.Globalization.CultureInfo(
     System.Globalization.CultureInfo.GetCultures(
     System.Globalization.CultureTypes.AllCultures)[i].Name);
    label2.Text=DateTime.Now.ToString(k.DateTimeFormat);
    label2.Text=DateTime.Now.ToString(k.DateTimeFormat);
    decimal para = 150000000M;
    label4.Text=para.ToString("C",k.NumberFormat);
   }
   catch
   {
    this.Text="Desteklenmiyor";
   }
  }
 }
}
