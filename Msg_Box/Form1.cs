using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Msg_Box
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(152, 112);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(96, 23);
   this.button4.TabIndex = 16;
   this.button4.Text = "Uzun Bir Mesaj";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(152, 72);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(96, 23);
   this.button3.TabIndex = 15;
   this.button3.Text = "Uzun Bir Hesap";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(152, 40);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(96, 23);
   this.button2.TabIndex = 14;
   this.button2.Text = "Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(152, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 13;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 40);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(120, 121);
   this.listBox1.TabIndex = 12;
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(120, 20);
   this.textBox1.TabIndex = 11;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(256, 174);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.listBox1,
                                                              this.textBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
   if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
   {
    DialogResult c;
    c = MessageBox.Show("Bu eleman zaten listede var. Tekrar ekleyeyim mi?", "Eleman Var",
     MessageBoxButtons.YesNo,MessageBoxIcon.Information);
    if (c == DialogResult.Yes)
    {
     listBox1.Items.Add(textBox1.Text);
    }
   }
   else
    listBox1.Items.Add(textBox1.Text);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   if (listBox1.SelectedIndex < 0)
    MessageBox.Show("Sileceðiniz elemaný seçin", "Seçmediniz",
     MessageBoxButtons.OK,MessageBoxIcon.Information);
   else
   {
    DialogResult c;
    c = MessageBox.Show("Bu elemaný silmek istediðinize emin misiniz?", "Eleman Silme",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    if (c == DialogResult.Yes)
     listBox1.Items.Remove(listBox1.SelectedItem);
   }
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   DialogResult cevap;
   cevap = MessageBox.Show("Bu iþlem çok uzun sürecek. Devam edeyim mi", "Çok uzun bir iþlem",
    MessageBoxButtons.YesNo,MessageBoxIcon.Information);
   if (cevap == DialogResult.Yes)
   {
    int i;
    long toplam=0;
    for (i = 1 ; i<= 1000000000 ; i++)
     toplam += i;
    MessageBox.Show("Sonuç: " + toplam.ToString(),  "Toplam", MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   DialogResult cevap;
   cevap = MessageBox.Show("Program kapanacak", "Çýkýþ",
    MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
   if (cevap == DialogResult.Cancel)
    e.Cancel = true; //Çýkýþý durdur
   else
    MessageBox.Show("Hoþçakalýn", "Program bitti", MessageBoxButtons.OK,MessageBoxIcon.Information);
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   MessageBox.Show("Bir sorun var. Dosyalar Silinemedi. Olasý sebepler:\r\n" +
     "Sürücüde disket olmayabilir\r\n" +
     "Ana klasörde dosya olmayabilir\r\n" +
     "Disketin proteði kapalý olabilir\r\n" +
     "Silinen dosyayý bir program kullanýyor olabilir\r\n" +
     "Bilgisayarýnýzda disket sürücü olmayabilir", 
    "Sorun Çýktý",
    MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation
    );
  }
 }                                                                                                                                                                     
}
                                                                                                                                                                        
