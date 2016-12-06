using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace �izim_ResimG�ster
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
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
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(528, 454);
   this.Name = "Form1";
   this.Text = "Form1";
   this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
   this.Load += new System.EventHandler(this.Form1_Load);
   this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
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

  Boolean se�ildi;
  string[] resimler = new string[500];

  private void Form1_Load(object sender, System.EventArgs e)
  {
   openFileDialog1.Title = 
    "G�sterilecek resimlerin bulundu�u klas�r� se�iniz";
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   if (se�ildi==false)
    e.Graphics.DrawString("Resim se�mek i�in formu �ift t�klay�n", 
     new Font("Tahoma", 16, FontStyle.Regular), 
     new SolidBrush(Color.Black), 0, 0);
   else
   {
    e.Graphics.Clear(this.BackColor);
    System.IO.FileInfo d = new System.IO.FileInfo(openFileDialog1.FileName);
    System.IO.DirectoryInfo klas�r = new System.IO.DirectoryInfo(d.DirectoryName);
    System.IO.FileInfo[] dosyalar;
    string[] uzant�lar= {"*.jpg", "*.bmp", "*.gif", "*.wmf"};
    int u, k=0, sat�r=0, s�tun=0, max_s�tun;
    max_s�tun = this.ClientSize.Width / 50;
    for (u = 0 ; u<= uzant�lar.Length - 1 ; u++)
    {
     dosyalar = klas�r.GetFiles(uzant�lar[u]);
      int i;
     for (i = 0 ; i<= dosyalar.Length - 1 ; i++)
     {
      if (s�tun == max_s�tun)
      {
       s�tun = 0;
       sat�r += 1;
      }
      resimler[k] = dosyalar[i].FullName;
      try
      {
       e.Graphics.DrawImage(Image.FromFile(dosyalar[i].FullName), 
        new Rectangle(s�tun * 50, sat�r * 50, 45, 45));
      }
      catch
      {
       e.Graphics.DrawString("BOZUK", 
        new Font("Tahoma", 8, FontStyle.Regular), 
        new SolidBrush(Color.Red), 
        s�tun * 50, sat�r * 50);
      }
      s�tun += 1;
      k += 1;
     }
    }
   }
  }

  private void Form1_DoubleClick(object sender, System.EventArgs e)
  {
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    se�ildi = true;
    this.Invalidate(); //Paint olay�n�n �al��mas�n� sa�la
   }
  }

  private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (se�ildi)
    if (e.Button == MouseButtons.Left)
    {
     int i, sat�r, s�tun, max_s�tun;
     max_s�tun = this.ClientSize.Width / 50;
     sat�r = e.Y / 50;
     s�tun = e.X / 50;
     i = sat�r * max_s�tun + s�tun;
     Form2 frm = new Form2();
     try
     {
      Image resim = Image.FromFile(resimler[i]);
      frm.BackgroundImage = resim;
      frm.Width = resim.Width + 5;
      frm.Height = resim.Height + 20;
      frm.Text = resimler[i];
      frm.Show();
     }
     catch
     {;}
    }
  }
 }
}
