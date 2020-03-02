using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCesitleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exceptionlarin çok fazla çeşitleri vardır.daha fazla bilgi için kaynaga başvurun ==>
            //https://docs.microsoft.com/tr-tr/dotnet/api/system.exception?view=netframework-4.8
            try
            {
                Console.WriteLine("sayı girişi yapınız");
                decimal sayi = decimal.Parse(Console.ReadLine());
                Console.WriteLine("sayi girişi yap");
                decimal sayi2 = decimal.Parse(Console.ReadLine());
                decimal bolme = sayi / sayi2;
            }
            catch (FormatException ex)//format hatası
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("doğru formatta giriş yap");
            }
            catch (InvalidCastException ex)//tür donusumu hatası
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("cast edilemiyor");
            }
            catch (OverflowException ex)//taşma sınırı hatası
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)//0 a bolme hatası kontrolu
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
