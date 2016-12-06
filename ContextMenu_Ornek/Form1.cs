using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ContextMenu_Ornek
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ContextMenu contextMenu1;
  internal System.Windows.Forms.MenuItem Mn_B�y�k;
  internal System.Windows.Forms.MenuItem Mn_K���k;
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
   this.contextMenu1 = new System.Windows.Forms.ContextMenu();
   this.Mn_B�y�k = new System.Windows.Forms.MenuItem();
   this.Mn_K���k = new System.Windows.Forms.MenuItem();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // contextMenu1
   // 
   this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                             this.Mn_B�y�k,
                                                                             this.Mn_K���k});
   // 
   // Mn_B�y�k
   // 
   this.Mn_B�y�k.Index = 0;
   this.Mn_B�y�k.Text = "B�y�k Harfe �evir";
   this.Mn_B�y�k.Click += new System.EventHandler(this.Mn_B�y�k_Click);
   // 
   // Mn_K���k
   // 
   this.Mn_K���k.Index = 1;
   this.Mn_K���k.Text = "K���k Harfe �evir";
   this.Mn_K���k.Click += new System.EventHandler(this.Mn_K���k_Click);
   // 
   // textBox1
   // 
   this.textBox1.ContextMenu = this.contextMenu1;
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

  private void Mn_B�y�k_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = textBox1.Text.ToUpper();
  }

  private void Mn_K���k_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = textBox1.Text.ToLower();
  }
	}
}
