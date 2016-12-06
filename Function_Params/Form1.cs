using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Function_Params
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
   this.button1.Location = new System.Drawing.Point(248, 24);
   this.button1.Name = "button1";
   this.button1.TabIndex = 0;
   this.button1.Text = "Kare Topla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(248, 56);
   this.button2.Name = "button2";
   this.button2.TabIndex = 1;
   this.button2.Text = "Çiz";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(336, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
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

  double Kare_Topla(params double[] x)
  {
   double t=0;
   int i;
   for (i = 0 ; i <= x.Length - 1 ; i++)
    t = t + Math.Pow(x[i], 2);
   return t;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   double sonuç;
   sonuç=Kare_Topla(5, 12);
   MessageBox.Show(sonuç.ToString());
   sonuç=Kare_Topla(3, 4, 2, 4, 5, 6, 7, 8, 9, 0, 2);
   MessageBox.Show(sonuç.ToString());
  }
  
  void çiz(Color renk, int kalýnlýk, params Point[] xy)
  {
   int i;
   Graphics g;
   g = this.CreateGraphics();
   for (i = 1 ; i <= xy.Length - 1 ; i++)
    g.DrawLine(new Pen(new SolidBrush(renk),kalýnlýk),xy[i],xy[i-1]);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   çiz(Color.Red,3,new Point(0,0),new Point(100,140),new Point(150,150));
   çiz(Color.Blue,5,new Point(10,10),new Point(15,15),new Point(15,50),new Point(150,50),new Point(15,60));
  }

	}
}
