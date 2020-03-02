using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Out
{
    class Program
    {
        static void Main(string[] args)
        {

            //OUT

            //bir method içerisinde dışarıya birden fazla deger gondermek istedigimizde return kelimesi ihtiyacımızı
            //karşılamaz bu işlemi gerçekleştirebilmek için 'Out' kullanmamız gerekir.
            //Cok kez kullandıgımız int.tryParse() methoduda out parametresiyle çalışmaktadır.
            
            //ornek 1
            int sayi;
            Firlat(out sayi);
            Console.WriteLine(sayi);
            Console.ReadKey();

            //ornek 2
            int deger;//out ile gelecek degeri tutmak için tanımlamış oldugumuz degişken
            int donenDeger = Firlat2(out deger);//donenDeger degişkeni return edilen deger olacaktır.
            Console.WriteLine($"Bu metottan dönen deger (return edilen deger) {donenDeger} fırlatılan deger {sayi}");
            Console.ReadKey();

            //ornek 3
            int sayi1;
            int returnDeger = Firlat3(5, out sayi1);
            Console.WriteLine($"Bu metottan dönen deger (return edilen deger) {returnDeger} fırlatılan deger {sayi1}");
            Console.WriteLine($"Bu metottan dönen deger (return edilen deger) {Firlat3(5, out sayi1)} fırlatılan deger {sayi1}");
            Console.ReadKey();

            //ornek 4 //birden fazla degeri out ile method dışına fırlatmak.
            int deger1;
            int deger2;
            int donenDeger1 = Firlat4(5, out deger1, out deger2);
            Console.WriteLine($"geriye dönen deger {donenDeger1}, fırlatılan degerler {deger1}, {deger2}");
            Console.ReadKey();

            //ornek 5   //kullanıcıdan iki sayı alın bu iki sayıyla bildiğimiz tüm aritmatik işlemleri fırlatalım
            Console.WriteLine("sayı giriniz");
            int sayi_Bir = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı giriniz");
            int sayi_Iki = int.Parse(Console.ReadLine());
            int toplamaSonucu;
            int cıkarmaSonucu;
            int carpmaSonucu;
            double bolmeSonucu;
            byte modSonucu;

            Islem(sayi_Bir, sayi_Iki, out toplamaSonucu, out cıkarmaSonucu, out bolmeSonucu, out carpmaSonucu, out modSonucu);
            Console.WriteLine("Toplama sonucu => " + toplamaSonucu + "\nCıkarma sonucu =>" + cıkarmaSonucu + "\nBolme sonucu=> " + bolmeSonucu + "\ncarpma sonucu => " + carpmaSonucu + "\nMod sonucu => " + modSonucu);
            Console.ReadKey();
        }
        static void Firlat(out int sayi)//kesinlikle out oldugunu belirtmemiz gereklidir.
        {
            sayi = 30;
        }
        static int Firlat2(out int deger)
        {
            deger = 20;
            return 40;
        }
        static int Firlat3(int sayi, out int firlatilanSayi)
        {
            int islem = sayi + sayi;
            firlatilanSayi = islem * 2;
            return islem;
        }
        static int Firlat4(int sayi, out int firlatilanSayi1, out int FirlatilanDeger2)
        {
            firlatilanSayi1 = sayi * sayi;
            FirlatilanDeger2 = sayi + sayi;
            return sayi;
        }

        //kullanıcıdan iki sayı alın bu iki sayıyla bildiğimiz tüm aritmatik işlemleri fırlatın methodu
        static void Islem(int sayi_Bir,int sayi_Iki,out int toplam,out int fark,out double bolum,out int carpım,out byte mod)
        {
            toplam = sayi_Bir + sayi_Iki;
            fark = sayi_Bir - sayi_Iki;
            bolum = sayi_Bir / sayi_Iki;
            carpım = sayi_Bir * sayi_Iki;
            mod = (byte)(sayi_Bir % sayi_Iki);
        }
    }
}
