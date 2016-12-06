using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataGrid_Satýþ
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.DataGrid dataGrid1;
  internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
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
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.Label1 = new System.Windows.Forms.Label();
   this.dataGrid1 = new System.Windows.Forms.DataGrid();
   this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
   ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(376, 56);
   this.button2.Name = "button2";
   this.button2.TabIndex = 9;
   this.button2.Text = "Aç";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(376, 24);
   this.button1.Name = "button1";
   this.button1.TabIndex = 8;
   this.button1.Text = "Kaydet";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(264, 200);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(104, 23);
   this.label2.TabIndex = 7;
   this.label2.Text = "label2";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(176, 200);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(80, 23);
   this.Label1.TabIndex = 6;
   this.Label1.Text = "Genel Toplam:";
   // 
   // dataGrid1
   // 
   this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
   this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
   this.dataGrid1.BackgroundColor = System.Drawing.Color.LightGray;
   this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
   this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
   this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
   this.dataGrid1.DataMember = "";
   this.dataGrid1.FlatMode = true;
   this.dataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
   this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
   this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
   this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
   this.dataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
   this.dataGrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
   this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
   this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
   this.dataGrid1.Location = new System.Drawing.Point(8, 8);
   this.dataGrid1.Name = "dataGrid1";
   this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
   this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
   this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
   this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
   this.dataGrid1.Size = new System.Drawing.Size(360, 184);
   this.dataGrid1.TabIndex = 5;
   this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
   // 
   // saveFileDialog1
   // 
   this.saveFileDialog1.FileName = "doc1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(456, 230);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label2,
                                                              this.Label1,
                                                              this.dataGrid1,
                                                              this.button2,
                                                              this.button1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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
   DataTable dt = new DataTable();
   DataColumn sütun;
   DataRow satýr;

   //Sütunlarý oluþtur
   sütun = new DataColumn("Malzeme Adý", Type.GetType("System.String"));
   //Sütunlara ekle
   dt.Columns.Add(sütun);

   //Yeni bir sütun daha  oluþtur
   sütun = new DataColumn("Adet", Type.GetType("System.Int32"));
   //Sütunlara ekle
   dt.Columns.Add(sütun);

   //Yeni bir sütun daha  oluþtur
   sütun = new DataColumn("Birim Fiyat", Type.GetType("System.Decimal"));
   //Sütunlara ekle
   dt.Columns.Add(sütun);

   //Yeni bir sütun daha  oluþtur
   sütun = new DataColumn("Toplam", Type.GetType("System.Decimal"));
   sütun.Expression = "Adet*[Birim Fiyat]";
   //Sütunlara ekle
   dt.Columns.Add(sütun);

   //dataGrid kontrolünde oluþturduðumuz tabloyu göster
   dataGrid1.DataSource = dt;
  }

  private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
  {
   toplam_bul();
  }

  private void toplam_bul()
  {
   DataTable dt;
   dt = (DataTable) dataGrid1.DataSource;
   int i;
   decimal toplam=0;
   for (i = 0 ; i<= dt.Rows.Count - 1 ; i++)
    try
    {
     toplam += decimal.Parse(dataGrid1[i, 3].ToString());
    }
    catch
    {;}
   label2.Text = toplam.ToString();
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   saveFileDialog1.DefaultExt = "xml";
   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
   {
    DataTable dt;
    dt = (DataTable)dataGrid1.DataSource;
    DataSet ds = new DataSet();
    ds.Tables.Add(dt);
    //Verileri kaydet
    ds.WriteXml(saveFileDialog1.FileName);
    string xsd;
    //Ayný isimde bir xsd dosyasý oluþtur
    xsd = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf("."));
    xsd = xsd + ".XSD";
    //Sütun bilgilerini bu dosyaya kaydet
    ds.WriteXmlSchema(xsd);
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   openFileDialog1.Filter = "XML Dosyalarý|*.xml";
   openFileDialog1.FilterIndex = 0;
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    DataSet ds = new DataSet();
    string xsd;
    //Ayný isimde bir xsd dosya adý oluþtur
    xsd = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("."));
    xsd = xsd + ".XSD";
    //Sütun bilgilerini oku
    ds.ReadXmlSchema(xsd);
    //Verileri oku 
    ds.ReadXml(openFileDialog1.FileName);
    DataTable dt;
    dt = ds.Tables[0];
    dataGrid1.DataSource = dt;
   }
  }
 }                                                          
}

