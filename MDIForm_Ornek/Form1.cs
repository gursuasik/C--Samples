using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MDIForm_Ornek
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MainMenu mainMenu1;
  internal System.Windows.Forms.MenuItem Mn_Dosya;
  internal System.Windows.Forms.MenuItem Mn_Yeni;
  internal System.Windows.Forms.MenuItem Mn_Kapat;
  internal System.Windows.Forms.MenuItem Mn_Pencere;
  internal System.Windows.Forms.MenuItem Mn_Yatay_Döþe;
  internal System.Windows.Forms.MenuItem Mn_Dikey_Döþe;
  internal System.Windows.Forms.MenuItem Mn_Basamakla;
  internal System.Windows.Forms.MenuItem Mn_Simgeleri_Yerleþtir;
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
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.Mn_Dosya = new System.Windows.Forms.MenuItem();
   this.Mn_Yeni = new System.Windows.Forms.MenuItem();
   this.Mn_Kapat = new System.Windows.Forms.MenuItem();
   this.Mn_Pencere = new System.Windows.Forms.MenuItem();
   this.Mn_Yatay_Döþe = new System.Windows.Forms.MenuItem();
   this.Mn_Dikey_Döþe = new System.Windows.Forms.MenuItem();
   this.Mn_Basamakla = new System.Windows.Forms.MenuItem();
   this.Mn_Simgeleri_Yerleþtir = new System.Windows.Forms.MenuItem();
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Dosya,
                                                                          this.Mn_Pencere});
   // 
   // Mn_Dosya
   // 
   this.Mn_Dosya.Index = 0;
   this.Mn_Dosya.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                         this.Mn_Yeni,
                                                                         this.Mn_Kapat});
   this.Mn_Dosya.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
   this.Mn_Dosya.Text = "Dosya";
   // 
   // Mn_Yeni
   // 
   this.Mn_Yeni.Index = 0;
   this.Mn_Yeni.Text = "Yeni";
   this.Mn_Yeni.Click += new System.EventHandler(this.Mn_Yeni_Click);
   // 
   // Mn_Kapat
   // 
   this.Mn_Kapat.Index = 1;
   this.Mn_Kapat.MergeOrder = 2;
   this.Mn_Kapat.Text = "Kapat";
   this.Mn_Kapat.Click += new System.EventHandler(this.Mn_Kapat_Click);
   // 
   // Mn_Pencere
   // 
   this.Mn_Pencere.Index = 1;
   this.Mn_Pencere.MdiList = true;
   this.Mn_Pencere.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                           this.Mn_Yatay_Döþe,
                                                                           this.Mn_Dikey_Döþe,
                                                                           this.Mn_Basamakla,
                                                                           this.Mn_Simgeleri_Yerleþtir});
   this.Mn_Pencere.Text = "Pencere";
   // 
   // Mn_Yatay_Döþe
   // 
   this.Mn_Yatay_Döþe.Index = 0;
   this.Mn_Yatay_Döþe.Text = "Yatay Döþe";
   this.Mn_Yatay_Döþe.Click += new System.EventHandler(this.Mn_Yatay_Döþe_Click);
   // 
   // Mn_Dikey_Döþe
   // 
   this.Mn_Dikey_Döþe.Index = 1;
   this.Mn_Dikey_Döþe.Text = "Dikey Döþe";
   this.Mn_Dikey_Döþe.Click += new System.EventHandler(this.Mn_Dikey_Döþe_Click);
   // 
   // Mn_Basamakla
   // 
   this.Mn_Basamakla.Index = 2;
   this.Mn_Basamakla.Text = "Basamakla";
   this.Mn_Basamakla.Click += new System.EventHandler(this.Mn_Basamakla_Click);
   // 
   // Mn_Simgeleri_Yerleþtir
   // 
   this.Mn_Simgeleri_Yerleþtir.Index = 3;
   this.Mn_Simgeleri_Yerleþtir.Text = "Simgeleri Yerleþtir";
   this.Mn_Simgeleri_Yerleþtir.Click += new System.EventHandler(this.Mn_Simgeleri_Yerleþtir_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.IsMdiContainer = true;
   this.Menu = this.mainMenu1;
   this.Name = "Form1";
   this.Text = "Form1";
   this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   Form2 frm = new Form2();
   frm.MdiParent = this;
   frm.Show();
  }
  
  int form_sayýsý =0;
  private void Mn_Yeni_Click(object sender, System.EventArgs e)
  {
   form_sayýsý += 1 ;
   Form2 frm = new Form2();
   frm.MdiParent = this;
   frm.Text = "Yeni Form " + form_sayýsý.ToString();
   frm.Show();
  }

  private void Mn_Kapat_Click(object sender, System.EventArgs e)
  {
   if (this.ActiveMdiChild != null)
    ActiveMdiChild.Close();
  }

  private void Form1_MdiChildActivate(object sender, System.EventArgs e)
  {
   if (this.ActiveMdiChild != null)
    this.Text = this.ActiveMdiChild.Text;
  }

  private void Mn_Yatay_Döþe_Click(object sender, System.EventArgs e)
  {
   this.LayoutMdi(MdiLayout.TileHorizontal);
  }

  private void Mn_Dikey_Döþe_Click(object sender, System.EventArgs e)
  {
   this.LayoutMdi(MdiLayout.TileVertical);
  }

  private void Mn_Basamakla_Click(object sender, System.EventArgs e)
  {
   this.LayoutMdi(MdiLayout.Cascade);
  }

  private void Mn_Simgeleri_Yerleþtir_Click(object sender, System.EventArgs e)
  {
   this.LayoutMdi(MdiLayout.ArrangeIcons);
  }
	}
}
