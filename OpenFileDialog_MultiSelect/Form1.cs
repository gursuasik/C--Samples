using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OpenFileDialog_MultiSelect
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Timer timer1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog2;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.PictureBox pictureBox1;
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
   this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
   this.button2 = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.button1 = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // openFileDialog2
   // 
   this.openFileDialog2.HelpRequest += new System.EventHandler(this.openFileDialog2_HelpRequest);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(104, 8);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(88, 23);
   this.button2.TabIndex = 5;
   this.button2.Text = "Dosya Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // openFileDialog1
   // 
   this.openFileDialog1.HelpRequest += new System.EventHandler(this.openFileDialog1_HelpRequest);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(88, 23);
   this.button1.TabIndex = 4;
   this.button1.Text = "Resim Show";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // pictureBox1
   // 
   this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.pictureBox1.Location = new System.Drawing.Point(8, 40);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(376, 280);
   this.pictureBox1.TabIndex = 3;
   this.pictureBox1.TabStop = false;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(392, 326);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.pictureBox1});
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
   timer1.Enabled = false;
   timer1.Interval = 1000;
   pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

   openFileDialog1.ShowHelp = true;
   openFileDialog1.Filter = "Resimler|*.GIF;*.BMP;*.JPG;*.WMF;*.PNG;*.ICO";
   openFileDialog1.Title = "Gösterilecek resimleri seçiniz";
   openFileDialog1.Multiselect = true;
  
   openFileDialog2.ShowHelp = true;
   openFileDialog2.Filter = "Geçici dosyalar|*.TMP;*.~*;~*.*|" + 
    "Bütün dosyalar|*.*";
   openFileDialog2.Title = "Sileceðiniz dosyalarý seçiniz";
   openFileDialog2.Multiselect = true;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    timer1.Enabled = true;
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   if (openFileDialog2.ShowDialog() == DialogResult.OK)
   {
    DialogResult c;
    c = MessageBox.Show("Dikkat! Seçtiðiniz bütün dosyalar silinecek","Dikkat",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2 );
    if (c == DialogResult.OK)
    {
     int i;
     for (i = 0 ; i<= openFileDialog2.FileNames.Length - 1 ; i++)
      try
      {
       System.IO.FileInfo dosya = new System.IO.FileInfo(openFileDialog2.FileNames[i]);
       dosya.Delete();
      }
      catch
      {
       MessageBox.Show(openFileDialog2.FileNames[i] + " Bu dosya silinemedi");
      }
    }
   }
  }
  
  int say=0;
  private void timer1_Tick(object sender, System.EventArgs e)
  {
   say++;
   say = say % openFileDialog1.FileNames.Length;
   try
   {
    pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[say]);
    this.Text = openFileDialog1.FileNames[say];
   }
   catch
   {
    this.Text = openFileDialog1.FileNames[say] + " dosyasý geçersiz";
   }
  }

  private void openFileDialog1_HelpRequest(object sender, System.EventArgs e)
  {
   MessageBox.Show("Gösterilecek resimleri seçiniz.\r\n"+
    "Birden fazla resmi seçmek için " + 
    "Shift veya Ctrl tuþlarýný basýlý tutunuz");
  }

  private void openFileDialog2_HelpRequest(object sender, System.EventArgs e)
  {
   MessageBox.Show("Silinecek dosyalarý seçiniz. \r\n"+
    "Birden fazla resmi seçmek için " + 
    "Shift veya Ctrl tuþlarýný basýlý tutunuz");
  }
 }
}
