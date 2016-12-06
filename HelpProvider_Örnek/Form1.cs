using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HelpProvider_Örnek
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.GroupBox GroupBox2;
  internal System.Windows.Forms.Button Button3;
  internal System.Windows.Forms.HelpProvider HelpProvider1;
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.Button Button2;
  internal System.Windows.Forms.Button Button1;
  internal System.Windows.Forms.TextBox TextBox4;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox TextBox1;
  internal System.Windows.Forms.Label Label1;
  private System.Windows.Forms.Label label5;
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
   this.GroupBox2 = new System.Windows.Forms.GroupBox();
   this.Button3 = new System.Windows.Forms.Button();
   this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.Button2 = new System.Windows.Forms.Button();
   this.Button1 = new System.Windows.Forms.Button();
   this.TextBox4 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.GroupBox2.SuspendLayout();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // GroupBox2
   // 
   this.GroupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.Button3});
   this.GroupBox2.Location = new System.Drawing.Point(8, 136);
   this.GroupBox2.Name = "GroupBox2";
   this.GroupBox2.Size = new System.Drawing.Size(400, 80);
   this.GroupBox2.TabIndex = 3;
   this.GroupBox2.TabStop = false;
   this.GroupBox2.Text = "Windows\\Help klasörü altýndaki  glossary.chm dosyasýný görmek için aþaðýdaki düðm" +
    "eyi týklayýn";
   // 
   // Button3
   // 
   this.Button3.Location = new System.Drawing.Point(24, 32);
   this.Button3.Name = "Button3";
   this.Button3.Size = new System.Drawing.Size(352, 32);
   this.Button3.TabIndex = 0;
   this.Button3.Text = "Teknik terimler sözlüðü";
   this.Button3.Click += new System.EventHandler(this.Button3_Click);
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.label5,
                                                                        this.Button2,
                                                                        this.Button1,
                                                                        this.TextBox4,
                                                                        this.Label4,
                                                                        this.TextBox3,
                                                                        this.Label3,
                                                                        this.TextBox2,
                                                                        this.Label2,
                                                                        this.TextBox1,
                                                                        this.Label1});
   this.GroupBox1.Location = new System.Drawing.Point(8, 8);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(400, 120);
   this.GroupBox1.TabIndex = 2;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "F1 Tuþuna basarak bu bölümdeki kontroller hakkýnda yardým alabilirsiniz.";
   // 
   // Button2
   // 
   this.HelpProvider1.SetHelpString(this.Button2, "Personele ait bilgi giriþ kutularýný silmek için bu düðmeyi kullanabilirsiniz");
   this.Button2.Location = new System.Drawing.Point(248, 48);
   this.Button2.Name = "Button2";
   this.HelpProvider1.SetShowHelp(this.Button2, true);
   this.Button2.Size = new System.Drawing.Size(96, 23);
   this.Button2.TabIndex = 19;
   this.Button2.Text = "Sil";
   this.Button2.Click += new System.EventHandler(this.Button2_Click);
   // 
   // Button1
   // 
   this.HelpProvider1.SetHelpString(this.Button1, "Personelin alacaðý maaþý hesaplamak için bu düðmeye basýnýz");
   this.Button1.Location = new System.Drawing.Point(248, 16);
   this.Button1.Name = "Button1";
   this.HelpProvider1.SetShowHelp(this.Button1, true);
   this.Button1.Size = new System.Drawing.Size(96, 23);
   this.Button1.TabIndex = 18;
   this.Button1.Text = "Hesapla";
   this.Button1.Click += new System.EventHandler(this.Button1_Click);
   // 
   // TextBox4
   // 
   this.HelpProvider1.SetHelpString(this.TextBox4, "Bu kutunun içeriði Yevmiyesi ve Çalýþtýðý Gün Sayýsý kutularýnýn içeriðine göre o" +
    "tomatik hesaplanýr. Sonucu görmek için Hesapla düðmesine basmalýsýnýz");
   this.TextBox4.Location = new System.Drawing.Point(128, 88);
   this.TextBox4.Name = "TextBox4";
   this.HelpProvider1.SetShowHelp(this.TextBox4, true);
   this.TextBox4.TabIndex = 17;
   this.TextBox4.Text = "TextBox4";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(16, 88);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 16;
   this.Label4.Text = "Alacaðý ücret";
   // 
   // TextBox3
   // 
   this.HelpProvider1.SetHelpString(this.TextBox3, "Bu kutuya maaþýný hesaplayacaðýnýz personelin kaç gün çalýþtýðýný yazýnýz");
   this.TextBox3.Location = new System.Drawing.Point(128, 64);
   this.TextBox3.Name = "TextBox3";
   this.HelpProvider1.SetShowHelp(this.TextBox3, true);
   this.TextBox3.TabIndex = 15;
   this.TextBox3.Text = "TextBox3";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(16, 64);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(104, 23);
   this.Label3.TabIndex = 14;
   this.Label3.Text = "Çalýþtýðý Gün Sayýsý";
   // 
   // TextBox2
   // 
   this.HelpProvider1.SetHelpString(this.TextBox2, "Bu kutuya maaþýný hesaplayacaðýnýz personelin bir günlük ücretini yazýnýz");
   this.TextBox2.Location = new System.Drawing.Point(128, 40);
   this.TextBox2.Name = "TextBox2";
   this.HelpProvider1.SetShowHelp(this.TextBox2, true);
   this.TextBox2.TabIndex = 13;
   this.TextBox2.Text = "TextBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(16, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 12;
   this.Label2.Text = "Yevmiyesi";
   // 
   // TextBox1
   // 
   this.HelpProvider1.SetHelpString(this.TextBox1, "Bu kutuya maaþýný hesaplayacaðýnýz personelin adýný ve soyadýný yazýnýz");
   this.TextBox1.Location = new System.Drawing.Point(128, 16);
   this.TextBox1.Name = "TextBox1";
   this.HelpProvider1.SetShowHelp(this.TextBox1, true);
   this.TextBox1.TabIndex = 11;
   this.TextBox1.Text = "TextBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 16);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 10;
   this.Label1.Text = "Adý Soyadý";
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(248, 80);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(144, 32);
   this.label5.TabIndex = 20;
   this.label5.Text = "Sað üst köþedeki ? simgesi ile de yardým alabilirsiniz.";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(408, 222);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.GroupBox1,
                                                              this.GroupBox2});
   this.HelpButton = true;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "Form1";
   this.Text = "Form1";
   this.GroupBox2.ResumeLayout(false);
   this.GroupBox1.ResumeLayout(false);
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

  private void Button1_Click(object sender, System.EventArgs e)
  {
    TextBox4.Text = (int.Parse(TextBox2.Text) * int.Parse(TextBox3.Text)).ToString();
  }

  private void Button2_Click(object sender, System.EventArgs e)
  {
   TextBox1.Text = "";
   TextBox2.Text = "";
   TextBox3.Text = "";
   TextBox4.Text = "";
  }

  private void Button3_Click(object sender, System.EventArgs e)
  {
   Help.ShowHelp(this, "C:\\WINDOWS\\Help\\Glossary.chm");
  }
	}
}
