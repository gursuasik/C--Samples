using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace Path_Ge�iciDosyaOlu�turma
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   string ge�ici_dosya_ad� = System.IO.Path.GetTempFileName();
   MessageBox.Show(ge�ici_dosya_ad� + " dosyas� olu�turuldu");
   FileInfo fileInfo = new FileInfo(ge�ici_dosya_ad�);
   FileStream f = new FileStream(ge�ici_dosya_ad�, FileMode.Open);
   StreamWriter s = new StreamWriter(f);
   s.WriteLine("L�zumsuz bir bilgi");
   s.WriteLine("Bu da l�zumsuz bir bilgi");
   s.Close();
   f.Close();
   fileInfo.Refresh();
   MessageBox.Show("Ge�ici dosyaya bir�eyler yaz�ld�");
   //Not defteri ile ge�ici dosyay� g�ster
   System.Diagnostics.Process.Start("notepad.exe" , ge�ici_dosya_ad�);
   MessageBox.Show("�imdi silinecek");
   fileInfo.Delete();//Sil
   MessageBox.Show("Ge�ici dosyaya silindi");
  }
	}
}
