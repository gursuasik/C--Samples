using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_KodlaMenuOluþturma
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem Mn_Font_Boyutu;
  internal System.Windows.Forms.MainMenu mainMenu1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.Mn_Font_Boyutu = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Mn_Font_Boyutu
   // 
   this.Mn_Font_Boyutu.Index = 0;
   this.Mn_Font_Boyutu.Text = "Font Boyutu";
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Font_Boyutu});
   // 
   // textBox1
   // 
   this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(292, 266);
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1});
   this.Menu = this.mainMenu1;
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.ResumeLayout(false);

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

  private void  Menü_Týklandý(object sender, System.EventArgs e)
  {
   int boyut;
   boyut = int.Parse((sender as MenuItem).Text);
   textBox1.Font = new Font(textBox1.Font.FontFamily, 
                        boyut, 
                        textBox1.Font.Style);
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   int i;
   for (i = 8 ; i<= 20 ;i+= 2)
    Mn_Font_Boyutu.MenuItems.Add(i.ToString(), new EventHandler(Menü_Týklandý));
  }

	}
}
