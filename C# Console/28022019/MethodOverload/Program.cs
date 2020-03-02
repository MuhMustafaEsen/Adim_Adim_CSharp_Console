using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir methodun birden fazla şekilde kullanılması gerektiğinde yapılması gereken işlem method
            //imzasının yeniden ve farklı şekilde oluşturulmasıdır. Bu yapıya methodu overload etmek denir.
            //Aynı method ismi kullanılmalı
            //1.ornek  method isimleri aynı imzalari farklı
            Console.WriteLine(Topla());
            Console.WriteLine(Topla(4, 6));
            Console.WriteLine(Topla(4, 6, 8));

            //2.ornek method isimleri aynı 4 farklı imzası var imzasına gore mail adresini ilgili methoda
            //gidip olusturuyor.
            string msn =  MailOlustur("mustafa", "esen");
            string msn2 = MailOlustur("mustafa", "esen", "hotmail");
            string msn3 = MailOlustur("mustafa", "esen", "outlook", '-');
            string msn4 = MailOlustur("mustafa", "esen", "gmail", "uk");

            Console.WriteLine(msn);
            Console.WriteLine(msn2);
            Console.WriteLine(msn3);
            Console.WriteLine(msn4);


            Console.ReadKey();

        }

        /// <summary>
        /// iki sayı için toplama işlemi yapar
        /// </summary>
        /// <param name="sayiBir">integer bir sayi giriniz</param>
        /// <param name="sayiIki">integer bir sayi giriniz</param>
        /// <returns></returns>
        static int Topla(int sayiBir, int sayiIki)
        {
            return sayiBir + sayiIki;
        }


        /// <summary>
        /// üç sayinin için toplama işlemi yapar
        /// </summary>
        /// <param name="sayiBir">integer bir sayı giriniz</param>
        /// <param name="sayiIki">integer bir sayı giriniz</param>
        /// <param name="SayiUc">integer bir sayı giriniz</param>
        /// <returns></returns>
        static int Topla(int sayiBir, int sayiIki, int SayiUc)
        {
            return sayiIki + sayiBir + SayiUc;
        }

        /// <summary>
        /// 5'5le toplar.
        /// </summary>
        /// <returns>int döner</returns>
        static int Topla()
        {
            return 5 + 5;
        }


        //mail adresi oluşturma metodu yazacağız
        //1 ad soyad al ad.soyad@bilgeadam.com
        static string MailOlustur(string ad, string soyad)
        {
            return ad + "." + soyad + "@mail.com";
        }
        //2 ad soyad uzantı ad.soyad@uzantı.com
        static string MailOlustur(string ad, string soyad, string uzantı)
        {
            return ad + "." + soyad + "@" + uzantı + ".com";
        }

        //3 ad soyad uzantı tr ad.soyad@uzantı.com.tr
        static string MailOlustur(string ad, string soyad, string uzantı, string tr)
        {
            return ad + "." + soyad + "@" + uzantı + ".com." + tr;
        }
        //4 ad soyad uzantı sembol al adsembolsoyad@uzantı.com bas
        static string MailOlustur(string ad, string soyad, string uzantı, char sembol)
        {
            return ad + sembol + soyad + "@" + uzantı + ".com";
        }
    }
}
