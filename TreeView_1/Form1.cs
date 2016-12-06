using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TreeView_1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Button button1;
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
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // treeView1
   // 
   this.treeView1.ImageIndex = -1;
   this.treeView1.Location = new System.Drawing.Point(1, 48);
   this.treeView1.Name = "treeView1";
   this.treeView1.SelectedImageIndex = -1;
   this.treeView1.Size = new System.Drawing.Size(344, 264);
   this.treeView1.TabIndex = 1;
   this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 16);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(168, 23);
   this.label1.TabIndex = 2;
   this.label1.Text = "Çarpanlarýna ayrýlacak sayý:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(184, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(72, 20);
   this.textBox1.TabIndex = 3;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(272, 16);
   this.button1.Name = "button1";
   this.button1.TabIndex = 4;
   this.button1.Text = "Tamam";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(352, 318);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox1,
                                                              this.label1,
                                                              this.treeView1});
   this.Name = "Form1";
   this.Text = "Form1";
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   treeView1.Nodes.Clear();
   try
   {
    treeView1.Nodes.Add(int.Parse(textBox1.Text).ToString());
    MessageBox.Show("Listeden sayýyý çift týklayarak asal çarpanlarýna ulaþabilirsiniz");
   }
   catch
   {
    MessageBox.Show("Sayý geçersiz");
   }
  }

  private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
  {
   int i;
   //daha önce eklenmiþse çýk
   if (e.Node.GetNodeCount(true) > 0) 
    return;
   for (i = 2 ; i<= int.Parse(e.Node.Text) - 1 ; i++)
    if ((int.Parse(e.Node.Text) % i) == 0)
     //Tam olarak bölünebiliyorsa alt eleman olarak ekle
     e.Node.Nodes.Add(i.ToString());
  }
	}
}
