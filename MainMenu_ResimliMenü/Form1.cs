using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_ResimliMenü
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem Mn_Bilgisayar_Parçalarý;
  internal System.Windows.Forms.MenuItem Mn_Monitör;
  internal System.Windows.Forms.MenuItem Mn_Klavye;
  internal System.Windows.Forms.MenuItem Mn_Fare;
  internal System.Windows.Forms.ImageList ýmageList1;
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
   this.Mn_Bilgisayar_Parçalarý = new System.Windows.Forms.MenuItem();
   this.Mn_Monitör = new System.Windows.Forms.MenuItem();
   this.Mn_Klavye = new System.Windows.Forms.MenuItem();
   this.Mn_Fare = new System.Windows.Forms.MenuItem();
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   // 
   // Mn_Bilgisayar_Parçalarý
   // 
   this.Mn_Bilgisayar_Parçalarý.Index = 0;
   this.Mn_Bilgisayar_Parçalarý.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                        this.Mn_Monitör,
                                                                                        this.Mn_Klavye,
                                                                                        this.Mn_Fare});
   this.Mn_Bilgisayar_Parçalarý.OwnerDraw = true;
   this.Mn_Bilgisayar_Parçalarý.Text = "Bilgisayar Parçalarý";
   this.Mn_Bilgisayar_Parçalarý.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_Bilgisayar_Parçalarý_DrawItem);
   this.Mn_Bilgisayar_Parçalarý.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Mn_Bilgisayar_Parçalarý_MeasureItem);
   // 
   // Mn_Monitör
   // 
   this.Mn_Monitör.Index = 0;
   this.Mn_Monitör.OwnerDraw = true;
   this.Mn_Monitör.Text = "Monitör";
   this.Mn_Monitör.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_Monitör_DrawItem);
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
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.ýmageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList1.ImageStream")));
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Bilgisayar_Parçalarý});
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

  private void Mn_Bilgisayar_Parçalarý_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   //ImageList içindeki ilk resmi çiz
   ýmageList1.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, 0);
   //Resmin yanýna menü baþlýðýný yaz
   e.Graphics.DrawString((sender as MenuItem).Text, this.Font, Brushes.Black, 
    e.Bounds.Left + ýmageList1.ImageSize.Width + 2, 
    e.Bounds.Top);
  }
  
  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Olaylarý birleþtir
   Mn_Klavye.DrawItem += new DrawItemEventHandler(Mn_Monitör_DrawItem);
   Mn_Fare.DrawItem += new DrawItemEventHandler(Mn_Monitör_DrawItem);

   Mn_Monitör.MeasureItem += new MeasureItemEventHandler(Mn_Bilgisayar_Parçalarý_MeasureItem);
   Mn_Klavye.MeasureItem += new MeasureItemEventHandler(Mn_Bilgisayar_Parçalarý_MeasureItem);
   Mn_Fare.MeasureItem += new MeasureItemEventHandler(Mn_Bilgisayar_Parçalarý_MeasureItem);
  }

  private void Mn_Monitör_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   //Menünün zeminini çiz
   e.DrawBackground();
   int ind;
   //Menünün sýrasýný öðren
   ind = (sender as MenuItem).Index;
   //ýmageList içindeki o resmi çiz
   ýmageList1.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, ind + 1);
   //Resmin yanýna menü baþlýðýný yaz
   e.Graphics.DrawString((sender as MenuItem).Text, this.Font, Brushes.Black, 
    e.Bounds.Left + ýmageList1.ImageSize.Width + 2, 
    e.Bounds.Top);
   //Aktif menüyü çiz
   e.DrawFocusRectangle();
  }

  private void Mn_Bilgisayar_Parçalarý_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   e.ItemHeight = ýmageList1.ImageSize.Height + 3;
   e.ItemWidth = 100;
  }

  
	}
}
