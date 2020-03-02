using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametresizVoidMethod_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //methodu çağıracağım yer
            EkranaYaz();
            Topla();
            IslemYap();
            Console.ReadKey();
        }
        static void EkranaYaz()
        {
            Console.WriteLine("dfsdgsg");
        }

        static void Topla()
        {
            int sayiBir = 10;
            int sayiIki = 20;
            int toplam = sayiBir + sayiIki;
            Console.WriteLine(toplam);
        }

        // 5 ve 10 sayılarının toplayıp karesini alın bulduğunuz sayının 5 ile bölümünden kalanın 1 fazlası kaçtır.?

        static void IslemYap()
        {
            int sayiBir = 5;
            int sayiIki = 10;
            int sonuc = (((sayiBir + sayiIki) * (sayiBir + sayiIki)) % 5) + 1;
            Console.WriteLine(sonuc);
        }
    }
}
