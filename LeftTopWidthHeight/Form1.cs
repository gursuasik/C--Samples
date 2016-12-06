using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LeftTopWidthHeight
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.NumericUpDown numericUpDown4;
  internal System.Windows.Forms.NumericUpDown numericUpDown3;
  internal System.Windows.Forms.NumericUpDown numericUpDown2;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
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
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.textBox1 = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(136, 208);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(56, 23);
   this.Label4.TabIndex = 17;
   this.Label4.Text = "Yükseklik:";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(16, 208);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(48, 23);
   this.Label3.TabIndex = 16;
   this.Label3.Text = "Geniþlik:";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(136, 176);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(24, 23);
   this.Label2.TabIndex = 15;
   this.Label2.Text = "Üst:";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(24, 176);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(24, 23);
   this.Label1.TabIndex = 14;
   this.Label1.Text = "Sol:";
   // 
   // numericUpDown4
   // 
   this.numericUpDown4.Location = new System.Drawing.Point(192, 208);
   this.numericUpDown4.Name = "numericUpDown4";
   this.numericUpDown4.Size = new System.Drawing.Size(64, 20);
   this.numericUpDown4.TabIndex = 13;
   this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
   // 
   // numericUpDown3
   // 
   this.numericUpDown3.Location = new System.Drawing.Point(64, 208);
   this.numericUpDown3.Name = "numericUpDown3";
   this.numericUpDown3.Size = new System.Drawing.Size(64, 20);
   this.numericUpDown3.TabIndex = 12;
   this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
   // 
   // numericUpDown2
   // 
   this.numericUpDown2.Location = new System.Drawing.Point(192, 176);
   this.numericUpDown2.Name = "numericUpDown2";
   this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
   this.numericUpDown2.TabIndex = 11;
   this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(64, 176);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
   this.numericUpDown1.TabIndex = 10;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(48, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(152, 20);
   this.textBox1.TabIndex = 9;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(272, 238);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.numericUpDown4,
                                                              this.numericUpDown3,
                                                              this.numericUpDown2,
                                                              this.numericUpDown1,
                                                              this.textBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Text kutusunn geniþiðinin büyüyebilmesi için AutoSize false olmalý
   textBox1.AutoSize = false;
   //Koordinatlar 0-1000 arasý deðiþebilsin
   numericUpDown1.Maximum = 1000;
   numericUpDown2.Maximum = 1000;
   numericUpDown3.Maximum = 1000;
   numericUpDown4.Maximum = 1000;
   //Text kutusunun þu anki koordinatlarýný numericUpDownlar içinde göster
   numericUpDown1.Value = textBox1.Left;
   numericUpDown2.Value = textBox1.Top;
   numericUpDown3.Value = textBox1.Width;
   numericUpDown4.Value = textBox1.Height;
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   //Sol koordinatý ayarla
   textBox1.Left = (int) numericUpDown1.Value;
  }

  private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
  {
   //Üst koordinatý ayarla
   textBox1.Top = (int) numericUpDown2.Value;
  }

  private void numericUpDown3_ValueChanged(object sender, System.EventArgs e)
  {
   //Geniþliði ayarla
   textBox1.Width = (int) numericUpDown3.Value;
  }

  private void numericUpDown4_ValueChanged(object sender, System.EventArgs e)
  {
   //Yüksekliði ayarla
   textBox1.Height = (int) numericUpDown4.Value;
  }
	}
}
