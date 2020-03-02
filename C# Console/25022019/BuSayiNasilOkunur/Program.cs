using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuSayiNasilOkunur
{
    class Program
    {
        static void Main(string[] args)
        {
            //4235645687 gibi rakamsal ifadelerle bir girdi alınız bu girdi en fazla üç basamaklı olmalı
            //girilen bu sayi 435 ise çıktısı dörtyüzotuzbeş olarak verilsin dizi kullanılsın.
            //yani rakamsal olarak ifade edilen 3 basamaklı saynin okunusu gosterilsin.

            string[] birler = { "", "bir" , "iki", "üç" , "dört" , "beş" ,"altı" ,"yedi" ,"sekiz" , "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetimiş", "seksen", "doksan" };

            Console.WriteLine("Bir sayi giriniz");
            string sayi =Console.ReadLine();

            if (sayi.Length <= 3 && sayi.Length > 0)
            {
                int deger = int.Parse(sayi);
                int birlerbasamagi = deger % 10;                
                int onlarbasamagi = (deger / 10) % 10;
                int yüzlerbasamagi = deger / 100;
                if (yüzlerbasamagi == 1)
                {
                    Console.WriteLine("yüz" + onlar[onlarbasamagi] + birler[birlerbasamagi]);
                }
                else if (yüzlerbasamagi == 0)
                {
                    Console.WriteLine(onlar[onlarbasamagi] + birler[birlerbasamagi]);
                }
                else
                {
                    Console.WriteLine(birler[yüzlerbasamagi] + "yüz"  + onlar[onlarbasamagi] + birler[birlerbasamagi]);
                }
            }
            else
            {
                Console.WriteLine("lütfen 3 basamaklı bir sayi giriniz.");
            }
            Console.ReadKey();

        }
    }
}
