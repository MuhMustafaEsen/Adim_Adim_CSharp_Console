using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random sınıfı rastgele deger uretmek için olusturulmus hazır bir c# sınıfıdır.
            //Rastgele olarak belirledigimiz araliklar arasında sayi uretebilmektedir.
            Random rnd = new Random();
            int randomSayi = rnd.Next(1, 10);
            int randomSayi1 = rnd.Next(1, 100);
            int randomSayi2 = rnd.Next(50, 250);
            int randomSayi3 = rnd.Next(0, 1000);
            int randomSayi4 = rnd.Next(1000, 5000);

            Console.WriteLine(randomSayi);
            Console.WriteLine(randomSayi1);
            Console.WriteLine(randomSayi2);
            Console.WriteLine(randomSayi3);
            Console.WriteLine(randomSayi4);



            // Random olarak üretilen iki sayının toplamını yine random bir sayı ile çarpıp sonucu verin aralıklar (0 15) olsun

            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, 15);
            Console.WriteLine(rastgeleSayi);
            int rastgeleSayi2 = rastgele.Next(0, 15);
            Console.WriteLine(rastgeleSayi2);
            int rastgeleSayi3 = rastgele.Next(0, 15);
            Console.WriteLine(rastgeleSayi3);

            int islem = (rastgeleSayi + rastgeleSayi2) * rastgeleSayi3;
            Console.WriteLine(rastgeleSayi + " + " + rastgeleSayi2 + " * " + rastgeleSayi3 + " isleminin sonucu = " + islem);
            Console.ReadKey();
        }
    }
}
