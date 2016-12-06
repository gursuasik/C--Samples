using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace timer_TextAnimasyon
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Timer timer1;
  private System.ComponentModel.IContainer components;

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
   this.components = new System.ComponentModel.Container();
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);

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
   timer1.Interval = 100;
   timer1.Enabled = true;
   this.Text = "Bizim Program";
  }

  int x=0, art�m=-1;
  string t = "Version 1.0 �hsan Karag�lle";
  private void timer1_Tick(object sender, System.EventArgs e)
  {
   //yaz�n�n sonuna veya ba��na gelince art�m� ters �evir
   if (x == t.Length) art�m = -art�m;
   if (x <= 0) art�m = -art�m;
   x += art�m;
   //Art�m pozitifse ileri, negatifse geri do�ru gel
   if (art�m > 0) this.Text = "Bizim Program " + t.Substring(0, x-1);
   if (art�m < 0) this.Text = "Bizim Program " + t.Substring(t.Length-x);
  }
	}
}
