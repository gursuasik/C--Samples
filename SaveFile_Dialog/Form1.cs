using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SaveFile_Dialog
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
  internal System.Windows.Forms.RichTextBox richTextBox1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
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
   this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
   this.richTextBox1 = new System.Windows.Forms.RichTextBox();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.SuspendLayout();
   // 
   // saveFileDialog1
   // 
   this.saveFileDialog1.FileName = "doc1";
   // 
   // richTextBox1
   // 
   this.richTextBox1.Location = new System.Drawing.Point(8, 8);
   this.richTextBox1.Name = "richTextBox1";
   this.richTextBox1.Size = new System.Drawing.Size(248, 232);
   this.richTextBox1.TabIndex = 7;
   this.richTextBox1.Text = "richTextBox1";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(168, 256);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(88, 23);
   this.button3.TabIndex = 6;
   this.button3.Text = "Farklý Kaydet";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(88, 256);
   this.button2.Name = "button2";
   this.button2.TabIndex = 5;
   this.button2.Text = "Kaydet";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 256);
   this.button1.Name = "button1";
   this.button1.TabIndex = 4;
   this.button1.Text = "Aç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(264, 286);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.richTextBox1,
                                                              this.button3});
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
   openFileDialog1.Filter = "RTF Dosyalarý|*.rtf|" +
    "Metin dosyalarý|*.txt|" +
    "Bütün Dosyalar|*.*";
   openFileDialog1.Title = "Açýlacak dosya";
   saveFileDialog1.Filter = openFileDialog1.Filter;
   saveFileDialog1.DefaultExt = "rtf";
   saveFileDialog1.Title = "Kaydedilecek dosya";
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Aç düðmesi
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    try //önce rtf olarak açmayý dene
    {
     richTextBox1.LoadFile(openFileDialog1.FileName, 
      RichTextBoxStreamType.RichText);
    }
    catch
    {
     try //olmazsa düz metin olarak açmayý dene
     {
      richTextBox1.LoadFile(openFileDialog1.FileName, 
       RichTextBoxStreamType.PlainText);
     }
     catch //o da olmazsa hata ver
     {
      MessageBox.Show(openFileDialog1.FileName + " Bu dosya açýlamadý");
     }
    }
  }                    

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Kaydet düðmesi
   if (openFileDialog1.FileName != "") //Bir dosya açýlmýþsa
    //ayný isimle kaydet
    richTextBox1.SaveFile(openFileDialog1.FileName, 
     RichTextBoxStreamType.RichText);
   else //dosya açýlmamýþsa
    //SaveDialog penceresi ile dosya adý sor
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    //O adla kaydet
    richTextBox1.SaveFile(saveFileDialog1.FileName, 
     RichTextBoxStreamType.RichText);
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   //Farklý kaydet düðmesi
   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    richTextBox1.SaveFile(saveFileDialog1.FileName, 
     RichTextBoxStreamType.RichText);
  }
 }
}
