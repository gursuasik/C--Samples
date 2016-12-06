using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Group_Box
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.GroupBox groupBox3;
  internal System.Windows.Forms.RadioButton radioButton7;
  internal System.Windows.Forms.RadioButton radioButton6;
  internal System.Windows.Forms.RadioButton radioButton5;
  internal System.Windows.Forms.RadioButton radioButton4;
  internal System.Windows.Forms.GroupBox groupBox4;
  internal System.Windows.Forms.TextBox textBox5;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.GroupBox groupBox5;
  internal System.Windows.Forms.TextBox textBox6;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.RadioButton RadioButton11;
  internal System.Windows.Forms.RadioButton RadioButton10;
  internal System.Windows.Forms.RadioButton RadioButton9;
  internal System.Windows.Forms.RadioButton RadioButton8;
  internal System.Windows.Forms.GroupBox groupBox1;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.GroupBox groupBox2;
  internal System.Windows.Forms.RadioButton radioButton3;
  internal System.Windows.Forms.RadioButton radioButton2;
  internal System.Windows.Forms.RadioButton radioButton1;
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
   this.groupBox3 = new System.Windows.Forms.GroupBox();
   this.radioButton7 = new System.Windows.Forms.RadioButton();
   this.radioButton6 = new System.Windows.Forms.RadioButton();
   this.radioButton5 = new System.Windows.Forms.RadioButton();
   this.radioButton4 = new System.Windows.Forms.RadioButton();
   this.groupBox4 = new System.Windows.Forms.GroupBox();
   this.textBox5 = new System.Windows.Forms.TextBox();
   this.Label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.groupBox5 = new System.Windows.Forms.GroupBox();
   this.textBox6 = new System.Windows.Forms.TextBox();
   this.Label6 = new System.Windows.Forms.Label();
   this.RadioButton11 = new System.Windows.Forms.RadioButton();
   this.RadioButton10 = new System.Windows.Forms.RadioButton();
   this.RadioButton9 = new System.Windows.Forms.RadioButton();
   this.RadioButton8 = new System.Windows.Forms.RadioButton();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.radioButton3 = new System.Windows.Forms.RadioButton();
   this.radioButton2 = new System.Windows.Forms.RadioButton();
   this.radioButton1 = new System.Windows.Forms.RadioButton();
   this.groupBox3.SuspendLayout();
   this.groupBox4.SuspendLayout();
   this.groupBox5.SuspendLayout();
   this.groupBox1.SuspendLayout();
   this.groupBox2.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox3
   // 
   this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.radioButton7,
                                                                        this.radioButton6,
                                                                        this.radioButton5,
                                                                        this.radioButton4});
   this.groupBox3.Location = new System.Drawing.Point(296, 104);
   this.groupBox3.Name = "groupBox3";
   this.groupBox3.Size = new System.Drawing.Size(120, 144);
   this.groupBox3.TabIndex = 7;
   this.groupBox3.TabStop = false;
   this.groupBox3.Text = "Öðrenim Durumu:";
   // 
   // radioButton7
   // 
   this.radioButton7.Checked = true;
   this.radioButton7.Location = new System.Drawing.Point(8, 111);
   this.radioButton7.Name = "radioButton7";
   this.radioButton7.TabIndex = 3;
   this.radioButton7.TabStop = true;
   this.radioButton7.Text = "Üniversite";
   // 
   // radioButton6
   // 
   this.radioButton6.Location = new System.Drawing.Point(8, 82);
   this.radioButton6.Name = "radioButton6";
   this.radioButton6.TabIndex = 2;
   this.radioButton6.Text = "Lise";
   // 
   // radioButton5
   // 
   this.radioButton5.Location = new System.Drawing.Point(8, 53);
   this.radioButton5.Name = "radioButton5";
   this.radioButton5.TabIndex = 1;
   this.radioButton5.Text = "Orta";
   // 
   // radioButton4
   // 
   this.radioButton4.Location = new System.Drawing.Point(8, 24);
   this.radioButton4.Name = "radioButton4";
   this.radioButton4.TabIndex = 0;
   this.radioButton4.Text = "Ýlk";
   // 
   // groupBox4
   // 
   this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.textBox5,
                                                                        this.Label5,
                                                                        this.Label4,
                                                                        this.textBox4});
   this.groupBox4.Location = new System.Drawing.Point(416, 8);
   this.groupBox4.Name = "groupBox4";
   this.groupBox4.Size = new System.Drawing.Size(176, 96);
   this.groupBox4.TabIndex = 8;
   this.groupBox4.TabStop = false;
   this.groupBox4.Text = "Aile Bilgileri";
   // 
   // textBox5
   // 
   this.textBox5.Location = new System.Drawing.Point(96, 56);
   this.textBox5.Name = "textBox5";
   this.textBox5.Size = new System.Drawing.Size(72, 20);
   this.textBox5.TabIndex = 4;
   this.textBox5.Text = "textBox5";
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(6, 64);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 3;
   this.Label5.Text = "Evlenme Tarihi:";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(3, 26);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(77, 23);
   this.Label4.TabIndex = 2;
   this.Label4.Text = "Çoçuk Sayýsý:";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(96, 24);
   this.textBox4.Name = "textBox4";
   this.textBox4.Size = new System.Drawing.Size(72, 20);
   this.textBox4.TabIndex = 0;
   this.textBox4.Text = "textBox4";
   // 
   // groupBox5
   // 
   this.groupBox5.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.textBox6,
                                                                        this.Label6,
                                                                        this.RadioButton11,
                                                                        this.RadioButton10,
                                                                        this.RadioButton9,
                                                                        this.RadioButton8});
   this.groupBox5.Location = new System.Drawing.Point(416, 104);
   this.groupBox5.Name = "groupBox5";
   this.groupBox5.Size = new System.Drawing.Size(176, 144);
   this.groupBox5.TabIndex = 9;
   this.groupBox5.TabStop = false;
   this.groupBox5.Text = "Mezun Olduðu Fakülte";
   // 
   // textBox6
   // 
   this.textBox6.Location = new System.Drawing.Point(64, 112);
   this.textBox6.Name = "textBox6";
   this.textBox6.TabIndex = 5;
   this.textBox6.Text = "textBox6";
   // 
   // Label6
   // 
   this.Label6.Location = new System.Drawing.Point(8, 114);
   this.Label6.Name = "Label6";
   this.Label6.TabIndex = 4;
   this.Label6.Text = "Diðer:";
   // 
   // RadioButton11
   // 
   this.RadioButton11.Location = new System.Drawing.Point(64, 88);
   this.RadioButton11.Name = "RadioButton11";
   this.RadioButton11.TabIndex = 3;
   this.RadioButton11.Text = "Týp";
   // 
   // RadioButton10
   // 
   this.RadioButton10.Location = new System.Drawing.Point(64, 64);
   this.RadioButton10.Name = "RadioButton10";
   this.RadioButton10.TabIndex = 2;
   this.RadioButton10.Text = "Fen/Edebiyat";
   // 
   // RadioButton9
   // 
   this.RadioButton9.Location = new System.Drawing.Point(64, 40);
   this.RadioButton9.Name = "RadioButton9";
   this.RadioButton9.TabIndex = 1;
   this.RadioButton9.Text = "Eðitim";
   // 
   // RadioButton8
   // 
   this.RadioButton8.Location = new System.Drawing.Point(64, 16);
   this.RadioButton8.Name = "RadioButton8";
   this.RadioButton8.TabIndex = 0;
   this.RadioButton8.Text = "Mühendislik";
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.Label3,
                                                                        this.textBox3,
                                                                        this.Label2,
                                                                        this.Label1,
                                                                        this.textBox1,
                                                                        this.textBox2});
   this.groupBox1.Location = new System.Drawing.Point(8, 8);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(280, 240);
   this.groupBox1.TabIndex = 5;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Personelin";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(16, 64);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 4;
   this.Label3.Text = "Adresi:";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(120, 64);
   this.textBox3.Multiline = true;
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(152, 168);
   this.textBox3.TabIndex = 3;
   this.textBox3.Text = "textBox3";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(16, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 2;
   this.Label2.Text = "Telefonu:";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 16);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 0;
   this.Label1.Text = "Adý Soyadý:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(152, 20);
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "textBox1";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(120, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(152, 20);
   this.textBox2.TabIndex = 1;
   this.textBox2.Text = "textBox2";
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.radioButton3,
                                                                        this.radioButton2,
                                                                        this.radioButton1});
   this.groupBox2.Location = new System.Drawing.Point(296, 8);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(120, 96);
   this.groupBox2.TabIndex = 6;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Medeni Hali:";
   // 
   // radioButton3
   // 
   this.radioButton3.Location = new System.Drawing.Point(8, 64);
   this.radioButton3.Name = "radioButton3";
   this.radioButton3.TabIndex = 2;
   this.radioButton3.Text = "Dul";
   // 
   // radioButton2
   // 
   this.radioButton2.Checked = true;
   this.radioButton2.Location = new System.Drawing.Point(8, 40);
   this.radioButton2.Name = "radioButton2";
   this.radioButton2.TabIndex = 1;
   this.radioButton2.TabStop = true;
   this.radioButton2.Text = "Evli";
   // 
   // radioButton1
   // 
   this.radioButton1.Location = new System.Drawing.Point(8, 16);
   this.radioButton1.Name = "radioButton1";
   this.radioButton1.TabIndex = 0;
   this.radioButton1.Text = "Bekar";
   this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(600, 254);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.groupBox3,
                                                              this.groupBox4,
                                                              this.groupBox5,
                                                              this.groupBox1,
                                                              this.groupBox2});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.groupBox3.ResumeLayout(false);
   this.groupBox4.ResumeLayout(false);
   this.groupBox5.ResumeLayout(false);
   this.groupBox1.ResumeLayout(false);
   this.groupBox2.ResumeLayout(false);
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
   //Olaylarý birleþtir. 
   radioButton2.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   radioButton3.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   radioButton4.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   radioButton5.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   radioButton6.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   radioButton7.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   //Bütün RadioGroup kontrolleri için radioButton1_CheckedChanged olayý çalýþacaktýr
  }

  private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
  {
   if (radioButton1.Checked==true) //Bekar iþaretliyse
    groupBox4.Visible = false;     //Aile durumunu gizle
   else                            //Deðilse 
    groupBox4.Visible = true;      //Göster

   if (radioButton7.Checked==true) //Üniversite iþaretliyse
    groupBox5.Visible = true;      //Fakülte bölümünü göster
   else                            //Deðilse 
    groupBox5.Visible = false;     //Gizle
  }
	}
}
