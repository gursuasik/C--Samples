using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListBox_DosyaKlasörListesi
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ImageList ýmageList1;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label label2;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.Label1 = new System.Windows.Forms.Label();
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(56, 16);
   this.Label1.TabIndex = 13;
   this.Label1.Text = "Klasör";
   // 
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.ýmageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList1.ImageStream")));
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(72, 40);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(184, 199);
   this.listBox1.TabIndex = 12;
   this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
   this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
   this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(208, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(48, 24);
   this.button1.TabIndex = 11;
   this.button1.Text = "Listele:";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(72, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(128, 20);
   this.textBox1.TabIndex = 10;
   this.textBox1.Text = "textBox1";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(72, 248);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(192, 16);
   this.label2.TabIndex = 14;
   this.label2.Text = "Label2";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(264, 278);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.listBox1,
                                                              this.button1,
                                                              this.textBox1,
                                                              this.label2,
                                                              this.Label1});
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

  void listele(string yol)
  {
   System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(yol);
   if (d.Exists==false)
    MessageBox.Show("Bu klasör bulunamadý");
   else
   {
    listBox1.Items.Clear();
    System.IO.FileSystemInfo[] dosyalar;
    dosyalar = new System.IO.DirectoryInfo(yol).GetFileSystemInfos();
    listBox1.Items.AddRange(dosyalar);
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   listBox1.DrawMode = DrawMode.OwnerDrawFixed;
   listBox1.ItemHeight = 18;
   textBox1.Text = "c:\\";
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   listele(textBox1.Text);
  }

  private void listBox1_DoubleClick(object sender, System.EventArgs e)
  {
   if (listBox1.SelectedIndex >= 0)
   {
    //Listedeki dosya veya klasörü al
    System.IO.FileSystemInfo seçili = (System.IO.FileSystemInfo) listBox1.SelectedItem;
    if ((seçili.Attributes & System.IO.FileAttributes.Directory) > 0)
     //Seçili eleman klasörse o klasörü listele
     listele(seçili.FullName);
    else
     //Klasör deðilse özelliklerini göster
     MessageBox.Show("Dosya Adý: " + seçili.FullName + "\r\n" + 
      "Oluþturulma Tarihi:" + seçili.CreationTime + "\r\n" + 
      "Deðiþtirilme Tarihi:" + seçili.LastWriteTime + "\r\n" + 
      "Son Kullanýldýðý Tarih:" + seçili.LastAccessTime);
   }
  }

  private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   if (listBox1.SelectedIndex >= 0)
    label2.Text = ((System.IO.FileSystemInfo)listBox1.SelectedItem).FullName;
  }

  private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   if (e.Index < 0) 
    return;
   //Seçili bölgeyi oluþtur
   e.DrawBackground();
   e.DrawFocusRectangle();

   //Listedeki dosya veya klasörü al
   System.IO.FileSystemInfo seçili = (System.IO.FileSystemInfo ) listBox1.Items[e.Index];

   //Klasörse ilk resmi, deðilse ikinci resmi çiz
   if ((seçili.Attributes & System.IO.FileAttributes.Directory) > 0)
    ýmageList1.Draw(e.Graphics, e.Bounds.X, e.Bounds.Y, 0);
   else
    ýmageList1.Draw(e.Graphics, e.Bounds.X, e.Bounds.Y, 1);
  
   //Resmin yanýna metni yaz
   e.Graphics.DrawString(seçili.Name, listBox1.Font, 
    Brushes.Black, 20, e.Bounds.Y);
  }
 }
}
