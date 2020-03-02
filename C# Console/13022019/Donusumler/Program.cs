using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dönüşümler
             * Convert Sınıfı=>Var olan değişkenimizin tipini değiştirmek için kullandığımız yapılardan ilkidir.
             * Uygun olan her tipi başka her tipe cevirebilir
             * Convert.ToInt32(deger)
             * Parse => Parse yapısı sadece string olan değişkenlerin tipinin diğer değişkenlere dönüştürülmesinde kullanılır.
             * int.Parse(deger) String degeri intger e çevirmeye çalışır.
             * Cast => Rica işlemidir. Eğer yapı o tip dönüştürülmeye uygun ise dönüştürme işlemi yapar.
             * (byte)deger
             * ToString() => Değişken tiplerini stringe cevirmek için kullanılır.
             * deger.ToString();
             * 
             */

            /*Dönüşümler Explicit ve İmplicit olabilirler
             * C#’ta bilinçli ve bilinçsiz olmak üzere iki tür veri dönüşümü söz konusudur.
             * Bilinçsiz olarak yapılan tür dönüşümü Implicit Conversion şeklinde tarif edilirken,
             * bilinçli dönüşüme ise Explicit Conversion diye nitelendirilmektedir.
             * Hatta biliyorsunuz ki, Implicit Conversion’da herhangi bir operatör yahut ek bir syntax kullanmazken,
             * Explicist Conversion’da “()” – Cast operatörü kullanılmaktadır.
             * 
             */

            //Implicit
            int int_sayi;
            byte sayi = 125;
            int_sayi = sayi;

            //Explicit
            int int_sayi2;
            long sayi1 = 125;
            int_sayi2 = (int)sayi1;

        }
    }
}
