using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "Emre";
            P1.Soyisim = "Gemici";
            P1.Emailadres = "gmcc.emree";
            P1.Cinsiyet = 717770001; //Bay => 717770002-Bayan

            Personel P2 = new Personel();
            P2.Isim = "Ali";
            P2.Soyisim = "Gel";
            P2.Emailadres = "ali.gel";
            P2.Cinsiyet = 717770001; //Bay => 717770002-Bayan

            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P2.Isim + P2.Soyisim);

            Console.ReadKey ();
        }
    }
}
