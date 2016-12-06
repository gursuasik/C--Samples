using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RichTextBox_KelimeIslemci
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem MenuItem2;
  internal System.Windows.Forms.MenuItem Mn_Yatay_Döþe;
  internal System.Windows.Forms.MenuItem Mn_Dikey_Döþe;
  internal System.Windows.Forms.MenuItem Mn_Basamakla;
  internal System.Windows.Forms.MenuItem Mn_Simgeleri_Yerleþtir;
  internal System.Windows.Forms.MenuItem Mn_Yeni;
  internal System.Windows.Forms.MenuItem Mn_Kapat;
  internal System.Windows.Forms.MainMenu mainMenu1;
  internal System.Windows.Forms.MenuItem MenuItem1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
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
				if(components != null)
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
   this.MenuItem2 = new System.Windows.Forms.MenuItem();
   this.Mn_Yatay_Döþe = new System.Windows.Forms.MenuItem();
   this.Mn_Dikey_Döþe = new System.Windows.Forms.MenuItem();
   this.Mn_Basamakla = new System.Windows.Forms.MenuItem();
   this.Mn_Simgeleri_Yerleþtir = new System.Windows.Forms.MenuItem();
   this.Mn_Yeni = new System.Windows.Forms.MenuItem();
   this.Mn_Kapat = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.MenuItem1 = new System.Windows.Forms.MenuItem();
   // 
   // MenuItem2
   // 
   this.MenuItem2.Index = 1;
   this.MenuItem2.MdiList = true;
   this.MenuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Yatay_Döþe,
                                                                          this.Mn_Dikey_Döþe,
                                                                          this.Mn_Basamakla,
                                                                          this.Mn_Simgeleri_Yerleþtir});
   this.MenuItem2.MergeOrder = 5;
   this.MenuItem2.Text = "Pencere";
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
   // Mn_Yeni
   // 
   this.Mn_Yeni.Index = 0;
   this.Mn_Yeni.Text = "Yeni";
   this.Mn_Yeni.Click += new System.EventHandler(this.Mn_Yeni_Click);
   // 
   // Mn_Kapat
   // 
   this.Mn_Kapat.Index = 1;
   this.Mn_Kapat.MergeType = System.Windows.Forms.MenuMerge.Remove;
   this.Mn_Kapat.Text = "Kapat";
   this.Mn_Kapat.Click += new System.EventHandler(this.Mn_Kapat_Click);
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.MenuItem1,
                                                                          this.MenuItem2});
   // 
   // MenuItem1
   // 
   this.MenuItem1.Index = 0;
   this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Yeni,
                                                                          this.Mn_Kapat});
   this.MenuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
   this.MenuItem1.Text = "Dosya";
   // 
   // Form3
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(744, 529);
   this.IsMdiContainer = true;
   this.Menu = this.mainMenu1;
   this.Name = "Form3";
   this.Text = "Form3";
   this.MdiChildActivate += new System.EventHandler(this.Form3_MdiChildActivate);
   this.Load += new System.EventHandler(this.Form3_Load);

  }
		#endregion

  private void Mn_Yeni_Click(object sender, System.EventArgs e)
  {
   Form1 frm = new Form1();
   frm.Text = "Bizim Word V 1.0";
   frm.MdiParent = this;
   frm.Show();
  }

  private void Mn_Kapat_Click(object sender, System.EventArgs e)
  {
   this.Close();
  }

  private void Form3_Load(object sender, System.EventArgs e)
  {
   Mn_Yeni.PerformClick(); //Yeni menüsünü çaðýr
  }

  private void Form3_MdiChildActivate(object sender, System.EventArgs e)
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

  private void Mn_Simgeleri_Yerleþtir_Click(object sender, 
   System.EventArgs e)
  {
   this.LayoutMdi(MdiLayout.ArrangeIcons);
  }

	}
}
