using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikselIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ornek1
            //Dışarıdan alınan fiyatın kdvsini hesaplayınız.
            Console.WriteLine("Lütfen bir fiyat değeri giriniz");
            double fiyat = double.Parse(Console.ReadLine());
            double kdv = fiyat * 0.18;
            Console.WriteLine($"ürünün kdvsi {kdv} TL'dir");
            Console.ReadKey();
            #region Ornek2
            //Ürünün kdvsiz fiyatı alınsın kdv eklendikten sonra fiyatının kaç oldugu gösterilsin

            Console.WriteLine("Lütfen bir fiyat değeri giriniz");
            double fiyati = double.Parse(Console.ReadLine());
            double kdvsi = fiyati * 0.18;
            double kdvliFiyat = fiyat + kdv;
            Console.WriteLine("Bu ürünün kdvli fiyatı " + kdvliFiyat);

            Console.WriteLine("Lütfen bir fiyat değeri giriniz");
            double fiyat2 = double.Parse(Console.ReadLine());
            double kdvlifiyat2 = fiyat2 * 1.18;
            Console.WriteLine($"bu ürünün kdvli fiyati {kdvlifiyat2}");
            #endregion Ornek2

            #region Ornek2
            //Dışarıdan girilen bir sayının 10 eksiğinin 40 fazlasının 2 ye bölümünden kalan kaçtır?
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            sayi = sayi - 10;
            sayi = sayi + 40;
            sayi = sayi % 2;
            Console.WriteLine($"Sorunun cevabı = {sayi}");

            //Degişken üzerinde birden fazla matematiksel işlem yapılabilir.
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = ((sayi2 - 10) + 40) % 2;
            Console.WriteLine(sonuc);
            Console.ReadKey();
            #endregion

            // Dışarıdan girilen iki sayının toplamıyla farkının birbirine bölümününden kalan kaçtır?
            Console.WriteLine("Lütfen birinci sayıyı giriniz");
            int sayiBir = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int sayiIki = int.Parse(Console.ReadLine());
            int toplam = sayiBir + sayiIki;
            int fark = sayiBir - sayiIki;
            int sonuc2 = toplam % fark;

            //tek bir degişken tanımlayrak bütün işlemler halledilebilir.
            int kısaSonuc = (sayiBir + sayiIki) % (sayiBir - sayiIki);
            Console.WriteLine("2. Orneğin cevabı = " + sonuc2);
            Console.ReadKey();

            //Dışarıdan girilen iki sayının karelerinin toplamı ile karelerinin farkının toplamı kaçtır?
            Console.WriteLine("Lütfen birinci sayıyı giriniz");
            int sayi_Bir = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int sayi_Iki = int.Parse(Console.ReadLine());
            int sonuc3 = ((sayiBir * sayiBir) + (sayiIki * sayiIki)) + ((sayiBir * sayiBir) - (sayiIki * sayiIki));

            Console.WriteLine("Sorunun cevabı : " + sonuc3);
            Console.ReadKey();

            //Dışarıdan iki vize bir final notu alınsın vizelerin yüzde 30u finalin yüzde 40 alındığında ders geçme notu bulunur. Öğrencinin girdiği notlara göre ders geçme notunu hesaplayınız.
            Console.WriteLine("Lütfen birinci vize notunuzu giriniz");
            double vize1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci vize notunuzu giriniz");
            double vize2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen final notu giriniz");
            double final = double.Parse(Console.ReadLine());

            double vize1ort = vize1 * 0.3;
            double vize2ort = vize2 * 0.3;
            double finalort = final * 0.4;
            double ortalama = vize1ort + vize2ort + finalort;
            double kısaOrtalama = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
            Console.WriteLine("Öğrencinin yıl sonu notu " + ortalama);
            Console.WriteLine("Öğrencinin yıl sonu notu " + kısaOrtalama);
            Console.ReadKey();

            //boxing unboxing nedir araştırın.

            //kullanıcıdan önce isim sonra soyisim verileri alınsın bu veriler kullanılarak çıktı isim.soyisim@gmail.com şeklinde verilsin

            Console.WriteLine("Lütfen adınızı giriniz.");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz");
            string soyad = Console.ReadLine();
            string mail = ad + "." + soyad + "@gmail.com";
            Console.WriteLine(mail);
            Console.WriteLine(ad + "." + soyad + "@gmail.com");
            Console.ReadKey();

            //kullanıcıdan istenen ad ve yaş değerlerini alınız bu değerleri "yaş yaşındaki isim ismindeki kullanıcı sisteme giriş yaptı" şeklinde çıktı Uretiniz.
            Console.WriteLine("Lütfen adınızı giriniz");
            string adi = Console.ReadLine();
            Console.WriteLine("Lütfen yaşınızı giriniz");
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine($"{yas} yaşındaki {ad} ismindeki kullanıcı sisteme giriş yaptı");
            Console.ReadKey();
        }
    }
}
