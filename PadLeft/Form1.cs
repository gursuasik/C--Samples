using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PadLeft
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
   this.button1.Location = new System.Drawing.Point(192, 24);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(128, 23);
   this.button1.TabIndex = 0;
   this.button1.Text = "Sola Yana��k Yaz";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(192, 72);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(128, 23);
   this.button2.TabIndex = 1;
   this.button2.Text = "Sa�a Yana��k Yaz";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(328, 118);
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

  private void button2_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   SolidBrush yaz�_rengi = new SolidBrush(Color.Yellow);
   Font fnt = new Font("Courier New", 10, FontStyle.Bold);
   int[] say�lar = {5, 17, 230, 900, 40, 8000};
   g = this.CreateGraphics();
   g.Clear(Color.Blue);
   string StrSay�;
   int i; 
   for (i = 0 ; i<= say�lar.Length - 1 ; i++)
   {
    StrSay� = say�lar[i].ToString();
    g.DrawString(StrSay�.PadLeft(7, ' '), fnt, yaz�_rengi, 10, i * 15);
    //g.DrawString(String.Format("{0,7}", StrSay�), fnt, yaz�_rengi,10,i * 15); bu �ekilde de olur
   }
   g.Dispose();
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   SolidBrush yaz�_rengi = new SolidBrush(Color.Yellow);
   Font fnt = new Font("Courier New", 10, FontStyle.Bold);
   int[] say�lar = {5, 17, 230, 900, 40, 8000};
   g = this.CreateGraphics();
   g.Clear(Color.Blue);
   string StrSay�;
   int i; 
   for (i = 0 ; i<= say�lar.Length - 1 ; i++)
   {
    StrSay� = say�lar[i].ToString();
    g.DrawString(StrSay�, fnt, yaz�_rengi, 10, i * 15);
   }
   g.Dispose();
  }
	}
}
