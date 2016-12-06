using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ForEachNext
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(128, 104);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(104, 23);
   this.button3.TabIndex = 7;
   this.button3.Text = "Topla";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(128, 72);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(104, 23);
   this.button2.TabIndex = 6;
   this.button2.Text = "Topla";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(128, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 56);
   this.button1.TabIndex = 5;
   this.button1.Text = "Yüz Tane Rasgele Sayý Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(112, 199);
   this.listBox1.TabIndex = 4;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 214);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.listBox1});
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
   int i;
   Random r = new Random();
   for (i = 1 ; i <= 100 ; i++)
    listBox1.Items.Add(r.Next(1000).ToString());
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int toplam=0;
   foreach (string i in listBox1.Items)
    toplam += int.Parse(i);
   MessageBox.Show(toplam.ToString());
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   int i, toplam=0;
   for (i = 0 ; i<= listBox1.Items.Count - 1 ; i++)
    toplam += int.Parse(listBox1.Items[i].ToString());
   MessageBox.Show(toplam.ToString());
  }
	}
}
