using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalIslemler
{
    class Program
    {
        static void Main(string[] args)
        {/*
             * Mantıksal İşlemler
             * Karşılatırma yapmamızı sağlayan yapılardır
             * <
             * >
             * <=
             * >=
             * !=
             * &&
             * ||
             */
            #region ornek1
            bool buyukMu = 3 > 5;
            Console.WriteLine(buyukMu);
            bool ucMu = 3 == 3;
            Console.WriteLine(ucMu);
            string ad = "mustafa";
            string soyad = "esen";
            bool oMu = ad == "mustafa" && soyad == "esen";
            Console.WriteLine(oMu);
            Console.ReadKey();

            #endregion
            #region Ornek 2
            //Dışarıdan iki sayı verisi aliniz bu iki sayı birbirine eşit mi diye sorgulayın ve sonucu bool olarak gosterin
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayiBir = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayiIki = int.Parse(Console.ReadLine());

            bool esitMi = sayiBir == sayiIki;
            Console.WriteLine(esitMi);
            Console.ReadKey();
            #endregion


            //Dışarıdan iki sayı verisi alınız bu iki sayının birbirine eşit olmama durumunu sorgulayınız.
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            bool esitDegilmi = sayi1 != sayi2;
            Console.WriteLine(esitDegilmi);
            Console.ReadKey();

            //kullancıdan iki yas bilgisi alıp birinci alınan yaşın ikinci alınan yaştan küçük olma durumunu sorgulayınız.
            Console.WriteLine("lütfen yaşınızı giriniz");
            int yasBir = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen yaşınızı giriniz");
            int yasIki = int.Parse(Console.ReadLine());

            bool kucukMu = yasBir < yasIki;
            Console.WriteLine(kucukMu);

            // kullancıdan iki yas alıp birinci alınan yaşın ikinci alınan yaştan büyük olma durumunu sorgulayınız.
            Console.WriteLine("lütfen yaşınızı giriniz");
            int yas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen yaşınızı giriniz");
            int yas2 = int.Parse(Console.ReadLine());

            bool buyuk_Mu = yas1 > yas2;
            Console.WriteLine(buyuk_Mu);

            //username = "admin" password = 123 şartları sağlanınca true çıktısı alan kodu yazınız.
            Console.WriteLine("kullanıcı adı");
            string kAdi = Console.ReadLine();
            Console.WriteLine("password");
            int password = int.Parse(Console.ReadLine());

            bool adminMi = kAdi == "admin" && password == 123;
            Console.WriteLine(adminMi);

            // kullanıcıdan iki isim alınsın bu iki isimden biri Arda ise true dönsün
            Console.WriteLine("İsim gir");
            string isimBir = Console.ReadLine();
            Console.WriteLine("İsim gir");
            string isimIki = Console.ReadLine();

            bool ardaMi = isimBir == "Arda" || isimIki == "Arda";
            Console.WriteLine(ardaMi);

            //kullanıcıdan bir isim bir yaş alınsın yas 15 ise true dönsün
            Console.WriteLine("İsim gir");
            string isim_bir = Console.ReadLine();
            Console.WriteLine("yaş gir");
            int yas = int.Parse(Console.ReadLine());
            bool yasOnBes = yas == 15;
            Console.WriteLine(yasOnBes);
            //kullanıcıdan iki sayı alınsın bu iki sayının toplamı büyük veya eşit 50 ise true dönsün

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi_Bir = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi_Iki = int.Parse(Console.ReadLine());

            int toplam = sayi_Bir + sayi_Iki;
            bool elliMi = toplam >= 50;

            Console.WriteLine(elliMi);
            //kullanıcıdan bir sayı alınıp o sayı çift ise true dönen kod

            Console.WriteLine("Lütfen bir sayı giriniz");
            int deger = int.Parse(Console.ReadLine());
            bool ciftMi = deger % 2 == 0;
            Console.WriteLine(ciftMi);
            //kullanıcıdan alınan 3 sayının birer fazlalarının toplamı 40 dan buyuk ise true dönen kod parcacıgını yazınız
            Console.WriteLine("Lütfen bir sayı giriniz");
            int ilkSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı giriniz");
            int ikinciSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı giriniz");
            int ucuncuSayi = int.Parse(Console.ReadLine());
            ilkSayi++;
            ikinciSayi += 1;
            ucuncuSayi = ucuncuSayi + 1;
            int total = ilkSayi + ikinciSayi + ucuncuSayi;
            bool buyukMu2 = total > 40;
            Console.WriteLine(buyukMu2);
            //kullanıcıdan bir sayı alınız bu sayının karesi kendisine eşit ise true dönsün
            Console.WriteLine("Lütfen bir sayı giriniz");
            int number = int.Parse(Console.ReadLine());
            int kare = number * number;
            bool kareMi = kare == number;
            Console.WriteLine(kareMi);

            //kullanıcıdan alınan 3 isim ayşe fatma hayriye ise true dönen kod parcacıgını yazınız
            Console.WriteLine("isim gir");
            string isim = Console.ReadLine();
            Console.WriteLine("isim gir");
            string isim1 = Console.ReadLine();
            Console.WriteLine("isim gir");
            string isim2 = Console.ReadLine();

            bool isimler = isim == "ayşe" && isim1 == "fatma" && isim2 == "hayriye";
            Console.WriteLine(isimler);

            //bankada 200 tl var kullanıcıdan alınan bankadan çekilecek miktar 200e esit veya küçük ise true dönsün
            Console.WriteLine("kaç para istiyorsun??");
            int para = int.Parse(Console.ReadLine());
            int bakiye = 200;
            bool cekerMi = para <= bakiye;
            Console.WriteLine(cekerMi);

        }
    }
}
