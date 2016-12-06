using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_RenkliMen�
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem Mn_Ye�il;
  internal System.Windows.Forms.MenuItem MenuItem1;
  internal System.Windows.Forms.MenuItem Mn_K�rm�z�;
  internal System.Windows.Forms.MenuItem Mn_Mavi;
  internal System.Windows.Forms.MenuItem Mn_Sar�;
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
   this.Mn_Ye�il = new System.Windows.Forms.MenuItem();
   this.MenuItem1 = new System.Windows.Forms.MenuItem();
   this.Mn_K�rm�z� = new System.Windows.Forms.MenuItem();
   this.Mn_Mavi = new System.Windows.Forms.MenuItem();
   this.Mn_Sar� = new System.Windows.Forms.MenuItem();
   this.Mn_Kahverengi = new System.Windows.Forms.MenuItem();
   this.Mn_Siyah = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   // 
   // Mn_Ye�il
   // 
   this.Mn_Ye�il.Index = 3;
   this.Mn_Ye�il.OwnerDraw = true;
   this.Mn_Ye�il.Text = "Ye�il";
   // 
   // MenuItem1
   // 
   this.MenuItem1.Index = 0;
   this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_K�rm�z�,
                                                                          this.Mn_Mavi,
                                                                          this.Mn_Sar�,
                                                                          this.Mn_Ye�il,
                                                                          this.Mn_Kahverengi,
                                                                          this.Mn_Siyah});
   this.MenuItem1.Text = "Renkler";
   // 
   // Mn_K�rm�z�
   // 
   this.Mn_K�rm�z�.Index = 0;
   this.Mn_K�rm�z�.OwnerDraw = true;
   this.Mn_K�rm�z�.Text = "K�rm�z�";
   this.Mn_K�rm�z�.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_K�rm�z�_DrawItem);
   this.Mn_K�rm�z�.Click += new System.EventHandler(this.Mn_K�rm�z�_Click);
   this.Mn_K�rm�z�.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Mn_K�rm�z�_MeasureItem);
   // 
   // Mn_Mavi
   // 
   this.Mn_Mavi.Index = 1;
   this.Mn_Mavi.OwnerDraw = true;
   this.Mn_Mavi.Text = "Mavi";
   // 
   // Mn_Sar�
   // 
   this.Mn_Sar�.Index = 2;
   this.Mn_Sar�.OwnerDraw = true;
   this.Mn_Sar�.Text = "Sar�";
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

  Color Renk_Bul(string renk_ad�)
  {
   switch(renk_ad�)
   {
    case "K�rm�z�":
     return Color.Red;
    case "Mavi":
     return Color.Blue;
    case "Ye�il":
     return Color.Green;
    case "Sar�":
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
   //Olaylar� birle�tir
   Mn_Mavi.Click += new EventHandler(Mn_K�rm�z�_Click);
   Mn_Sar�.Click += new EventHandler(Mn_K�rm�z�_Click);
   Mn_Ye�il.Click += new EventHandler(Mn_K�rm�z�_Click);
   Mn_Kahverengi.Click += new EventHandler(Mn_K�rm�z�_Click);
   Mn_Siyah.Click += new EventHandler(Mn_K�rm�z�_Click);

   Mn_Mavi.DrawItem += new DrawItemEventHandler(Mn_K�rm�z�_DrawItem);
   Mn_Sar�.DrawItem += new DrawItemEventHandler(Mn_K�rm�z�_DrawItem);
   Mn_Ye�il.DrawItem += new DrawItemEventHandler(Mn_K�rm�z�_DrawItem);
   Mn_Kahverengi.DrawItem += new DrawItemEventHandler(Mn_K�rm�z�_DrawItem);
   Mn_Siyah.DrawItem += new DrawItemEventHandler(Mn_K�rm�z�_DrawItem);

   Mn_Mavi.MeasureItem += new MeasureItemEventHandler(Mn_K�rm�z�_MeasureItem);
   Mn_Sar�.MeasureItem += new MeasureItemEventHandler(Mn_K�rm�z�_MeasureItem);
   Mn_Ye�il.MeasureItem += new MeasureItemEventHandler(Mn_K�rm�z�_MeasureItem);
   Mn_Kahverengi.MeasureItem += new MeasureItemEventHandler(Mn_K�rm�z�_MeasureItem);
   Mn_Siyah.MeasureItem += new MeasureItemEventHandler(Mn_K�rm�z�_MeasureItem);
  }

  private void Mn_K�rm�z�_Click(object sender, System.EventArgs e)
  {
   Color renk;
   renk = Renk_Bul((sender as MenuItem).Text);
   this.BackColor = renk;
  }

  private void Mn_K�rm�z�_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   Color renk;
   renk = Renk_Bul((sender as MenuItem).Text);
   //Men�n�n zeminini �iz
   e.DrawBackground();
   e.Graphics.DrawString((sender as MenuItem).Text, this.Font, new SolidBrush(renk), 
    e.Bounds.Left, e.Bounds.Top);
   //Aktif men�y� �iz
   e.DrawFocusRectangle();
  }

  private void Mn_K�rm�z�_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   e.ItemHeight = this.Font.Height;
   e.ItemWidth = 100;
  }

  

	}
}
