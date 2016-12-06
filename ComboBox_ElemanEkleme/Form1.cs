using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ComboBox_ElemanEkleme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  private System.Windows.Forms.Label label4;
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
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 56);
   this.textBox2.Multiline = true;
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(120, 56);
   this.textBox2.TabIndex = 11;
   this.textBox2.Text = "textBox2";
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(112, 32);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(121, 21);
   this.comboBox1.TabIndex = 10;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
   this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(120, 20);
   this.textBox1.TabIndex = 9;
   this.textBox1.Text = "textBox1";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 8;
   this.Label3.Text = "Adresi";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 7;
   this.Label2.Text = "Mesleði";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 6;
   this.Label1.Text = "Adý Soyadý";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(8, 120);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(224, 40);
   this.label4.TabIndex = 12;
   this.label4.Text = "ComboBox içinde olmayan meslekleri elle yazabilirsiniz. Yazdýðýnýz meslekler list" +
    "eye eklenecektir.";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.textBox2,
                                                              this.comboBox1,
                                                              this.textBox1,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1});
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
   string[] meslekler = {"Ýþçi", "Mühendis", "Muhasebeci", "Eðitimci", 
                         "Programcý", "Teknisyen"};
    comboBox1.Items.AddRange(meslekler);
  }

  private void comboBox1_Leave(object sender, System.EventArgs e)
  {
   if (comboBox1.FindStringExact(comboBox1.Text) < 0)
    //Yazýlan eleman comboBox içinde yoksa
    comboBox1.Items.Add(comboBox1.Text); //Listeye ekle
  }

  private void comboBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
  {
   if (e.KeyChar == (char)27)
    //ESC’ye basýldý ise
    comboBox1.Text = comboBox1.Items[0].ToString();
  }
	}
}
