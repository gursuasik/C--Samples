using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Progress_Bar2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ProgressBar progressBar2;
  internal System.Windows.Forms.ProgressBar progressBar1;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label1;
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
   this.progressBar2 = new System.Windows.Forms.ProgressBar();
   this.progressBar1 = new System.Windows.Forms.ProgressBar();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.button1 = new System.Windows.Forms.Button();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // progressBar2
   // 
   this.progressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.progressBar2.Location = new System.Drawing.Point(0, 216);
   this.progressBar2.Name = "progressBar2";
   this.progressBar2.Size = new System.Drawing.Size(296, 23);
   this.progressBar2.TabIndex = 15;
   // 
   // progressBar1
   // 
   this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.progressBar1.Location = new System.Drawing.Point(0, 239);
   this.progressBar1.Name = "progressBar1";
   this.progressBar1.Size = new System.Drawing.Size(296, 23);
   this.progressBar1.TabIndex = 14;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 28);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(160, 173);
   this.listBox1.TabIndex = 13;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(176, 44);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(112, 23);
   this.button1.TabIndex = 12;
   this.button1.Text = "BUL";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(168, 12);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(136, 13);
   this.Label2.TabIndex = 11;
   this.Label2.Text = "ye kadar olan Asal sayýlarý";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(104, 4);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(64, 20);
   this.textBox2.TabIndex = 10;
   this.textBox2.Text = "TextBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 4);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(72, 20);
   this.textBox1.TabIndex = 9;
   this.textBox1.Text = "TextBox1";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(80, 12);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(23, 13);
   this.Label1.TabIndex = 8;
   this.Label1.Text = "den";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(296, 262);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.progressBar2,
                                                              this.progressBar1,
                                                              this.listBox1,
                                                              this.button1,
                                                              this.Label2,
                                                              this.textBox2,
                                                              this.textBox1,
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
   progressBar1.Dock = DockStyle.Bottom;
   progressBar2.Dock = DockStyle.Bottom;
   progressBar1.Visible = false;
   progressBar2.Visible = false;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int i, j;
   Boolean asal;
   listBox1.Items.Clear();
   progressBar1.Visible = true;
   progressBar2.Visible = true;
   progressBar1.Maximum = int.Parse(textBox2.Text);
   progressBar1.Minimum = int.Parse(textBox1.Text);
   for (i = int.Parse(textBox1.Text); i<= int.Parse(textBox2.Text); i++)
   {
    asal = true;
    progressBar2.Minimum = 2;
    progressBar2.Maximum = i;
    progressBar1.Value = i;
    for (j = 2; j <= i - 1; j++)
    {
     progressBar2.Value = j;
     Application.DoEvents();
     if ((i % j) == 0) 
     {
      //Tam bölünüyorsa asal deðil
      asal = false;
      break;
     }
    }
    if (asal) 
     listBox1.Items.Add(i);
   }
   progressBar1.Visible = false;
   progressBar2.Visible = false;
  }
	}
}
