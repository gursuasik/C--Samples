using System;

namespace Class_Sifre
{
 public class sifre
 {

  public sifre()
  {
   �ifre= "123";
   text= "�ifrelenecek metin";
  }

  public sifre(string �ifre, string Text)
  {
   �ifre = �ifre;
   text = Text;
  }

  private string �ifre;
  public string �ifre
  {
   get
   {
    return �ifre; 
   }
   set
   {
    �ifre = value; 
   }
  }

  private string text;
  public string Text
  {
   get
   {
    return text; 
   }
   set
   {
    text = value; 
   }
  }

  public string �ifrele()//�ifrele metodu
  {
   return (�ifrele_��z());
  }

  public string ��z()//��z metodu
  {
   return (�ifrele_��z());
  }

  private string �ifrele_��z()//�ifreleme ve ��zme fonksiyonu
  {
   string Sonu�, AraSonu�;
   int i, j;
   char c;
   Sonu� = text;
   for (j = 0 ; j<= �ifre.Length - 1 ; j++)
   {
    AraSonu� = "";
    for (i = 0 ; i<= Sonu�.Length - 1 ; i++)
    {
     c = (char) (Sonu�[i] ^ �ifre[j]);
     if (c == '0')
      c = �ifre[j];
     AraSonu�  = AraSonu�  + (char) c;
    }
    Sonu� = AraSonu�;
   }
   return Sonu�;
  }
 }
}
