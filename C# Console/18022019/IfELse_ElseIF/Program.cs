using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfELse_ElseIF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * KARAR YAPILARI
             * Kod yazarken bir durumun doğru ve yanlış olma durumunu ayrı ayrı incelemek istediğimizde
             * karar yapılarını kullanırız.
             * İf Else
             * switch case
             * ternary if
             */
            //İF ELSE (kullanım,yazım şekli)
            //Syntax
            //if (true)
            //{

            //}
            //else
            //{

            //}
            //kullanıcıdan alınan sayi eğer 9'a tam bölünüyor ise çıktı olarak "girdiğiniz sayi 9 un katıdır " çıktısı versin.
            //değil ise "bu sayının 9 a bölümünden kalan x dir" çıktısı alınsın

            /*
            Console.WriteLine("Lütfen bir sayi giriniz");
            int deger = int.Parse(Console.ReadLine());
            int kalan = deger % 9;
            if (deger % 9 == 0)
            {
                Console.WriteLine("girdiğiniz sayi 9 un katıdır");
            }
            else
            {
                Console.WriteLine("bu sayının 9 a bölümünden kalan {0} dir", kalan);
            }
            */
            //Her zaman else durumuna ihtiyacımız olmayabilir.
            //Eğer bir durumun sadece olma ihtimalinde yapacak işimiz var ise bize ifi yazmak yeterlidir else false durumu içindir
            //Aşagıdaki ornekte sadece 9'un kati olma durumu incelenmiştir.
            /*
            Console.WriteLine("Lütfen bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 9 == 0)
            {
                Console.WriteLine("girdiğiniz sayi 9 un katıdır");
            }
           
            Console.ReadKey();
            */

            //girilen bir sayının 10'dan büyük olma ihtimalini değerlendiriniz buna göre iki farklı çıktı oluşturunuz.
            /*
            Console.WriteLine("Lütfen bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 10)
            {
                Console.WriteLine("Sayi 10dan büyüktür");
            }
            else
            {
                Console.WriteLine("Sayi 10dan küçük veya 10'a eşittir");
            }
            Console.ReadKey();
            */

            //Kullanıcıdan metinsel bir şifre aldığımızı düşünelim bu şifrenini uzunluğu 8 den büyük ise giriş yapıldı çıktısı alınsın ancak 8 den küçük ise uyarı olarak lütfen en az 8 karakterli bir şifre giriniz basılsın.
            /*
            Console.WriteLine("Lütfen şifrenizi giriniz.");
            string sifre = Console.ReadLine();
            if (sifre.Length >= 8)//Length sifre stringinin karakter sayisini verir.
            {
                Console.WriteLine("giriş yapıldı");
            }
            else
            {
                Console.WriteLine("lütfen en az 8 karakterli bir şifre giriniz");
            }
            Console.ReadKey();
            */

            //klavyeden girilen değerin dtek mi çift mi olduğunu bildiren kod bloğunu oluşturunuz.
            /*
            Console.WriteLine("lütfen bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
            Console.ReadKey();
            */
            // belirlenen kullanıcı adı ve şifresi kullanıcıdan alinsin eğer kullanici adı admin şifre 123 ise giriş yapıldı her hangi biri 
            //doğru değil ise 'şifre veya kullanıcı adını yanlış girdiniz' bilgisi yazsın
            /*
            Console.WriteLine("lütfen kullanıcı adı giriniz");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("lütfen şifre giriniz");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "123")
            {
                Console.WriteLine("Giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Şifre veya kullanıcı adı yanlış girildi");
            }

            Console.ReadKey();
            */
            //iç içe sorgu
            /*
            if (kullaniciAdi == "admin")
            {
                if (sifre == "123")
                {
                    Console.WriteLine("Giriş yapıldı.");
                }
                else
                {
                    Console.WriteLine("Lütfen şifreyi doğru giriniz");
                }
            }
            else
            {
                Console.WriteLine("Lütfen kullanıcı adını doğru giriniz");
            }
            Console.ReadKey();
            */

            // bir mağazada alınan ürünlerin fiyatı 100 tlnin üzerinde ise kargo ücreti alınmamaktadır Kargo parası = 5tl Bu bilgiye dayanarak kullanıcıdan ne kadarlık ürün aldığı öğrenilerek ödeyeceği ücreti veren kodu oluşturun.
            /*
                        Console.WriteLine("Lütfen aldığınız ürünlerin toplam fiyatını giriniz");
                        double fiyat = double.Parse(Console.ReadLine());

                        if (fiyat >= 100)
                        {
                            Console.WriteLine($"Ödenecek tutar {fiyat}");
                        }
                        else
                        {
                            fiyat += 5;
                            Console.WriteLine($"Ödenecek tutar { fiyat}");
                        }
                        Console.ReadKey();
                        */

            // kullanıcıdan, aldığı iki ürünün fiyatı alınsın eğer bu iki ürünün toplam fiyat 100 tl'yi geçer ise ucuz olan ürüne %25 indirim yapılsın Kullanıcıya ödeyeceği tutar çıktı olarak verilsin.
            /*
            Console.WriteLine("Ürün fiyatını giriniz");
            double urunBir = double.Parse(Console.ReadLine());
            Console.WriteLine("Ürün fiyatını giriniz");
            double urunIki = double.Parse(Console.ReadLine());

            double toplam = urunBir + urunIki;
            if (toplam > 100)
            {
                if (urunBir > urunIki)
                {
                    urunIki = urunIki * 0.75;
                    toplam = urunIki + urunBir;
                    Console.WriteLine($"Ödenecek tutar { toplam}");

                }
                else
                {
                    urunBir = urunBir * 0.75;
                    toplam = urunBir + urunIki;
                    Console.WriteLine($"Ödenecek tutar { toplam}");
                }
            }
            else
            {
                Console.WriteLine($"Ödenecek tutar { toplam}");
            }
            Console.ReadKey();
            */

            //kullanıcıdan aldığı üç ürünün fiyatı alınır Bu üç urunun toplam fiyatı 250 den fazla ise çıktı olarak Bu ayki harcama limitinizi aştınız yazsın değil ise limitiniz şu kadar kaldı diye uyarı yazısı yazsın
            /*
            Console.WriteLine("birinci ürünün fiyatını giriniz");
            decimal fiyatBir = decimal.Parse(Console.ReadLine());

            Console.WriteLine("ikinci ürünün fiyatını giriniz");
            decimal fiyatIki = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Üçüncü ürünün fiyatını giriniz");
            decimal fiyatUc = decimal.Parse(Console.ReadLine());

            decimal toplam = fiyatBir + fiyatIki + fiyatUc;
            decimal kalanTutar = 0;
            if (toplam > 250)
            {
                Console.WriteLine("limiti aştınız");
            }
            else
            {
                kalanTutar = 250 - toplam;
                Console.WriteLine("bakiyede kalan tutar {0} TL'dir", kalanTutar);
            }
            Console.ReadKey();
            */

            // kullanıcıdan yaşadığı ortamın sıcaklık bilgisi alınsın bu sıcaklı 20-26 arasında ise cıktı olarak uygun yaşama sıcaklığı yazsın değil ise bu ortam sizin için uygun değil çıktısı alınsın.
            /*
            Console.WriteLine("Lütfen ortam sıcaklığını giriniz");
            double derece = double.Parse(Console.ReadLine());

            if (derece > 20 && derece <= 26)
            {
                Console.WriteLine("Ortam yaşamak için uygundur.");
            }
            else
            {
                Console.WriteLine("Ortam yaşamak için elverişli değil");
            }

            Console.ReadKey();
            */

            //dışarıdan girilen sayının tek mi çift mi yoksa 0 mı olduğunu kontrol edin girilen değer sayısal bir ifade değil ise hata mesajı verin

            //TryParse yapısı içine girilen deger eğer istenilen tipe cevrilebiliyorsa cevirir ve kendi true dönerken sayıyı da fırlatır eger yapı convert edilemiyor ise o zaman false döner ve bir deger fırlatmaz.
            /*
            Console.WriteLine("bir sayı giriniz");
            int sayi = 0;
            bool donustuMu = int.TryParse(Console.ReadLine(), out sayi);
            if (!donustuMu)
            {
                Console.WriteLine("Hatalı giriş yapıldı");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("sayi 0 dır");
            }
            else if (sayi % 2 == 0)
            {
                Console.WriteLine("sayi çifttir");
            }
            else
            {
                Console.WriteLine("sayi tektir");
            }
            Console.ReadKey();
            */

            //kullanıcıdan vize ve final notları alınız vizenin %40 finalin %60 alarak bir sene sonu notu oluşturunuz bu oluşturulan nota göre 
            //0-25 beşlik sistemde notunuz 0
            //25-45 beşlik sistemde notunuz 1
            //45-55 beşlik sistemde notunuz 2 
            //55-65 beşlik sistemde notunuz 3
            //65-85  beşlik sistemde notunuz 4
            //85-100 beşlik sistemde notunuz 5
            //olarak çıktı versin
            /*
            Console.WriteLine("Lütfen vize notunuzu giriniz");
            double vize = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen final notunuzu giriniz");
            double final = double.Parse(Console.ReadLine());
            double not = (vize * 0.4) + (final * 0.6);
            if (not >= 0 && not < 25)
            {
                Console.WriteLine("beşlik sistemde notunuz 0");
            }
            else if (not >= 25 && not < 45)
            {
                Console.WriteLine("beşlik sistemde notunuz 1");
            }
            else if (not >= 45 && not < 55)
            {
                Console.WriteLine("beşlik sistemde notunuz 2");
            }
            else if (not >= 55 && not < 65)
            {
                Console.WriteLine("beşlik sistemde notunuz 3");
            }
            else if (not >= 65 && not < 85)
            {
                Console.WriteLine("beşlik sistemde notunuz 4");
            }
            else if (not >= 85 && not <= 100)
            {
                Console.WriteLine("beşlik sistemde notunuz 5");
            }
            Console.ReadKey();
            */

            //Kullanıcıdan iki sayı ve yapılacak işlem istensin bu değişkenler kullanılarak yapılan işlemin sonucu basılsın.
            /*
            Console.WriteLine("sayı girişi yapınız");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("sayı girişi yapınız");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Yapılacak işlem Toplama ise +' ya basınız \nYapılacak işlem çıkarma ise -' ye basınız \nYapılacak işlem Çarpma ise *' a basınız \nYapılacak işlem Bölme ise /' ya basınız \nYapılacak işlem Mod alma ise %' ya basınız ");
            string islem = Console.ReadLine();
            double sonuc = 0;

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;


            }
            else if (islem == "-")
            {
                sonuc = sayi2 - sayi1;


            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;


            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;

            }
            else if (islem == "%")
            {
                sonuc = sayi2 % sayi1;

            }
            else
            {
                Console.WriteLine("geçersiz veri girişi yaptınız");
            }
            Console.WriteLine("Bu işlemin sonucu = " + sonuc);
            Console.ReadKey();
            */

            //bir işyerinde çalışanlar maaşları dışında prim almaktadırlar Prim hesabı sattıkları ürün bazından işlenmektedir 
            //1-10 ürün satışında ürün başı 5TL
            //11-25 ürün satışında ürün başı 7TL
            //26-30 ürün satışında ürün başı 11TL
            //30 ve üzeri ürün satışında ürün başı 20TL prim verilmekte 
            //kullanıcan önce maaşı sonra sattığı ürün adeti alınarak verilenlere göre prim dahil alacağı ücretin kac tl olduğunu veren kod bloğunu yazınız.
            /*
            Console.WriteLine("maaş bilgisi giriniz");
            double maas = double.Parse(Console.ReadLine());
            Console.WriteLine("Sattığınız ürün adedini giriniz");
            double adet = double.Parse(Console.ReadLine());
            double prim = 0;
            if (adet > 0 && adet <= 10)
            {
                prim = adet * 5;
            }
            else if (adet > 10 && adet <= 25)
            {
                prim = adet * 7;
            }
            else if (adet > 25 && adet <= 30)
            {
                prim = adet * 11;
            }
            else if (adet > 30)
            {
                prim = adet * 20;
            }
            double toplamOdenecek = maas + prim;
            Console.WriteLine("Bu ay size ödenecek hakediş" + toplamOdenecek);
            Console.ReadKey();
            */

            
        }
    }
}
