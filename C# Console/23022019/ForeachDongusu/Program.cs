using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lokanta = { "Balkan", "tava", "Beyran", "Seyran", "Rumeli", "Oses" };
            for (int i = 0; i < lokanta.Length; i++)
            {
                Console.WriteLine(lokanta[i]);
            }
            Console.ReadKey();
            //yaygın kullanım şekli
            foreach (string item in lokanta)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //kullanıcıdan aldığın metnin harflerini listele 
            Console.WriteLine("metin giriniz");
            string metin = Console.ReadLine();
            foreach (char item in metin)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
            //int tipli bir dizi oluşturun bu dizi en az 10 eleman sahip olsun ikiye bölünenleri listeleyin hem ikiye hem üçe bölünenlerin sayısını basın

            int[] sayilar = { 23, 45, 235, 57, 235, 76, 23, 58, 56, 2557, 9, 6, 12, 36 };
            int sayac = 0;
            foreach (int item in sayilar)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
                if (item % 2 == 0 && item % 3 == 0)
                {
                    sayac++;
                }

            }
            Console.WriteLine("hem ikiye hem üçe bölünen sayıların adeti=" + sayac);
            Console.ReadKey();
        }
    }
}
