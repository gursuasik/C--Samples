using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace «izim_Araba«iz
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(360, 190);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

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

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   Pen kalem = new Pen(Color.Blue, 2);
   e.Graphics.DrawLine(kalem, 10, 50, 90, 50);//1
   e.Graphics.DrawLine(kalem, 90, 50, 130, 20);//2
   e.Graphics.DrawLine(kalem, 130, 20, 170, 20);//3
   e.Graphics.DrawLine(kalem, 170, 20, 210, 50);//4
   e.Graphics.DrawLine(kalem, 210, 50, 300, 50);//5
   e.Graphics.DrawLine(kalem, 300, 50, 300, 90);//6
   e.Graphics.DrawLine(kalem, 300, 90, 10, 90);//7
   e.Graphics.DrawLine(kalem, 10, 90, 10, 50);//8
   e.Graphics.DrawEllipse(kalem, 220, 70, 40, 40);//9
   e.Graphics.DrawEllipse(kalem, 50, 70, 40, 40);//10
  }
	}
}
