using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametresizGeriDonusluMethod_03
{
    class Program
    {
        static void Main(string[] args)
        {   
            string tamIsim = AdSoyad();
            Console.WriteLine(tamIsim);
            Console.WriteLine(AdSoyad());

            int sonuc = Islem();
            sonuc *= 3;
            Console.WriteLine(sonuc);
            Console.WriteLine(Islem()*3);

            double alan = (Pi()) * 3 * 3;
            Console.WriteLine($"r=3 degeri için dairenin alanı {alan}");

            Console.ReadKey();
        }

        static string AdSoyad()
        {
            string isim = "Mustafa";
            string soyisim = "Esen";
            return isim + "." + soyisim + "@gmail.com";
        }

        //bir metot ile 10 ile 20 yi topla main metodu içerisinde toplam degerinin 3 le çarp
        static int Islem()
        {
            int sayiBir = 10;
            int sayiIki = 20;
            int toplam = sayiBir + sayiIki;
            return toplam;

        }

        //pi sayısını döndüren metot yaz main içinde R=3 için cember alanı bul 
        static double Pi()
        {
            return 3.14;
        }
    }
}
