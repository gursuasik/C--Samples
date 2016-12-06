using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace Path_GeçiciKlasörüTemizle
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button1;
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
   this.label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(8, 32);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(35, 13);
   this.label2.TabIndex = 5;
   this.label2.Text = "label2";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(121, 13);
   this.Label1.TabIndex = 4;
   this.Label1.Text = "Geçici klasör adresiniz:";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(48, 64);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(208, 23);
   this.button1.TabIndex = 3;
   this.button1.Text = "Geçici Klasörü Temizle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(320, 94);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label2,
                                                              this.Label1,
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
   label2.Text = Path.GetTempPath();
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   string geçici_klasör_adý;
   geçici_klasör_adý = Path.GetTempPath();
   DirectoryInfo geçici_klasör = new DirectoryInfo(geçici_klasör_adý);
   try
   {
    geçici_klasör.Delete(true);
   }
   catch (Exception hata)
   {
    MessageBox.Show("Geçici klasör silinirken bir sorun çýktý.\r\n" +
     hata.Message);
   }
  }
 }
}
