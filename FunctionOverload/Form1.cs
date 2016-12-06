using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FunctionOverload
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
   this.button1.Location = new System.Drawing.Point(32, 136);
   this.button1.Name = "button1";
   this.button1.TabIndex = 0;
   this.button1.Text = "button1";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(128, 136);
   this.button2.Name = "button2";
   this.button2.TabIndex = 1;
   this.button2.Text = "button2";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 182);
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

  int topla(int x, int y) 
  {
   MessageBox.Show("2 parametreli olan çalýþýyor");
   return x + y;
  }

  int topla(int x, int y, int z) 
  {
   MessageBox.Show("3 parametreli olan çalýþýyor");
   return x + y + z;
  }
                  
  private void Form1_Load(object sender, System.EventArgs e)
  {
  
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   MessageBox.Show(topla(5, 6).ToString());
   MessageBox.Show(topla(5, 6, 7).ToString());
  }

  int çýkar(int x , int y)
  {
   return x - y;
  }

  string çýkar(string x , string y)
  {
   return x.Replace(y, "");
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   MessageBox.Show(çýkar(10, 3).ToString()); //Sonuç:7
   MessageBox.Show(çýkar("Hakkari", "a"));//Sonuç: Hkkri
  }

	}
}
