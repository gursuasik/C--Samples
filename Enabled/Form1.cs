using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Enabled
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Button button2;
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
   this.button1 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(176, 32);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 23);
   this.button1.TabIndex = 0;
   this.button1.Text = "Baðlan";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(176, 64);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(104, 23);
   this.button2.TabIndex = 1;
   this.button2.Text = "Baðlantýyý Kes";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 126);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1});
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Baþlangýçta 1. düðme Aktif 2. düðme Pasif
   button1.Enabled = true;
   button2.Enabled = false;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Baðlan düðmesi pasif, Baðlantýyý kes düðmesi Pasif
   button1.Enabled = false;
   button2.Enabled = true;
   this.Text = "Baðlantý saðlandý";
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Baðlan düðmesi Aktif, Baðlantýyý kes düðmesi Pasif
   button1.Enabled = true;
   button2.Enabled = false;
   this.Text = "Baðlantý Kesildi";
  }
	}
}
