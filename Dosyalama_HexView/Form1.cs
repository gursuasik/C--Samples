using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dosyalama_HexView
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  private System.Windows.Forms.OpenFileDialog openFileDialog1;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.VScrollBar vScrollBar1;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label6;
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
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
   this.button1 = new System.Windows.Forms.Button();
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(264, 32);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(176, 192);
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(8, 32);
   this.textBox2.Multiline = true;
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(248, 192);
   this.textBox2.TabIndex = 1;
   this.textBox2.Text = "textBox2";
   // 
   // vScrollBar1
   // 
   this.vScrollBar1.Location = new System.Drawing.Point(448, 32);
   this.vScrollBar1.Name = "vScrollBar1";
   this.vScrollBar1.Size = new System.Drawing.Size(32, 192);
   this.vScrollBar1.TabIndex = 2;
   this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
   this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 232);
   this.button1.Name = "button1";
   this.button1.TabIndex = 3;
   this.button1.Text = "Dosya Aç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.TabIndex = 4;
   this.label1.Text = "Hex Kodlarý";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(264, 8);
   this.label2.Name = "label2";
   this.label2.TabIndex = 5;
   this.label2.Text = "Karakterler";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(112, 232);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(48, 23);
   this.label3.TabIndex = 6;
   this.label3.Text = "Boyut:";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(176, 232);
   this.label4.Name = "label4";
   this.label4.TabIndex = 7;
   this.label4.Text = "label4";
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(288, 232);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(40, 23);
   this.label5.TabIndex = 8;
   this.label5.Text = "Konum:";
   // 
   // label6
   // 
   this.label6.Location = new System.Drawing.Point(336, 232);
   this.label6.Name = "label6";
   this.label6.TabIndex = 9;
   this.label6.Text = "label6";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(488, 270);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label6,
                                                              this.label5,
                                                              this.label4,
                                                              this.label3,
                                                              this.label2,
                                                              this.label1,
                                                              this.button1,
                                                              this.vScrollBar1,
                                                              this.textBox2,
                                                              this.textBox1});
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
  //Global deðiþkenlerimiz
  System.IO.FileStream fs ;
  System.IO.BinaryReader dosya ;

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Text kutularýnda kaydýrma çubuðu görüntülenmesin
   textBox1.ScrollBars=ScrollBars.None;
   textBox2.ScrollBars=ScrollBars.None;
   //Text kutularý deðiþtirilemesin
   textBox1.ReadOnly=true;
   textBox2.ReadOnly=true;
   //Düzgün görünmesi için Courier New fontunu seç
   textBox1.Font=new Font("Courier New",10,FontStyle.Regular );
   textBox2.Font=textBox1.Font;
   //Seçili bölgeleri gizleme
   textBox1.HideSelection=false;
   textBox2.HideSelection=false;
   
   vScrollBar1.SmallChange=10;
   vScrollBar1.LargeChange=100;
  }

  private void oku(int Baþlangýç)
  {
   byte [] d = new byte[100];
   fs.Seek(Baþlangýç,System.IO.SeekOrigin.Begin);
   //100 baytý oku
   d=dosya.ReadBytes(100);
   System.Text.ASCIIEncoding çevirici = new System.Text.ASCIIEncoding();
   string s;
   //okunan bilgileri stringe çevir
   s = çevirici.GetString(d);
   int i;
   textBox1.Text="";
   textBox2.Text="";
   for(i=0;i<=s.Length-1;i++)
   {
    if ((i % 10)==0) //Her 10 karakterde bir alt satýra geç
    {
     textBox1.Text=textBox1.Text+"\r\n";
     textBox2.Text=textBox2.Text+"\r\n";
    }
    textBox1.Text=textBox1.Text+" "+s[i];
    textBox2.Text=textBox2.Text+" "+((int)((char) s[i])).ToString("X2");
   }
  }
  private void button1_Click(object sender, System.EventArgs e)
  {
   //dosya.Close();
   //fs.Close();
   openFileDialog1.Filter = "Bütün dosyalar|*.*";
   openFileDialog1.Title  = "Açýlacak dosyayý seçiniz";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    fs = new  System.IO.FileStream(openFileDialog1.FileName ,
     System.IO.FileMode.Open);
    dosya = new System.IO.BinaryReader(fs);
    this.Text=openFileDialog1.FileName;
    vScrollBar1.Maximum=(int)(new System.IO.FileInfo(openFileDialog1.FileName)).Length;
    label4.Text=vScrollBar1.Maximum.ToString();
    label6.Text="0";
    vScrollBar1.Value=0;
    oku(0);//Baþtan 100 karakteri okut
   }
  }

  private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
  {
   oku(vScrollBar1.Value);
   label6.Text=vScrollBar1.Value.ToString();
  }

  private void vScrollBar1_ValueChanged(object sender, System.EventArgs e)
  {
   oku(vScrollBar1.Value);
   label6.Text=vScrollBar1.Value.ToString();
  }
 }
}
