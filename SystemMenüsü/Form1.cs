using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;//bunu kodun en baþýna yazýn
namespace SystemMenüsü
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
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);

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
  
  private System.Windows.Forms.OpenFileDialog openFileDialog1;

  //Api tanýmlarý
  [DllImport("user32.dll")]
  public static extern int AppendMenu(
   int hMenu,	
   int uFlags,	
   int uIDNewItem,	
   string lpNewItem	
   );
  [DllImport("user32.dll")]
  public static extern int GetSystemMenu(
   int hWnd,
   Boolean bRevert
   );
  //OpenFileDialog türünden public static deðiþkenimiz
  public static OpenFileDialog Dosya_Aç_Penceresi;

  private void Form1_Load(object sender, System.EventArgs e)
  {
   int Handle_No, tanitici1, tanitici2;
   tanitici1 = 10;
   tanitici2 = 20;
   Handle_No = GetSystemMenu((int)this.Handle, false);
   AppendMenu(Handle_No, 0, tanitici1, "Program Hakkýnda");
   AppendMenu(Handle_No, 0, tanitici2, "Çalýþtýr");
   //public static deðiþkenimize openFileDialog1 kontrolünü ata
   Dosya_Aç_Penceresi = openFileDialog1;
   Application.AddMessageFilter(new Mesaj_Ýþle());
  }
	}
}
