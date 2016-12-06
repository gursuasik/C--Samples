using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace switchcase
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.ComboBox comboBox1;
  private System.Windows.Forms.Label label1;
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
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(88, 24);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(121, 21);
   this.comboBox1.TabIndex = 3;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(16, 24);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(64, 23);
   this.label1.TabIndex = 2;
   this.label1.Text = "Çizim þekli";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.comboBox1,
                                                              this.label1});
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
   comboBox1.Items.Add("Dikdörtgen");
   comboBox1.Items.Add("Kare");
   comboBox1.Items.Add("Çember");
   comboBox1.Items.Add("Elips");
   comboBox1.Items.Add("Yazý");
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   g.Clear(this.BackColor);//önceki þekli sil
   switch(comboBox1.Text)
   {
    case "Dikdörtgen":
     g.FillRectangle(new SolidBrush(Color.Red),10,100,75,125);
     break;
    case "Kare":
     g.FillRectangle(new SolidBrush(Color.Red),10,100,75,75);
     break;
    case "Çember":
     g.FillEllipse(new SolidBrush(Color.Red),10,100,75,75);
     break;
    case "Elips":
     g.FillEllipse(new SolidBrush(Color.Red),10,100,75,125);
     break;
    case "Yazý":
     g.DrawString("Visual C # .NET", 
      new Font("Tahoma",16,FontStyle.Regular),
      new SolidBrush(Color.Red),10,100);
     break;
    default:
     MessageBox.Show("Listeden bir deðer seçin");
     break;
   }
   g.Dispose();
  }
	}
}
