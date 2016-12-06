using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RichTextBox_KelimeIslemci
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.MenuItem MenuItem34;
  internal System.Windows.Forms.MenuItem Mn_��k��;
  internal System.Windows.Forms.MenuItem Mn_Farkl�Kaydet;
  internal System.Windows.Forms.MenuItem MenuItem6;
  internal System.Windows.Forms.MenuItem Mn_Madde��areti;
  internal System.Windows.Forms.MenuItem MenuItem25;
  internal System.Windows.Forms.MenuItem Mn_Yinele;
  internal System.Windows.Forms.ToolBar toolBar1;
  internal System.Windows.Forms.MenuItem Mn_D�zen;
  internal System.Windows.Forms.MenuItem Mn_GeriAl;
  internal System.Windows.Forms.MenuItem MenuItem11;
  internal System.Windows.Forms.MenuItem Mn_Kes;
  internal System.Windows.Forms.MenuItem Mn_Kopyala;
  internal System.Windows.Forms.MenuItem Mn_Yap��t�r;
  internal System.Windows.Forms.MenuItem Mn_Sil;
  internal System.Windows.Forms.MenuItem MenuItem16;
  internal System.Windows.Forms.MenuItem Mn_Bul;
  internal System.Windows.Forms.ImageList �mageList1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.MenuItem Mn_�stSimge;
  internal System.Windows.Forms.ColorDialog colorDialog1;
  internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
  internal System.Windows.Forms.MenuItem Mn_Kaydet;
  internal System.Windows.Forms.MenuItem Mn_Kal�n;
  internal System.Windows.Forms.MenuItem Mn_A�;
  internal System.Windows.Forms.MenuItem Mn_Ortaya;
  internal System.Windows.Forms.MenuItem Mn_Sa�a;
  internal System.Windows.Forms.MenuItem MenuItem1;
  internal System.Windows.Forms.MenuItem Mn_Yeni;
  internal System.Windows.Forms.MenuItem Mn_Yaz�tipi;
  internal System.Windows.Forms.MenuItem Mn_E�ik;
  internal System.Windows.Forms.MenuItem Mn_Alt��izili;
  internal System.Windows.Forms.MenuItem Mn_�st��izili;
  internal System.Windows.Forms.MenuItem MenuItem27;
  internal System.Windows.Forms.MenuItem Mn_AltSimge;
  internal System.Windows.Forms.MenuItem MenuItem23;
  internal System.Windows.Forms.MenuItem Mn_FontSe�;
  internal System.Windows.Forms.MenuItem Mn_RenkSe�;
  internal System.Windows.Forms.MenuItem Mn_Sola;
  internal System.Windows.Forms.MenuItem Mn_Paragraf;
  internal System.Windows.Forms.MainMenu mainMenu1;
  internal System.Windows.Forms.FontDialog fontDialog1;
  internal System.Windows.Forms.Panel Panel1;
  internal System.Windows.Forms.ComboBox comboBox4;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.ComboBox comboBox3;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.ComboBox comboBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Panel Panel2;
  internal System.Windows.Forms.ProgressBar progressBar1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.RichTextBox richTextBox1;
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
   this.MenuItem34 = new System.Windows.Forms.MenuItem();
   this.Mn_��k�� = new System.Windows.Forms.MenuItem();
   this.Mn_Farkl�Kaydet = new System.Windows.Forms.MenuItem();
   this.MenuItem6 = new System.Windows.Forms.MenuItem();
   this.Mn_Madde��areti = new System.Windows.Forms.MenuItem();
   this.MenuItem25 = new System.Windows.Forms.MenuItem();
   this.Mn_Yinele = new System.Windows.Forms.MenuItem();
   this.toolBar1 = new System.Windows.Forms.ToolBar();
   this.Mn_D�zen = new System.Windows.Forms.MenuItem();
   this.Mn_GeriAl = new System.Windows.Forms.MenuItem();
   this.MenuItem11 = new System.Windows.Forms.MenuItem();
   this.Mn_Kes = new System.Windows.Forms.MenuItem();
   this.Mn_Kopyala = new System.Windows.Forms.MenuItem();
   this.Mn_Yap��t�r = new System.Windows.Forms.MenuItem();
   this.Mn_Sil = new System.Windows.Forms.MenuItem();
   this.MenuItem16 = new System.Windows.Forms.MenuItem();
   this.Mn_Bul = new System.Windows.Forms.MenuItem();
   this.�mageList1 = new System.Windows.Forms.ImageList(this.components);
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.Mn_�stSimge = new System.Windows.Forms.MenuItem();
   this.colorDialog1 = new System.Windows.Forms.ColorDialog();
   this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
   this.Mn_Kaydet = new System.Windows.Forms.MenuItem();
   this.Mn_Kal�n = new System.Windows.Forms.MenuItem();
   this.Mn_A� = new System.Windows.Forms.MenuItem();
   this.Mn_Ortaya = new System.Windows.Forms.MenuItem();
   this.Mn_Sa�a = new System.Windows.Forms.MenuItem();
   this.MenuItem1 = new System.Windows.Forms.MenuItem();
   this.Mn_Yeni = new System.Windows.Forms.MenuItem();
   this.Mn_Yaz�tipi = new System.Windows.Forms.MenuItem();
   this.Mn_E�ik = new System.Windows.Forms.MenuItem();
   this.Mn_Alt��izili = new System.Windows.Forms.MenuItem();
   this.Mn_�st��izili = new System.Windows.Forms.MenuItem();
   this.MenuItem27 = new System.Windows.Forms.MenuItem();
   this.Mn_AltSimge = new System.Windows.Forms.MenuItem();
   this.MenuItem23 = new System.Windows.Forms.MenuItem();
   this.Mn_FontSe� = new System.Windows.Forms.MenuItem();
   this.Mn_RenkSe� = new System.Windows.Forms.MenuItem();
   this.Mn_Sola = new System.Windows.Forms.MenuItem();
   this.Mn_Paragraf = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.fontDialog1 = new System.Windows.Forms.FontDialog();
   this.Panel1 = new System.Windows.Forms.Panel();
   this.comboBox4 = new System.Windows.Forms.ComboBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.comboBox3 = new System.Windows.Forms.ComboBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.comboBox2 = new System.Windows.Forms.ComboBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.Panel2 = new System.Windows.Forms.Panel();
   this.progressBar1 = new System.Windows.Forms.ProgressBar();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.richTextBox1 = new System.Windows.Forms.RichTextBox();
   this.Panel1.SuspendLayout();
   this.Panel2.SuspendLayout();
   this.SuspendLayout();
   // 
   // MenuItem34
   // 
   this.MenuItem34.Index = 3;
   this.MenuItem34.Text = "-";
   // 
   // Mn_��k��
   // 
   this.Mn_��k��.Index = 5;
   this.Mn_��k��.Text = "Kapat";
   this.Mn_��k��.Click += new System.EventHandler(this.Mn_��k��_Click);
   // 
   // Mn_Farkl�Kaydet
   // 
   this.Mn_Farkl�Kaydet.Index = 3;
   this.Mn_Farkl�Kaydet.Text = "Farkl� Kaydet";
   this.Mn_Farkl�Kaydet.Click += new System.EventHandler(this.Mn_Farkl�Kaydet_Click);
   // 
   // MenuItem6
   // 
   this.MenuItem6.Index = 4;
   this.MenuItem6.Text = "-";
   // 
   // Mn_Madde��areti
   // 
   this.Mn_Madde��areti.Index = 4;
   this.Mn_Madde��areti.Text = "Madde ��areti";
   this.Mn_Madde��areti.Click += new System.EventHandler(this.Mn_Madde��areti_Click);
   // 
   // MenuItem25
   // 
   this.MenuItem25.Index = 9;
   this.MenuItem25.Text = "-";
   // 
   // Mn_Yinele
   // 
   this.Mn_Yinele.Index = 1;
   this.Mn_Yinele.Text = "Yinele";
   this.Mn_Yinele.Click += new System.EventHandler(this.Mn_Yinele_Click);
   // 
   // toolBar1
   // 
   this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
   this.toolBar1.Cursor = System.Windows.Forms.Cursors.Hand;
   this.toolBar1.DropDownArrows = true;
   this.toolBar1.Name = "toolBar1";
   this.toolBar1.ShowToolTips = true;
   this.toolBar1.Size = new System.Drawing.Size(568, 39);
   this.toolBar1.TabIndex = 102;
   this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
   // 
   // Mn_D�zen
   // 
   this.Mn_D�zen.Index = 1;
   this.Mn_D�zen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                         this.Mn_GeriAl,
                                                                         this.Mn_Yinele,
                                                                         this.MenuItem11,
                                                                         this.Mn_Kes,
                                                                         this.Mn_Kopyala,
                                                                         this.Mn_Yap��t�r,
                                                                         this.Mn_Sil,
                                                                         this.MenuItem16,
                                                                         this.Mn_Bul});
   this.Mn_D�zen.Text = "D�zen";
   this.Mn_D�zen.Select += new System.EventHandler(this.Mn_D�zen_Select);
   // 
   // Mn_GeriAl
   // 
   this.Mn_GeriAl.Index = 0;
   this.Mn_GeriAl.Text = "Geri Al";
   this.Mn_GeriAl.Click += new System.EventHandler(this.Mn_GeriAl_Click);
   // 
   // MenuItem11
   // 
   this.MenuItem11.Index = 2;
   this.MenuItem11.Text = "-";
   // 
   // Mn_Kes
   // 
   this.Mn_Kes.Index = 3;
   this.Mn_Kes.Text = "Kes";
   this.Mn_Kes.Click += new System.EventHandler(this.Mn_Kes_Click);
   // 
   // Mn_Kopyala
   // 
   this.Mn_Kopyala.Index = 4;
   this.Mn_Kopyala.Text = "Kopyala";
   this.Mn_Kopyala.Click += new System.EventHandler(this.Mn_Kopyala_Click);
   // 
   // Mn_Yap��t�r
   // 
   this.Mn_Yap��t�r.Index = 5;
   this.Mn_Yap��t�r.Text = "Yap��t�r";
   this.Mn_Yap��t�r.Click += new System.EventHandler(this.Mn_Yap��t�r_Click);
   // 
   // Mn_Sil
   // 
   this.Mn_Sil.Index = 6;
   this.Mn_Sil.Text = "Sil";
   this.Mn_Sil.Click += new System.EventHandler(this.Mn_Sil_Click);
   // 
   // MenuItem16
   // 
   this.MenuItem16.Index = 7;
   this.MenuItem16.Text = "-";
   // 
   // Mn_Bul
   // 
   this.Mn_Bul.Index = 8;
   this.Mn_Bul.Text = "Bul";
   this.Mn_Bul.Click += new System.EventHandler(this.Mn_Bul_Click);
   // 
   // �mageList1
   // 
   this.�mageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.�mageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.�mageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("�mageList1.ImageStream")));
   this.�mageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // Mn_�stSimge
   // 
   this.Mn_�stSimge.Index = 5;
   this.Mn_�stSimge.Text = "�st Simge";
   this.Mn_�stSimge.Click += new System.EventHandler(this.Mn_�stSimge_Click);
   // 
   // saveFileDialog1
   // 
   this.saveFileDialog1.FileName = "doc1";
   // 
   // Mn_Kaydet
   // 
   this.Mn_Kaydet.Index = 2;
   this.Mn_Kaydet.Text = "Kaydet";
   this.Mn_Kaydet.Click += new System.EventHandler(this.Mn_Kaydet_Click);
   // 
   // Mn_Kal�n
   // 
   this.Mn_Kal�n.Index = 0;
   this.Mn_Kal�n.Text = "Kal�n";
   this.Mn_Kal�n.Click += new System.EventHandler(this.Mn_Kal�n_Click);
   // 
   // Mn_A�
   // 
   this.Mn_A�.Index = 1;
   this.Mn_A�.Text = "A�";
   this.Mn_A�.Click += new System.EventHandler(this.Mn_A�_Click);
   // 
   // Mn_Ortaya
   // 
   this.Mn_Ortaya.Index = 1;
   this.Mn_Ortaya.Text = "Ortaya";
   this.Mn_Ortaya.Click += new System.EventHandler(this.Mn_Ortaya_Click);
   // 
   // Mn_Sa�a
   // 
   this.Mn_Sa�a.Index = 2;
   this.Mn_Sa�a.Text = "Sa�a";
   this.Mn_Sa�a.Click += new System.EventHandler(this.Mn_Sa�a_Click);
   // 
   // MenuItem1
   // 
   this.MenuItem1.Index = 0;
   this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Yeni,
                                                                          this.Mn_A�,
                                                                          this.Mn_Kaydet,
                                                                          this.Mn_Farkl�Kaydet,
                                                                          this.MenuItem6,
                                                                          this.Mn_��k��});
   this.MenuItem1.Text = "Dosya";
   // 
   // Mn_Yeni
   // 
   this.Mn_Yeni.Index = 0;
   this.Mn_Yeni.Text = "Yeni";
   this.Mn_Yeni.Click += new System.EventHandler(this.Mn_Yeni_Click);
   // 
   // Mn_Yaz�tipi
   // 
   this.Mn_Yaz�tipi.Index = 2;
   this.Mn_Yaz�tipi.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.Mn_Kal�n,
                                                                            this.Mn_E�ik,
                                                                            this.Mn_Alt��izili,
                                                                            this.Mn_�st��izili,
                                                                            this.MenuItem27,
                                                                            this.Mn_�stSimge,
                                                                            this.Mn_AltSimge,
                                                                            this.MenuItem23,
                                                                            this.Mn_FontSe�,
                                                                            this.MenuItem25,
                                                                            this.Mn_RenkSe�});
   this.Mn_Yaz�tipi.Text = "Yaz� Tipi";
   this.Mn_Yaz�tipi.Select += new System.EventHandler(this.Mn_Yaz�tipi_Select);
   // 
   // Mn_E�ik
   // 
   this.Mn_E�ik.Index = 1;
   this.Mn_E�ik.Text = "E�ik";
   this.Mn_E�ik.Click += new System.EventHandler(this.Mn_E�ik_Click);
   // 
   // Mn_Alt��izili
   // 
   this.Mn_Alt��izili.Index = 2;
   this.Mn_Alt��izili.Text = "Alt� �izili";
   this.Mn_Alt��izili.Click += new System.EventHandler(this.Mn_Alt��izili_Click);
   // 
   // Mn_�st��izili
   // 
   this.Mn_�st��izili.Index = 3;
   this.Mn_�st��izili.Text = "�st� �izili";
   this.Mn_�st��izili.Click += new System.EventHandler(this.Mn_�st��izili_Click);
   // 
   // MenuItem27
   // 
   this.MenuItem27.Index = 4;
   this.MenuItem27.Text = "-";
   // 
   // Mn_AltSimge
   // 
   this.Mn_AltSimge.Index = 6;
   this.Mn_AltSimge.Text = "Alt Simge";
   this.Mn_AltSimge.Click += new System.EventHandler(this.Mn_AltSimge_Click);
   // 
   // MenuItem23
   // 
   this.MenuItem23.Index = 7;
   this.MenuItem23.Text = "-";
   // 
   // Mn_FontSe�
   // 
   this.Mn_FontSe�.Index = 8;
   this.Mn_FontSe�.Text = "Font Se�";
   this.Mn_FontSe�.Click += new System.EventHandler(this.Mn_FontSe�_Click);
   // 
   // Mn_RenkSe�
   // 
   this.Mn_RenkSe�.Index = 10;
   this.Mn_RenkSe�.Text = "Renk Se�";
   this.Mn_RenkSe�.Click += new System.EventHandler(this.Mn_RenkSe�_Click);
   // 
   // Mn_Sola
   // 
   this.Mn_Sola.Index = 0;
   this.Mn_Sola.Text = "Sola";
   this.Mn_Sola.Click += new System.EventHandler(this.Mn_Sola_Click);
   // 
   // Mn_Paragraf
   // 
   this.Mn_Paragraf.Index = 3;
   this.Mn_Paragraf.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.Mn_Sola,
                                                                            this.Mn_Ortaya,
                                                                            this.Mn_Sa�a,
                                                                            this.MenuItem34,
                                                                            this.Mn_Madde��areti});
   this.Mn_Paragraf.Text = "Paragraf";
   this.Mn_Paragraf.Select += new System.EventHandler(this.Mn_Paragraf_Select);
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.MenuItem1,
                                                                          this.Mn_D�zen,
                                                                          this.Mn_Yaz�tipi,
                                                                          this.Mn_Paragraf});
   // 
   // Panel1
   // 
   this.Panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                     this.comboBox4,
                                                                     this.Label4,
                                                                     this.comboBox3,
                                                                     this.Label3,
                                                                     this.comboBox2,
                                                                     this.Label2,
                                                                     this.comboBox1,
                                                                     this.Label1});
   this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
   this.Panel1.Location = new System.Drawing.Point(0, 39);
   this.Panel1.Name = "Panel1";
   this.Panel1.Size = new System.Drawing.Size(568, 32);
   this.Panel1.TabIndex = 1041;
   // 
   // comboBox4
   // 
   this.comboBox4.Location = new System.Drawing.Point(472, 8);
   this.comboBox4.Name = "comboBox4";
   this.comboBox4.Size = new System.Drawing.Size(88, 21);
   this.comboBox4.TabIndex = 7;
   this.comboBox4.Text = "comboBox4";
   this.comboBox4.TextChanged += new System.EventHandler(this.comboBox4_TextChanged);
   // 
   // Label4
   // 
   this.Label4.AutoSize = true;
   this.Label4.Location = new System.Drawing.Point(440, 8);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(36, 13);
   this.Label4.TabIndex = 6;
   this.Label4.Text = "Zoom:";
   // 
   // comboBox3
   // 
   this.comboBox3.Location = new System.Drawing.Point(352, 8);
   this.comboBox3.Name = "comboBox3";
   this.comboBox3.Size = new System.Drawing.Size(80, 21);
   this.comboBox3.TabIndex = 5;
   this.comboBox3.Text = "comboBox3";
   this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
   this.comboBox3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox3_DrawItem);
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(320, 8);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(31, 13);
   this.Label3.TabIndex = 4;
   this.Label3.Text = "Renk";
   // 
   // comboBox2
   // 
   this.comboBox2.Location = new System.Drawing.Point(232, 8);
   this.comboBox2.Name = "comboBox2";
   this.comboBox2.Size = new System.Drawing.Size(80, 21);
   this.comboBox2.TabIndex = 3;
   this.comboBox2.Text = "comboBox2";
   this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(192, 8);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(33, 13);
   this.Label2.TabIndex = 2;
   this.Label2.Text = "Boyut";
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(64, 8);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(121, 21);
   this.comboBox1.TabIndex = 1;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   this.comboBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox1_MeasureItem);
   this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(48, 13);
   this.Label1.TabIndex = 0;
   this.Label1.Text = "Yaz� Tipi";
   // 
   // Panel2
   // 
   this.Panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                     this.progressBar1,
                                                                     this.button3,
                                                                     this.button2,
                                                                     this.button1});
   this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
   this.Panel2.Location = new System.Drawing.Point(0, 71);
   this.Panel2.Name = "Panel2";
   this.Panel2.Size = new System.Drawing.Size(568, 52);
   this.Panel2.TabIndex = 1042;
   // 
   // progressBar1
   // 
   this.progressBar1.Location = new System.Drawing.Point(8, 24);
   this.progressBar1.Name = "progressBar1";
   this.progressBar1.Size = new System.Drawing.Size(1600, 8);
   this.progressBar1.TabIndex = 3;
   this.progressBar1.Value = 100;
   // 
   // button3
   // 
   this.button3.Image = ((System.Drawing.Bitmap)(resources.GetObject("button3.Image")));
   this.button3.Location = new System.Drawing.Point(544, 32);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(16, 16);
   this.button3.TabIndex = 2;
   this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
   // 
   // button2
   // 
   this.button2.Image = ((System.Drawing.Bitmap)(resources.GetObject("button2.Image")));
   this.button2.Location = new System.Drawing.Point(8, 32);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(16, 15);
   this.button2.TabIndex = 1;
   this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
   // 
   // button1
   // 
   this.button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("button1.Image")));
   this.button1.Location = new System.Drawing.Point(8, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(16, 16);
   this.button1.TabIndex = 0;
   this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
   // 
   // richTextBox1
   // 
   this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.richTextBox1.Location = new System.Drawing.Point(0, 123);
   this.richTextBox1.Name = "richTextBox1";
   this.richTextBox1.Size = new System.Drawing.Size(568, 294);
   this.richTextBox1.TabIndex = 1043;
   this.richTextBox1.Text = "RichTextBox1";
   this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
   this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(568, 417);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.richTextBox1,
                                                              this.Panel2,
                                                              this.Panel1,
                                                              this.toolBar1});
   this.Menu = this.mainMenu1;
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Panel1.ResumeLayout(false);
   this.Panel2.ResumeLayout(false);
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
   toolBar1.ImageList = �mageList1;
   string[] dugmeler = {"Yeni", "A�", "Kaydet", "Kesme", "Kes", "Kopyala", 
                        "Yap��t�r", "Sil", "Kesme", "Kal�n", "E�ik", 
                        "Alt� �izili", "�st� �izili", "Kesme", 
                        "Sola", "Ortaya", "Sa�a", "Kesme", "Bul", 
                        "Kesme", "Geri Al", "Yinele", "Kesme", 
                        "Madde ��areti", "Kesme", "�st Simge", "Alt Simge"};
   int[] stiller = {0, 0, 0, 1, 0, 0, 0, 0, 1, 2, 2, 2, 2, 1, 2, 2, 
                    2, 1, 0, 1, 0, 0, 1, 2, 1, 2, 2};
   //resimleri �mageList i�inden al
   int i, resim=0;
   //D��meleri ekle
   for (i = 0 ; i<= dugmeler.Length - 1 ; i++)
   {
    ToolBarButton dugme = new ToolBarButton();
    toolBar1.Buttons.Add(dugme);
    dugme.ToolTipText = dugmeler[i];
    dugme.ImageIndex = resim;
    dugme.Text = dugmeler[i];
    switch(stiller[i])
    {
     case 0:
      dugme.Style = ToolBarButtonStyle.PushButton;
      resim += 1;
      break;
     case 1:
      dugme.Style = ToolBarButtonStyle.Separator;
      dugme.ImageIndex = -1; //Ay�r�c� d��melerin resmi yok
      break;
     case 2:
      dugme.Style = ToolBarButtonStyle.ToggleButton;
      resim += 1;
      break;
    }
   }

   //Fontlar� ekle
   comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
   FontFamily[] fontlar = FontFamily.Families;
   for (i = 0 ; i<= fontlar.GetUpperBound(0)-1 ; i++)
    comboBox1.Items.Add(fontlar[i].Name);
   comboBox1.Text = richTextBox1.Font.Name;

   //Font boyutlar�n� ekle
   for (i = 8 ; i<= 100 ; i+=2)
    comboBox2.Items.Add(i.ToString());
   comboBox2.Text = richTextBox1.Font.Size.ToString();

   //Renkleri ekle
   comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
   string[] renkler = {"K�rm�z�", "Ye�il", "Sar�", "Siyah", "Mavi", 
                       "Kahverengi"};
   comboBox3.Items.AddRange(renkler);
   comboBox3.Text = "Siyah";

   //Zoom oranlar�n� ekle
   comboBox4.Items.Add("%64");
   comboBox4.Items.Add("%75");
   comboBox4.Items.Add("%100");
   comboBox4.Items.Add("%150");
   comboBox4.Items.Add("%200");
   comboBox4.Items.Add("%400");
   comboBox4.Items.Add("%500");
   comboBox4.Items.Add("%1000");
   comboBox4.Text = "%100";

   //se�ili k�sm� gizleme
   richTextBox1.HideSelection = false;
   richTextBox1.Text = "";
   richTextBox1.Modified = false;
  }

  private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
  {
   switch(e.Button.Text)
   {
    case "Yeni":
     yeni();
     break;
    case "A�":
     a�();
     break;
    case "Kaydet":
     kaydet();
     break;
    case "Kes":
     kes();
     break;
    case "Kopyala":
     kopyala();
     break;
    case "Yap��t�r":
     yap��t�r();
     break;
    case "Sil":
     sil();
     break;
    case "Kal�n":
     kal�n(e.Button.Pushed);
     break;
    case "E�ik":
     e�ik(e.Button.Pushed);
     break;
    case "Alt� �izili":
     alt�_�izili(e.Button.Pushed);
     break;
    case "�st� �izili":
     �st�_�izili(e.Button.Pushed);
     break;
    case "Sola": case "Ortaya": case "Sa�a":
     yasla(e.Button);
     break;
    case "Bul":
     bul();
     break;
    case "Geri Al":
     geri_al();
     break;
    case "Yinele":
     yinele();
     break;
    case "Madde ��areti":
     madde_i�areti(e.Button.Pushed);
     break;
    case "�st Simge":case "Alt Simge":
     alt_�st_simge(e.Button);
     break;
   }
  }

  private void Mn_Yeni_Click(object sender, System.EventArgs e)
  {
   yeni();
  }

  private void Mn_A�_Click(object sender, System.EventArgs e)
  {
   a�();
  }

  private void Mn_Kaydet_Click(object sender, System.EventArgs e)
  {
   kaydet();
  }

  private void Mn_Farkl�Kaydet_Click(object sender, System.EventArgs e)
  {
   farkl�_kaydet();
  }

  private void Mn_��k��_Click(object sender, System.EventArgs e)
  {
   if (��k()==true)
    this.Close();
  }

  private void Mn_GeriAl_Click(object sender, System.EventArgs e)
  {
   geri_al();
  }

  private void Mn_Yinele_Click(object sender, System.EventArgs e)
  {
   yinele();
  }

  private void Mn_Kes_Click(object sender, System.EventArgs e)
  {
   kes();
  }

  private void Mn_Kopyala_Click(object sender, System.EventArgs e)
  {
   kopyala();
  }

  private void Mn_Yap��t�r_Click(object sender, System.EventArgs e)
  {
   yap��t�r();
  }

  private void Mn_Sil_Click(object sender, System.EventArgs e)
  {
   sil();
  }

  private void Mn_Bul_Click(object sender, System.EventArgs e)
  {
   bul();
  }

  private void Mn_Sola_Click(object sender, System.EventArgs e)
  {
   richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
  }

  private void Mn_Ortaya_Click(object sender, System.EventArgs e)
  {
   richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
  }

  private void Mn_Sa�a_Click(object sender, System.EventArgs e)
  {
   richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
  }

  private void Mn_Madde��areti_Click(object sender, System.EventArgs e)
  {
   richTextBox1.SelectionBullet = ! richTextBox1.SelectionBullet;
  }

  private void Mn_Kal�n_Click(object sender, System.EventArgs e)
  {
   kal�n(true);
  }

  private void Mn_E�ik_Click(object sender, System.EventArgs e)
  {
   e�ik(true);
  }

  private void Mn_Alt��izili_Click(object sender, System.EventArgs e)
  {
   alt�_�izili(true);
  }

  private void Mn_�st��izili_Click(object sender, System.EventArgs e)
  {
   �st�_�izili(true);
  }

  private void Mn_�stSimge_Click(object sender, System.EventArgs e)
  {
   richTextBox1.SelectionCharOffset = (int) richTextBox1.SelectionFont.Size / 2;
  }

  private void Mn_AltSimge_Click(object sender, System.EventArgs e)
  {
   richTextBox1.SelectionCharOffset = (int) -richTextBox1.SelectionFont.Size / 2;
  }

  private void Mn_FontSe�_Click(object sender, System.EventArgs e)
  {
   if (richTextBox1.SelectionFont != null)
    fontDialog1.Font = richTextBox1.SelectionFont;
   else
    fontDialog1.Font = null;
   if (fontDialog1.ShowDialog() == DialogResult.OK)
    richTextBox1.SelectionFont = fontDialog1.Font;
  }

  private void Mn_RenkSe�_Click(object sender, System.EventArgs e)
  {
   colorDialog1.Color = richTextBox1.SelectionColor;
   if (colorDialog1.ShowDialog() == DialogResult.OK)
    richTextBox1.SelectionColor = colorDialog1.Color;
  }

  private void comboBox1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   Font fnt;
   string ad;
   ad = comboBox1.Items[e.Index].ToString(); //Listede yazan font ad�
   try
   {
    fnt = new Font(ad, 12, FontStyle.Regular); //Listedeki fontu olu�tur
    e.ItemHeight = fnt.Height; //Y�ksekli�ini belirle
   }
   catch
   {;}
  }

  private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   //fontlar� �iz
   e.DrawBackground(); //Eleman�n arka plan�n� �iz
   e.DrawFocusRectangle(); //Elaman�n se�me �er�evesini �iz
   string ad;
   ad = comboBox1.Items[e.Index].ToString(); //Listede yazan font ad�
   try
   {
    //Font ad�n� o fontla yaz 
    e.Graphics.DrawString(ad, new Font(ad, 12, FontStyle.Regular), 
     new SolidBrush(Color.Black), 
     e.Bounds.Left, e.Bounds.Top);
   }
   catch
   {;}
  }

  private void comboBox3_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   //renkleri �iz
   Color renk=Color.Black;
   string eleman;
   eleman = comboBox3.Items[e.Index].ToString();
   switch(eleman)
   {
    case "K�rm�z�" : renk = Color.Red;break;
    case "Ye�il" : renk = Color.Green;break;
    case "Sar�" : renk = Color.Yellow;break;
    case "Siyah" : renk = Color.Black;break;
    case "Mavi" : renk = Color.Blue;break;
    case "Kahverengi" : renk = Color.Brown;break;
   }
   if (e.State == DrawItemState.Selected)//se�ili ise turquaz renkle �iz
    e.Graphics.FillRectangle(new SolidBrush(Color.Turquoise), 
     e.Bounds.Left, e.Bounds.Top, 
     e.Bounds.Width, e.Bounds.Height);
   else //Se�ili de�ilse kendi rengiyle �iz
    e.Graphics.FillRectangle(new SolidBrush(renk), 
     e.Bounds.Left, e.Bounds.Top, 
     e.Bounds.Width, e.Bounds.Height);
   //Rengin ad�n� beyaz olarak yaz
   e.Graphics.DrawString(eleman, e.Font, new SolidBrush(Color.White), 
    e.Bounds.Left, e.Bounds.Top);
   //Se�me �er�evesini �iz
   e.DrawFocusRectangle();
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //se�ili fontu uygula
   try
   {
    richTextBox1.SelectionFont = 
     new Font(comboBox1.SelectedItem.ToString(), 
     richTextBox1.SelectionFont.Size, 
     richTextBox1.SelectionFont.Style);
   }
   catch
   {;}
   richTextBox1.Focus();
  }

  private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //se�ili boyutu uygula
   try
   {
    richTextBox1.SelectionFont = 
     new Font(richTextBox1.SelectionFont.Name, 
     float.Parse(comboBox2.Text), 
     richTextBox1.SelectionFont.Style);
   }
   catch
   {;}
   richTextBox1.Focus();
  }

  private void comboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //se�ili rengi uygula
   Color renk=Color.Black;
   string eleman;
   eleman = comboBox3.SelectedItem.ToString();
   switch(eleman)
   {
    case "K�rm�z�" : renk = Color.Red;break;
    case "Ye�il" : renk = Color.Green;break;
    case "Sar�" : renk = Color.Yellow;break;
    case "Siyah" : renk = Color.Black;break;
    case "Mavi" : renk = Color.Blue;break;
    case "Kahverengi" : renk = Color.Brown;break;
   }
   richTextBox1.SelectionColor = renk;
   comboBox3.BackColor = renk;
   comboBox3.ForeColor = Color.White;
   richTextBox1.Focus();
  }

  private void comboBox4_TextChanged(object sender, System.EventArgs e)
  {
   //se�ili oranda b�y�lt
   try
   {
    richTextBox1.ZoomFactor = float.Parse(comboBox4.Text.Substring(1)) / 100;
   }
   catch
   {;}
  }

  string Dosya_Ad�;
  private void yeni()
  {
   //de�i�iklik olmu�sa kaydedilsin mi diye sor
   if (richTextBox1.Modified)
   {
    DialogResult c;
    c = MessageBox.Show("De�i�iklikler kaydedilsin mi?", "Kaydet",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
    if (c == DialogResult.Yes)
     kaydet();
   }
   richTextBox1.Text = "";
   richTextBox1.Modified = false;
   Dosya_Ad� = "";
   this.Text = "Yeni Dosya";
  }

  private void kaydet()
  {
   //Daha �nce kaydedilmemi�se farkl�_kaydeti �a��r
   if (Dosya_Ad� == "")
    farkl�_kaydet();
   else
   {
    richTextBox1.SaveFile(Dosya_Ad�);
    richTextBox1.Modified = false;
   }
  }

  private void farkl�_kaydet()
  {
   saveFileDialog1.Title = "Farkl� kaydet";
   saveFileDialog1.Filter = "RTF dosyalar�|*.rtf";
   saveFileDialog1.DefaultExt = "RTF";
   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
   {
    Dosya_Ad� = saveFileDialog1.FileName;
    richTextBox1.SaveFile(Dosya_Ad�);
    richTextBox1.Modified = false;
    this.Text = Dosya_Ad�;//Dosya ad�n� formun ba�l���na yaz
   }
  }

  private void a�()
  {
   openFileDialog1.Title = "A�";
   openFileDialog1.Filter = "RTF dosyalar�|*.rtf";
   openFileDialog1.DefaultExt = "RTF";
   //de�i�iklik olmu�sa kaydedilsin mi diye sor
   if (richTextBox1.Modified)
   {
    DialogResult c;
    c = MessageBox.Show("De�i�iklikler kaydedilsin mi?", "Kaydet",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
    if (c == DialogResult.Yes)
     kaydet();
   }
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    Dosya_Ad� = openFileDialog1.FileName;
    richTextBox1.LoadFile(Dosya_Ad�);
    richTextBox1.Modified = false;
    this.Text = Dosya_Ad�;//Dosya ad�n� formun ba�l���na yaz
   }
  }

  private Boolean ��k()
  {
   //de�i�iklik olmu�sa kaydedilsin mi diye sor
   if (richTextBox1.Modified)
   {
    DialogResult c;
    c = MessageBox.Show("De�i�iklikler kaydedilsin mi?", "��k��",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
    switch(c)
    {
     case DialogResult.Yes:
      kaydet();
      return true;
     case DialogResult.No:
      return true;
     case DialogResult.Cancel:
      return false;
    }
   }
   else
    return true;
   return true;
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   if (��k()==false)
    e.Cancel = true;
  }

  private void kal�n(Boolean bas�l� )
  {
   if (bas�l�)
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style | FontStyle.Bold);
   else
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
  }

  private void alt�_�izili(Boolean bas�l�)
  {
   if (bas�l�)
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style | FontStyle.Underline);
   else
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
  }

  private void e�ik(Boolean bas�l�)
  {
   if (bas�l�)
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style | FontStyle.Italic);
   else
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
  }

  private void �st�_�izili(Boolean bas�l�)
  {
   if (bas�l�)
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
   else
    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 
     richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);
  }

  private void yasla(ToolBarButton d��me)
  {
   //Sola, ortaya, sa�a d��melerinden sadece biri bas�l� olabilir
   Boolean bas�l�;
   bas�l� = d��me.Pushed;
   toolBar1.Buttons[14].Pushed = false;
   toolBar1.Buttons[15].Pushed = false;
   toolBar1.Buttons[16].Pushed = false;
   if (bas�l�)
    switch(d��me.Text)
    {
     case "Sola":
      richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
      toolBar1.Buttons[14].Pushed = true;
      break;
     case "Ortaya":
      richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
      toolBar1.Buttons[15].Pushed = true;
      break;
     case "Sa�a":
      richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
      toolBar1.Buttons[16].Pushed = true;
      break;
    }
  }

  private void alt_�st_simge(ToolBarButton d��me)
  {
   //Alt ve �st Simge d��melerinden sadece biri bas�l� olabilir
   Boolean bas�l�;
   bas�l� = d��me.Pushed;
   toolBar1.Buttons[25].Pushed = false;
   toolBar1.Buttons[26].Pushed = false;
   if (bas�l�)
    switch(d��me.Text)
    {
     case "�st Simge":
      richTextBox1.SelectionCharOffset = (int)
       richTextBox1.SelectionFont.Size / 2;
      toolBar1.Buttons[25].Pushed = true;
      break;
     case "Alt Simge":
      richTextBox1.SelectionCharOffset = (int)
       -richTextBox1.SelectionFont.Size / 2;
      toolBar1.Buttons[26].Pushed = true;
      break;
    }
   else
    richTextBox1.SelectionCharOffset = 0;
  }

  private void kes()
  {
   richTextBox1.Cut();
  }

  private void kopyala()
  {
   richTextBox1.Copy();
  }

  private void yap��t�r()
  {
   try
   {
    richTextBox1.Paste();
   }
   catch
   {
    MessageBox.Show("Panodaki bilgi al�namad�");
   }
  }

  private void sil()
  {
   richTextBox1.SelectedText = "";
  }

  private void geri_al()
  {
   if (richTextBox1.CanUndo)
    richTextBox1.Undo();
  }

  private void yinele()
  {
   if (richTextBox1.CanRedo)
    richTextBox1.Redo();
  }

  private void madde_i�areti(Boolean bas�l�)
  {
   richTextBox1.SelectionBullet = bas�l�;
  }

  private void button1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {
    button1.Left = e.X + button1.Left;
    richTextBox1.SelectionIndent = button1.Left;
    richTextBox1.SelectionHangingIndent = button2.Left - button1.Left;
   }
  }

  private void button2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {
    button2.Left = e.X + button2.Left;
    richTextBox1.SelectionHangingIndent = button2.Left - button1.Left;
   }
  }

  private void button3_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {
    button3.Left = e.X + button3.Left;
    try
    {
     richTextBox1.SelectionRightIndent = richTextBox1.ClientSize.Width 
      - button3.Left;
    }
    catch
    {
     button3.Left = richTextBox1.ClientSize.Width;
    }
   }
  }

  private void richTextBox1_SelectionChanged(object sender, System.EventArgs e)
  {
   //Se�ili k�s�m yoksa kes, kopyala, sil d��melerini pasif yap
   if (richTextBox1.SelectionLength == 0)
   {
    toolBar1.Buttons[4].Enabled = false;
    toolBar1.Buttons[5].Enabled = false;
    toolBar1.Buttons[7].Enabled = false;
   }
   else
   {
    toolBar1.Buttons[4].Enabled = true;
    toolBar1.Buttons[5].Enabled = true;
    toolBar1.Buttons[7].Enabled = true;
   }

   if (richTextBox1.SelectionFont != null)
   {
    //font bi�imlendirme d��melerini ayarla
    if (richTextBox1.SelectionFont.Bold)
     toolBar1.Buttons[9].Pushed = true;
    else
     toolBar1.Buttons[9].Pushed = false;
    if (richTextBox1.SelectionFont.Italic)
     toolBar1.Buttons[10].Pushed = true;
    else
     toolBar1.Buttons[10].Pushed = false;
    if (richTextBox1.SelectionFont.Underline)
     toolBar1.Buttons[11].Pushed = true;
    else
     toolBar1.Buttons[11].Pushed = false;
    if (richTextBox1.SelectionFont.Strikeout)
     toolBar1.Buttons[12].Pushed = true;
    else
     toolBar1.Buttons[12].Pushed = false;
    //font boyunu ve b�y�kl���n� ayarla
    comboBox1.Text = richTextBox1.SelectionFont.Name;
    comboBox2.Text = richTextBox1.SelectionFont.Size.ToString();
   }

   //Paragraf bi�imlendirme d��melerini ayarla
   toolBar1.Buttons[14].Pushed = false;
   toolBar1.Buttons[15].Pushed = false;
   toolBar1.Buttons[16].Pushed = false;
   switch(richTextBox1.SelectionAlignment)
   {
    case HorizontalAlignment.Left:
     toolBar1.Buttons[14].Pushed = true;
     break;
    case HorizontalAlignment.Center:
     toolBar1.Buttons[15].Pushed = true;
     break;
    case HorizontalAlignment.Right:
     toolBar1.Buttons[16].Pushed = true;
     break;
   }

   //Madde i�areti d��mesini ayarla
   if (richTextBox1.SelectionBullet)
    toolBar1.Buttons[23].Pushed = true;
   else
    toolBar1.Buttons[23].Pushed = false;

   //�ste simge, Alt simge d��melerini ayarla
   if (richTextBox1.SelectionCharOffset > 0)
    toolBar1.Buttons[25].Pushed = true;
   else
    toolBar1.Buttons[25].Pushed = false;
   if (richTextBox1.SelectionCharOffset < 0)
    toolBar1.Buttons[26].Pushed = true;
   else
    toolBar1.Buttons[26].Pushed = false;
  
   //Paragraf girintilerini ayarla
   if (richTextBox1.SelectionIndent == 0)
   {
    button1.Left = 0;
    button2.Left = 0;
    button3.Left = richTextBox1.ClientSize.Width - button3.Width;
   }
   else
   {
    button1.Left = richTextBox1.SelectionIndent ;
    button2.Left = richTextBox1.SelectionHangingIndent + button1.Left;
    button3.Left = richTextBox1.ClientSize.Width 
     - richTextBox1.SelectionRightIndent;
   }
  }

  private void richTextBox1_TextChanged(object sender, System.EventArgs e)
  {
   //geri al, yinele d��melerini ayarla
   if (richTextBox1.CanUndo)
   {
    toolBar1.Buttons[20].Enabled = true;
    toolBar1.Buttons[20].ToolTipText = "Geri Al-" +
     richTextBox1.UndoActionName;
   }
   else
   {
    toolBar1.Buttons[20].Enabled = false;
    toolBar1.Buttons[20].ToolTipText = "Geri Al�namaz";
   }
   if (richTextBox1.CanRedo)
   {
    toolBar1.Buttons[21].Enabled = true;
    toolBar1.Buttons[21].ToolTipText = "Yeniden yap-" + 
     richTextBox1.RedoActionName;
   }
   else
   {
    toolBar1.Buttons[21].Enabled = false;
    toolBar1.Buttons[21].ToolTipText = "Yeniden yap�lamaz";
   }
  }

  private void Mn_D�zen_Select(object sender, System.EventArgs e)
  {
   //Se�ili k�s�m yoksa kes, kopyala, sil men�lerini pasif yap
   if (richTextBox1.SelectionLength == 0)
   {
    Mn_Kes.Enabled = false;
    Mn_Kopyala.Enabled = false;
    Mn_Sil.Enabled = false;
   }
   else
   {
    Mn_Kes.Enabled = true;
    Mn_Kopyala.Enabled = true;
    Mn_Sil.Enabled = true;
   }

   //geri al, yinele d��melerini ayarla
   if (richTextBox1.CanUndo)
   {
    Mn_GeriAl.Enabled = true;
    Mn_GeriAl.Text = "Geri Al-" + richTextBox1.UndoActionName;
   }
   else
   {
    Mn_GeriAl.Enabled = false;
    Mn_GeriAl.Text = "Geri Al�namaz";
   }
   if (richTextBox1.CanRedo)
   {
    Mn_Yinele.Enabled = true;
    Mn_Yinele.Text = "Yeniden yap-" + richTextBox1.RedoActionName;
   }
   else
   {
    Mn_Yinele.Enabled = false;
    Mn_Yinele.Text = "Yeniden yap�lamaz";
   }
  }

  private void Mn_Yaz�tipi_Select(object sender, System.EventArgs e)
  {
   if (richTextBox1.SelectionFont != null)
   {
    //font bi�imlendirme men�lerini ayarla
    if (richTextBox1.SelectionFont.Bold)
     Mn_Kal�n.Checked = true;
    else
     Mn_Kal�n.Checked = false;
    if (richTextBox1.SelectionFont.Italic)
     Mn_E�ik.Checked = true;
    else
     Mn_E�ik.Checked = false;
    if (richTextBox1.SelectionFont.Underline)
     Mn_Alt��izili.Checked = true;
    else
     Mn_Alt��izili.Checked = false;
    if (richTextBox1.SelectionFont.Strikeout)
     Mn_�st��izili.Checked = true;
    else
     Mn_�st��izili.Checked = false;
   }

   //�ste simge, Alt simge men�lerini ayarla
   if (richTextBox1.SelectionCharOffset > 0)
    Mn_�stSimge.Checked = true;
   else
    Mn_�stSimge.Checked = false;
   if (richTextBox1.SelectionCharOffset < 0)
    Mn_AltSimge.Checked = true;
   else
    Mn_AltSimge.Checked = false;
  }

  private void Mn_Paragraf_Select(object sender, System.EventArgs e)
  {
   Mn_Sola.Checked = false;
   Mn_Ortaya.Checked = false;
   Mn_Sa�a.Checked = false;
   //Sola, Ortaya, Sa�a men�lerini ayarla
   switch(richTextBox1.SelectionAlignment)
   {
    case HorizontalAlignment.Left:
     Mn_Sola.Checked = true;
     break;
    case HorizontalAlignment.Center:
     Mn_Ortaya.Checked = true;
     break;
    case HorizontalAlignment.Right:
     Mn_Sa�a.Checked = true;
     break;
   }

   //Madde i�areti men�s�n� ayarla
   if (richTextBox1.SelectionBullet)
    Mn_Madde��areti.Checked = true;
   else
    Mn_Madde��areti.Checked = false;
  }

  private void richTextBox1_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
  {
   System.Diagnostics.Process.Start(e.LinkText);
  }

  Form2 frm = new Form2();
  public static RichTextBox Rich_Text_Box;
  public void bul()
  {
   frm.textBox1.Text = richTextBox1.SelectedText;
   Rich_Text_Box = richTextBox1;
   frm.Show();
  }

  
 }
}
