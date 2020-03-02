using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            //küçük bir ogrenci otomasyon sistemi yapınız.
            //program ogrenci sayisini alınması ile başlayacak 
            //ogrenci sayisini giriniz : 3 gibi
            //bu sistemde 4 adet giriş/çıkş menusu olsun aşagıdaki gibi bir sistem menu açılacak
            /*
             *  1. Öğrenci Ekle
                2. Not Girişi Yap
                3. Geçti Kaldı
                4. Programı Kapat
             */
            //1. Ogrenci eklede ile ögrencinin ismi ile ogrenciyi sisteme kayıt ediniz.
            /*
             * ogrencinin adini giriniz : mustafa
             * ogrencinin adini giriniz : ali
             * ogrencinin adini giriniz : veli
             */
            //2. kayıt olan ogrencilerin not girişi isme karşılık yapılılmalı.
            /*
             * mustafa : 50
             * ali : 75
             * veli :20
             * 
             * gibi
             * */
            //3. eger ogrenci notu 50 den buyuk ve eşitse geçti kucukse kaldı bilgisi isme karşılık gelmeli
            /*
             * mustafa geçti.
             * ali geçti.
             * veli kaldı.
             */
            //4. programı kapat seçenegi ile program sonlandırılmalı

            Console.WriteLine("Kaç adet ogrenci kaydı yapacaksin en fazla 20 ogrenci kaydı yapabilirisiniz.");
            int ogrenciSayisi;
            bool sayiMi = int.TryParse(Console.ReadLine(), out ogrenciSayisi); 
            string[] ogrenciler = new string[ogrenciSayisi];
            int[] notlar = new int[ogrenciSayisi];
            byte secim = 0;
            string answer = "";
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1. Öğrenci Ekle");
                        Console.WriteLine("2. Not Girişi Yap");
                        Console.WriteLine("3. Geçti Kaldı");
                        Console.WriteLine("4. Programı Kapat");
                        secim = byte.Parse(Console.ReadLine());

                        switch (secim)
                        {
                            case 1:
                                for (int i = 0; i < ogrenciSayisi; i++)
                                {
                                    Console.Write("Ogrenci adini giriniz : ");
                                    ogrenciler[i] = Console.ReadLine();
                                }
                                break;
                            case 2:
                                for (int i = 0; i < ogrenciSayisi; i++)
                                {
                                    Console.WriteLine(ogrenciler[i] + " : ");
                                    notlar[i] = int.Parse(Console.ReadLine());
                                }
                                break;
                            case 3:
                                for (int i = 0; i < ogrenciSayisi; i++)
                                {
                                    if (notlar[i] >= 50)
                                    {
                                        Console.WriteLine(ogrenciler[i] + " : " + "geçti");
                                    }
                                    else if (notlar[i] < 50)
                                    {
                                        Console.WriteLine(ogrenciler[i] + " : " + "kaldi");
                                    }

                                }
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("yanliş seçim!");
                                break;
                        }

               Console.WriteLine("Başka bir işlem yapmak istermisiniz ? E/H ");
               answer = Console.ReadLine();

            } while (answer == "E" || answer == "e");
            Console.WriteLine("Program Kapandi");
            Console.ReadKey();

        }
    }
}
