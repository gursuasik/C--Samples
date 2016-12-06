using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HareketliTop
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.RadioButton radioButton1;
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
   this.radioButton1 = new System.Windows.Forms.RadioButton();
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   this.SuspendLayout();
   // 
   // radioButton1
   // 
   this.radioButton1.Location = new System.Drawing.Point(40, 48);
   this.radioButton1.Name = "radioButton1";
   this.radioButton1.TabIndex = 0;
   this.radioButton1.Text = "radioButton1";
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.radioButton1});
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
   radioButton1.Text = "";
   radioButton1.Width = 10;
   timer1.Interval = 50;
   timer1.Enabled = true;
  }
  
  int sx = 5, sy = 5;
  private void timer1_Tick(object sender, System.EventArgs e)
  {
   if (radioButton1.Top <= 0 || radioButton1.Bottom >= this.ClientSize.Height)
    //Formun üstüne veya altýna ulaþýldý ise artýmý ters çevir
    sy = -sy; //artýþ yönünü ters çevir
   if (radioButton1.Left <= 0 || radioButton1.Right >= this.ClientSize.Width)
    //Formun soluna veya saðýna ulaþýldý ise artýmý ters çevir.
    sx = -sx; //artýþ yönünü ters çevir
   radioButton1.Left += sx;
   radioButton1.Top += sy;
  }
	}
}
