using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Modified
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(192, 24);
   this.Label1.TabIndex = 3;
   this.Label1.Text = "Bu text kutusuna yazdýðýnýz bilgiler bilgi.dat dosyasýna kaydedilir.";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 40);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(192, 152);
   this.textBox1.TabIndex = 2;
   this.textBox1.Text = "textBox1";
   this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(208, 198);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.textBox1});
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

  private void textBox1_TextChanged(object sender, System.EventArgs e)
  {
  
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox1.Text="";
   //Bilgi.dat dosyasýndaki satýrlarý textBox1 içine al
   try
   {
    System.IO.TextReader dosya = System.IO.File.OpenText("bilgi.dat");
    string satýr;
    while((satýr = dosya.ReadLine())!= null)
     textBox1.Text+=satýr+(char)13+(char)10;
    dosya.Close();
   }
   catch
   {
     ;
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   if (textBox1.Modified==true) //Bilgi deðiþtirildiyse
   {
    DialogResult c;
    c = MessageBox.Show("Deðiþiklikler kaydedilsin mi","Çýkýþ",MessageBoxButtons.YesNo );
     if (c == DialogResult.Yes) //Evet seçildiyse
     {
      //textBox1 içindeki bilgileri bilgi.dat içine yaz
      System.IO.TextWriter dosya = System.IO.File.CreateText("bilgi.dat");
      dosya.Write(textBox1.Text);
      dosya.Close();
     }
   }
  }
	}
}
