using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan yaş bilgisini alınız(su yaştaki öğrencimizin kayıdı oluşturulmuştur) şeklinde ekranda gösteriniz. 
            Console.WriteLine("Lütfen yaşınızı giriniz.");
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine(yas + " yaşındaki öğrencimizin kaydı oluşturulmuştur");
            Console.ReadKey();
        }
    }
}
