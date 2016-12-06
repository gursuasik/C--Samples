using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Font_Özellikleri
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
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
   this.Label1 = new System.Windows.Forms.Label();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(248, 112);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(72, 23);
   this.Label1.TabIndex = 18;
   this.Label1.Text = "Font :Boyutu";
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(336, 112);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
   this.numericUpDown1.TabIndex = 17;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(176, 112);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(64, 23);
   this.button4.TabIndex = 16;
   this.button4.Text = "Üstü Çizili";
   this.button4.Click += new System.EventHandler(this.button1_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(112, 112);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(56, 23);
   this.button3.TabIndex = 15;
   this.button3.Text = "Altý Çizili";
   this.button3.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(64, 112);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(40, 23);
   this.button2.TabIndex = 14;
   this.button2.Text = "Eðik";
   this.button2.Click += new System.EventHandler(this.button1_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 112);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(48, 23);
   this.button1.TabIndex = 13;
   this.button1.Text = "Kalýn";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(384, 96);
   this.textBox1.TabIndex = 12;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(400, 142);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.numericUpDown1,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
    switch((sender as Button).Text)
    {
     case "Kalýn":
      textBox1.Font = new Font(textBox1.Font, 
       textBox1.Font.Style ^ FontStyle.Bold);
      break;
     case "Eðik":
      textBox1.Font = new Font(textBox1.Font, 
       textBox1.Font.Style ^ FontStyle.Italic);
      break;
     case "Altý Çizili":
      textBox1.Font = new Font(textBox1.Font, 
       textBox1.Font.Style ^ FontStyle.Underline);
      break;
     case "Üstü Çizili":
      textBox1.Font = new Font(textBox1.Font, 
       textBox1.Font.Style ^ FontStyle.Strikeout);
      break;
    }
   }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   textBox1.Font = new Font(textBox1.Font.Name, (float) numericUpDown1.Value, 
    textBox1.Font.Style);
  }
	}
}
