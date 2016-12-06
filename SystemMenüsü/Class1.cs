using System;

namespace SystemMen�s�
{
 /// <summary>
 /// Summary description for Class1.
 /// </summary>
 public class Mesaj_��le  : System.Windows.Forms.IMessageFilter
 {
  public Mesaj_��le()
  {
   //
   // TODO: Add constructor logic here
   //
  }
  public Boolean PreFilterMessage(ref System.Windows.Forms.Message m) 
  {
   if (m.Msg == 0x112) //WM_SYSCOMMAND ise
    switch(m.WParam.ToInt32())
    {
     case 10 : System.Windows.Forms.MessageBox.Show("Bu program formlar�n System Men�s�ne yeni men�lerin " +
                "nas�l eklenece�ini g�stermek i�in yap�lm��t�r");
      return true; //mesaj�n i�lendi�ini bildir
     case 20 : 
      Form1.Dosya_A�_Penceresi.Filter = 
       "Program dosyalar�|*.exe;*.com;*.bat;*.pif|" + 
       "B�t�n dosyalar|*.*";
      if (Form1.Dosya_A�_Penceresi.ShowDialog() == System.Windows.Forms.DialogResult.OK)
       System.Diagnostics.Process.Start(Form1.Dosya_A�_Penceresi.FileName);
      return true; //mesaj�n i�lendi�ini bildir
     case 0xF030: //Ekran� kapla men�s�
      System.Windows.Forms.MessageBox.Show("Ekran� kapla men�s� iptal edildi");
      //mesaj�n i�lendi�ini bildirerek ekran� kapla kodunun �al��mas�n� �nle
      return true;
     default:
      return false; //Mesaj�n i�lenmedi�ini bildir
    }
   else
    return false; //Mesaj�n i�lenmedi�ini bildir
  }
	}
}
