using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Array_DiziÝþlemleri
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button5;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label1;
  private System.Windows.Forms.TextBox textBox2;
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
   this.button5 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button5
   // 
   this.button5.Location = new System.Drawing.Point(384, 72);
   this.button5.Name = "button5";
   this.button5.TabIndex = 14;
   this.button5.Text = "Ters Çevir";
   this.button5.Click += new System.EventHandler(this.button5_Click);
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(224, 72);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(152, 23);
   this.button4.TabIndex = 13;
   this.button4.Text = "Dizi Elemanlarýný Göster";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(384, 40);
   this.button3.Name = "button3";
   this.button3.TabIndex = 12;
   this.button3.Text = "Bul";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(384, 8);
   this.button2.Name = "button2";
   this.button2.TabIndex = 11;
   this.button2.Text = "Sýrala";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(224, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(152, 23);
   this.button1.TabIndex = 10;
   this.button1.Text = "Diziye Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 9;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 8;
   this.Label1.Text = "Adý Soyadý";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(224, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(152, 20);
   this.textBox2.TabIndex = 15;
   this.textBox2.Text = "textBox2";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(472, 246);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox2,
                                                              this.button5,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1,
                                                              this.Label1});
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

  //10 elemanlý dizi tanýmla
  string [] ad = new string[10];
  int sýra_no;

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Text kutusundaki bilgiyi diziye aktar
   ad[sýra_no] = textBox1.Text;
   sýra_no += 1; //Bir sonraki elemanýn numarasý
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Diziyi sýrala
   Array.Sort(ad);
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   //Aranan kiþiyi bul
   string aranan;
   int yer;
   aranan = textBox2.Text;
   yer = Array.IndexOf(ad, aranan);
   while (yer >= 0)
   {
    MessageBox.Show(aranan + " kiþi listede " + yer.ToString() + ".sýrada");
    yer = Array.IndexOf(ad, aranan, yer + 1);
   }
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   //Dizideki elemanlarý forma yazdýr
   Graphics g;
   g = this.CreateGraphics();
   g.Clear(this.BackColor);//zemini sil
   int i;
   for (i = 0 ; i <= ad.GetLength(0) - 1 ; i++)
    g.DrawString(ad[i], new Font("Tahoma", 8, FontStyle.Regular), 
     new SolidBrush(Color.Red), 10, 30 + i * 10);
  }

  private void button5_Click(object sender, System.EventArgs e)
  {
   //Diziyi ters çevir
   Array.Reverse(ad);
  }
 }
}
