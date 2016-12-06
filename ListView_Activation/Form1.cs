using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListView_Activation
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
   this.listView1.Location = new System.Drawing.Point(8, 8);
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(384, 97);
   this.listView1.TabIndex = 1;
   this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(400, 110);
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
   listView1.Activation = ItemActivation.OneClick;

   listView1.Columns.Add("Adý Soyadý", -2, HorizontalAlignment.Left);
   listView1.Columns.Add("Email Adresi", -2, HorizontalAlignment.Left);

   listView1.Items.Add("Ihsan Karagülle");
   listView1.Items[0].SubItems.Add("ikaragulle@hotmail.com");

   listView1.Items.Add("Kemalettin Toraman");
   listView1.Items[1].SubItems.Add("Kemalettin@hotmail.com");

   listView1.Items.Add("Musa Ataþ");
   listView1.Items[2].SubItems.Add("musaatas@yahoo.com");
  
   listView1.View = View.Details;
   listView1.Sorting = SortOrder.Ascending;
  }

  private void listView1_ItemActivate(object sender, System.EventArgs e)
  {
   string email;
   email = "mailto:" + listView1.SelectedItems[0].SubItems[1].Text;
   System.Diagnostics.Process.Start(email);
  }
	}
}
