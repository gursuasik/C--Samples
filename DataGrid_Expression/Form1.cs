using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataGrid_Expression
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.DataGrid dataGrid1;
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
   this.dataGrid1 = new System.Windows.Forms.DataGrid();
   ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
   this.SuspendLayout();
   // 
   // dataGrid1
   // 
   this.dataGrid1.DataMember = "";
   this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
   this.dataGrid1.Name = "dataGrid1";
   this.dataGrid1.Size = new System.Drawing.Size(432, 270);
   this.dataGrid1.TabIndex = 1;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(432, 270);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.dataGrid1});
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
	}
}
