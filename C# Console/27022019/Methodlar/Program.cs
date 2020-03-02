using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Metot, program içerisinde belirli görevleri yerine getirmek için özelleştirilmiş kod bloklarına verilen isimdir.
             *Metot Kullanmanın Avantajları
                Metotlar aynı kodların sürekli tekrarlanmasını önler.
                Programların okunabilirliğini ve anlaşılabilirliğini arttırır.
                Aynı kod bloklarının farklı farklı yerlerde yeniden kullanılmasına olanak sağlar.
                Metotlar nesne tabanlı programlamada önemli bir yere sahiptir. 
             */
            SayHello();
            Console.WriteLine("metin gir");
            string metin = Console.ReadLine();
            SayHello(metin);
            SayHello("Hellooooo!!!");
            int toplam = Toplaa(5);
            toplam += 5;
            Console.WriteLine(toplam);
            Console.WriteLine(PiSayisi());
            Console.ReadKey();
        }
        static void SayHello() //void => geriye deger döndürmeyen ()=> parametresiz bir metot
        {
            //return kullanılmıyor
            Console.WriteLine("Hello World");
        }
        static void SayHello(string metin) //void => geriye deger döndürmüyor (string metin) string yapıda bir parametre alan metot
        {
            Console.WriteLine(metin);
        }
        static int Toplaa(int sayi) //int geriye döndüreceğin değerin tipi return => geriye dönecek degere yapılacak işlemlerin sonucunu veren yapı
        {
            int toplam = sayi + sayi;
            return toplam;
        }
        static double Topla(int sayi) 
        {
            return sayi + sayi;
        }
        
        static double PiSayisi()//parametresiz geriye deger donduren double tipinde pi sayisini fırlatıyor.
        {
            return 3.142;
        }
    }
    }

