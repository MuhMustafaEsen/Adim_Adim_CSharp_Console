using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHİLE
            //int baslangıcDegeri = 0;
            //while (kosul)
            //{
            //    yapılacaklar
            //    baslangıcDegeri artımı
            //}

            //1den 20 ye kadar olan sayıların toplamını while kullanarak bulunuz.

            /*
             *    1
             *    2
             *    3
             *    4
             *    5
             *    6
             *    7
             *    8
             *    9
             *    10
             *    11
             *    12
             *    13
             *    14
             *    15
             *    16
             *    17
             *    18
             *    19
             *    20
             * +   
             * ----------
             *    210
             *    
             */
            /*
           int sonuc = 0;
           int sayi = 1;
           while (sayi <= 20)
           {
               Console.WriteLine("\t" + sayi);
               sonuc += sayi;
               sayi++;
           }
           Console.WriteLine("+");
           Console.WriteLine("------------------");
           Console.WriteLine("\t" + sonuc);
           Console.ReadKey();
           */

            //1den 20 ye kadar olan çift sayıların toplamını while kullanarak bulunuz.
            /*
            int sonuc = 0;
            int sayi = 0;
            while (sayi <= 20)
            {
                Console.WriteLine("\t" + sayi);
                sonuc += sayi;
                sayi += 2;
            }
            Console.WriteLine("+");
            Console.WriteLine("------------------");
            Console.WriteLine("\t" + sonuc);
            Console.ReadKey();
            */

            //Kullanıcıdan 0 ile 100 arasında bir sayı alınız eğer kullanıcı metinsel bir ifade girdiyse ve aralık dışında bir sayı girdiyse hata mesajı verip yeniden sayı isteyiniz.
            /*
            int sayi;
            Console.WriteLine("Lütfen bir sayı giriniz");
            bool sayiMi = int.TryParse(Console.ReadLine(), out sayi);
            while (!(sayi >= 0 && sayi <= 100) || sayiMi == false)
            {
                if (!sayiMi)
                {
                    Console.WriteLine("Lütfen sayı giriniz");
                }
                else
                {
                    Console.WriteLine("lütfen 0-100 aralığında deger giriniz");
                }
                //Console.WriteLine("Lütfen bir sayı giriniz");
                sayiMi = int.TryParse(Console.ReadLine(), out sayi);
            }
            Console.WriteLine("sayınız : " + sayi);
            Console.ReadKey();
            */
            #region Rus Çarpması
            // birbirleriyle çarpılacak sayılar yan yana yazılır. ilk sayı ikiye bölünür ve sonuç hemen altına yazılır.sonuç küsuratlı(kesirli) çıktıysa kesir kısmıyla ilgilenilmez sadece tam sayı kısmı yazılır.diğer sayı ise ikiyle çarpılır ve sonuç hemen altına yazılır. bu işlem yeni sayılar için tekrarlanır, ta ki ilk sayı ikiye bölüne bölüne 1(bir)değerine ulaşana kadar.birinci sütundaki çift sayıların ikinci sütundaki karşılıkları silinir. ikinci sütunda silinmeyen sayılar toplandığında elde edilen sonuç istenilen sayıdır. örnek:
            //456 x 219 = ?

            //456...........219
            //228..........438
            //114..........876
            //57...........1752
            //28...........3504
            //14..........7008
            //7..........14016
            //3..........28032
            //1..........56064

            //birinci sütunda çift olan sayıların karşısındaki rakam ikinci sütunda silinir ve ikinci sütunun toplamı alınır.
            //456..........0
            //228..........0
            //114..........0
            //57..........1752
            //28..........0
            //14..........0
            //7..........14016
            //3...........28032
            //1..........56064

            //1752 + 14016 + 28032 + 56064 = 99864

            //demek ki 456 x 219 = 99864 ediyormuş.
            #endregion
            /*
            Console.WriteLine("sayı giriniz");
            int sayiBir = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı giriniz");
            int sayiIki = int.Parse(Console.ReadLine());
            int toplam = 0;

            while (sayiBir > 0)
            {
                if (sayiBir % 2 == 1)
                {
                    toplam += sayiIki;
                }
                sayiBir = sayiBir / 2;
                sayiIki = sayiIki * 2;

            }
            Console.WriteLine(toplam);
            Console.ReadKey();
            */
        }
    }
}
