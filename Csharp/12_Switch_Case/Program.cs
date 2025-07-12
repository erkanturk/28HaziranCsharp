using System.Security.Cryptography.X509Certificates;

namespace _12_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch-Case (Koşul yapısı)
            /*
              Yapı 
            switch(Koşul değer)
            case:"Değer" yapılacak iş; Break;
            case:"Değer" yapılacak iş; Break;
            case:"Değer" yapılacak iş; Break;
            case:"Değer" yapılacak iş; Break;
            case:"Değer" yapılacak iş; Break;
            case:"Değer" yapılacak iş; Break;
            default:Geriye kalan tüm işlemler için;Break;
            switch kısmında değer kısmında kontrol edilecek değişken yazılır.
            case kısmında karşılama işlemleri gerçekleştirilir.
            break ise eşleşme gerçekleşmesi durumunda çalışacak bloğun çalışması sonucu koşul yapısını sonlandırır.
            default ise caselerden herhangi biri çalışmama durumunda varsayılan olarak geriye kalan tüm koşulları kapsayan yapıdır.
            */

            Console.WriteLine("Aradığız şehrin Adını giriniz Plakasını bulunuz");
            string sehir = Console.ReadLine();

            switch (sehir)    
            {
                case "istanbul": Console.WriteLine($"{sehir} plakası 34"); break;
                case "izmir": Console.WriteLine($"{sehir} plakası 35"); break;
                case "Ankara": Console.WriteLine($"{sehir} plakası 06"); break;
                case "Bursa": Console.WriteLine($"{sehir} plakası 16"); break;
                case "Adana": Console.WriteLine($"{sehir} plakası 01"); break;
                case "Hatay": Console.WriteLine($"{sehir} plakası 31"); break;
                case "Düzce": Console.WriteLine($"{sehir} plakası 81"); break;
                case "Amasya": Console.WriteLine($"{sehir} plakası 05"); break;
                default: Console.WriteLine("Aradığınız şehir bilgisine ulaşılamadı lütfen sonra tekrar deneyin"); break;

            }
           
        }
    }
}
