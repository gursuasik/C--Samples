using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MultiSelectListBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ListBox listBox2;
  internal System.Windows.Forms.ListBox listBox1;
  private System.Windows.Forms.TextBox textBox1;
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
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(136, 80);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(40, 23);
   this.button4.TabIndex = 11;
   this.button4.Text = "<<";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(136, 48);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(40, 23);
   this.button3.TabIndex = 10;
   this.button3.Text = ">>";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(200, 8);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(64, 23);
   this.button2.TabIndex = 9;
   this.button2.Text = "Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(136, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(56, 24);
   this.button1.TabIndex = 8;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(192, 40);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(120, 95);
   this.listBox2.TabIndex = 7;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 40);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(120, 95);
   this.listBox1.TabIndex = 6;
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(120, 20);
   this.textBox1.TabIndex = 12;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(320, 142);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.listBox2,
                                                              this.listBox1});
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
   //Listelerden birden fazla eleman seçilebilsin
   listBox1.SelectionMode = SelectionMode.MultiSimple;
   listBox2.SelectionMode = SelectionMode.MultiSimple;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Ekle düðmesi 
   listBox1.Items.Add(textBox1.Text);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Sil düðmesi
   int i;
   DialogResult c;
   c = MessageBox.Show(listBox1.SelectedIndices.Count.ToString() + " elaman silinsin mi", 
    "Sil",MessageBoxButtons.YesNo );
   if (c == DialogResult.Yes)
    for (i = listBox1.SelectedIndices.Count - 1;i>=0;i--)
     listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   //>> düðmesi
   int i;
   for (i = listBox1.SelectedIndices.Count - 1;i>=0;i--)
   {
    //Seçili elemaný ikinci listeye ekle
    listBox2.Items.Add(listBox1.SelectedItems[i]);
    //seçili elemaný birinci listeden çýkar
    listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
   }
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   //<<düðmesi
   int i;
   for (i = listBox2.SelectedIndices.Count - 1 ; i>=0 ; i--)
   {
    //Seçili elemaný birinci listeye ekle
    listBox1.Items.Add(listBox2.SelectedItems[i]);
    //seçili elemaný ikinci listeden çýkar
    listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
   }
  }
	}
}
