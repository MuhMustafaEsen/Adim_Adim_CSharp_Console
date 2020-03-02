using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hatasız kod yazılmaz önemli olan hatayı yönetmektir.Doğru yönetilen hatalar projede ileride çıkabilicek sorunları önceden görmemizi sağlar.
            //Üç farklı hata tipi vardır
            //Syntax Hataları
            //Programcının kodu yazarken yanlış yazması durumunda aldığı hata tipidir.Yönetilmesi en kolay hatalardır. ErrorList ile yönetilir.
            //Derleme Hataları
            //Derleme hataları son kullanıcı tarafında yapılacak hatalardır. Örneğin kullanıcı adı gireceği textboxa integer deger girmesi gibi. 
            //Eğer yönetilmezlerse projeyi patlatırlar. Bu yüzden önemlidirler. her zaman son kullanıcıyı baltaya eş değer tutmalıyız. 
            //Derleme hatalarını try cath kullanarak yönetiriz.
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //Mantıksal Hatalar
            //Mantıksal hatalar en zor yönetilen hatalardır. Bize hatayı verecek yada gösterecek bir yapı yoktur 
            //çünkü bakıldığında kod doğru çalışyordur ancak istenilen çıktıyı basmıyorsur.
            //Bu gibi durumlarda yapılacak en doğru aksiyon breakpoint atmaktır. 
            //breakpoint ile kod çalıştığı şekilde adım adım incelenir ve hata nerede kolayca görülür.

            Console.WriteLine("----------------Hata Yönetimi Yok--------------");
            Console.WriteLine("numara girişi yapınız");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("Tebrikler doğru formatta no girdiniz");
            Console.ReadKey();

            Console.WriteLine("----------------Hata Yönetimli Sorgu--------------");
            try
            {   //seçili kodu try içerisine almak için ctrl+k+s yapılabilir.
                //giriş doğru yapıldığında çalışacak kodlar
                Console.WriteLine("numara girişi yapınız");
                int no1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Tebrikler doğru formatta no girdiniz");
            }
            catch (Exception)
            {
                //hatalı giriş yapıldığında çalışacak kodlar
                Console.WriteLine("lütfen doğru formatta veri girişi yapınız");
            }


            Console.WriteLine("----------------Detaylı Hata Yönetimli Sorgu--------------");
            try
            {
                Console.WriteLine("numara girişi yapınız");
                int no1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Tebrikler doğru formatta no girdiniz");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine("----------------Finally kullanarak Hata Yönetimli Sorgu--------------");

            try
            {
                Console.WriteLine("numara girişi yapınız");
                int no1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Tebrikler doğru formatta no girdiniz");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //hata var yada yok çalışacak kodlar
                Console.WriteLine("hata olup olmadığını bilmiyorum çalışıyorum");
            }

            Console.ReadKey();
        }
    }
}
