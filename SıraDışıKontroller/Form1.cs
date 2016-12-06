using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SýraDýþýKontroller
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
   this.button1.BackColor = System.Drawing.Color.Blue;
   this.button1.Location = new System.Drawing.Point(32, 40);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(88, 40);
   this.button1.TabIndex = 0;
   this.button1.Text = "button1";
   this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
   // 
   // button2
   // 
   this.button2.BackColor = System.Drawing.Color.Blue;
   this.button2.Location = new System.Drawing.Point(128, 40);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(88, 40);
   this.button2.TabIndex = 1;
   this.button2.Text = "button2";
   this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
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
  }

  private void button1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   System.Drawing.Drawing2D.GraphicsPath Grafik_Þekli;
   Grafik_Þekli = new System.Drawing.Drawing2D.GraphicsPath();
   Grafik_Þekli.AddEllipse(0, 0, (sender as Control).Width, (sender as Control).Height);
   (sender as Control).Region = new Region(Grafik_Þekli);
  }

  private void button2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   System.Drawing.Drawing2D.GraphicsPath Grafik_Þekli;
   Grafik_Þekli = new System.Drawing.Drawing2D.GraphicsPath();
   //Kenarlarýna dikdörtgen
   Grafik_Þekli.AddRectangle(new Rectangle(0, 0, 
    (sender as Control).Width, (sender as Control).Height));
   //Ýçine elips
   Grafik_Þekli.AddEllipse(10, 10, (sender as Control).Width - 20, (sender as Control).Height - 20);
   (sender as Control).Region = new Region(Grafik_Þekli);
  }
	}
}
