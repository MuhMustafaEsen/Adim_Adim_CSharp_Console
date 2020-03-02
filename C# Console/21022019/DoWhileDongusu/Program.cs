using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 için while dongusu ile faktoriyel hesabı yapınız.
            /*
            int sayi = 5;
            int faktoriyel = 1;
            while (sayi > 0)
            {
                faktoriyel *= sayi;
                sayi--;
            }
            Console.WriteLine(faktoriyel);
            Console.ReadKey();
            */
            //do while dongusu kullanarak 5 için faktoriyel hesabı yapınız.
            /*
            int sayi1 = 5;
            int faktoriyel1 = 1;
            do
            {
                faktoriyel1 *= sayi1;
                sayi1--;
            }
            while (sayi1 > 0);
            Console.WriteLine(faktoriyel1);
            Console.ReadKey();
            */

            //kullanıcı 0 girene kadar girdiği tüm sayıları toplayan kod (dowhile)
            /*
            int sum = 0;
            int sayi = 0;
            bool kontrol = false;
            do
            {
                Console.WriteLine("Sayi :");
                kontrol = int.TryParse(Console.ReadLine(), out sayi);
                sum += sayi;
            }
            while (sayi != 0 || !kontrol);
            Console.WriteLine("sayının toplamı:" + sum);
            Console.ReadKey();
            */

            //kullanıcı bir tuşa basınız ifadesi ile karşılansın bastığı tuş q ise sonlansın 
            /*
            Console.WriteLine("sistemden çıkmak istediğinizde q ya basınız");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("bir tuşa basınız");
                Console.ReadLine();
                keyInfo = Console.ReadKey();
                Console.WriteLine("Girilen karakter :" + keyInfo.KeyChar);

            } while (keyInfo.Key != ConsoleKey.Q);
            Console.ReadKey();
            */

            //1-1000 arasında 7 ye bölünüp 21e bölünemyen sayıları listeleyiniz.
            /*
            int sayac = 1;
            do
            {
                if (sayac % 7 == 0 && sayac % 3 != 0)
                {
                    Console.WriteLine(sayac);

                }
                sayac++;
            } while (sayac <= 1000);
            Console.ReadKey();
            */
            //kullanıcı sayı girişi yapsın tamam yazdığında işlem sonlansın tamam yazana kadar girdi 
            //olarak verdiği tüm sayılar içerisinden en büyük olanı tamamdan sonra kullanıcıya gosterin
            /*
            string metin = string.Empty;
            bool kontrol = true;
            int sayi = 0;
            int max = 0;
            do
            {
                Console.WriteLine("lütfen bir sayı giriniz");
                metin = Console.ReadLine();
                kontrol = int.TryParse(metin, out sayi);
                if (sayi > max)
                {
                    max = sayi;
                }

            }
            while (kontrol && metin != "tamam");
            Console.WriteLine("Girdiğiniz sayıların en büyüğü {0}", max);
            Console.ReadKey();
            */
        }
    }
}
