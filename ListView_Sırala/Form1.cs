using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListView_S�rala
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ListView listView1;
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
   this.listView1 = new System.Windows.Forms.ListView();
   this.SuspendLayout();
   // 
   // listView1
   // 
   this.listView1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right);
   this.listView1.Location = new System.Drawing.Point(8, 8);
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(424, 232);
   this.listView1.TabIndex = 1;
   this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(440, 246);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.listView1});
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   listView1.Columns.Add("Ad� Soyad�", -2, HorizontalAlignment.Left);
   listView1.Columns.Add("�nvan�", -2, HorizontalAlignment.Left);
   listView1.Columns.Add("Sicil Numaras�", -2, HorizontalAlignment.Right);
   listView1.Columns.Add("Do�um Tarihi", -2, HorizontalAlignment.Left);

   listView1.Items.Add("Ali");
   listView1.Items[0].SubItems.Add("��retim G�revlisi");
   listView1.Items[0].SubItems.Add("1856");
   listView1.Items[0].SubItems.Add("5/5/1970");
   listView1.Items.Add("Veli");
   listView1.Items[1].SubItems.Add("Uzman");
   listView1.Items[1].SubItems.Add("1210");
   listView1.Items[1].SubItems.Add("5/12/1960");
   listView1.Items.Add("Ahmet");
   listView1.Items[2].SubItems.Add("Prof Dr.");
   listView1.Items[2].SubItems.Add("4578");
   listView1.Items[2].SubItems.Add("1/1/1950");
   listView1.Items.Add("Mehmet");
   listView1.Items[3].SubItems.Add("Yard.Do�");
   listView1.Items[3].SubItems.Add("7845");
   listView1.Items[3].SubItems.Add("4/6/1968");
   listView1.Items.Add("Ay�e");
   listView1.Items[4].SubItems.Add("Do�ent");
   listView1.Items[4].SubItems.Add("7888");
   listView1.Items[4].SubItems.Add("14/2/1970");
   listView1.View = View.Details;
   listView1.Sorting = SortOrder.Ascending;
  }

  private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
  {
   switch(e.Column)
   {
    case 0:
     listView1.ListViewItemSorter = new Alfabetik_S�rala();
     break;
    case 1:
     listView1.ListViewItemSorter = new Unvan_S�rala();
     break;
    case 2:
     listView1.ListViewItemSorter = new Say�_S�rala();
     break;
    case 3:
     listView1.ListViewItemSorter = new Tarih_S�rala();
     break;
   }
  }
	}
}
