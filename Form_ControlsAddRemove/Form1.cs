using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_ControlsAddRemove
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem Mn_Sil;
  internal System.Windows.Forms.MenuItem Mn_Ekle;
  internal System.Windows.Forms.MenuItem MenuItem1;
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
   this.Mn_Sil = new System.Windows.Forms.MenuItem();
   this.Mn_Ekle = new System.Windows.Forms.MenuItem();
   this.MenuItem1 = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   // 
   // Mn_Sil
   // 
   this.Mn_Sil.Index = 1;
   this.Mn_Sil.Text = "Sil";
   this.Mn_Sil.Click += new System.EventHandler(this.Mn_Sil_Click);
   // 
   // Mn_Ekle
   // 
   this.Mn_Ekle.Index = 0;
   this.Mn_Ekle.Text = "Ekle";
   this.Mn_Ekle.Click += new System.EventHandler(this.Mn_Ekle_Click);
   // 
   // MenuItem1
   // 
   this.MenuItem1.Index = 0;
   this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Ekle,
                                                                          this.Mn_Sil});
   this.MenuItem1.Text = "Kontroller";
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

  int say, y;
  private void Mn_Ekle_Click(object sender, System.EventArgs e)
  {
   Button Komut_Düðmesi = new Button();
   Komut_Düðmesi.Top = y;
   Komut_Düðmesi.Left = 0;
   Komut_Düðmesi.Width = 150;
   say++;
   Komut_Düðmesi.Text = "Yeni Komut Düðmesi " + say.ToString();
   y += Komut_Düðmesi.Height + 5;
   Komut_Düðmesi.Click += new EventHandler(týkla);
   this.Controls.Add(Komut_Düðmesi);
  }

  private void týkla(object sender, System.EventArgs e)
  {
   MessageBox.Show((sender as Button).Text + " týklandý");
  }

  private void Mn_Sil_Click(object sender, System.EventArgs e)
  {
   this.Controls.Remove(this.ActiveControl);
  }

	}
}
