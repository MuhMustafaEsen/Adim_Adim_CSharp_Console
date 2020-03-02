using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //TernaryIf => tek satırda if kodu yazmanı sağlar içine yazılacak if bloğunun tek true tek false'u olmalıdır.
            /*
            string metin1 = "mustafa";
            string metin2 = metin1 == "mustafa" ? "giriş yapıldı" : "yanlış giriş"; //TernaryIf yazım şekli

            Console.WriteLine(metin2);
            Console.ReadKey();
            */

            //kullanıcıdan iki sayı alınız bu iki sayıyı ilkgirilen < songirilen şeklinde sorgulayıp hangisinin daha büyük olduğunun çıktısını alınız
            /*
            Console.WriteLine("sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi < sayi2 ? "İkinci sayi büyük" : "birinci sayi büyük yada eşittir");
            Console.ReadKey();
            */

            //dışarıdan girilen sayı eger 9 a tam bölünüyor ise 9un katıdır bölünmüyor ise değildir çıktısı alın
            /*
            Console.WriteLine("sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            string metin = sayi % 9 == 0 ? "9un katıdır" : "9'a tam bölünmez";
            Console.WriteLine(metin);
            Console.ReadKey();
            */

            //girilen sayının 10dan büyük olup olmadığını kontrol ediniz.
            /*
            Console.WriteLine("sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());     
            Console.WriteLine(sayi1 > 10 ? "10dan büyüktür" : "10dan küçüktür");
            Console.ReadKey();
            */
        }
    }
}
