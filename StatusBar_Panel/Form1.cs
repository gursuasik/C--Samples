using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;//bunu kodun en baþýna yazýn
namespace StatusBar_Panel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.StatusBar statusBar1;
  internal System.Windows.Forms.StatusBarPanel StatusBarPanel1;
  internal System.Windows.Forms.StatusBarPanel StatusBarPanel2;
  internal System.Windows.Forms.StatusBarPanel StatusBarPanel3;
  internal System.Windows.Forms.StatusBarPanel StatusBarPanel4;
  internal System.Windows.Forms.Timer timer1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.statusBar1 = new System.Windows.Forms.StatusBar();
   this.StatusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
   this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
   this.StatusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
   this.StatusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).BeginInit();
   this.SuspendLayout();
   // 
   // statusBar1
   // 
   this.statusBar1.Location = new System.Drawing.Point(0, 240);
   this.statusBar1.Name = "statusBar1";
   this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
                                                                              this.StatusBarPanel1,
                                                                              this.StatusBarPanel2,
                                                                              this.StatusBarPanel3,
                                                                              this.StatusBarPanel4});
   this.statusBar1.ShowPanels = true;
   this.statusBar1.Size = new System.Drawing.Size(616, 22);
   this.statusBar1.TabIndex = 3;
   this.statusBar1.Text = "StatusBar1";
   // 
   // StatusBarPanel1
   // 
   this.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
   this.StatusBarPanel1.Icon = ((System.Drawing.Icon)(resources.GetObject("StatusBarPanel1.Icon")));
   this.StatusBarPanel1.Text = "Disk Kapasitesi";
   this.StatusBarPanel1.Width = 113;
   // 
   // StatusBarPanel2
   // 
   this.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
   this.StatusBarPanel2.Icon = ((System.Drawing.Icon)(resources.GetObject("StatusBarPanel2.Icon")));
   this.StatusBarPanel2.Text = "Ekran Çözünürlüðü";
   this.StatusBarPanel2.Width = 132;
   // 
   // StatusBarPanel3
   // 
   this.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
   this.StatusBarPanel3.Icon = ((System.Drawing.Icon)(resources.GetObject("StatusBarPanel3.Icon")));
   this.StatusBarPanel3.Text = "Tuþlarýn Durumu";
   this.StatusBarPanel3.Width = 297;
   // 
   // StatusBarPanel4
   // 
   this.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
   this.StatusBarPanel4.Icon = ((System.Drawing.Icon)(resources.GetObject("StatusBarPanel4.Icon")));
   this.StatusBarPanel4.Text = "Saat";
   this.StatusBarPanel4.ToolTipText = "Saat";
   this.StatusBarPanel4.Width = 58;
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(616, 262);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.statusBar1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).EndInit();
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
  public static extern int GetDiskFreeSpaceExA(string lpRootPathName, 
                                               ref long lpFreeBytesAvailableToCaller, 
                                               ref long lpTotalNumberOfBytes, 
                                               ref long lpTotalNumberOfFreeBytes);
  
  private void Form1_Load(object sender, System.EventArgs e)
  {
   this.KeyPreview = true;
   timer1.Interval = 1000;
   timer1.Enabled = true;
   statusBar1.Panels[0].ToolTipText = "Disk Kapasitesi";
   statusBar1.Panels[1].ToolTipText = "Ekran çözünürlüðü";
   statusBar1.Panels[2].ToolTipText = "Basýlý tuþ";
   statusBar1.Panels[3].ToolTipText = "Saat";

   //Sistemdeki sürücülerin kapasitesini ilk panele ekle
   long x=0, y=0, z=0;
   string s="";
   string[] sürücüler = System.IO.Directory.GetLogicalDrives();
   int i;
   for (i = 0 ; i<= sürücüler.GetUpperBound(0); i++)
   {
    y=0;
    GetDiskFreeSpaceExA(sürücüler[i], ref x, ref y, ref z);
    if (y>1024*1024*1024)
     s += sürücüler[i] + "=" + (y / 1024 / 1024 / 1024).ToString() + "GB" + " ";
    else
     s += sürücüler[i] + "=" + (y / 1024 / 1024).ToString() + "MB" + " ";
   }
   statusBar1.Panels[0].Text = s;

   //Ekran koordinatlarýný ikinci panele ekle
   Rectangle r = new Rectangle();
   r = Screen.GetBounds(r);
   statusBar1.Panels[1].Text = r.Width.ToString() + "x" + r.Height.ToString();
  }

  private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   //Basýlan tuþu üçüncü panele ekle
   statusBar1.Panels[2].Text = e.KeyData.ToString();
  }

  private void timer1_Tick(object sender, System.EventArgs e)
  {
   //Saati son panele ekle
   statusBar1.Panels[3].Text = DateTime.Now.TimeOfDay.ToString();
  }
	}
}
