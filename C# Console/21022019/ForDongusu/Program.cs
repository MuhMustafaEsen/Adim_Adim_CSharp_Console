using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DONGULER
             * tekrar eden kodları bir kere yapıp ne kadar tekrar etmem gerekiyorsa o kadar döndürdüğüm yapılardır.
             * 4 farklı döngü vardır
             * for
             * while
             * dowhile
             * foreach
            */

            //FOR
            //for (başlangıç degeri ; koşul; artım)
            //{
            //döngü çalıştığı sürece okunacak kodlar
            //}

            //1den 10a kadar olan sayıları yazdır
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            //10 dan 1e kadar olan sayıları yazdır
            /*
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            //harfleri alfabetik sıralama
            /*
            for (char i = 'A'; i < 'a'; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            //tipi int vermek zorunda değiliz
            /*
            for (double i = 0.1; i < 5; i+=0.1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            //1 den 100 2 şer 2 şer farklı artırım miktarları olabilir.
            /*
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            //farklı yazım şekli
            /*
            int i = 5;
            for (;  i< 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            //for döngüsü içerisinde mantıksal işlemler yapılabilir.
            /*
            int value = 10;
            for (int i = 0; i < 10 && value == 10; i++)
            {
                Console.WriteLine(i);
                value--;
            }
            Console.ReadLine();
            */

            //sonsuz döngü
            /*
            int i = 0;
            for (; ; )
            {
                Console.WriteLine(i);
            }
            */

            //1 den 100e kadar olan sayıların toplamı kaçtır?
            /*
            int toplam = 0;
            for (int i = 0; i <= 100; i++)
            {
                toplam += i;

            }
            Console.WriteLine("Bu işlemin sonucu" + toplam);
            Console.ReadLine();
            */

            //for döngülerini iç içe kullanabilirsiniz 
            /* 0 1
             * 0 2
             * 0 3
             * 1 1
             * 1 2
             * 1 3
             * 2 1
             * 2 2
             * 2 3
             */

            /*
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"{i}  {j}");
                }
            }
            Console.ReadLine();
            */

            //1-100 e kadar olan çift sayıların toplamı ile tek sayıların toplamının farkı kaçtır?
            /*
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            Console.WriteLine($"Çiftlerin toplamı {evenSum}, Teklerin Toplamı {oddSum}, farkları {evenSum - oddSum} ");
            Console.ReadLine();
             */


            //1945ten günümüze kadar olan yıları listeleyiniz. 1970 ve 1965 yılları listelenmesin
            /*
            for (int i = 1945; i < DateTime.Now.Year; i++)
            {
                if (i != 1970 && i != 1965)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            */

            //100ün bir ve kendisi dışında en büyük ve en küçük katını bulup basınız.
            /*
            int number = 100;
            int smallest = 1;
            int largest = 1;
            for (int i = 2; i < number / 2; i++)
            {
                if (smallest == 1 || number % i == 0)
                {
                    smallest = i;
                    break;
                }
            }
            for (int j = number / 2; j > 2; j--)
            {
                if (largest == 1 || number % j == 0)
                {
                    largest = j;
                    break;
                }
            }
            Console.ReadLine();
            */
            //aynı soru farklı yapım şekli tek for
            /*
            for (int i = 2, j = number / 2; i < number / 2 && j > 2; i++, j--)
            {
                if (smallest == 1 || number % i == 0)
                {
                    smallest = i;
                }
                if (largest == 1 || number % j == 0)
                {
                    largest = j;
                }
            }
            Console.WriteLine("100ün en küçük çarpanı {0} en büyük çarpanı {1}", smallest, largest);
            Console.ReadLine();
            */

            //kullanıcıdan alınan fibonacci index degeri için o index değerine ait olan sayıyı veren kodu oluştur
            //1 index  1
            //2 index  1
            //3 index  2
            //4 index  3
            //5 index  5 ...
            //5 8 13 21 34..............

            /*
            Console.WriteLine("lütfen index giriniz");
            int index = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            if (index == 1 || index == 2)
            {
                Console.WriteLine("istenilen fibo sayısı = 1");
            }
            else
            {
                int counter = 3;
                number1 = 1;
                number2 = 1;
                int fibonumber = number1 + number2;
                for (; counter < index; counter++)
                {
                    number1 = number2;
                    number2 = fibonumber;
                    fibonumber = number1 + number2;
                }
                Console.WriteLine("istenilen fibo sayısı" + fibonumber);
            }
            Console.ReadLine();
            */

            //Aşağıdaki şekilde çarpım tablosunu bas
            /*
            1 x 1 = 1
            1 x 2 = 2
            1 x 3 = 3
            1 x 4 = 4
            1 x 5 = 5
                .
                .
                .
           1 x (1,2,3,4,5,6,7,8,9,10)
           2 x (1,2,3,4,5,6,7,8,9,10)
           3 x (1,2,3,4,5,6,7,8,9,10)
           4 x (1,2,3,4,5,6,7,8,9,10)
            */

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            Console.ReadLine();


            //kullanıcıdan bir kullanıcı adı birde password alınız ve 3 hakkınız var diye yazınız.
            //Eğer kullanıcı üç kez yanlış giriş yaparsa hesabınız kitlendi cıktısı alsın
            //her girişten sonra hak bilgisi güncellensin.Doğru giriş yaparsa hoşgeldin admin
            /*
            string username, password;
            bool isOk = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Kalan hak {3 - i}");
                Console.WriteLine("Kullanıcı Adı:");
                username = Console.ReadLine();
                Console.WriteLine("Sifre:");
                password = Console.ReadLine();
                if (username == "admin" && password == "123")
                {
                    i = 10;
                    isOk = true;
                }

            }
            if (isOk)
            {
                Console.WriteLine("Hoşgeldin admin");
            }
            else
            {
                Console.WriteLine("Hesabınız kitlendi");
            }

            Console.ReadKey();
            */
        }
    }
}
