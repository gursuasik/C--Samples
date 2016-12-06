using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace StatusBar_OwnerDraw
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Timer timer1;
  internal System.Windows.Forms.StatusBar statusBar1;
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
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   this.statusBar1 = new System.Windows.Forms.StatusBar();
   this.SuspendLayout();
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // statusBar1
   // 
   this.statusBar1.Location = new System.Drawing.Point(0, 246);
   this.statusBar1.Name = "statusBar1";
   this.statusBar1.Size = new System.Drawing.Size(624, 48);
   this.statusBar1.TabIndex = 2;
   this.statusBar1.Text = "StatusBar1";
   this.statusBar1.DrawItem += new System.Windows.Forms.StatusBarDrawItemEventHandler(this.statusBar1_DrawItem);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(624, 294);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.statusBar1});
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


  //Api tanýmý
  [DllImport("kernel32.dll")]
  public static extern int 
   GetDiskFreeSpaceExA(string lpRootPathName, 
   ref long lpFreeBytesAvailableToCaller, 
   ref long lpTotalNumberOfBytes, 
   ref long lpTotalNumberOfFreeBytes);

  float[] yüzdeler;
  private void Form1_Load(object sender, System.EventArgs e)
  {
   statusBar1.ShowPanels = true;
   long x=0, y=0, z=0;
   string s;
   string[] sürücüler = System.IO.Directory.GetLogicalDrives();
   yüzdeler = new float[sürücüler.Length];
   int i;
   StatusBarPanel panel;
   for (i = 0 ; i<= sürücüler.GetUpperBound(0) ; i++)
   {
    y = 0;
    z = 0;
    GetDiskFreeSpaceExA(sürücüler[i], ref x, ref y, ref z);
    s = sürücüler[i];
    panel = statusBar1.Panels.Add(s);
    panel.Style = StatusBarPanelStyle.OwnerDraw;
    panel.AutoSize = StatusBarPanelAutoSize.Spring;
    if (y == 0)
     yüzdeler[i] = 0;
    else
     yüzdeler[i] = (float)z / y * 100;
    panel.ToolTipText = sürücüler[i] + "=" +
     (y / 1024 / 1024).ToString() + " MB Dolu, " + 
     (z / 1024 / 1024).ToString() + " MB Boþ";
   }
   panel = statusBar1.Panels.Add("Saat");
   panel.ToolTipText = "Saat";
   panel.Style = StatusBarPanelStyle.OwnerDraw;
   panel.Width =(int) (statusBar1.Height * 1.5);
   timer1.Interval = 1000;
   timer1.Enabled = true;
  }

  private void statusBar1_DrawItem(object sender, System.Windows.Forms.StatusBarDrawItemEventArgs sbdevent)
  {
   Rectangle k = new Rectangle();
   k = sbdevent.Bounds;
   if (sbdevent.Index < yüzdeler.Length)  //sürücü paneli
   {
    sbdevent.Graphics.DrawString(sbdevent.Panel.Text, 
     new Font("Tahoma", 12, FontStyle.Bold), 
     Brushes.Blue, 
     sbdevent.Bounds.Left, 
     sbdevent.Bounds.Top);
    //Sürücü harfinden 30 pixel uzaða
    k.X = sbdevent.Bounds.Left + 30;
    //mavi dikdörtgen çiz
    sbdevent.Graphics.FillRectangle(Brushes.Blue, k);
    //yüzdeliðin geniþliðini bul
    k.Width = (int) ((sbdevent.Bounds.Width - 30) * (1 - yüzdeler[sbdevent.Index] / 100));
    //dolu kýsým için kýrmýzý dikdörtgen çiz
    sbdevent.Graphics.FillRectangle(Brushes.Red, k);
    //Yüzde oranýný beyaz renkle yaz
    sbdevent.Graphics.DrawString("%" + ((int)yüzdeler[sbdevent.Index]).ToString() + 
     " boþ", 
     new Font("Tahoma", 8, FontStyle.Bold), 
     Brushes.White, 
     sbdevent.Bounds.Left + 30, 
     sbdevent.Bounds.Top);
   }
   else //saat paneli
   {
    sbdevent.Graphics.DrawRectangle(new Pen(Color.Red), k);
    float xorta, yorta, çap, sx, sy;
    xorta = k.Left + k.Width / 2;
    yorta = k.Top + k.Height / 2;
    if (k.Width > k.Height)
     çap = k.Height / 2;
    else
     çap = k.Width / 2;
    int aci, saniye, dakika, saat;

    saat = DateTime.Now.Hour; //saati al
    aci = -saat * 30 + 90; //her saat 30 derecedir. 
    //360 derece / 12 saat = 30
    sx = (float) (xorta + çap * 2 / 3 * Math.Cos(aci * 3.1415 / 180));
    sy = (float) (yorta - çap * 2 / 3 * Math.Sin(aci * 3.1415 / 180));
    sbdevent.Graphics.DrawLine(new Pen(Color.Red, 2), 
     xorta, yorta, sx, sy);

    dakika = DateTime.Now.Minute; //dakikayý saatten al
    aci = -dakika * 6 + 90; //her bir dakika 6 derecedir.360 derece/60dakika
    sx = (float) (xorta + çap * Math.Cos(aci * 3.1415 / 180));
    sy = (float) (yorta - çap * Math.Sin(aci * 3.1415 / 180));
    sbdevent.Graphics.DrawLine(new Pen(Color.Blue, 2), 
     xorta, yorta, sx, sy);

    saniye = DateTime.Now.Second; //saniyeyi saatten al
    aci = -saniye * 6 + 90; //her bir saniye 6 derecedir.360 derece/60saniye
    sx = (float) (xorta + çap * Math.Cos(aci * 3.1415 / 180));
    sy = (float) (yorta - çap * Math.Sin(aci * 3.1415 / 180));
    sbdevent.Graphics.DrawLine(new Pen(Color.Black, 1), 
     xorta, yorta, sx, sy);
   }
  }

  private void timer1_Tick(object sender, System.EventArgs e)
  {
     //son panele saati yaz
   statusBar1.Panels[yüzdeler.Length].Text = DateTime.UtcNow.ToString();
  }
	}
}
