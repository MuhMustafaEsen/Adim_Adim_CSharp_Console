using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliGeriDonusluMethod_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayi girişi yapınız");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sayi girişi yapınız");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("sayi girişi yapınız");
            int sayi3 = int.Parse(Console.ReadLine());

            int toplam = Topla(sayi1, sayi2, sayi3);
            Console.WriteLine(toplam);

            int mutlak = MutlakDeger(-11);
            Console.WriteLine(mutlak);

            int sayiBir = YukarıYuvarla(5.7); //6
            int sayiIki = YukarıYuvarla(100.567); //101
            int buyukSayi = Buyuk(sayiBir, sayiIki); //101
            Console.WriteLine("yuvarlanan sayıların buyuk olanı =>>>" + buyukSayi);

            Console.WriteLine(IsaretGoster(-45));
            Console.WriteLine(IsaretGoster(45));
            Console.WriteLine(IsaretGoster(0));

            Console.WriteLine("sayı gir");
            int sayi = int.Parse(Console.ReadLine());
            bool durum = CiftMi(sayi);
            if (durum)
            {
                Console.WriteLine("sayı çift");
            }
            else
            {
                Console.WriteLine("sayı tek");
            }

            Console.WriteLine("Sayi girişi yapınız");
            int deger = int.Parse(Console.ReadLine());
            Console.WriteLine("Kacıncı üstü alınsın??");
            int ust = int.Parse(Console.ReadLine());
            int sonuc = Power(deger, ust);
            Console.WriteLine(string.Format("{0} un {1} .ustu =>  {2}", deger, ust, sonuc));

            Console.WriteLine("Lütfen bir sesli harf giriniz");
            char harf = Convert.ToChar(Console.ReadLine());
            char buyukHarf = BuyukYaz(harf);
            Console.WriteLine(buyukHarf);

            Console.WriteLine("Lütfen metin girin");
            string metin = Console.ReadLine();
            int adet = SesliHarfler(metin);
            Console.WriteLine($" {metin} metninin içerisinde {adet} adet sesli harf vardır.");

            string[] aylar = { "Ocak", "Şubat", "Mart" };
            string[] aylarDevam = { "Nisan", "Mayıs" };
            string[] ilkBesAy = DiziBirlestir(aylar, aylarDevam);
            foreach (string item in ilkBesAy)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
        }

        static int Topla(int sayiBir, int sayiIki, int sayiUc)
        {
            return sayiBir + sayiIki + sayiUc;

        }

        //kullanıcıdan alınan sayinin mutlak degerini veren methodu oluştur.
        static int MutlakDeger(int sayi)
        {
            if (sayi < 0)
            {
                return sayi * (-1);
            }
            else
            {
                return sayi;
            }

        }

        //kullanıcıdan alınan sayıyı yukarı yuvarlayan methodu oluştur
        //4.1 => 5
        static int YukarıYuvarla(double sayi) //4.12
        {
            int altSayi = Convert.ToInt32(sayi); //4
            if (altSayi < sayi)
            {
                altSayi++;
            }
            return altSayi;
        }
        //kullanıcıdan iki sayı alınsın büyuk olanı cıktı veren method

        static int Buyuk(int sayiBir, int sayiIki)
        {
            if (sayiBir > sayiIki)
            {
                return sayiBir;
            }
            else
            {
                return sayiIki;
            }
        }

        //kullanıcıdan bir sayı al o sayı pozitif ise 1 negatif ise -1 0 ise 0 dön
        static int IsaretGoster(int sayi)
        {
            if (sayi > 0)
            {
                return 1;
            }
            else if (sayi == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        //kullanıcıdan alınan sayının tek mi çiftmi olduğunu true(çift) false(tek) ile gösteren method
        static bool CiftMi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                return true;
            }
            return false;
        }
        //kullanıcıdan bir sayı birde o sayının kacıncı kuvvetinin alınacağı bilgisi alınsın işlem sonucu döndürülsün
        static int Power(int sayi, int ust)
        {
            int result = 1;
            for (int i = 0; i < ust; i++)
            {
                result *= sayi;
            }
            return result;
        }
        //Kullanıcıdan sesli harf alıp o sesli harfi büyük harfe ceviren method(Upper kullanma)
        static char BuyukYaz(char value)
        {
            string kucukHarf = "aeıioöuü";
            string buyukHarf = "AEIİOÖUÜ";
            char result = value;
            for (int i = 0; i < kucukHarf.Length; i++)
            {
                if (kucukHarf[i] == value)
                {
                    result = buyukHarf[i];
                    break;
                }
            }
            return result;
        }

        //metnin içerisinde kaçtane sesli harf olduğunu döndüren method
        static int SesliHarfler(string text)
        {
            string sesliHarfler = "AEIİOÖUÜ";
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (BuyukYaz(text[i]) == sesliHarfler[j]) //metot içerisinde başka metot cağırılabilir
                    {
                        counter++;
                        break;
                    }
                }
            }
            return counter;
        }
        //oluşturulan iki diziyi birleştiren ve tek dizide veren method

        static string[] DiziBirlestir(string[] dizi1, string[] dizi2)
        {
            string[] yeniDizi = new string[dizi1.Length + dizi2.Length];
            for (int i = 0; i < dizi1.Length; i++)
            {
                yeniDizi[i] = dizi1[i];
            }
            for (int i = dizi1.Length; i < dizi1.Length + dizi2.Length; i++)
            {
                yeniDizi[i] = dizi2[i - dizi1.Length];
            }
            return yeniDizi;
        }

    }
}
