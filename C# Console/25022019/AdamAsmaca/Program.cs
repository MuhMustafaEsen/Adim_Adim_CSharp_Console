using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Başkentlerin oldugu bir dizi olusturunuz. bu diziden rastgele bir şehir getirip kullanıcının klasik
            //adam asmaca kuralları ile sehri tahmin etmesini saglayınız.3 adet yanlıs yapma hakkı tanıyınız.
            string []sehirler = { "İSTANBUL", "ANKARA", "İZMİR", "BURSA", "TRABZON", "SİVAS", "BARCELONA", "PARİS", "LONDRA", "RİO DE JANEİRO", "RİGA" };
            Random rnd = new Random();
            int sayi = rnd.Next(sehirler.Length);
            string secilenSehir = sehirler[sayi];
            char[] tire = new char[secilenSehir.Length];
            char harf = '\0';
            int tireSayisi = tire.Length;
            int hak = 4;
            bool bildiMi = false;
            for (int i = 0; i < secilenSehir.Length; i++)
            {
                if (secilenSehir[i] == ' ')
                {
                    tire[i] = ' ';
                    tireSayisi--;
                }
                else
                {
                    tire[i] = '_';
                }
            }
            Console.WriteLine();
            do
            {
                foreach (char item in tire)
                {
                    Console.Write(item + " ");
                }
                Console.Write("Tahmin : " );
                harf = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < secilenSehir.Length; i++)
                {
                    if (secilenSehir[i] == harf)
                    {
                        tire[i] = harf;
                        tireSayisi--;
                        bildiMi = true;
                    }
                    
                }
                if (!bildiMi)
                {
                    hak--;
                }
                bildiMi = false;
                Console.WriteLine();
            } while (hak > 0 && tireSayisi > 0);
            foreach (char item in tire)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
