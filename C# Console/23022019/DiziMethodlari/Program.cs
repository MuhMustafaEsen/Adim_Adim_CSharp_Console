using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziMethodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Metotları
            //lenght()
            //dizide kaç eleman olduğunu basar
            char[] harf = { 'h', 'k', 'l', 'a', 'e', 'ı' };
            int uzunluk = harf.Length;
            Console.WriteLine(uzunluk);
            Console.ReadKey();
           
            //dizinin son elemanı veren kod
            string[] arabalar = { "mercedes", "audi", "tofaş", "toyata " };
            int elemanSayi = arabalar.Length;
            Console.WriteLine(arabalar[elemanSayi - 1]);
            Console.WriteLine(arabalar[arabalar.Length - 1]);
            Console.ReadKey();
            
            //bir 1-20 arası çift sayılar dizisi oluşturup diziden rastgele bir elemanı basın.
            Random rnd = new Random();
            int[] ciftSayilar = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            Console.WriteLine(ciftSayilar[rnd.Next(0, ciftSayilar.Length - 1)]);
            Console.ReadKey();

            //clear()
            //diziden eleman silmemizi sağlar
            //Array.Clear(diziAdi,başlangıçİndexi,kacElemanSilecek)
            string[] gunler = { "ptesi", "salı", "çarşamba", "perşembe", "cuma ", "cumartesi", "pazar" };
            Array.Clear(gunler, 2, 3);
            Console.WriteLine(gunler[0]);
            Console.WriteLine(gunler[1]);
            Console.WriteLine(gunler[2]);
            Console.WriteLine(gunler[3]);
            Console.WriteLine(gunler[4]);
            Console.WriteLine(gunler[5]);
            Console.WriteLine(gunler[6]);
            Console.ReadKey();

            //clone()
            //kopyasını başka bir diziye aktarır olusturur
            string[] gunler1 = { "ptesi", "salı", "çarşamba", "perşembe", "cuma ", "cumartesi", "pazar" };
            string[] cloneGunler = new string[7];
            cloneGunler = (string[])gunler1.Clone();

            for (int i = 0; i < cloneGunler.Length; i++)
            {
                Console.WriteLine(cloneGunler[i]);
            }
            Console.ReadKey();

            //sort()
            //sıralama yapar küçükten büyüğe ya da a dan z ye
            string[] gunler2 = { "ptesi", "salı", "çarşamba", "perşembe", "cuma ", "cumartesi", "pazar" };
            Array.Sort(gunler2);
            for (int i = gunler.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(gunler2[i]);
            }
            Console.ReadKey();

            ////reverse
            ////diziyi tersine cevirir

            string[] gunler3 = { "ptesi", "salı", "çarşamba", "perşembe", "cuma ", "cumartesi", "pazar" };
            Array.Sort(gunler3);
            Array.Reverse(gunler3);
            for (int i = 0; i < gunler3.Length; i++)
            {
                Console.WriteLine(gunler3[i]);
            }
            Console.ReadKey();

            //Resize
            //dizinin eleman sayısını arttırmak istediğinde kullanırsın
            string[] mevsimler = { "ilkbahar", "yaz", "sonbahar", "kış" };
            Array.Resize(ref mevsimler, 5);
            mevsimler[4] = "sdasfsa";
            for (int i = 0; i < mevsimler.Length; i++)
            {
                Console.WriteLine(mevsimler[i]);
            }
            Console.ReadKey();

            //IndexOf
            //Dizinin elemanının kaçıncı indexe sahip olduğunu verir eğer o eleman dizinin içerisinde yoksa -1 döner.

            int[] tekSayilar = { 1,3,5,7,9,11,13,15,17,19 };
            int index = Array.IndexOf(tekSayilar, 10);
            Console.WriteLine(index);
            Console.ReadKey();

            //kullanıcıdan haftanın günü alınsın çıktı olarak haftanın kaçıncı günü olduğu basılsın 

            Console.WriteLine("Lütfen gün degeri giriniz");
            string gun = Console.ReadLine();
            string[] gunler4 = { "", "ptesi", "salı", "carşamba", "perşembe", "cuma" };
            int indexim = Array.IndexOf(gunler4, gun);
            if (indexim == -1)
            {
                Console.WriteLine("öyle bir gün yok");
            }
            else
            {
                Console.WriteLine($"haftanın {indexim}. günü");
            }
            Console.ReadKey();

            //bir dizi oluşturun bu dizide ik, arge, ıt, finans gibi iş bölümleri bulunsun kullanıcı bu iş bölümlerin birini sectiğinde index numarasına göre her seçimin kendi iş tanımı basılsın
            /*
            string[] isler = { "ik", "arge", "it", "finans" };
            Console.WriteLine("lütfen bağlı olduğunuz birimi yazın");
            string birim = Console.ReadLine();
            int index = Array.IndexOf(isler, birim);
            string mesaj;
            if (index == 0)
            {
                mesaj = "işe adam alır";
            }
            else if (index == 1)
            {
                mesaj = "geliştirir";
            }
            else if (index == 2)
            {
                mesaj = "sistem sorunlarıyla ilgilenir";
            }
            else if (index == 3)
            {
                mesaj = "parayla oynar";
            }
            else
            {
                mesaj = "öyle bir birim yok";
            }
            Console.WriteLine(mesaj);
            Console.ReadKey();
            */
        }
    }
}
