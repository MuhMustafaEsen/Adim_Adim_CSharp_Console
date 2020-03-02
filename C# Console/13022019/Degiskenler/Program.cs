using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DEĞİŞKENLER?
             * verilerin depolandığı yerler.
             * Değişkenlerin içine degişkenlerin ram de bize ayırmış oldugu alana kadar veri atabiliriz.
             * ve bu verileri degişkene verdigimiz ismi kullanarak ramden tekrar çagırıp kullanabiliriz.
     
             */
            //Sayısal Veri Tipleri 
            byte sayi = 125;
            sbyte pozitifSayi = 34;
            int sayi2 = 2354646;
            short sayiUc = 3453;
            long uzunSayi = 32556787654;

            //Ondalık Sayı Veri Tipleri

            float ondalikSayi = 6.45F;
            double ondalikSayi2 = 46.45345;
            decimal ondalikSayi3 = 45.3467876M;

            //Metinsel Veri Tipleri
            //Metindel ifadeler için kullanılır metinsel olarak rakamlarıda tutabiliriz fakat onlarla 
            //sayisal işlemler gerçekleştiremeyebiliriz.
            string metinselIfade = "bilge adam işkur akşam grubu";
            char karakter = '$';
            string bosMetin = " ";

            string metin = "metinsel ifadeler arası bir\t tab boşluk bırakır";
            string ciftTırnak = "Ben \"Bilge Adam\" öğrencisiyim";
            Console.WriteLine(ciftTırnak);
            Console.ReadKey();

            //mantıksal Veri Tipi
            //mantıksal olarak var veya yok, 1 ve 0 i temsil eden bool veri tipi
            bool BuyukMu = 10 > 2;
            bool bugunTatilMi = false;
        }
    }
}
