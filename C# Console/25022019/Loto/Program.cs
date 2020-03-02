using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen satır sayisina gore 6 sutunlu sıralı sayilardan olusan loto sayilari uretiniz 
            //ornek
            //Kolon sayısını giriniz >>> 4
            //8 11 23 26 40 48

            //5 17 21 25 30 45

            //1 7 8 20 40 49

            //3 9 10 14 25 27

            Console.WriteLine("Lütfen satır sayısı giriniz");
            int satir = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] rastgeleSayilar = new int[6];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    rastgeleSayilar[j] = rnd.Next(0, 100);

                }
                Array.Sort(rastgeleSayilar); //küçükten büyüğe sıralama
                for (int k = 0; k < 6; k++)
                {
                    Console.Write(rastgeleSayilar[k] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
