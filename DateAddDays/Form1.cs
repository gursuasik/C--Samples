using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DateAddDays
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.label4 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(112, 56);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(160, 23);
   this.label4.TabIndex = 17;
   this.label4.Text = "Label4";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(160, 20);
   this.textBox2.TabIndex = 16;
   this.textBox2.Text = "TextBox2";
   this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(160, 20);
   this.textBox1.TabIndex = 15;
   this.textBox1.Text = "TextBox1";
   this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 14;
   this.Label3.Text = "Kurs Bitimi:";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 13;
   this.Label2.Text = "Kurs Süresi(gün)";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(88, 24);
   this.Label1.TabIndex = 12;
   this.Label1.Text = "Kurs Baþlangýcý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(288, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1});
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

  private void textBox1_TextChanged(object sender, System.EventArgs e)
  {
   DateTime baslangic, bitis;
   int gun;
   try
   {
    baslangic = DateTime.Parse(textBox1.Text);
    gun = int.Parse(textBox2.Text);
    bitis = baslangic.AddDays(gun);
    label4.Text = bitis.ToLongDateString();
   }
   catch 
   {
    //hata oluþursa herhangi bir iþlem yapýlmayacak
    ;
   }
  }

  private void textBox2_TextChanged(object sender, System.EventArgs e)
  {
   textBox1_TextChanged(textBox2, e);//textBox1e yazdýðým kodu çaðýr
  }
 }
}
