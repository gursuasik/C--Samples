using System;

namespace ListView_S�rala
{
 /// <summary>
 /// Summary description for Class1.
 /// </summary>
 public class Alfabetik_S�rala:System.Collections.IComparer
 {
  public Alfabetik_S�rala()
  {
			
  }
  public int Compare(object x , object y)
  {
   string eleman1, eleman2;
   eleman1 = ((System.Windows.Forms.ListViewItem)x).Text.ToUpper();
   eleman2 = ((System.Windows.Forms.ListViewItem)y).Text.ToUpper();
   return eleman1.CompareTo(eleman2);
  }
 }

 class Unvan_S�rala:System.Collections.IComparer
 {
  public Unvan_S�rala()
  {
			
  }
  public int Compare(object x , object y)
  {
   string eleman1, eleman2;
   eleman1 = ((System.Windows.Forms.ListViewItem)x).SubItems[1].Text;
   eleman2 = ((System.Windows.Forms.ListViewItem)y).SubItems[1].Text;
   string[] s�ralama = {
                        "Uzman", "��retim G�revlisi", "Yard.Do�", "Do�ent", 
                        "Prof Dr."};
   if (Array.IndexOf(s�ralama, eleman1) > 
    Array.IndexOf(s�ralama, eleman2))
    return 1;
   else
    if (Array.IndexOf(s�ralama, eleman1) < 
    Array.IndexOf(s�ralama, eleman2))
    return -1;
   else
    return 0;
  }
 }
 class Say�_S�rala:System.Collections.IComparer
 {
  public Say�_S�rala()
  {
			
  }
  public int Compare(object x , object y)
  {
   int eleman1, eleman2;
   eleman1 = int.Parse(((System.Windows.Forms.ListViewItem)x).SubItems[2].Text);
   eleman2 = int.Parse(((System.Windows.Forms.ListViewItem)y).SubItems[2].Text);
  
   return Math.Sign(eleman1 - eleman2);
  }
 }
 class Tarih_S�rala:System.Collections.IComparer
 {
  public Tarih_S�rala()
  {
			
  }

  public int Compare(object x , object y)
  {
   DateTime eleman1, eleman2;
   eleman1 = DateTime.Parse(((System.Windows.Forms.ListViewItem)x).SubItems[3].Text);
   eleman2 = DateTime.Parse(((System.Windows.Forms.ListViewItem)y).SubItems[3].Text);
   return eleman1.CompareTo(eleman2);
  }
 }
}
