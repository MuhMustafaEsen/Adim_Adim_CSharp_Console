using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatorler
            /*
             * Aritmatik operatorler
             * + toplama
             * - çıkarma
             * / bolme
             * * carpma
             * % mod alma ,kalani verir
             * Mantıksal
             * && ve
             * || veya
             * != eşit degil
             * <= kucuk esit
             * <  kucuktur
             * >= buyuk eşit
             * >  buyuktur
             */

            //Aritmatik İşlemler
            //Toplama
            int sayiBir = 34;
            int sayiIki = 56;
            int toplamBir = sayiBir + sayiIki;
            //cw+tab+tab
            //Console.WriteLine(toplamBir);


            //Çıkarma
            int eksicikarmaIslemi = sayiBir - sayiIki;
            int artiCikarmaIslemi = sayiIki - sayiBir;
            Console.WriteLine(artiCikarmaIslemi);

            //Bölme İşlemi
            int tamSayi = 100;
            int sayiTam = 6;
            int bolme = tamSayi / sayiTam;
            Console.WriteLine(bolme);

            double ondalikSayi = 100;
            double sayiOndalik = 6;
            double bolmeOndalik = ondalikSayi / sayiOndalik;
            Console.WriteLine(bolmeOndalik);

            //Çarpma İşlemi 
            int carpmaSayi = 14;
            int carpmaSayi2 = 15;
            int sonuc = carpmaSayi * carpmaSayi2;
            Console.WriteLine(sonuc);

            //mod alma işlemi 
            sayiBir = 67;
            sayiIki = 89;
            int kalan = sayiBir % sayiIki;
            Console.WriteLine("67 nin 89a bölümünden kalan =" + kalan);
            //Console da farklı yazım şekli dolar kullanımı
            Console.WriteLine($"67 nin 89a bölümünden kalan = {kalan}");

            int kalan2 = sayiIki % sayiBir;
            Console.WriteLine(kalan2);

            Console.ReadKey();

            //Ornek sayısal deger olarak toplama
            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir sayi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi + sayi2;
            Console.WriteLine(toplam);
            Console.ReadKey();

            //Ornek metinsel deger olarak toplama
            Console.WriteLine("Bir sayı giriniz");
            string deger1 = Console.ReadLine(); //45
            Console.WriteLine("Bir sayi giriniz");
            string deger2 = Console.ReadLine(); //64
            string toplami = deger1 + deger2;
            Console.WriteLine(toplami); //4564
            Console.WriteLine("string olarak toplam sonucu : " + toplami);
            Console.WriteLine(sayi + sayi2);

            Console.ReadKey();
        }
    }
}
