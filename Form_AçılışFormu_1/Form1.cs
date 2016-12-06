using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_AçýlýþFormu_1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Timer timer1;
  internal System.Windows.Forms.Label Label2;
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
   this.Label1 = new System.Windows.Forms.Label();
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   this.Label2 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Label1.Location = new System.Drawing.Point(46, 53);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(208, 23);
   this.Label1.TabIndex = 2;
   this.Label1.Text = "Açýlýþ Formu";
   this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // timer1
   // 
   this.timer1.Interval = 1000;
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // Label2
   // 
   this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
   this.Label2.Location = new System.Drawing.Point(80, 197);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(152, 23);
   this.Label2.TabIndex = 3;
   this.Label2.Text = "5 Saniye Ýçinde Kapanacak";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.ControlBox = false;
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label2,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
   timer1.Interval = 5000;
   timer1.Enabled = true;
  }

  private void timer1_Tick(object sender, System.EventArgs e)
  {
   this.Close();
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   Form2 frm = new Form2();
   frm.Show();
   e.Cancel = true;
   timer1.Enabled=false;
   this.Hide();
  }

  
	}
}
