using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AileYard�m�
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.CheckBox checkBox2;
  internal System.Windows.Forms.CheckBox checkBox1;
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
   this.button1 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.checkBox2 = new System.Windows.Forms.CheckBox();
   this.checkBox1 = new System.Windows.Forms.CheckBox();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 144);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(200, 23);
   this.button1.TabIndex = 13;
   this.button1.Text = "Aile Yard�m� Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 112);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 12;
   this.textBox2.Text = "textBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 112);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 11;
   this.Label2.Text = "�ocuk Say�n�z";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 10;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 9;
   this.Label1.Text = "Maa� Katsay�n�z";
   // 
   // checkBox2
   // 
   this.checkBox2.Location = new System.Drawing.Point(112, 80);
   this.checkBox2.Name = "checkBox2";
   this.checkBox2.TabIndex = 8;
   this.checkBox2.Text = "E�im �al���yor";
   // 
   // checkBox1
   // 
   this.checkBox1.Location = new System.Drawing.Point(112, 48);
   this.checkBox1.Name = "checkBox1";
   this.checkBox1.Size = new System.Drawing.Size(112, 24);
   this.checkBox1.TabIndex = 7;
   this.checkBox1.Text = "Evli";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 182);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.Label1,
                                                              this.checkBox2,
                                                              this.checkBox1});
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
   int mk, �ocuk_Say�s�, Aile_Yard�m� ;
   try
   {
    mk = int.Parse(textBox1.Text);
   }
   catch
   {
    MessageBox.Show("Maa� katsay�s� i�in ge�ersiz say� girilmi�");
    return;//prosed�rden ��k
   }
   if (checkBox1.Checked == false) //Evli i�aretli de�ilse
    Aile_Yard�m� = 0;
   else
   {
    try
    {
     �ocuk_Say�s� = int.Parse(textBox2.Text);
    }
    catch
    {
     MessageBox.Show("�ocuk say�s� i�in ge�ersiz say� girilmi�");
     return;//prosed�rden ��k
    }
    if (�ocuk_Say�s� > 2)
     �ocuk_Say�s� = 2;
    if (checkBox2.Checked == true)//E�im �al���yor i�aretliyse
     Aile_Yard�m� = �ocuk_Say�s� * 50 * mk;
    else
     Aile_Yard�m� = �ocuk_Say�s� * 50 * mk + 300 * mk;
   }
   MessageBox.Show("Aile Yard�m� " + Aile_Yard�m�.ToString("###,###") + "TL dir");
  }
	}
}
