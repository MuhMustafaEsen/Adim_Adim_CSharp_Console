using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime(1990, 7, 6);
            Console.WriteLine(time.AddDays(6));
            Console.WriteLine(time.AddMonths(4));
            Console.WriteLine(time.ToLongDateString());
            Console.WriteLine(time.ToShortDateString());
            Console.WriteLine(time.Year);
            Console.WriteLine(time.Month);
            Console.WriteLine(time.DayOfWeek);

            TimeSpan fark = DateTime.Now - time;
            Console.WriteLine(fark.Days);
            Console.WriteLine(fark.Hours);
            Console.WriteLine(fark.Minutes);

            Console.ReadKey();
        }
    }
}
