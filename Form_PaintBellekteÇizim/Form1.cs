using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_PaintBellekte«izim
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
  Bitmap bmp;

  private void Áiz()
  {
   Graphics gr;
   gr = Graphics.FromImage(bmp);
   Random r= new Random();
   int i;
   for (i = 1 ; i<= 10000 ; i++) 
   {
    gr.DrawEllipse(new Pen(Color.FromArgb(r.Next(255), 
     r.Next(255), 
     r.Next(255))), 
     r.Next(1000), r.Next(1000), 
     r.Next(1000), r.Next(1000));
    gr.DrawRectangle(new Pen(Color.FromArgb(r.Next(255), 
     r.Next(255), 
     r.Next(255))), 
     r.Next(1000), r.Next(1000), 
     r.Next(1000), r.Next(1000));
   }
   for (i = 1 ; i<= 10 ; i++)
    gr.DrawString("Visual C# .Net", 
     new Font("Tahoma", 18, FontStyle.Bold), 
     new SolidBrush(Color.Yellow), 
     r.Next(300), r.Next(300));
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   //sadece gerekli bˆlgeyi Bitmap nesnesinden forma kopyala
   e.Graphics.DrawImage(bmp, e.ClipRectangle, 
    e.ClipRectangle.Left, e.ClipRectangle.Top, 
    e.ClipRectangle.Width, e.ClipRectangle.Height, 
    GraphicsUnit.Pixel);
  }


  private void Form1_Load(object sender, System.EventArgs e)
  {
   Rectangle p = new Rectangle();
   p = Screen.GetBounds(p);
   bmp = new Bitmap(p.Width, p.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
   this.Show();
   Áiz();   
  }
	}
}
