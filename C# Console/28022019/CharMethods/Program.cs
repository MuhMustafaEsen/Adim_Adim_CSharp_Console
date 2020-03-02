using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter = 'A';
            if(char.IsLetter(karakter))
            {
                Console.WriteLine("Harftir");
            }
            else
            {
                Console.WriteLine("harf değil");
            }

            if (char.IsNumber(karakter))
            {
                Console.WriteLine("numaradır");
            }
            else
            {
                Console.WriteLine("değildir");
            }

            if (char.IsSymbol(karakter))
            {
                Console.WriteLine("semboldur");
            }
            else
            {
                Console.WriteLine("değildir.");
            }

            if (char.IsUpper(karakter))
            {
                Console.WriteLine("büyük harf");
            }
            else
            {
                Console.WriteLine("küçük harf");
            }

            if (char.IsWhiteSpace(karakter))
            {
                Console.WriteLine("boşluk var");
            }
            else
            {
                Console.WriteLine("boşluk yok");
            }
            Console.ReadKey();
        }
    }
}
