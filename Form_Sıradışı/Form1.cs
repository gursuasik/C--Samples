using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_Sýradýþý
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button Button1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.Label1 = new System.Windows.Forms.Label();
   this.Button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.BackColor = System.Drawing.Color.Transparent;
   this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Label1.Location = new System.Drawing.Point(264, 56);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(304, 128);
   this.Label1.TabIndex = 3;
   this.Label1.Text = "Ben bir garip maden iþçisiyim. Gece gündüz çalýþýrým.";
   this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // Button1
   // 
   this.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
   this.Button1.Location = new System.Drawing.Point(576, 24);
   this.Button1.Name = "Button1";
   this.Button1.Size = new System.Drawing.Size(24, 16);
   this.Button1.TabIndex = 2;
   this.Button1.Text = "x";
   this.Button1.Click += new System.EventHandler(this.Button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
   this.ClientSize = new System.Drawing.Size(672, 534);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.Button1});
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
   this.Name = "Form1";
   this.Text = "Form1";
   this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
   this.Load += new System.EventHandler(this.Form1_Load);
   this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
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
   this.TransparencyKey = Color.FromArgb(128, 64, 0);
  }

  Point týklanan_nokta;
  private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
    //Farenin týklandýðý noktadaki koordinatlarýný al
    týklanan_nokta = new Point(e.X, e.Y);
  }

  private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   //Sol tuþ basýlý olarak hareket ettiriliyorsa formu taþý
   if (e.Button == MouseButtons.Left)
   {
    Point Koordinatlar;
    Koordinatlar = Control.MousePosition;
    Koordinatlar.Offset(-týklanan_nokta.X, -týklanan_nokta.Y);
    this.Location = Koordinatlar;
   }
  }

  private void Button1_Click(object sender, System.EventArgs e)
  {
   this.Close();
  }
	}
}
