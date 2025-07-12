namespace _13_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Goto case örneği
            //string islemYap = "Satış Yap";

            //switch (islemYap)
            //{
            //    case "Stok Eksilt":
            //        Console.WriteLine("Stok eksiltme işlemi başarılı");
            //        break;
            //    case "Urün Ekle":
            //        Console.WriteLine("Ürün ekleme işlemi başarılı");
            //        break;
            //    case "Satış Yap":
            //        Console.WriteLine("Satış işlemi başarılı");
            //        goto case "Stok Eksilt";
            //    default:
            //        Console.WriteLine("Hatalı işlem");
            //        break;
            //}
            #endregion


            Console.WriteLine("1.Sayı");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapacağınız işlem");
            string islem = Console.ReadLine();

            switch (islem)
            {
                case "+":
                    Console.WriteLine($"Sonuc: {sayi1 + sayi2}");
                    break;
                case "-": Console.WriteLine($"Sonuc: {sayi1 - sayi2}");
                    break;
                case "*": Console.WriteLine($"Sonuc: {sayi1 * sayi2}");
                    break;
                case "/":
                    if (sayi2 != 0)
                    {
                        Console.WriteLine($"Sonuc: {sayi1 / sayi2}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Bir sayı sıfıra bölünemez");
                    }
                    break;
                case "%":
                    Console.WriteLine($"Sayının modu {sayi1 % sayi2}");
                    break;
                default: Console.WriteLine("Hatalı işlem"); break;


            }

        }
    }
}
