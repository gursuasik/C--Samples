using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dosyalama_AçKaydet
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right);
   this.textBox1.Location = new System.Drawing.Point(8, 16);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(288, 224);
   this.textBox1.TabIndex = 3;
   this.textBox1.Text = "TextBox1";
   // 
   // saveFileDialog1
   // 
   this.saveFileDialog1.FileName = "doc1";
   // 
   // button2
   // 
   this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button2.Location = new System.Drawing.Point(216, 248);
   this.button2.Name = "button2";
   this.button2.TabIndex = 5;
   this.button2.Text = "Kaydet";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 248);
   this.button1.Name = "button1";
   this.button1.TabIndex = 4;
   this.button1.Text = "Dosya Aç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(304, 278);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox1,
                                                              this.button2});
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
   openFileDialog1.Filter = "Metin dosyalarý|*.txt|" +
    "Bütün dosyalar|*.*";
   openFileDialog1.Title = "Açýlacak dosyayý seçiniz";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    string dosya_adý;
    dosya_adý = openFileDialog1.FileName;
    System.IO.TextReader dosya = System.IO.File.OpenText(dosya_adý);
    string x;
    x=dosya.ReadToEnd();
    dosya.Close();
    //okunan bilgileri textBox1 içine aktar
    textBox1.Text = x;
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   saveFileDialog1.Title = "Kaydetmek için bir ad girin";
   saveFileDialog1.Filter = "Metin dosyalarý|*.txt|" +
    "Bütün dosyalar|*.*";
   saveFileDialog1.DefaultExt = "txt";
   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
   {
    string dosya_adý;
    dosya_adý = saveFileDialog1.FileName;
    System.IO.TextWriter dosya=System.IO.File.CreateText(dosya_adý);
    //textBox içeriðini dosyaya yaz
    dosya.Write(textBox1.Text);
    //Dosyayý kapat
    dosya.Close();
   }
  }
 }
}
