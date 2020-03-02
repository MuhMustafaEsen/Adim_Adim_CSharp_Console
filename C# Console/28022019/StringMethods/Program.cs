using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Join
            string[] cities = { "Kars", "Konya", "Tokat", "Ardahan", "Van" };
            string joinedcities = string.Join("_", cities);
            Console.WriteLine(joinedcities);
            //Kars_Konya_Tokat_Ardahan_Van

            //Split
            string names = "Gizem,Cihan-Mustafa,Furkan-Rumeysa-Barış-Mahsun";
            string[] adlar = names.Split('-', ',');
            foreach (string item in adlar)
            {
                Console.WriteLine(item);
            }

            //Cointains
            string metin = "Mustafa adam dır";
            Console.WriteLine(metin.Contains("adam") ? "adam metnin içerinde var" : "adam metnin içerisinde yok");

            //Remove
            string metin1 = "Bu bir cumledir";
            string silinenMetin = metin1.Remove(5);
            string silinenMetin2 = metin1.Remove(5, 3);
            Console.WriteLine(silinenMetin2);


            //Substring
            string cumle = "mustafaesenmustafa";
            //metin = cumle.Substring(5); 
            string metin2 = cumle.Substring(5, 4);
            Console.WriteLine(metin2);

            //Trim
            string value = "       Mustafa          ";
            value = value.Trim();
            value = value + "Esen";
            Console.WriteLine(value);

            //Replace 
            string text = "mustafa";
            //text = text.Replace('a', 'i');
            text = text.Replace("adam", "kadın");
            Console.WriteLine(text);

            //ToUpper ToLower
            string isim = "GiZem";
            string isim1 = "MustaFA";
            string birlestir = isim.ToLower() + isim1.ToUpper();
            Console.WriteLine(birlestir);

            //Insert
            string deger = "burdavarmı";
            deger = deger.Insert(5, "bir");
            Console.WriteLine(deger);

            //IndexOf LastIndexOf
            string cumle1 = "bilge bir adam Mustafa";
            int index = cumle1.IndexOf('b');
            int sonIndex = cumle1.LastIndexOf('b');
            Console.WriteLine($"{cumle1} metninde b nin bulundu ilk index {index} , son index {sonIndex}");

            //metotlar birbirine bağlanarak bu şekilde kullanılanılabilir
            string cumle2 = "Bilgeadam";
            cumle2 = cumle2.Replace('a', 'e').Substring(5, 4).ToLower();
            Console.WriteLine(cumle2);
            Console.ReadKey();
        }
    }
}
