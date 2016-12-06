using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_Check
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.MenuItem Mn_Düzen;
  internal System.Windows.Forms.MenuItem Mn_Kalýn;
  internal System.Windows.Forms.MenuItem Mn_Eðik;
  internal System.Windows.Forms.MenuItem Mn_Altý_Çizili;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Mn_Düzen = new System.Windows.Forms.MenuItem();
   this.Mn_Kalýn = new System.Windows.Forms.MenuItem();
   this.Mn_Eðik = new System.Windows.Forms.MenuItem();
   this.Mn_Altý_Çizili = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(292, 266);
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "textBox1";
   this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   // 
   // Mn_Düzen
   // 
   this.Mn_Düzen.Index = 0;
   this.Mn_Düzen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                         this.Mn_Kalýn,
                                                                         this.Mn_Eðik,
                                                                         this.Mn_Altý_Çizili});
   this.Mn_Düzen.Text = "Dü&zen";
   // 
   // Mn_Kalýn
   // 
   this.Mn_Kalýn.Index = 0;
   this.Mn_Kalýn.Shortcut = System.Windows.Forms.Shortcut.CtrlK;
   this.Mn_Kalýn.Text = "Kalýn";
   this.Mn_Kalýn.Click += new System.EventHandler(this.Mn_Kalýn_Click);
   // 
   // Mn_Eðik
   // 
   this.Mn_Eðik.Index = 1;
   this.Mn_Eðik.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
   this.Mn_Eðik.Text = "Eðik";
   this.Mn_Eðik.Click += new System.EventHandler(this.Mn_Eðik_Click);
   // 
   // Mn_Altý_Çizili
   // 
   this.Mn_Altý_Çizili.Index = 2;
   this.Mn_Altý_Çizili.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
   this.Mn_Altý_Çizili.Text = "Altý Çizili";
   this.Mn_Altý_Çizili.Click += new System.EventHandler(this.Mn_Altý_Çizili_Click);
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Düzen});
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

  private void Mn_Kalýn_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   if (Mn_Kalýn.Checked)
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style | FontStyle.Bold);
   else
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style ^ FontStyle.Bold);
  }

  private void Mn_Eðik_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   if (Mn_Eðik.Checked)
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style | FontStyle.Italic);
   else
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style ^ FontStyle.Italic);
  }

  private void Mn_Altý_Çizili_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   if (Mn_Altý_Çizili.Checked)
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style | FontStyle.Underline);
   else
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style ^ FontStyle.Underline);
  }
	}
}
