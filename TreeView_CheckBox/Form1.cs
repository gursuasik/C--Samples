using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TreeView_CheckBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TreeView treeView1;
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
   this.treeView1 = new System.Windows.Forms.TreeView();
   this.SuspendLayout();
   // 
   // treeView1
   // 
   this.treeView1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right);
   this.treeView1.ImageIndex = -1;
   this.treeView1.Location = new System.Drawing.Point(8, 8);
   this.treeView1.Name = "treeView1";
   this.treeView1.SelectedImageIndex = -1;
   this.treeView1.Size = new System.Drawing.Size(240, 168);
   this.treeView1.TabIndex = 1;
   this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(256, 182);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.treeView1});
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
   treeView1.CheckBoxes = true;
   treeView1.Nodes.Add("Doðu Anadolu");
   treeView1.Nodes[0].Nodes.Add("Erzurum");
   treeView1.Nodes[0].Nodes[0].Nodes.Add("Tortum");
   treeView1.Nodes[0].Nodes[0].Nodes.Add("Oltu");
   treeView1.Nodes[0].Nodes[0].Nodes.Add("Hasankale");
   treeView1.Nodes[0].Nodes.Add("Hakkari");
   treeView1.Nodes[0].Nodes[1].Nodes.Add("Çukurca");
   treeView1.Nodes[0].Nodes[1].Nodes.Add("Yüksekova");
   treeView1.Nodes[0].Nodes[1].Nodes.Add("Þemdinli");
   treeView1.Nodes[0].Nodes.Add("Van");
   treeView1.Nodes.Add("Akdeniz");
   treeView1.Nodes[1].Nodes.Add("Mersin");
   treeView1.Nodes[1].Nodes.Add("Antalya");
   treeView1.Nodes.Add("Karadeniz");
   treeView1.Nodes[2].Nodes.Add("Rize");
   treeView1.Nodes[2].Nodes.Add("Trabzon");
   treeView1.Nodes.Add("Marmara");
   treeView1.Nodes.Add("Orta Anadolu");
   treeView1.Nodes.Add("Güneydoðu Anadolu");
  }

  private void treeView1_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
  {
   Boolean durum;
   durum = e.Node.Checked;
   TreeNode Alt_Düðüm;
   Alt_Düðüm = e.Node.FirstNode;
   while (Alt_Düðüm != null)
   {
    Alt_Düðüm.Checked = durum;
    Alt_Düðüm = Alt_Düðüm.NextNode;
   }
  }
	}
}
