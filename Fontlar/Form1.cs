using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Fontlar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
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
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

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
     
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   FontFamily[] fontlar  = FontFamily.GetFamilies(e.Graphics);
   Font fnt=null;
   float x=0, y=0;
   int i;
   string str;
   for (i = 0 ; i<= fontlar.Length-1 ; i++)
   {
    try
    {
     fnt = new Font(fontlar[i].Name, 8, FontStyle.Regular);
     str = fontlar[i].Name;
    }
    catch
    {
     str = fontlar[i].Name + " bu font görüntülenemedi";
    }
    e.Graphics.DrawString(str, fnt, Brushes.Black, x, y);
    y += fnt.Height;
    //Her sütuna 20 tane font yazýlsýn
    if (((i + 1) % 20) == 0) 
    {
     x = x + 200;
     y = 0;
    }
   }
  }
 }
}
