using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliVoidMethod_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Yaz("Mustafa Esen");

            string yazı = "Esen";
            Yaz(yazı);
            
            int sayi = 4;
            WriteByNumber(sayi);

            byte byteSayi= 4;
            WriteByByte(byteSayi);
            WriteByNumber(byteSayi);
            WriteByByte((byte)sayi);

            Console.WriteLine("Bir sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir sayı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Carp(sayi1, sayi2);



            Console.WriteLine("Bir sayı giriniz");
            int deger = int.Parse(Console.ReadLine());
            Square(deger);

            Console.WriteLine("kullanıcı adı giriniz");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("şifre giriniz");
            string sifre = Console.ReadLine();
            Login(kullaniciAdi, sifre, "admin", "123", 1);
            Login(kullaniciAdi, sifre, "admin", "123", 2);
            Login(kullaniciAdi, sifre, null, null, 3);

            Console.WriteLine("gün ay yıl girişi yap");
            Console.Write("gün : ");
            int gun = int.Parse(Console.ReadLine());
            Console.Write("ay : ");
            int ay = int.Parse(Console.ReadLine());
            Console.Write("yil : ");
            int yıl = int.Parse(Console.ReadLine());
            DateTime birthday = new DateTime(yıl, ay, gun);
            Yas(birthday);

            int[] sayilar = { 12, 34, 55, 78, 91, 46, 56, 57, 90, 45, 467 };
            AltiyaTamBolunenler(sayilar);

            Console.WriteLine("Kaça kadar sayalım");
            int sonDeger = int.Parse(Console.ReadLine());

            Say(sonDeger);

            Console.ReadKey();
        }

        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }

        //cw ile tam sayı yazdıran metot
        static void WriteByNumber(int number)
        {
            Console.WriteLine(number);
        }

        static void WriteByByte(byte number)
        {
            Console.WriteLine(number);
        }

        //dışarıdan alınan iki sayıyı çarpıp basan method
        static void Carp(int sayiBir, int sayiIki)
        {
            int sonuc = sayiBir * sayiIki;
            Console.WriteLine(sonuc);

        }

        //Dışarıdan alınan sayının karesini basan method
        static void Square(int number)
        {
            int sonuc = number * number;
            Console.WriteLine($"Bu çarpmanın sonucu {sonuc}");

        }

        //kullanıcıdan bir kullanıcı adı bir password alınsın 3 farklı çekilde kontrol edilsin 
        //1.kullanış dışarıdan alınan doğru girdilerle eşit olum olmadığına bakılsın kullanıcı adı ve password degerlerinden herhangi biri yanlış ise girdilerden biri yanlış dedin
        //2kullanış dışarıdan alınan doğru girdilerle eşit olum olmadığına bakılsın kullanıcı adı yanlış ise ayrı uyarı şifre yanlış ise ayrı uyarı gelsin
        //3kullanıcı adının admin şifrenin 123 olduğu kontrol edilsin  yanlış ise yine ayrı ayrı çıktı verilsin

        static void Login(string user, string password, string systemuser, string systempassword, int type)
        {
            switch (type)
            {
                case 1:
                    if (user == systemuser && password == systempassword)
                    {
                        Console.WriteLine("doğru giriş yaptınız");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş");
                    }
                    break;
                case 2:
                    if (user == systemuser)
                    {
                        if (password == systempassword)
                        {
                            Console.WriteLine("Doğru giriş yaptın");
                        }
                        else
                        {
                            Console.WriteLine("password yanlış");
                        }
                    }
                    else
                    {
                        Console.WriteLine("kullanıcı adı yanlış");
                    }
                    break;
                case 3:
                    if (user == "admin")
                    {
                        if (password == "123")
                        {
                            Console.WriteLine("Doğru giriş yaptın");
                        }
                        else
                        {
                            Console.WriteLine("password yanlış");
                        }
                    }
                    else
                    {
                        Console.WriteLine("kullanıcı adı yanlış");
                    }
                    break;
                default:
                    Console.WriteLine("Öyle bir tip yok");
                    break;
            }
        }

        //Doğum günü tarihini gün ay yıl olarak alıp yaşı basan metot
        static void Yas(DateTime birthday)
        {
            int yas = DateTime.Now.Year - birthday.Year;
            if (birthday.Month > DateTime.Now.Month)
            {
                yas--;
            }
            else if (birthday.Month == DateTime.Now.Month)
            {
                if (birthday.Day > DateTime.Now.Day)
                {
                    yas--;
                }
            }
            Console.WriteLine($"Yaşınız {yas}");
        }

        // 12,34,55,78,91,46,56,57,90,45,467 sayılarından ikiye ve üçe bölünenleri basınız

        //!!!method dizi parametresi alabilir.
        static void AltiyaTamBolunenler(int[] dizi)
        {
            foreach (int item in dizi)
            {
                if (item % 2 == 0 && item % 3 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //Kullanıcıdan alınan degere kadar olan sayıları listele
        static void Say(int deger)
        {
            for (int i = 0; i <= deger; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
