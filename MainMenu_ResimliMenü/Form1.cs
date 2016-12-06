using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_ResimliMen�
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem Mn_Bilgisayar_Par�alar�;
  internal System.Windows.Forms.MenuItem Mn_Monit�r;
  internal System.Windows.Forms.MenuItem Mn_Klavye;
  internal System.Windows.Forms.MenuItem Mn_Fare;
  internal System.Windows.Forms.ImageList �mageList1;
  internal System.Windows.Forms.MainMenu mainMenu1;
  private System.ComponentModel.IContainer components;

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
   this.components = new System.ComponentModel.Container();
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.Mn_Bilgisayar_Par�alar� = new System.Windows.Forms.MenuItem();
   this.Mn_Monit�r = new System.Windows.Forms.MenuItem();
   this.Mn_Klavye = new System.Windows.Forms.MenuItem();
   this.Mn_Fare = new System.Windows.Forms.MenuItem();
   this.�mageList1 = new System.Windows.Forms.ImageList(this.components);
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   // 
   // Mn_Bilgisayar_Par�alar�
   // 
   this.Mn_Bilgisayar_Par�alar�.Index = 0;
   this.Mn_Bilgisayar_Par�alar�.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                        this.Mn_Monit�r,
                                                                                        this.Mn_Klavye,
                                                                                        this.Mn_Fare});
   this.Mn_Bilgisayar_Par�alar�.OwnerDraw = true;
   this.Mn_Bilgisayar_Par�alar�.Text = "Bilgisayar Par�alar�";
   this.Mn_Bilgisayar_Par�alar�.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_Bilgisayar_Par�alar�_DrawItem);
   this.Mn_Bilgisayar_Par�alar�.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Mn_Bilgisayar_Par�alar�_MeasureItem);
   // 
   // Mn_Monit�r
   // 
   this.Mn_Monit�r.Index = 0;
   this.Mn_Monit�r.OwnerDraw = true;
   this.Mn_Monit�r.Text = "Monit�r";
   this.Mn_Monit�r.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_Monit�r_DrawItem);
   // 
   // Mn_Klavye
   // 
   this.Mn_Klavye.Index = 1;
   this.Mn_Klavye.OwnerDraw = true;
   this.Mn_Klavye.Text = "Klavye";
   // 
   // Mn_Fare
   // 
   this.Mn_Fare.Index = 2;
   this.Mn_Fare.OwnerDraw = true;
   this.Mn_Fare.Text = "Fare";
   // 
   // �mageList1
   // 
   this.�mageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.�mageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.�mageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("�mageList1.ImageStream")));
   this.�mageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Bilgisayar_Par�alar�});
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

  private void Mn_Bilgisayar_Par�alar�_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   //ImageList i�indeki ilk resmi �iz
   �mageList1.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, 0);
   //Resmin yan�na men� ba�l���n� yaz
   e.Graphics.DrawString((sender as MenuItem).Text, this.Font, Brushes.Black, 
    e.Bounds.Left + �mageList1.ImageSize.Width + 2, 
    e.Bounds.Top);
  }
  
  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Olaylar� birle�tir
   Mn_Klavye.DrawItem += new DrawItemEventHandler(Mn_Monit�r_DrawItem);
   Mn_Fare.DrawItem += new DrawItemEventHandler(Mn_Monit�r_DrawItem);

   Mn_Monit�r.MeasureItem += new MeasureItemEventHandler(Mn_Bilgisayar_Par�alar�_MeasureItem);
   Mn_Klavye.MeasureItem += new MeasureItemEventHandler(Mn_Bilgisayar_Par�alar�_MeasureItem);
   Mn_Fare.MeasureItem += new MeasureItemEventHandler(Mn_Bilgisayar_Par�alar�_MeasureItem);
  }

  private void Mn_Monit�r_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   //Men�n�n zeminini �iz
   e.DrawBackground();
   int ind;
   //Men�n�n s�ras�n� ��ren
   ind = (sender as MenuItem).Index;
   //�mageList i�indeki o resmi �iz
   �mageList1.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, ind + 1);
   //Resmin yan�na men� ba�l���n� yaz
   e.Graphics.DrawString((sender as MenuItem).Text, this.Font, Brushes.Black, 
    e.Bounds.Left + �mageList1.ImageSize.Width + 2, 
    e.Bounds.Top);
   //Aktif men�y� �iz
   e.DrawFocusRectangle();
  }

  private void Mn_Bilgisayar_Par�alar�_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   e.ItemHeight = �mageList1.ImageSize.Height + 3;
   e.ItemWidth = 100;
  }

  
	}
}
