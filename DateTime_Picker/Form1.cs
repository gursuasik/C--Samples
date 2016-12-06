using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DateTime_Picker
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.DateTimePicker dateTimePicker3;
  internal System.Windows.Forms.DateTimePicker dateTimePicker2;
  internal System.Windows.Forms.DateTimePicker dateTimePicker1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
   this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
   this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label6 = new System.Windows.Forms.Label();
   this.Label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.button1 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.dateTimePicker3,
                                                                        this.dateTimePicker2,
                                                                        this.dateTimePicker1,
                                                                        this.textBox3,
                                                                        this.textBox2,
                                                                        this.textBox1,
                                                                        this.Label6,
                                                                        this.Label5,
                                                                        this.Label4,
                                                                        this.Label3,
                                                                        this.Label2,
                                                                        this.Label1,
                                                                        this.button1,
                                                                        this.button2});
   this.GroupBox1.Location = new System.Drawing.Point(8, 8);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(528, 136);
   this.GroupBox1.TabIndex = 3;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "��rencinin";
   // 
   // dateTimePicker3
   // 
   this.dateTimePicker3.Location = new System.Drawing.Point(352, 70);
   this.dateTimePicker3.Name = "dateTimePicker3";
   this.dateTimePicker3.Size = new System.Drawing.Size(152, 20);
   this.dateTimePicker3.TabIndex = 11;
   // 
   // dateTimePicker2
   // 
   this.dateTimePicker2.Location = new System.Drawing.Point(352, 46);
   this.dateTimePicker2.Name = "dateTimePicker2";
   this.dateTimePicker2.Size = new System.Drawing.Size(152, 20);
   this.dateTimePicker2.TabIndex = 10;
   // 
   // dateTimePicker1
   // 
   this.dateTimePicker1.Location = new System.Drawing.Point(352, 22);
   this.dateTimePicker1.Name = "dateTimePicker1";
   this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
   this.dateTimePicker1.TabIndex = 9;
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(104, 72);
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(152, 20);
   this.textBox3.TabIndex = 8;
   this.textBox3.Text = "textBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(104, 44);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(152, 20);
   this.textBox2.TabIndex = 7;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(104, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(152, 20);
   this.textBox1.TabIndex = 6;
   this.textBox1.Text = "textBox1";
   // 
   // Label6
   // 
   this.Label6.AutoSize = true;
   this.Label6.Location = new System.Drawing.Point(264, 70);
   this.Label6.Name = "Label6";
   this.Label6.Size = new System.Drawing.Size(87, 13);
   this.Label6.TabIndex = 5;
   this.Label6.Text = "Mezuniyet Tarihi";
   // 
   // Label5
   // 
   this.Label5.AutoSize = true;
   this.Label5.Location = new System.Drawing.Point(264, 46);
   this.Label5.Name = "Label5";
   this.Label5.Size = new System.Drawing.Size(61, 13);
   this.Label5.TabIndex = 4;
   this.Label5.Text = "Kay�t Tarihi";
   // 
   // Label4
   // 
   this.Label4.AutoSize = true;
   this.Label4.Location = new System.Drawing.Point(264, 22);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(72, 13);
   this.Label4.TabIndex = 3;
   this.Label4.Text = "Do�um Tarihi";
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(16, 78);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(64, 13);
   this.Label3.TabIndex = 2;
   this.Label3.Text = "Do�um Yeri";
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(16, 51);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(50, 13);
   this.Label2.TabIndex = 1;
   this.Label2.Text = "Baba Ad�";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(16, 24);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(58, 13);
   this.Label1.TabIndex = 0;
   this.Label1.Text = "Ad� Soyad�";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(104, 104);
   this.button1.Name = "button1";
   this.button1.TabIndex = 1;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(184, 104);
   this.button2.Name = "button2";
   this.button2.TabIndex = 3;
   this.button2.Text = "Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 144);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(528, 173);
   this.listBox1.TabIndex = 4;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(544, 326);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.listBox1,
                                                              this.GroupBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
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

  struct ogrenci
  {
   public string Ad�, BabaAd�, Do�umYeri;
   public DateTime Do�umTarihi, Kay�tTarihi, MezuniyetTarihi;
   public Boolean MezunOldu;

   public override string ToString()
   {
    string s1, s2;
    s1 = Ad�;
    s1 = s1.PadRight(20);
    s2 = s1;

    s1 = BabaAd�;
    s1 = s1.PadRight(10);
    s2 = s2 + s1;

    s1 = Do�umYeri;
    s1 = s1.PadRight(10);
    s2 = s2 + s1;

    s1 = Do�umTarihi.ToShortDateString();
    s1 = s1.PadRight(11);
    s2 = s2 + s1;

    s1 = Kay�tTarihi.ToShortDateString();
    s1 = s1.PadRight(11);
    s2 = s2 + s1;
    if (MezunOldu)
     s1 = Do�umTarihi.ToShortDateString();
    else
     s1 = "Mezun olmad�";
    s1 = s1.PadRight(12);
    s2 = s2 + s1;
    return s2;
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Tarihler k�sa tarih format�nda g�sterilsin
   dateTimePicker1.Format = DateTimePickerFormat.Short;
   dateTimePicker2.Format = DateTimePickerFormat.Short;
   dateTimePicker3.Format = DateTimePickerFormat.Short;

   //Tarihler bug�n�n tarihinde b�y�k olamas�n
   dateTimePicker1.MaxDate = DateTime.Now;
   dateTimePicker2.MaxDate = DateTime.Now;
   dateTimePicker3.MaxDate = DateTime.Now;

   //Mezuniyet tarihinde checkBox bulunsun
   dateTimePicker3.ShowCheckBox = true;

   //Listenin d�zg�n g�z�kmesi i�in Courier New fontu kullan�ls�n
   listBox1.Font = new Font("Courier New", 8, FontStyle.Regular);
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   ogrenci o ;
   //Bilgileri ogrenci tipindeki de�i�kene al
   o.Ad� = textBox1.Text;
   o.BabaAd� = textBox2.Text;
   o.Do�umYeri = textBox3.Text;
   o.Do�umTarihi = dateTimePicker1.Value;
   o.Kay�tTarihi = dateTimePicker2.Value;
   o.MezuniyetTarihi = dateTimePicker3.Value;
   if (dateTimePicker3.Checked)
    o.MezunOldu = true;
   else
    o.MezunOldu = false;
   //Tarihlerin do�rulu�unu kontrol et
   if (o.Do�umTarihi >= o.Kay�tTarihi)
   {
    MessageBox.Show("Do�um Tarihi veya Kay�t Tarihi yanl�� girilmi�");
    return;
   }
   if (o.MezunOldu)
    if (o.Kay�tTarihi > o.MezuniyetTarihi)
    {
     MessageBox.Show("Mezuniyet Tarihi veya Kay�t Tarihi yanl�� girilmi�");
     return;
    }
   //Listeye ekle
   listBox1.Items.Add(o);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   listBox1.Items.Remove(listBox1.SelectedItem);
  }

  
	}
}
