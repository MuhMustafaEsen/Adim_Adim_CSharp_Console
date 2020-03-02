using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibo = Fibonacci(5);
            Console.WriteLine(fibo);

            int faktoriyel = Faktoriyel(4);
            Console.WriteLine(faktoriyel);

            Console.ReadKey();
        }

        //fibonacci recursive 
        //1 1 2 3 5
        static int Fibonacci(int x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }

        //faktöriyel recursive
        static int Faktoriyel(int sayi)
        {
            if (sayi == 0)
                return 1;
            else
                return sayi * Faktoriyel(sayi - 1);
        }
    }
}
