using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilecek öğrenci adedi:
            //1
            //Lütfen öğrencinin adını giriniz:
            //Mustafa
            //Lütfen Matematik ders notunuzu giriniz:
            //5
            //Lütfen Türkçe ders notunuzu giriniz:
            //            5
            //Lütfen Kimya ders notunuzu giriniz:
            //            5
            //Lütfen Tarih ders notunuzu giriniz:
            //            5
            //Lütfen İngilizce ders notunuzu giriniz:
            //5
            //------------------------------------ -

            //Sıra / ÖğrAdi   / Mat   / Tr  / Kimya  / Fizik   / Bio
            //------------------------------------ -

            //1     Mustafa     5       5       5       5       5
            //------------------------------------ -

            //yukarıda goruldugu gibi ogrenci adedine gore ogrencilerin ders notlarının girildigi ve tablo şeklinde 
            //gosterildigi gibi yazınız.
            Console.WriteLine("Kayit olacak ogrenci sayisi : ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());
            string[,] bilgiler = new string[ogrenciSayisi,6];
            int sayac = 0;
            while (sayac < ogrenciSayisi)
            {
                for (int i = 0; i < 6; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Ogrencinin Adini Giriniz : ");
                            bilgiler[sayac, i] = Console.ReadLine();
                            break;
                        case 1:
                            Console.WriteLine("Matematik Notu : ");
                            bilgiler[sayac, i] = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Turkce Notu : ");
                            bilgiler[sayac, i] = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Kimya Notu : ");
                            bilgiler[sayac, i] = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Fizik Notu : ");
                            bilgiler[sayac, i] = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Biyoloji Notu : ");
                            bilgiler[sayac, i] = Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                   
                }
                sayac++;
            }
            Console.WriteLine("Sıra " + " / " +  " ÖğrAdi " +  " / "  + " Mat "  +  " / " + " Tr " + " / " + " Kimya " + " / "+ " Fizik " +  " / "+ " Bio ");
            
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write(i + ". : ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(bilgiler[i,j]);
                    Console.Write("  /  " + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Kişiler başarı ile kayit olmustur.");
            Console.ReadKey();
        }
    }
}
