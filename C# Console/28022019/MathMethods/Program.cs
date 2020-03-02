using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //matematik kütüphanesinin hazır methodlari
            Console.WriteLine(Math.Abs(-5)); //5
            Console.WriteLine(Math.Cos(0));
            Console.WriteLine(Math.Round(4.6)); //4-4.5=> 4 4.6-5 =>5
            Console.WriteLine(Math.Floor(4.8)); //4
            Console.WriteLine(Math.Max(7, 100));
            Console.WriteLine(Math.Max(1000, (Math.Max(7, 100))));//1000
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Min(9, 22));//9
            Console.WriteLine(Math.Log10(10));//1
            Console.WriteLine(Math.Pow(2, 3)); //8
            Console.WriteLine(Math.Ceiling(4.0)); //5
            Console.WriteLine(Math.Equals(4, 4)); //true
            Console.WriteLine(Math.Sign(-5)); //-1
            Console.WriteLine(Math.Sqrt(16)); //4
            Console.WriteLine(Math.BigMul(6, 5)); //30
            Console.ReadKey();
        }
    }
}
