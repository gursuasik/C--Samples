using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BirdenFazlaDe�erG�nderme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Button button2;
  private System.Windows.Forms.Button button3;
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
   this.button3 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(32, 120);
   this.button1.Name = "button1";
   this.button1.TabIndex = 0;
   this.button1.Text = "button1";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(120, 120);
   this.button2.Name = "button2";
   this.button2.TabIndex = 1;
   this.button2.Text = "button2";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(208, 120);
   this.button3.Name = "button3";
   this.button3.TabIndex = 2;
   this.button3.Text = "button3";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 158);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button3,
                                                              this.button2,
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

  struct say�
  {
   public long tam;
   public double ondal�k;
  }

  say� Ay�r(double x) 
  {
   say� s;
   s.tam = (int) x;//Say�n�n tam k�sm�n� al
   s.ondal�k = x - s.tam ;//Say�dan tam k�sm� ��kar�l�rsa 
   //ondal�k k�sm� kal�r
   return s;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   double x;
   x = 145.39;
   say� s;
   s = Ay�r(x);
   MessageBox.Show("Tam K�s�m:" + s.tam.ToString() +
    " Ondal�k K�s�m:" + s.ondal�k.ToString());
  }

  void Ay�r2(double x, ref int tam, ref double ondal�k) 
  {
   tam = (int) x;//Say�n�n tam k�sm�n� al
   ondal�k = x - tam ;//Say�dan tam k�sm� ��kar�l�rsa 
                      //ondal�k k�sm� kal�r
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   double x, z=0;
   int y=0;
   x = 145.39;
   Ay�r2(x, ref y, ref z);
   MessageBox.Show("Tam K�s�m:" + y.ToString() + " Ondal�k K�s�m:" + z.ToString());
  }

  void Ay�r3(double x, out int tam, out double ondal�k) 
  {
   tam = (int) x;//Say�n�n tam k�sm�n� al
   ondal�k = x - tam ;//Say�dan tam k�sm� ��kar�l�rsa 
   //ondal�k k�sm� kal�r
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   double x, z;
   int y;
   x = 145.39;
   Ay�r3(x, out y, out z);
   MessageBox.Show("Tam K�s�m:" + y.ToString() + 
    " Ondal�k K�s�m:" + z.ToString());
  }
	}
}
