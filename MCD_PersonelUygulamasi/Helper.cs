using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    public static class Helper
    {
        //Static olarak işaretlenmiş class'lar örneklenemez.
        //Helper H1 = new Helper(); 

        /*Static olan class'lar içerisinde standart metotlar kullanılamaz.(Static olmayan metotlar)
         * 
        public void Test()
        {

        }
        */

        /*Static olan class'lar içerisinde static olmayan field tanımları yapılamaz.
         * 
        public string Tanim { get; set; }
        *
        */

        /*Her nesne örneği alındığında uygulama standart yapıcı metodu çalıştırır.
         * 
        public Helper()
        {

        }
        */

        static Helper()
        {
            //Uygulama içerisinde istenildiği kadar çağrılsınlar sadece ilk çağrılmada çalışırlar.
            Console.WriteLine("Helper => Static class => static CTOR");
        }

        public static void emailGonder(string aliciEmailAdres,string konu,string icerik)
        {
            //Email gönderme işlemleri devam edecek...
            Console.WriteLine("Mail göderim işlemi başarılı.");
        }
    }
}
