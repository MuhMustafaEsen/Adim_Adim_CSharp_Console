using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aşağıdaki koşulları sağlayan bir sayı tahmim oyunu hazırlayınız.
            //1.Bilgisayar 1 ile 100 arasında rastgele bir sayı tutmalıdır.
            //2.Sonsuz bir döngü içerisinde kullanıcının bu sayıyı tahmin etmesi ve tahmin sayisini için “X.tahmininizi:” yaptınız yazmalıdır.
            //3.Eğer kullanıcı belirtilen aralık dışında bir sayı girerse kullanıcı uyarılmalı ve sayaç arttırılmadan kullanıcının yeni sayı girmesi istenmelidir.
            //4.Eğer kullanıcı sayı dışında bir değer girerse (metinsel bir ifade) kullanıcı uyarılmalı ve sayaç arttırılmadan kullanıcının yeni sayı girmesi istenmelidir.
            //5.Doğru sayı bilindiğinde “Sayıyı X. tahmininizde buldunuz.” Yazmalıdır.
            //6.Kullanıcı uygulamadan çıkmak istiorsa “0” değerini girdiğinde otomatik olarak program kapanmalıdır.
            Random rnd = new Random();
            int bilgisayarınTutuguSayi = rnd.Next(1, 100);
            int tahminSayisi = 1;
            int tahmin = 0;
            bool sayiMi =false;
            do
            {
                Console.WriteLine("Tahminde bulunuz : ");
                sayiMi = Int32.TryParse(Console.ReadLine(),out tahmin);                
                if (sayiMi == false)
                {
                    Console.WriteLine("Lütfen sayisal bir deger giriniz.");
                    tahmin = 1;
                }
                else if (tahmin == bilgisayarınTutuguSayi)
                {
                    Console.WriteLine("Tebrikler sayiyi " + tahminSayisi + ". tahminde buldunuz.");
                }
                else if (tahmin > bilgisayarınTutuguSayi && tahmin < 100)
                {
                    Console.WriteLine("daha kucuk bir tahmin yapınız.");
                    tahminSayisi++;
                }
                else if (tahmin < bilgisayarınTutuguSayi && tahmin > 0)
                {
                    Console.WriteLine("daha buyuk bir tahmin yapınız.");
                    tahminSayisi++;
                }                    
            } while (tahmin != 0);
            Console.WriteLine("Oyun Kapandı");
            Console.ReadKey();
        }
    }
}
