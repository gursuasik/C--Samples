using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListBox_Edit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.button1 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(192, 32);
   this.Label1.TabIndex = 7;
   this.Label1.Text = "Listedeki elemanlar� �ift t�klayarak i�eri�ini de�i�tirebilirsiniz";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 184);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(152, 32);
   this.button1.TabIndex = 6;
   this.button1.Text = "Ekle";
   // 
   // listBox1
   // 
   this.listBox1.Items.AddRange(new object[] {
                                              "Yusuf K�l��",
                                              "�lyas Tatl�",
                                              "Abdullah Ya�ar",
                                              "Murat K���k",
                                              "Suat Temur",
                                              "KAD�R �AVDAR",
                                              "Abdurrahman Tek�e",
                                              "�mer Bak�r",
                                              "Aynur Tany�rek"});
   this.listBox1.Location = new System.Drawing.Point(16, 48);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(152, 134);
   this.listBox1.TabIndex = 5;
   this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDown);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(16, 216);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(152, 20);
   this.textBox1.TabIndex = 4;
   this.textBox1.Text = "TextBox1";
   this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
   this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(184, 246);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.button1,
                                                              this.listBox1,
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
    textBox1.Visible = false;
  }

  private void ListBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Clicks == 2) //�ift t�klanm��sa
   {
    int ind;
    //t�klanan koordinatlardaki eleman� bul
    ind = listBox1.IndexFromPoint(e.X, e.Y);
    if (ind < 0) //t�klanan noktada eleman yoksa ekle
    {
     //listenin sonuna bo� eleman ekle
     listBox1.Items.Add("");
     ind = listBox1.Items.Count - 1;
     //ve onu se�
     listBox1.SelectedIndex = ind;
    }
    Rectangle r;
    //O elemana ait koordinatlar� al
    r = listBox1.GetItemRectangle(ind);
    //Text kutusunu o koordinatlara ta��
    textBox1.SetBounds(listBox1.Left + r.Left, 
     listBox1.Top + r.Top, r.Width, r.Height);
    //�ift t�klanan eleman� listeden se�
    listBox1.SelectedIndex = ind;
    //Eleman�n i�eri�ini Text kutusuna al
    textBox1.Text = listBox1.Text;
    //Text kutusunu g�ster
    textBox1.Visible = true;
    //Text kutusunu �ne getir
    textBox1.BringToFront();
    //Text kutusuna kontrol� b�rak
    textBox1.Focus();
    //Kurs�r� sona g�t�r
    textBox1.SelectionStart = textBox1.Text.Length;
   }
  }

  private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
  {
   if (e.KeyChar == (char)(13))//entere bas�l�rsa
   {
    int ind;
    //Listede se�ili eleman� bul
    ind = listBox1.SelectedIndex;
    if (ind >= 0)
     listBox1.Items[ind] = textBox1.Text;
    textBox1.Visible = false;
    e.Handled = true;
   }

   if (e.KeyChar == (char)(27))//ESCye bas�l�rsa
   {
    textBox1.Text = listBox1.Text;
    textBox1.Visible = false;
    e.Handled = true;
   }
  }

  private void textBox1_Leave(object sender, System.EventArgs e)
  {
   int ind;
   //Listede se�ili eleman� bul
   ind = listBox1.SelectedIndex;
   if (ind >= 0)
    listBox1.Items[ind] = textBox1.Text;
   textBox1.Visible = false;
  }
	}
}
