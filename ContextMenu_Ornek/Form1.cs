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
  internal System.Windows.Forms.MenuItem Mn_Büyük;
  internal System.Windows.Forms.MenuItem Mn_Küçük;
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
   this.Mn_Büyük = new System.Windows.Forms.MenuItem();
   this.Mn_Küçük = new System.Windows.Forms.MenuItem();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // contextMenu1
   // 
   this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                             this.Mn_Büyük,
                                                                             this.Mn_Küçük});
   // 
   // Mn_Büyük
   // 
   this.Mn_Büyük.Index = 0;
   this.Mn_Büyük.Text = "Büyük Harfe Çevir";
   this.Mn_Büyük.Click += new System.EventHandler(this.Mn_Büyük_Click);
   // 
   // Mn_Küçük
   // 
   this.Mn_Küçük.Index = 1;
   this.Mn_Küçük.Text = "Küçük Harfe Çevir";
   this.Mn_Küçük.Click += new System.EventHandler(this.Mn_Küçük_Click);
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

  private void Mn_Büyük_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = textBox1.Text.ToUpper();
  }

  private void Mn_Küçük_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = textBox1.Text.ToLower();
  }
	}
}
