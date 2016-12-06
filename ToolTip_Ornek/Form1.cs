using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ToolTip_Ornek
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ToolTip toolTip1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  private System.ComponentModel.IContainer components;

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
   this.components = new System.ComponentModel.Container();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(120, 112);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(96, 23);
   this.button2.TabIndex = 19;
   this.button2.Text = "Sil";
   this.toolTip1.SetToolTip(this.button2, "Formdaki bilgileri silmek için týklayýn");
   this.button2.Click += new System.EventHandler(this.Button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 112);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 18;
   this.button1.Text = "Hesapla";
   this.toolTip1.SetToolTip(this.button1, "Ýþçinin alacaðý ücreti hesaplamak için týklayýn");
   this.button1.Click += new System.EventHandler(this.Button1_Click);
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(120, 80);
   this.textBox4.Name = "textBox4";
   this.textBox4.TabIndex = 17;
   this.textBox4.Text = "textBox4";
   this.toolTip1.SetToolTip(this.textBox4, "Bu iþçinin alacaðý ücret. Hesapla düðmesine basarak hesaplatabilirsiniz");
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 80);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 16;
   this.Label4.Text = "Alacaðý ücret";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(120, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 13;
   this.textBox2.Text = "textBox2";
   this.toolTip1.SetToolTip(this.textBox2, "Buraya bir günlük yevmiyesini giriniz");
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 12;
   this.Label2.Text = "Yevmiyesi";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 10;
   this.Label1.Text = "Adý Soyadý";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(120, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 15;
   this.textBox3.Text = "textBox3";
   this.toolTip1.SetToolTip(this.textBox3, "Buraya çalýþtýðý gün sayýsýný giriniz");
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(104, 23);
   this.Label3.TabIndex = 14;
   this.Label3.Text = "Çalýþtýðý Gün Sayýsý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 11;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 142);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox4,
                                                              this.Label4,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.textBox3,
                                                              this.Label3,
                                                              this.textBox1,
                                                              this.button2});
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
   toolTip1.SetToolTip(textBox1, "Buraya iþçinin adýný soyadýný giriniz");
   toolTip1.SetToolTip(textBox2, "Buraya bir günlük yevmiyesini giriniz");
   toolTip1.SetToolTip(textBox3, "Buraya çalýþtýðý gün sayýsýný giriniz");
   toolTip1.SetToolTip(textBox4, "Bu iþçinin alacaðý ücret. Hesapla düðmesine basarak hesaplatabilirsiniz");
   toolTip1.SetToolTip(button1, "Ýþçinin alacaðý ücreti hesaplamak için týklayýn");
   toolTip1.SetToolTip(button2, "Formdaki bilgileri silmek için týklayýn");
  }

  private void Button1_Click(object sender, System.EventArgs e)
  {
   textBox4.Text = (int.Parse(textBox2.Text) * int.Parse(textBox3.Text)).ToString();
  }

  private void Button2_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = "";
   textBox2.Text = "";
   textBox3.Text = "";
   textBox4.Text = "";
  }
	}
}
