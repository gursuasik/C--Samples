using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DateTimeTicks
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Button button1;
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
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 232);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(280, 32);
   this.button1.TabIndex = 0;
   this.button1.Text = "Soru Sor";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1});
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

  void bekle(long s�re)
  {
   long b;
   b = DateTime.Now.Ticks + s�re*10000000;
   while (DateTime.Now.Ticks < b )//s�re dolmad�ysa
   {
    this.Update();
    //bekle
   }
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Formun ba�l���na merhaba yaz
   this.Text = "Merhaba";
   bekle(3);
   //3 saniye sonra formun ba�l���na nas�ls�n yazar
   this.Text = "Nas�ls�n";
   bekle(5);
   //5 saniye sonra formun ba�l���na Ad�n Ne yazar
   this.Text = "Ad�n Nedir?";
   bekle(4);
   //4 saniye sonra formun ba�l���na Sorular�m Bitti yazar
   this.Text = "Sorular�m Bitti";
  }
	}
}
