using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataGrid_1
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
   this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
   this.dataGrid1.Location = new System.Drawing.Point(1, 0);
   this.dataGrid1.Name = "dataGrid1";
   this.dataGrid1.Size = new System.Drawing.Size(384, 160);
   this.dataGrid1.TabIndex = 0;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(384, 158);
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
     //Yeni veri tablosu olu�tur
  DataTable dt = new DataTable();
  DataColumn s�tun;
  DataRow sat�r ;

  //S�tunlar� olu�tur
  s�tun = new DataColumn("S�ra No");
  s�tun.DataType = Type.GetType("System.Int32");
  s�tun.AutoIncrement = true;
  s�tun.AutoIncrementStep = 1;
  //S�tunlara ekle
  dt.Columns.Add(s�tun);

  //Yeni bir s�tun daha  olu�tur
  s�tun = new DataColumn("Ad� Soyad�");
  s�tun.DataType = Type.GetType("System.String");
  //S�tunlara ekle
  dt.Columns.Add(s�tun);

  //Yeni bir s�tun daha  olu�tur
  s�tun = new DataColumn("Do�um Tarihi");
  s�tun.DataType = Type.GetType("System.DateTime");
  //S�tunlara ekle
  dt.Columns.Add(s�tun);

  //Yeni bir s�tun daha  olu�tur
  s�tun = new DataColumn("Do�um Yeri");
  s�tun.DataType = Type.GetType("System.String");
  //S�tunlara ekle
  dt.Columns.Add(s�tun);

  //dataGrid kontrol�nde olu�turdu�umuz tabloyu g�ster
  dataGrid1.DataSource = dt;

  //Yeni bir sat�r olu�tur
  sat�r = dt.NewRow();
  sat�r["Ad� Soyad�"] = "Ali";
  sat�r["Do�um Tarihi"] = "17/11/1973";
  sat�r["Do�um Yeri"] = "Erzurum";
  //Veri tablomuza kontrol�ne ekle
  dt.Rows.Add(sat�r);

  //Yeni bir sat�r daha olu�tur
  sat�r = dt.NewRow();
  sat�r["Ad� Soyad�"] = "Veli";
  sat�r["Do�um Tarihi"] = "5/5/1985";
  sat�r["Do�um Yeri"] = "Ankara";
  //Veri tablomuza kontrol�ne ekle
  dt.Rows.Add(sat�r);
  }
	}
}
