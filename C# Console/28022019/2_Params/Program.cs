using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //Params metot içerisinde bir kez kullanılır ve yanında parametre olacak ise params en sona yazılır.
            //Amacı  dışarıdan girilecek parametre degerinin adeti bilinmediğinde tüm parametrelere aynı işlemi uygulamaktır.
            //UNUTMAAAAAAAA ! params dizilerle çalışır.

            int toplam = Topla(3, 4, 5, 7, 8, 9, 6, 7, 9, 4, 9, 3, 8, 9);
            int[] sayilar = { 3, 4, 5, 7, 8, 9, 6, 7, 9, 4, 9, 3, 8, 9 };
            int toplamSonucu = Topla(sayilar);
            Console.WriteLine(toplam);
            Console.WriteLine(toplamSonucu);
            Console.ReadKey();

            //ornek 1
            //parametre olarak (adeti bilinmeyen) ürün fiyat değerlerinin toplam tutarını hesaplayan methodu yazınız
            double toplamFiyat = FiyatHesapla(4.5, 67.8, 4.7, 45.76, 4.4, 5.95, 6.99);
            Console.WriteLine("ürünlerin toplam fiyati =>" + toplamFiyat);
            Console.ReadKey();

            //ornek 2
            //dışarıdan girilen metin degerlerini(kaç metin degeri girileceği bilinmiyor) _ ile birleştiren methodu yazınız
            SiralaVoid("mustafa", "cihan", "muharrem", "dilara", "mehmet");
            Console.ReadKey();
        }
        static int Topla(int sayiBir)
        {
            return sayiBir + sayiBir;
        }

        static int Topla(int sayiBir, int sayiIKi)
        {
            return sayiBir + sayiIKi;
        }

        static int Topla(int sayiBir, int sayiIKi, int sayiUc)
        {
            return sayiBir + sayiIKi + sayiUc;
        }
        //yukarıda 3 adet methodda farklı sayilarda parametre alarak toplama işlemi gerçeklestiriyoruz fakat
        //her bir parametre artışında yeni bir method yazmak zorundayız ve dizilerde ne kadar veri gelecegini 
        //bilmiyoruz onun içim parametreden once params yazarak tek bir methodla dizi uzunlugu ne olursa olsun aynı
        //işlemi kotarabiliyoruz.
     
        static int Topla(params int[] sayiDizim)
        {
            int sonuc = 0;
            for (int i = 0; i < sayiDizim.Length; i++)
            {
                sonuc += sayiDizim[i];
            }
            return sonuc;
        }

        //parametre olarak (adeti bilinmeyen) ürün fiyat değerlerinin toplam tutarını hesaplayan method

        static double FiyatHesapla(params double[] fiyatlar)
        {
            double fiyat = 0;

            foreach (double item in fiyatlar)
            {
                fiyat += item;
            }
            return fiyat;
        }

        //dışarıdan girilen metin degerlerini(kaç metin degeri girileceği bilinmiyor) _ ile birleştiren method
        static void SiralaVoid(params string[] metinler)
        {
            foreach (string item in metinler)
            {
                Console.Write(item + "_");
            }
        }
    }
}
