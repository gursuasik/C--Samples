using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_RenkliMenü
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem Mn_Yeþil;
  internal System.Windows.Forms.MenuItem MenuItem1;
  internal System.Windows.Forms.MenuItem Mn_Kýrmýzý;
  internal System.Windows.Forms.MenuItem Mn_Mavi;
  internal System.Windows.Forms.MenuItem Mn_Sarý;
  internal System.Windows.Forms.MenuItem Mn_Kahverengi;
  internal System.Windows.Forms.MenuItem Mn_Siyah;
  internal System.Windows.Forms.MainMenu mainMenu1;
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
   this.Mn_Yeþil = new System.Windows.Forms.MenuItem();
   this.MenuItem1 = new System.Windows.Forms.MenuItem();
   this.Mn_Kýrmýzý = new System.Windows.Forms.MenuItem();
   this.Mn_Mavi = new System.Windows.Forms.MenuItem();
   this.Mn_Sarý = new System.Windows.Forms.MenuItem();
   this.Mn_Kahverengi = new System.Windows.Forms.MenuItem();
   this.Mn_Siyah = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   // 
   // Mn_Yeþil
   // 
   this.Mn_Yeþil.Index = 3;
   this.Mn_Yeþil.OwnerDraw = true;
   this.Mn_Yeþil.Text = "Yeþil";
   // 
   // MenuItem1
   // 
   this.MenuItem1.Index = 0;
   this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Kýrmýzý,
                                                                          this.Mn_Mavi,
                                                                          this.Mn_Sarý,
                                                                          this.Mn_Yeþil,
                                                                          this.Mn_Kahverengi,
                                                                          this.Mn_Siyah});
   this.MenuItem1.Text = "Renkler";
   // 
   // Mn_Kýrmýzý
   // 
   this.Mn_Kýrmýzý.Index = 0;
   this.Mn_Kýrmýzý.OwnerDraw = true;
   this.Mn_Kýrmýzý.Text = "Kýrmýzý";
   this.Mn_Kýrmýzý.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_Kýrmýzý_DrawItem);
   this.Mn_Kýrmýzý.Click += new System.EventHandler(this.Mn_Kýrmýzý_Click);
   this.Mn_Kýrmýzý.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Mn_Kýrmýzý_MeasureItem);
   // 
   // Mn_Mavi
   // 
   this.Mn_Mavi.Index = 1;
   this.Mn_Mavi.OwnerDraw = true;
   this.Mn_Mavi.Text = "Mavi";
   // 
   // Mn_Sarý
   // 
   this.Mn_Sarý.Index = 2;
   this.Mn_Sarý.OwnerDraw = true;
   this.Mn_Sarý.Text = "Sarý";
   // 
   // Mn_Kahverengi
   // 
   this.Mn_Kahverengi.Index = 4;
   this.Mn_Kahverengi.OwnerDraw = true;
   this.Mn_Kahverengi.Text = "Kahverengi";
   // 
   // Mn_Siyah
   // 
   this.Mn_Siyah.Index = 5;
   this.Mn_Siyah.OwnerDraw = true;
   this.Mn_Siyah.Text = "Siyah";
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.MenuItem1});
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Menu = this.mainMenu1;
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

  Color Renk_Bul(string renk_adý)
  {
   switch(renk_adý)
   {
    case "Kýrmýzý":
     return Color.Red;
    case "Mavi":
     return Color.Blue;
    case "Yeþil":
     return Color.Green;
    case "Sarý":
     return Color.Yellow;
    case "Kahverengi":
     return Color.Brown;
    case "Siyah":
     return Color.Black;
    default:
     return Color.Black;
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Olaylarý birleþtir
   Mn_Mavi.Click += new EventHandler(Mn_Kýrmýzý_Click);
   Mn_Sarý.Click += new EventHandler(Mn_Kýrmýzý_Click);
   Mn_Yeþil.Click += new EventHandler(Mn_Kýrmýzý_Click);
   Mn_Kahverengi.Click += new EventHandler(Mn_Kýrmýzý_Click);
   Mn_Siyah.Click += new EventHandler(Mn_Kýrmýzý_Click);

   Mn_Mavi.DrawItem += new DrawItemEventHandler(Mn_Kýrmýzý_DrawItem);
   Mn_Sarý.DrawItem += new DrawItemEventHandler(Mn_Kýrmýzý_DrawItem);
   Mn_Yeþil.DrawItem += new DrawItemEventHandler(Mn_Kýrmýzý_DrawItem);
   Mn_Kahverengi.DrawItem += new DrawItemEventHandler(Mn_Kýrmýzý_DrawItem);
   Mn_Siyah.DrawItem += new DrawItemEventHandler(Mn_Kýrmýzý_DrawItem);

   Mn_Mavi.MeasureItem += new MeasureItemEventHandler(Mn_Kýrmýzý_MeasureItem);
   Mn_Sarý.MeasureItem += new MeasureItemEventHandler(Mn_Kýrmýzý_MeasureItem);
   Mn_Yeþil.MeasureItem += new MeasureItemEventHandler(Mn_Kýrmýzý_MeasureItem);
   Mn_Kahverengi.MeasureItem += new MeasureItemEventHandler(Mn_Kýrmýzý_MeasureItem);
   Mn_Siyah.MeasureItem += new MeasureItemEventHandler(Mn_Kýrmýzý_MeasureItem);
  }

  private void Mn_Kýrmýzý_Click(object sender, System.EventArgs e)
  {
   Color renk;
   renk = Renk_Bul((sender as MenuItem).Text);
   this.BackColor = renk;
  }

  private void Mn_Kýrmýzý_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   Color renk;
   renk = Renk_Bul((sender as MenuItem).Text);
   //Menünün zeminini çiz
   e.DrawBackground();
   e.Graphics.DrawString((sender as MenuItem).Text, this.Font, new SolidBrush(renk), 
    e.Bounds.Left, e.Bounds.Top);
   //Aktif menüyü çiz
   e.DrawFocusRectangle();
  }

  private void Mn_Kýrmýzý_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   e.ItemHeight = this.Font.Height;
   e.ItemWidth = 100;
  }

  

	}
}
