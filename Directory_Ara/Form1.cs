using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Directory_Ara
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Label label3;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.label3 = new System.Windows.Forms.Label();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(16, 280);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(312, 23);
   this.label3.TabIndex = 13;
   this.label3.Text = "label3";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 56);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(320, 212);
   this.listBox1.TabIndex = 12;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(256, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(75, 40);
   this.button1.TabIndex = 11;
   this.button1.Text = "Ara";
   this.button1.Click += new System.EventHandler(this.Button1_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(144, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 10;
   this.textBox2.Text = "textBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(144, 23);
   this.Label2.TabIndex = 9;
   this.Label2.Text = "Aramanýn baþlayacaðý yer:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(144, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 8;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 7;
   this.Label1.Text = "Aranacak Dosya:";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(336, 310);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label3,
                                                              this.listBox1,
                                                              this.button1,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
   textBox1.Text = "*.jpg";
   textBox2.Text = "c:\\";
   this.AcceptButton = button1;
  }

  private void Button1_Click(object sender, System.EventArgs e)
  {
   if (System.IO.Directory.Exists(textBox2.Text))
   {
    listBox1.Items.Clear();
    ara(textBox2.Text);
   }
   else
    MessageBox.Show(textBox2.Text + " klasörü bulunamadý");
  }

  void ara (string yol)
  {
   string[] dosyalar;
   dosyalar = System.IO.Directory.GetFiles(yol, textBox1.Text);
   listBox1.Items.AddRange(dosyalar);
   string[] klasörler;
   klasörler = System.IO.Directory.GetDirectories(yol);
   int i;
   for (i = 0 ; i<= klasörler.Length - 1 ; i++)
   {
    ara(klasörler[i]);//Kendini çaðýrýp alt klasörleri listelemesini saðla
    label3.Text = klasörler[i];
    Application.DoEvents();
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   Environment.Exit(0);
  }

	}
}
