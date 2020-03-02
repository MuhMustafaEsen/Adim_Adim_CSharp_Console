using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Adınızı soyadınızı giriniz.");
            string ad = Console.ReadLine();

            //Escape Sequences
            /*
             * kod ile kullanıcıya gosterilmek istenen verinin daha net ayrıştırılması ve yazılım
             * denetleyicisinin hataya düşmemesi için oluşturulmus kaçış sekanslarıdır.
             * \0	Null sonlandırma karakteridir.Genel olarak dosya veya veri kanalının bitişini belirtmek için kullanılır.
            \a	Bip sesini çıkartan karakterdir
            \b	BackSpace – Geri – Önceki karakteri silme
            \t	Tab
            \r	Satır başı (Carriage Return)
            \n	Bir alt satıra iner
            \v	Dikey Tab
            \f	Sayfa ilerleme
            \”	Çift tırnak
            \’	Tek tırnak
            \	Backslash
            */
            //ReadLine() => o satırda var olan veriyi okur veriyi kullanmak istersen onu bir değişkene atayın.
            Console.Write("Hoşgeldin " + ad + "\nÇıkmak istersen bir tuşa bas");
            Console.ReadKey();
        }
    }
}
