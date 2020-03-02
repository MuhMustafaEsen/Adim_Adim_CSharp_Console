using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //yorum satırı alma => yorum satırına alınacak olan kod seçilir aynı anda ctrl+k+c'ye basılır
            //writeLine => Ekran üzerine yazı yazdırmak istediğimiz zaman kullanırız yazıyı yazdıktan sonra alt satıra iner.
            //Write => yazıyı tek satırda yazar.
            Console.WriteLine("Hello World");

             Console.Write("Mustafa ");
            Console.Write("Kemal ");
            Console.WriteLine("Ataturk");
            //ReadKey()=> propgram çalıştığı zaman her hangi bir tuşa basılmadığı sürece ekranın kapanmaması için gerekli kod

            Console.ReadKey();

        }
    }
}
