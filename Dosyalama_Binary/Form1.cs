using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dosyalama_Binary
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ProgressBar progressBar1;
  internal System.Windows.Forms.Label label3;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.Label label1;
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
   this.progressBar1 = new System.Windows.Forms.ProgressBar();
   this.label3 = new System.Windows.Forms.Label();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
   this.button1 = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // progressBar1
   // 
   this.progressBar1.Location = new System.Drawing.Point(16, 96);
   this.progressBar1.Name = "progressBar1";
   this.progressBar1.Size = new System.Drawing.Size(280, 23);
   this.progressBar1.TabIndex = 8;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(16, 72);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(38, 13);
   this.label3.TabIndex = 7;
   this.label3.Text = "Label3";
   // 
   // saveFileDialog1
   // 
   this.saveFileDialog1.FileName = "doc1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(112, 128);
   this.button1.Name = "button1";
   this.button1.TabIndex = 9;
   this.button1.Text = "Þifrele/Çöz";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(16, 40);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(38, 13);
   this.label2.TabIndex = 6;
   this.label2.Text = "Label2";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(16, 8);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(38, 13);
   this.label1.TabIndex = 5;
   this.label1.Text = "Label1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(312, 158);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.label2,
                                                              this.label1,
                                                              this.progressBar1,
                                                              this.label3});
   this.Name = "Form1";
   this.Text = "Form1";
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   byte k, c;
   long i,boyut;
   button1.Enabled = false;
   openFileDialog1.Title = "Açýlacak Dosyayý Seçin";
   saveFileDialog1.Title = "Oluþturulacak Dosyayý Yazýn";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
     label1.Text = "Orjinal dosya: " + openFileDialog1.FileName;
     System.IO.FileStream fs1 = new 
      System.IO.FileStream(openFileDialog1.FileName ,
      System.IO.FileMode.Open);
     System.IO.BinaryReader dosya1 = new System.IO.BinaryReader(fs1);
     label2.Text = "Oluþturulan dosya: " + saveFileDialog1.FileName;
     System.IO.FileStream fs2 = new 
      System.IO.FileStream(saveFileDialog1.FileName ,
      System.IO.FileMode.CreateNew);
     System.IO.BinaryWriter dosya2 = new System.IO.BinaryWriter(fs2);
     boyut=(new System.IO.FileInfo(openFileDialog1.FileName)).Length;
     progressBar1.Maximum = (int) boyut / 100;
     label3.Text = "Dosya Boyutu:" + boyut.ToString();
     for (i = 1 ; i<=boyut; i++)
     {
      c=dosya1.ReadByte();
      if ((i % 3) == 0)
       k = (byte) ~c;
      else
       k = c;
      if ((i % 100) == 0)
      {
       progressBar1.Value = (int) i / 100;
       Application.DoEvents();
      }
      dosya2.Write(k);
     }
     dosya1.Close();
     dosya2.Close();
     fs1.Close();
     fs2.Close();
    }
   button1.Enabled = true;
  }
	}
}
