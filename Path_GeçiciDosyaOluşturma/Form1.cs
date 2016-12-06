using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace Path_GeçiciDosyaOluþturma
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
   string geçici_dosya_adý = System.IO.Path.GetTempFileName();
   MessageBox.Show(geçici_dosya_adý + " dosyasý oluþturuldu");
   FileInfo fileInfo = new FileInfo(geçici_dosya_adý);
   FileStream f = new FileStream(geçici_dosya_adý, FileMode.Open);
   StreamWriter s = new StreamWriter(f);
   s.WriteLine("Lüzumsuz bir bilgi");
   s.WriteLine("Bu da lüzumsuz bir bilgi");
   s.Close();
   f.Close();
   fileInfo.Refresh();
   MessageBox.Show("Geçici dosyaya birþeyler yazýldý");
   //Not defteri ile geçici dosyayý göster
   System.Diagnostics.Process.Start("notepad.exe" , geçici_dosya_adý);
   MessageBox.Show("Þimdi silinecek");
   fileInfo.Delete();//Sil
   MessageBox.Show("Geçici dosyaya silindi");
  }
	}
}
