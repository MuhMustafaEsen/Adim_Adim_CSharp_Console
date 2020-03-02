using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi(Array)
            /*
             * Aynı tipte verileri bir arada tutmak ve o verilere ortak aksiyon sağlmak için kullanılır. 
             * Dizileri dizi yapan özellikler
             * 1)tip sınırlaması
             * her eleman aynı tipte olmalı
             * 2)eleman sayısı sınırlaması
             * her dizinin bir başlangıç eleman sayısı vardır Eğer eleman sayısından fazla giriş yapılırsa hata alınır(index out of range)
                       
             */

            //Dizi Tanımlama Yöntemleri
            //1.Yöntem
            int[] sayilar = new int[5];
            sayilar[0] = 23;
            sayilar[1] = 24;
            sayilar[2] = 25;
            sayilar[3] = 26;
            sayilar[4] = 27;
            //sayilar[5] = 67; hata verir dizimiz 5 elemanlıdır ve dizi uzunlugunu aşmış oluruz.

            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar[3]);
            Console.WriteLine(sayilar[4]);
            //Console.WriteLine(sayilar[5]);
            Console.ReadKey();
            ////2.Yontem
            string[] metin = new string[] { "metin1", "metin2", "metin3" };

            Console.WriteLine(metin[0]);
            Console.WriteLine(metin[1]);
            Console.WriteLine(metin[2]);
            //Console.WriteLine(metin[3]);//hata verir dizide olmayan elemanı ekrana basamassınız.
            Console.ReadKey();
            //3.Yontem
            double[] ondalikSayi = new double[5] { 56.6, 56, 4.6, 46.7, 6 };
            Console.WriteLine(ondalikSayi[0]);
            Console.WriteLine(ondalikSayi[1]);
            Console.WriteLine(ondalikSayi[2]);
            Console.WriteLine(ondalikSayi[3]);
            Console.WriteLine(ondalikSayi[4]);
            Console.ReadKey();
            ////4.Yontem
            string[] adlar = { "Mustafa", "Muharrem", "Dilara", "Agah" };
            Console.WriteLine(adlar[0]);
            Console.WriteLine(adlar[1]);
            Console.WriteLine(adlar[2]);
            Console.WriteLine(adlar[3]);

            Console.ReadKey();

            //haftanın günlerini bir dizeye atıp listele
            string[] gunler = { "ptesi", "salı", "çarşamba", "perşembe", "cuma ", "cumartesi", "pazar" };
            ////yılın aylarını listele
            string[] aylar = { "ocak", "subat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };
            //Sınıftaki kızların adlarını listele
            string[] kizlar = { "gamze", "rumeysa", "zeynep", "ayşe", "şilan", "dilara" };
            //1-5ye kadar sayıları dizi ile listele
            int[] sayi = { 1, 2, 3, 4, 5 };
            //0-1 aralığını 0.1 arttıra attıra bir dizeye ekle listele
            double[] ondalik = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };

            char[] harfler = { 'e', 's', 'e', 'n'};
            string yazi = "Mustafa Esen";

            Console.WriteLine(harfler[2]);
            Console.WriteLine(yazi[2]);

            // !! HER STRİNG YAPI BİR CHAR DİZİSİDİR !!!
            Console.ReadKey();
        }
    }
}
