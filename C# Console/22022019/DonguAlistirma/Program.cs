using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonguAlistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            //alt alta 5 tane X yaz
            Console.Write("alt alta 5 tane X yaz\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("X ");
            }
            //yanyana 5 tane X yaz
            Console.WriteLine("\nyanyana 5 tane X yaz");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("X ");
            }
            Console.WriteLine();
            //X'lerden 5x5lik bir kare oluştur.
            //xxxxx
            //xxxxx
            //xxxxx
            //xxxxx
            //xxxxx
            Console.WriteLine("\nX'lerden 5x5lik bir kare oluştur");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine(" ");
            }
            //giderek büyüyen ücgenler oluştur
            //x
            //xx

            //x
            //xx
            //xxx
            Console.WriteLine("\ngiderek büyüyen ücgenler oluştur");
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < k + 1; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("X ");
                    }
                    Console.WriteLine(" ");
                }
            }

            //içi boş kare oluştur
            //xxxxxxx
            //x     x
            //x     x
            //x     x
            //xxxxxxx
            Console.WriteLine("\niçi boş kare oluştur");
            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i == 9)
                {
                    Console.WriteLine("* * * * * * * * * *");
                }
                else
                {
                    Console.WriteLine("*                 *");
                }
            }
            Console.ReadKey();
        }
    }
}
