using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_Scale
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.Label1 = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 267);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(768, 23);
   this.Label1.TabIndex = 13;
   this.Label1.Text = "Ekran çözünürlüðünü deðiþtirdiðinizde bu formun ve içindeki kontrollerin boyutlar" +
    "ý da ayný oranda deðiþecektir.";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(8, 331);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(768, 216);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 12;
   this.pictureBox1.TabStop = false;
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(600, 299);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(176, 23);
   this.button4.TabIndex = 11;
   this.button4.Text = "Button4";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(392, 299);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(200, 23);
   this.button3.TabIndex = 10;
   this.button3.Text = "Button3";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(192, 299);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(192, 23);
   this.button2.TabIndex = 9;
   this.button2.Text = "Button2";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 299);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(176, 23);
   this.button1.TabIndex = 8;
   this.button1.Text = "Button1";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 11);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(768, 256);
   this.textBox1.TabIndex = 7;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(784, 558);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.pictureBox1,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1});
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

  int orijinal_x = 800;
  int orijinal_y = 600;

  private void Form1_Load(object sender, System.EventArgs e)
  {
   Rectangle çözünürlük = new Rectangle();
   çözünürlük = Screen.GetBounds(çözünürlük);
   float oran_x, oran_y;
   oran_x = (float) çözünürlük.Width / orijinal_x;
   oran_y = (float) çözünürlük.Height / orijinal_y;
   this.Left = 0;
   this.Top = 0;
   this.Scale(oran_x, oran_y);
  }
	}
}
