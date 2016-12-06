using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RichTextBox_KelimeIslemci
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.RadioButton radioButton2;
  internal System.Windows.Forms.RadioButton radioButton1;
  internal System.Windows.Forms.CheckBox checkBox2;
  internal System.Windows.Forms.CheckBox checkBox1;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.radioButton2 = new System.Windows.Forms.RadioButton();
   this.radioButton1 = new System.Windows.Forms.RadioButton();
   this.checkBox2 = new System.Windows.Forms.CheckBox();
   this.checkBox1 = new System.Windows.Forms.CheckBox();
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.radioButton2,
                                                                        this.radioButton1});
   this.GroupBox1.Location = new System.Drawing.Point(176, 72);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(128, 64);
   this.GroupBox1.TabIndex = 21;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "Arama Yönü";
   // 
   // radioButton2
   // 
   this.radioButton2.Location = new System.Drawing.Point(16, 36);
   this.radioButton2.Name = "radioButton2";
   this.radioButton2.Size = new System.Drawing.Size(64, 24);
   this.radioButton2.TabIndex = 1;
   this.radioButton2.Text = "Sondan";
   // 
   // radioButton1
   // 
   this.radioButton1.Location = new System.Drawing.Point(16, 16);
   this.radioButton1.Name = "radioButton1";
   this.radioButton1.Size = new System.Drawing.Size(64, 24);
   this.radioButton1.TabIndex = 0;
   this.radioButton1.Text = "Baþtan";
   // 
   // checkBox2
   // 
   this.checkBox2.Location = new System.Drawing.Point(8, 112);
   this.checkBox2.Name = "checkBox2";
   this.checkBox2.Size = new System.Drawing.Size(168, 24);
   this.checkBox2.TabIndex = 20;
   this.checkBox2.Text = "Yalnýzca Tam sözcükleri bul";
   // 
   // checkBox1
   // 
   this.checkBox1.Location = new System.Drawing.Point(8, 80);
   this.checkBox1.Name = "checkBox1";
   this.checkBox1.Size = new System.Drawing.Size(160, 24);
   this.checkBox1.TabIndex = 19;
   this.checkBox1.Text = "Büyük-Küçük Harf Duyarlý";
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(312, 112);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(96, 23);
   this.button4.TabIndex = 18;
   this.button4.Text = "Tümünü Deðiþtir";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(312, 80);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(96, 23);
   this.button3.TabIndex = 17;
   this.button3.Text = "Deðiþtir";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(312, 48);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(96, 23);
   this.button2.TabIndex = 16;
   this.button2.Text = "Sonrakini Bul";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(312, 16);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 15;
   this.button1.Text = "Bul";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(88, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(208, 20);
   this.textBox2.TabIndex = 14;
   this.textBox2.Text = "textBox2";
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(8, 48);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(61, 13);
   this.Label2.TabIndex = 12;
   this.Label2.Text = "Yeni Deðer";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 24);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(41, 13);
   this.Label1.TabIndex = 11;
   this.Label1.Text = "Aranan";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(88, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(208, 20);
   this.textBox1.TabIndex = 13;
   this.textBox1.Text = "textBox1";
   // 
   // Form2
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(416, 150);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.GroupBox1,
                                                              this.checkBox2,
                                                              this.checkBox1,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.textBox1});
   this.Name = "Form2";
   this.Text = "Form2";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form2_Closing);
   this.Load += new System.EventHandler(this.Form2_Load);
   this.GroupBox1.ResumeLayout(false);
   this.ResumeLayout(false);

  }
		#endregion

  private void Form2_Load(object sender, System.EventArgs e)
  {
   this.TopMost = true;
  }

  private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   e.Cancel = true;
   this.Hide();
  }

  public RichTextBoxFinds arama_modu()
  {
   RichTextBoxFinds  m;
   if (checkBox1.Checked == true)
    m = RichTextBoxFinds.MatchCase;
   else
    m = RichTextBoxFinds.None;
   if (checkBox2.Checked == true)
    m = m | RichTextBoxFinds.WholeWord;
   else
    m = m | RichTextBoxFinds.None;
   if (radioButton2.Checked == true)
    m = m | RichTextBoxFinds.Reverse;
   else
    m = m | RichTextBoxFinds.None;
   return m;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int yer;
   yer = Form1.Rich_Text_Box.Find(textBox1.Text, 0, arama_modu());
   if (yer < 0)
    MessageBox.Show("Bulunamadý");
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int yer;
   yer = Form1.Rich_Text_Box.Find(textBox1.Text, 
    Form1.Rich_Text_Box.SelectionStart + 1, 
    arama_modu());
   if (yer < 0)
    MessageBox.Show("Baþka bulunamadý");
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   //seçili ifade aranan ifadeyse onu deðiþtir
   if (Form1.Rich_Text_Box.SelectedText == textBox1.Text)
    Form1.Rich_Text_Box.SelectedText = textBox2.Text; //deðiþtir
   else
   {
    //aranan ifadeyi bulup deðiþtir
    int yer;
    yer = Form1.Rich_Text_Box.Find(textBox1.Text, 0, arama_modu());
    if (yer < 0)
     MessageBox.Show("Baþka bulunamadý");
    else
     Form1.Rich_Text_Box.SelectedText = textBox2.Text; //deðiþtir
   }
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   int yer, sayi=0;
   yer = Form1.Rich_Text_Box.Find(textBox1.Text, arama_modu());
   while (yer >= 0)
   {
    sayi = sayi + 1;
    Form1.Rich_Text_Box.SelectedText = textBox2.Text;
    yer = yer+textBox2.Text.Length-1;//Yeni yer deðiþtirilen metnin son harfi
    yer = Form1.Rich_Text_Box.Find(textBox1.Text, yer + 1, arama_modu());
   }
   MessageBox.Show(sayi.ToString() + " tane deðiþtirme iþlemi yapýldý");
  }
	}
}
