using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Alarm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Timer timer2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Timer timer1;
  internal System.Windows.Forms.Label Label1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.timer2 = new System.Windows.Forms.Timer(this.components);
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Image = ((System.Drawing.Bitmap)(resources.GetObject("button2.Image")));
   this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
   this.button2.Location = new System.Drawing.Point(280, 16);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(72, 56);
   this.button2.TabIndex = 26;
   this.button2.Text = "Alarmý Kapat";
   this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("button1.Image")));
   this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
   this.button1.Location = new System.Drawing.Point(192, 16);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(80, 56);
   this.button1.TabIndex = 25;
   this.button1.Text = "Alarmý Aç";
   this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(72, 23);
   this.Label3.TabIndex = 23;
   this.Label3.Text = "Alarm Metni";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(88, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 24;
   this.textBox3.Text = "TextBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(88, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 22;
   this.textBox2.Text = "TextBox2";
   // 
   // timer2
   // 
   this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 21;
   this.Label2.Text = "Alarm Saati";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(88, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 20;
   this.textBox1.Text = "TextBox1";
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(88, 16);
   this.Label1.TabIndex = 19;
   this.Label1.Text = "Alarm Tarihi";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(360, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label3,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.Label1,
                                                              this.button2,
                                                              this.button1});
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
   //tarih ve saati Text kutularýnda göster
   textBox1.Text = DateTime.Now.ToShortDateString();
   textBox2.Text = DateTime.Now.ToLongTimeString();
   //Baþlangýçta alarm kapalý
   timer2.Enabled = false;
   timer1.Enabled = false;
   //her 100 ms'de bir yanýp sönmeyi saðla
   timer2.Interval = 100;
   //her 1000 ms'de bir alarmý kontrol etsin
   timer1.Interval = 1000;
   Text = "Alarm Kapalý";
  }

  private void timer1_Tick(object sender, System.EventArgs e)
  {
   //alarm zamaný geldiyse
   if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToLongTimeString())
   {
    //timer2yi aktif yap (yanýp sönmeyi saðlayacak)
    timer2.Enabled = true;
    //Alarm metnini bildir
    MessageBox.Show(textBox3.Text);
   }
  }

  private void timer2_Tick(object sender, System.EventArgs e)
  {
   //Yazý ve zemin rengini deðiþtirerek 
   //Yanýp sönmesini saðla
   Color c;
   c=textBox3.BackColor;
   textBox3.BackColor=textBox3.ForeColor ;
   textBox3.ForeColor=c;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Alarmý aktif yap
   timer1.Enabled = true;
   this.Text = "Alarm Açýk";
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //alarmý kapat
   timer2.Enabled = false;
   timer1.Enabled = false;
   this.Text = "Alarm Kapalý";
  }
	}
}
