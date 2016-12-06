using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_Radio
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MainMenu mainMenu1;
  internal System.Windows.Forms.MenuItem Mn_Yasla;
  internal System.Windows.Forms.MenuItem Mn_Sola;
  internal System.Windows.Forms.MenuItem Mn_Ortaya;
  internal System.Windows.Forms.MenuItem Mn_Saða;
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
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.Mn_Yasla = new System.Windows.Forms.MenuItem();
   this.Mn_Sola = new System.Windows.Forms.MenuItem();
   this.Mn_Ortaya = new System.Windows.Forms.MenuItem();
   this.Mn_Saða = new System.Windows.Forms.MenuItem();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Yasla});
   // 
   // Mn_Yasla
   // 
   this.Mn_Yasla.Index = 0;
   this.Mn_Yasla.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                         this.Mn_Sola,
                                                                         this.Mn_Ortaya,
                                                                         this.Mn_Saða});
   this.Mn_Yasla.Text = "Yasla";
   // 
   // Mn_Sola
   // 
   this.Mn_Sola.Index = 0;
   this.Mn_Sola.RadioCheck = true;
   this.Mn_Sola.Text = "Sola";
   this.Mn_Sola.Click += new System.EventHandler(this.Mn_Sola_Click);
   // 
   // Mn_Ortaya
   // 
   this.Mn_Ortaya.Index = 1;
   this.Mn_Ortaya.RadioCheck = true;
   this.Mn_Ortaya.Text = "Ortaya";
   this.Mn_Ortaya.Click += new System.EventHandler(this.Mn_Ortaya_Click);
   // 
   // Mn_Saða
   // 
   this.Mn_Saða.Index = 2;
   this.Mn_Saða.RadioCheck = true;
   this.Mn_Saða.Text = "Saða";
   this.Mn_Saða.Click += new System.EventHandler(this.Mn_Saða_Click);
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

  private void Mn_Sola_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   Mn_Ortaya.Checked = false;
   Mn_Saða.Checked = false;
   textBox1.TextAlign = HorizontalAlignment.Left;
  }

  private void Mn_Ortaya_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   Mn_Sola.Checked = false;
   Mn_Saða.Checked = false;
   textBox1.TextAlign = HorizontalAlignment.Center;
  }

  private void Mn_Saða_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   Mn_Ortaya.Checked = false;
   Mn_Sola.Checked = false;
   textBox1.TextAlign = HorizontalAlignment.Right;
  }
	}
}
