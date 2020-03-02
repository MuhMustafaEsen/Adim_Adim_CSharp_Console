using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Öncelikle lütfen adınızı giriniz => ad girişi=> lütfen soyadınızı giriniz => soyadı girişi => Çıktı(Hoşgeldin ad + Soyad)
            Console.WriteLine("Lütfen adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz " + ad + " " + soyad);
            Console.ReadKey();
        }
    }
}
