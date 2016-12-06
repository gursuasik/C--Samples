using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TextChanged
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
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
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(112, 80);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 15;
   this.textBox3.Text = "TextBox3";
   this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 56);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 14;
   this.textBox2.Text = "TextBox2";
   this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(112, 32);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
   this.numericUpDown1.TabIndex = 13;
   this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_TextChanged);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 12;
   this.textBox1.Text = "TextBox1";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 80);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 11;
   this.Label4.Text = "Tutarý";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 32);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 10;
   this.Label3.Text = "Adeti";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 56);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 9;
   this.Label2.Text = "Birim Fiyatý";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 8;
   this.Label1.Text = "Malzeme Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 110);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.numericUpDown1,
                                                              this.textBox1,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
   textBox3.ReadOnly = true; //Tutarý deðiþtirilemesin;
   //Olaylarý birleþtir
   textBox2.TextChanged += new EventHandler(numericUpDown1_TextChanged);
  }

  private void numericUpDown1_TextChanged(object sender, System.EventArgs e)
  {
   try
   {
    textBox3.Text = (int.Parse(numericUpDown1.Text) * int.Parse(textBox2.Text)).ToString();
   }
   catch
   {
    textBox3.Text ="Sayýlar hatalý";
   }
  }
	}
}
