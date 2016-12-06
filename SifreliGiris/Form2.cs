using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SifreliGiris
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
				if(components != null)
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
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(16, 24);
   this.label1.Name = "label1";
   this.label1.TabIndex = 0;
   this.label1.Text = "Þifre";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(104, 24);
   this.textBox1.Name = "textBox1";
   this.textBox1.PasswordChar = '*';
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 72);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 2;
   this.button1.Text = "Tamam";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(112, 72);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(96, 23);
   this.button2.TabIndex = 3;
   this.button2.Text = "Ýptal";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form2
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 102);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1,
                                                              this.label1});
   this.Name = "Form2";
   this.Text = "Form2";
   this.Load += new System.EventHandler(this.Form2_Load);
   this.ResumeLayout(false);

  }
		#endregion

  int hak=0;
  private void button1_Click(object sender, System.EventArgs e)
  {
   hak++;
   if (textBox1.Text == "1234")
    this.DialogResult = DialogResult.OK;
   else
   {
    textBox1.Text =""; 
    this.Text="Yanlýþ þifre";
    if (hak == 3)
    {
     this.DialogResult = DialogResult.Cancel;
     MessageBox.Show("Programý yetkisiz kiþiler kullanamaz");
    }
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
     this.DialogResult = DialogResult.Cancel;
  }

  private void Form2_Load(object sender, System.EventArgs e)
  {
   //Esc'ye basýldýðýnda Ýptal düðmesi aktif olsun
   this.CancelButton=button2;
   //Enter'e basýldýðýnda Tamam düðmesi aktif olsun
   this.AcceptButton=button1;
  }
	}
}
