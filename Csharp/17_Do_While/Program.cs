namespace _17_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Do-While Loops 
             do-while yapısı koşul false olsa bile do tarafı işlemi bir defa gerçekleştirir eğer koşul false ise bu alandaki kod bir defa çalışmış olur
            koşul true ise çalışmaya devam eder.

            */
            #region do-while
            //int sayac = 1;
            //do
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            // while (sayac <= 10);

            //do
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //} while (sayac>=10);
            #endregion

            #region do-while örnek
            //do
            //{
            //  Console.WriteLine("Do while çalıştı");
            //} while (false);
            //string ad = "";
            //do
            //{
            //    Console.WriteLine("Adınızı giriniz");
            //    ad = Console.ReadLine();
            //} while (ad != "");

            //Kullanıcı 0 girene 
            //kadar girilen sayıları toplayarak devam etsin kullanıcı 0 a bastığında  döngü sonlansın ve toplam değeri söylesin

            //int sayi = 0;
            //int toplam = 0;

            //do
            //{
            //    Console.WriteLine("Lütfen sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    toplam += sayi;
            //}
            //while (sayi != 0);
            //Console.WriteLine(toplam);

            //Kullanıcının ilk girdiği değeri kontrol etme
            //int sayi = 0;
            //int toplam = 0;
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Lütfen sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        if (i == 0)
            //        {
            //            sayi++;
            //        }
            //    }
            //    i++;
            //    toplam += sayi;
            //}
            //while (sayi != 0);
            //Console.WriteLine(toplam);
            #endregion

            #region Do-while Tahmin
            //Random rnd = new Random();
            //int tutulanSayi = rnd.Next(1, 101);
            //int girilenSayi = 0;
            //int hak = 1;
            //do
            //{
            //    Console.WriteLine("{0}. Hakkınız.Lütfen Sayıyı Giriniz", hak);
            //    girilenSayi = Convert.ToInt32(Console.ReadLine());

            //    if (girilenSayi > tutulanSayi)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı giriniz");
            //    }
            //    else if (girilenSayi < tutulanSayi)
            //    {
            //        Console.WriteLine("Daha büyük sayı giriniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tebrikler doğru tahmin: " + tutulanSayi);
            //        break;
            //    }
            //    if (hak == 5)
            //    {
            //        Console.WriteLine("Hakkınız doldu. Aradığınız sayı: {0}", tutulanSayi);
            //        break;
            //    }
            //    hak++;
            //} while (girilenSayi != tutulanSayi && hak <= 5);

            #endregion

        }
    }
}
