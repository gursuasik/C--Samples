using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataGrid_SütunAyarlarý
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.DataGrid dataGrid1;
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
   this.dataGrid1.Size = new System.Drawing.Size(672, 134);
   this.dataGrid1.TabIndex = 0;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(672, 134);
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

   //Sütunlarý oluþtur
   sütun = new DataColumn("Müþterinin Adý", Type.GetType("System.String"));
   dt.Columns.Add(sütun);

   sütun = new DataColumn("Aldýðý Mal", Type.GetType("System.String"));
   dt.Columns.Add(sütun);

   sütun = new DataColumn("Adet", Type.GetType("System.Int32"));
   dt.Columns.Add(sütun);

   sütun = new DataColumn("Birim Fiyat", Type.GetType("System.Decimal"));
   dt.Columns.Add(sütun);

   sütun = new DataColumn("Toplam", Type.GetType("System.Decimal"));
   sütun.Expression = "Adet*[Birim Fiyat]";
   dt.Columns.Add(sütun);

   sütun = new DataColumn("Ödenen", Type.GetType("System.Decimal"));
   dt.Columns.Add(sütun);

   sütun = new DataColumn("Kalan", Type.GetType("System.Decimal"));
   sütun.Expression = "Toplam-Ödenen";
   dt.Columns.Add(sütun);

   sütun = new DataColumn("Borcu Yok", Type.GetType("System.Boolean"));
   sütun.Expression = "iif(kalan>0,false,true)";
   dt.Columns.Add(sütun);

   //dataGrid kontrolünde oluþturduðumuz tabloyu göster
   dataGrid1.DataSource = dt;

  
   //Sütun ayarlarýný yap
   DataGridTableStyle ts = new DataGridTableStyle();

   DataGridTextBoxColumn[] TextCol= new DataGridTextBoxColumn[7];
   TextCol[0] = new DataGridTextBoxColumn();
   TextCol[0].MappingName = "Müþterinin Adý";
   TextCol[0].HeaderText = "Müþterinin Adý";
   TextCol[0].Width = 100;
   ts.GridColumnStyles.Add(TextCol[0]);

   TextCol[1] = new DataGridTextBoxColumn();
   TextCol[1].MappingName = "Aldýðý Mal";
   TextCol[1].HeaderText = "Aldýðý Mal";
   TextCol[1].Width = 100;
   ts.GridColumnStyles.Add(TextCol[1]);

   TextCol[2] = new DataGridTextBoxColumn();
   TextCol[2].MappingName = "Adet";
   TextCol[2].HeaderText = "Adet";
   TextCol[2].Width = 30;
   TextCol[2].Alignment = HorizontalAlignment.Right;
   ts.GridColumnStyles.Add(TextCol[2]);

   TextCol[3] = new DataGridTextBoxColumn();
   TextCol[3].MappingName = "Birim Fiyat";
   TextCol[3].HeaderText = "Birim Fiyat";
   TextCol[3].Alignment = HorizontalAlignment.Right;
   TextCol[3].Format = "#,##";
   TextCol[3].Width = 70;
   ts.GridColumnStyles.Add(TextCol[3]);

   TextCol[4] = new DataGridTextBoxColumn();
   TextCol[4].MappingName = "Toplam";
   TextCol[4].HeaderText = "Toplam";
   TextCol[4].Width = 120;
   TextCol[4].Alignment = HorizontalAlignment.Right;
   TextCol[4].Format = "#,##";
   TextCol[4].TextBox.BackColor = Color.Gray;
   TextCol[4].ReadOnly = true;
   ts.GridColumnStyles.Add(TextCol[4]);

   TextCol[5] = new DataGridTextBoxColumn();
   TextCol[5].MappingName = "Ödenen";
   TextCol[5].HeaderText = "Ödenen";
   TextCol[5].Alignment = HorizontalAlignment.Right;
   TextCol[5].Format = "#,##";
   TextCol[5].Width = 120;
   ts.GridColumnStyles.Add(TextCol[5]);

   TextCol[6] = new DataGridTextBoxColumn();
   TextCol[6].MappingName = "Kalan";
   TextCol[6].HeaderText = "Kalan";
   TextCol[6].Width = 120;
   TextCol[6].Alignment = HorizontalAlignment.Right;
   TextCol[6].Format = "#,##";
   TextCol[6].TextBox.BackColor = Color.Gray;
   TextCol[6].ReadOnly = true;
   ts.GridColumnStyles.Add(TextCol[6]);

   DataGridBoolColumn BoolCol = new DataGridBoolColumn();
   BoolCol.MappingName = "Borcu Yok";
   BoolCol.HeaderText = "Borcu Yok";
   BoolCol.Width = 60;
   ts.GridColumnStyles.Add(BoolCol);

   ts.AlternatingBackColor = Color.Yellow;
   ts.BackColor = Color.LightYellow;
   dataGrid1.TableStyles.Add(ts);
  }
	}
}
