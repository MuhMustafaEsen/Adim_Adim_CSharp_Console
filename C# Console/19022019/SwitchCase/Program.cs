using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch Case 
            //İf ile farkı switch case sadece durumu inceler herhangi bir aralık incelemesi yapamaz.
            //Case'ler belirtilen durumların yönetilmesi için kullanılır

            //switch yapısını bir kitabın ısbn no'su olarak düşünebilirsiniz o numara durum olarak verilir ve switch doğrudan o durumun oluşturulduğu case'e gider.
            //Bu yapıyı ifte de kuruabiliriz ancak ifteki durum var olan tüm durumlar içerisinden arama yapmak olduğu için if kullanıldığında aklınıza raf bilgisi verildiği gelebilir  

            //Syntax (Kullanım Şekli)
            //switch (durum)
            //{
            //    case sonuc1:
            //        //bu durum gerçekleştiğinde çalışacak yapılar yazılır
            //        break;
            //    case sonuc2:
            //        //bu durum gerçekleştiğinde çalışacak yapılar yazılır
            //        break;
            //    case sonuc3:
            //        //bu durum gerçekleştiğinde çalışacak yapılar yazılır
            //        break;
            //    default:
            // Tüm durumlar geçersiz olduğunda yani hiç biri sağlanmadığı zaman çalışmasını istediğimiz kodları yazabiliriz.
            //        break;
            //}

            //Kullanıcıdan iki sayı ve bir işlem(+ - / * %) şeçeneği alınsın.Alınan sayıları seçilen işlemi uygulayıp sonucu basan kodu oluşturun
            /*
            Console.WriteLine("lütfen bir sayı giriniz");
            double sayiBir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lütfen bir sayı giriniz");
            double sayiIki = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lütfen bir işlem seçiniz (+,-,/,*,%)");
            string islem = Console.ReadLine();

            double sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = sayiBir + sayiIki;
                    break;
                case "-":
                    sonuc = sayiBir - sayiIki;
                    break;
                case "*":
                    sonuc = sayiBir * sayiIki;
                    break;
                case "/":
                    sonuc = sayiBir / sayiIki;
                    break;
                case "%":
                    sonuc = sayiBir % sayiIki;
                    break;


                default:
                    Console.WriteLine("öyle bir işlem yok");
                    break;
            }
            Console.WriteLine("Bu işlemin sonucu => " + sonuc);
            Console.ReadKey();
            */

            //Dışarıdan kaçıncı ay da olduğumuzu alıp o ayın hangi mevsimde olduğunu veren switch bloğunu oluşturun
            /*
            Console.WriteLine("Kaçıncı ayda olduğunuzu giriniz");
            int ay = int.Parse(Console.ReadLine());

            string mesaj;
            switch (ay)

            {
                case 1:
                case 12:
                case 2:
                    mesaj = "Kış";
                    break;
                case 3:
                case 4:
                case 5:
                    mesaj = "İlkbahar";
                    break;
                case 6:
                case 7:
                case 8:
                    mesaj = "Yaz";
                    break;
                case 9:
                case 10:
                case 11:
                    mesaj = "Sonbahar";
                    break;

                default:
                    mesaj = "Öyle bir ay yok";
                    break;
            }
            Console.WriteLine(mesaj);
            Console.ReadKey();
            */
            //kullanıcıdan ay değeri alınsın (kasım) bu degerin yılın kaçıncı ayı olduğu bilgisini versin (11)
            /*
            Console.WriteLine("Lütfen ayın ismini giriniz");
            string ay = Console.ReadLine().ToLower();
            string mesaj;
            switch (ay)
            {
                case "ocak":
                    mesaj = "1. ay";
                    break;
                case "subat":
                    mesaj = "2. ay";
                    break;
                case "mart":
                    mesaj = "3. ay";
                    break;
                case "nisan":
                    mesaj = "4. ay";
                    break;
                case "mayıs":
                    mesaj = "5. ay";
                    break;
                case "haziran":
                    mesaj = "6. ay";
                    break;
                case "temmuz":
                    mesaj = "7. ay";
                    break;
                case "ağustos":
                    mesaj = "8. ay";
                    break;
                case "eylül":
                    mesaj = "9. ay";
                    break;
                case "ekim":
                    mesaj = "10. ay";
                    break;
                case "kasım":
                    mesaj = "11. ay";
                    break;
                case "aralık":
                    mesaj = "12. ay";
                    break;
                default:
                    mesaj = "böyle bir ay yok";
                    break;
            }
            Console.WriteLine(mesaj);
            Console.ReadKey();
            */

            //giriş yapılacak baslik girilecek CEO Yonetici Başkan Mudur Moderator bu girişler yapıldığında yönetim paneline yönlendiriliriliyorsunuz çıktısı alınsın
            //uye girilirse anasayfaya yönlendiriliyorsunuz.Diğer girişlerde Bu sayfayı görmeye yetkiniz yok desin
            /*
            Console.WriteLine("Lütfen title giriniz");
            string title = Console.ReadLine().ToLower();

            string mesaj;
            switch (title)
            {
                case "ceo":
                case "yonetici":
                case "başkan":
                case "mudur":
                case "moderator":
                    mesaj = "Yönetim paneline yönlendiriliyorsunuz";
                    break;
                case "uye":
                    mesaj = "Ana sayfaya yonlendiriliyorsunuz";

                    break;

                default:
                    mesaj = "Bu sayfaya görmeye yetkiniz yok";
                    break;
            }
            Console.WriteLine(mesaj);
            Console.ReadKey();
            */
            //Bir işyerinde çalışanlar günü ve sabah mı akşam mı bilgisini girdiğinde o gün yapacakları iş karşılarına çıkmaktadır
            //ptesi sabah İŞKUR sabah grubu akşam işkur akşam grubu
            //salı sabah İŞKUR sabah grubu akşam bireysel akşam grubu
            //çarşamba sabah İŞKUR sabah grubu akşam kurumsal akşam grubu
            //perşembe sabah İŞKUR sabah grubu akşam işkur akşam grubu
            //cuma tatil
            //cumartesi sabah bireysel sabah grubu akşam bireysel akşam grubu
            //pazar sabah genç akademi sabah grubu akşam genç akademi akşam grubu

            /*
        Console.WriteLine("Lütfen günü giriniz");
        string gun = Console.ReadLine();
        Console.WriteLine("Çalışacağınız zamanı yazınız");
        string zaman = Console.ReadLine();
        string mesaj;
        switch (gun)
        {
            case "pazartesi":
                switch (zaman)
                {
                    case "sabah":
                        mesaj = "İşkur sabah";
                        break;
                    case "akşam":
                        mesaj = "işkur akşam";
                        break;

                    default:
                        mesaj = "günün o saati çalışmıyoruz";
                        break;
                }
                break;
            case "salı":
                switch (zaman)
                {
                    case "sabah":
                        mesaj = "işkur sabah";
                        break;
                    case "akşam":
                        mesaj = "işkur akşam";
                        break;

                    default:
                        mesaj = "günün o saati çalışmıyoruz";
                        break;
                }
                break;
            case "çarşamba":
                switch (zaman)
                {
                    case "sabah":
                        mesaj = "işkur sabah";
                        break;
                    case "akşam":
                        mesaj = "kurumsal akşam";
                        break;

                    default:
                        mesaj = "günün o saati çalışmıyoruz";
                        break;
                }
                break;
            case "perşembe":
                switch (zaman)
                {
                    case "sabah":
                        mesaj = "işkur sabah";
                        break;
                    case "akşam":
                        mesaj = "işkur akşam";
                        break;

                    default:
                        mesaj = "günün o saati çalışmıyoruz";
                        break;
                }
                break;
            case "cuma":
                mesaj = "tatil";
                break;
            case "cumartesi":
                switch (zaman)
                {
                    case "sabah":
                        mesaj = "bireysel sabah";
                        break;
                    case "akşam":
                        mesaj = "bireysel akşam";
                        break;

                    default:
                        mesaj = "günün o saati çalışmıyoruz";
                        break;
                }
                break;
            case "pazar":
                switch (zaman)
                {
                    case "sabah":
                        mesaj = "genç akademi sabah";
                        break;
                    case "akşam":
                        mesaj = "genç akademi akşam";

                        break;

                    default:
                        mesaj = "günün o saati çalışmıyoruz";
                        break;
                }
                break;

            default:
                mesaj = "öyle bir gün yok";
                break;
        }
        Console.WriteLine(mesaj);
        Console.ReadKey();
        */

            //iç içe switch kullanarak kullanıcı adı = admin şifre 123 olma durumunu kontrol ediniz.Şifre ve kullanıcı adı için hataları ayrı alınız.
            
            /*
            Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
            string kAdi = Console.ReadLine();
            Console.WriteLine("Lütfen şifre giriniz");
            string sifre = Console.ReadLine();
            string mesaj;
            switch (kAdi)
            {
                case "admin":
                    switch (sifre)
                    {
                        case "123":
                            mesaj = "Giriş yapıldı";
                            break;
                        default:
                            mesaj = "Lütfen şifreyi doğru giriniz";
                            break;
                    }
                    break;
                default:
                    mesaj = "Kullanıcı adını yanlış girdiniz";
                    break;
            }
            Console.WriteLine(mesaj);
            Console.ReadKey();
            */
            
        }
    }
}
