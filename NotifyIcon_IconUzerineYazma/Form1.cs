using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NotifyIcon_IconUzerineYazma
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.NotifyIcon notifyIcon1;
  internal System.Windows.Forms.Timer timer1;
  internal System.Windows.Forms.Label Label1;
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
   this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // notifyIcon1
   // 
   this.notifyIcon1.Text = "NotifyIcon1";
   this.notifyIcon1.Visible = true;
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // Label1
   // 
   this.Label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Label1.Location = new System.Drawing.Point(24, 24);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(312, 72);
   this.Label1.TabIndex = 1;
   this.Label1.Text = "Bu örnek System Traydaki simge üzerine nasýl yazý yazýlacaðýný göstermektedir";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(344, 110);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1});
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
   timer1.Interval = 1000;
   timer1.Enabled = true;
  }

  int i=0;
  private void timer1_Tick(object sender, System.EventArgs e)
  {
   //0-99 arasý i'yi artýr
   i = (i + 1) % 100;
   //16x16 pixel büyüklüðünde bir resim oluþtur
   Bitmap resim = new Bitmap(16, 16, 
    System.Drawing.Imaging.PixelFormat.Format24bppRgb);
   //Bu resimden bir grafik nesnesi oluþtur
   Graphics  g = Graphics.FromImage(resim);
   //Zemini kýrmýzý renge boya
   g.FillRectangle(Brushes.Red, 0, 0, 16, 16);
   //Üzerine i sayýsýný yaz
   g.DrawString(i.ToString(), 
    new Font("Tahoma", 8, FontStyle.Bold), 
    Brushes.White, 0, 0);
   //Bu resmi Icona çevirip System Tray üzerinde göster
   notifyIcon1.Icon = Icon.FromHandle(resim.GetHicon());
  }
	}
}
