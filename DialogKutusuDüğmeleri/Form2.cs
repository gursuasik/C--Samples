using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DialogKutusuDüðmeleri
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Label label1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button3
   // 
   this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.button3.Image = ((System.Drawing.Bitmap)(resources.GetObject("button3.Image")));
   this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.button3.Location = new System.Drawing.Point(304, 112);
   this.button3.Name = "button3";
   this.button3.TabIndex = 9;
   this.button3.Text = "Ýptal";
   // 
   // button2
   // 
   this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
   this.button2.Image = ((System.Drawing.Bitmap)(resources.GetObject("button2.Image")));
   this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.button2.Location = new System.Drawing.Point(224, 112);
   this.button2.Name = "button2";
   this.button2.TabIndex = 8;
   this.button2.Text = "Hayýr";
   // 
   // button1
   // 
   this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
   this.button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("button1.Image")));
   this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.button1.Location = new System.Drawing.Point(144, 112);
   this.button1.Name = "button1";
   this.button1.TabIndex = 7;
   this.button1.Text = "Evet";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(8, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(128, 128);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 6;
   this.pictureBox1.TabStop = false;
   // 
   // label1
   // 
   this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.label1.Location = new System.Drawing.Point(144, 32);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(240, 64);
   this.label1.TabIndex = 5;
   this.label1.Text = "Çýkmadan önce bilgileri dosyaya kaydetmemi ister misin?";
   // 
   // Form2
   // 
   this.AcceptButton = this.button1;
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.CancelButton = this.button3;
   this.ClientSize = new System.Drawing.Size(384, 150);
   this.ControlBox = false;
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.pictureBox1,
                                                              this.label1});
   this.Name = "Form2";
   this.Text = "Form2";
   this.ResumeLayout(false);

  }
		#endregion
	}
}
