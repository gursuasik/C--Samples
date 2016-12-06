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
  internal System.Windows.Forms.MenuItem Mn_D�zen;
  internal System.Windows.Forms.MenuItem Mn_Kal�n;
  internal System.Windows.Forms.MenuItem Mn_E�ik;
  internal System.Windows.Forms.MenuItem Mn_Alt�_�izili;
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
   this.Mn_D�zen = new System.Windows.Forms.MenuItem();
   this.Mn_Kal�n = new System.Windows.Forms.MenuItem();
   this.Mn_E�ik = new System.Windows.Forms.MenuItem();
   this.Mn_Alt�_�izili = new System.Windows.Forms.MenuItem();
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
   // Mn_D�zen
   // 
   this.Mn_D�zen.Index = 0;
   this.Mn_D�zen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                         this.Mn_Kal�n,
                                                                         this.Mn_E�ik,
                                                                         this.Mn_Alt�_�izili});
   this.Mn_D�zen.Text = "D�&zen";
   // 
   // Mn_Kal�n
   // 
   this.Mn_Kal�n.Index = 0;
   this.Mn_Kal�n.Shortcut = System.Windows.Forms.Shortcut.CtrlK;
   this.Mn_Kal�n.Text = "Kal�n";
   this.Mn_Kal�n.Click += new System.EventHandler(this.Mn_Kal�n_Click);
   // 
   // Mn_E�ik
   // 
   this.Mn_E�ik.Index = 1;
   this.Mn_E�ik.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
   this.Mn_E�ik.Text = "E�ik";
   this.Mn_E�ik.Click += new System.EventHandler(this.Mn_E�ik_Click);
   // 
   // Mn_Alt�_�izili
   // 
   this.Mn_Alt�_�izili.Index = 2;
   this.Mn_Alt�_�izili.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
   this.Mn_Alt�_�izili.Text = "Alt� �izili";
   this.Mn_Alt�_�izili.Click += new System.EventHandler(this.Mn_Alt�_�izili_Click);
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_D�zen});
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

  private void Mn_Kal�n_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   if (Mn_Kal�n.Checked)
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style | FontStyle.Bold);
   else
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style ^ FontStyle.Bold);
  }

  private void Mn_E�ik_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   if (Mn_E�ik.Checked)
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style | FontStyle.Italic);
   else
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style ^ FontStyle.Italic);
  }

  private void Mn_Alt�_�izili_Click(object sender, System.EventArgs e)
  {
   (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
   if (Mn_Alt�_�izili.Checked)
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style | FontStyle.Underline);
   else
    textBox1.Font = new Font(textBox1.Font, 
     textBox1.Font.Style ^ FontStyle.Underline);
  }
	}
}
