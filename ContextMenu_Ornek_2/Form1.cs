using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ContextMenu_Ornek_2
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.ContextMenu contextMenu1;
  internal System.Windows.Forms.MenuItem Mn_Renk;
  internal System.Windows.Forms.MenuItem Mn_Simge;
  internal System.Windows.Forms.MenuItem Mn_Ekraný_Kapla;
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
   this.contextMenu1 = new System.Windows.Forms.ContextMenu();
   this.Mn_Renk = new System.Windows.Forms.MenuItem();
   this.Mn_Simge = new System.Windows.Forms.MenuItem();
   this.Mn_Ekraný_Kapla = new System.Windows.Forms.MenuItem();
   // 
   // contextMenu1
   // 
   this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                             this.Mn_Renk,
                                                                             this.Mn_Simge,
                                                                             this.Mn_Ekraný_Kapla});
   // 
   // Mn_Renk
   // 
   this.Mn_Renk.Index = 0;
   this.Mn_Renk.Text = "Renk Deðiþ";
   this.Mn_Renk.Click += new System.EventHandler(this.Mn_Renk_Click);
   // 
   // Mn_Simge
   // 
   this.Mn_Simge.Index = 1;
   this.Mn_Simge.Text = "Simge Durumuna Küçült";
   this.Mn_Simge.Click += new System.EventHandler(this.Mn_Simge_Click);
   // 
   // Mn_Ekraný_Kapla
   // 
   this.Mn_Ekraný_Kapla.Index = 2;
   this.Mn_Ekraný_Kapla.Text = "Ekraný Kapla";
   this.Mn_Ekraný_Kapla.Click += new System.EventHandler(this.Mn_Ekraný_Kapla_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);

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

  private void Mn_Renk_Click(object sender, System.EventArgs e)
  {
   //Rasgele bir renge ayarla
   Random r = new Random();
   this.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
  }

  private void Mn_Simge_Click(object sender, System.EventArgs e)
  {
   //Simge durumuna küçült
   this.WindowState = FormWindowState.Minimized;
  }

  private void Mn_Ekraný_Kapla_Click(object sender, System.EventArgs e)
  {
   //Ekraný kapla
   this.WindowState = FormWindowState.Maximized;
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   this.ContextMenu = contextMenu1;
  }
 }
}