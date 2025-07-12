namespace _07_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region if else
        //kullanıcının girdiği değer tek mi çift mi kontrolü 
        //Console.WriteLine("Sayı giriniz");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //if (sayi % 2 == 0)
        //{
        //    Console.WriteLine("Sayı çifttir. sayınız: " + sayi);
        //}
        //else
        //{
        //    Console.WriteLine("Sayınız tektir.");
        //}

        //Kullanıcıya bir soru yöneltelim haftanın hangi günü olarak kullanıcı 1 değeri girerse pazartesi desin
        //eğer kullanıcı 1 den küçük 7 den büyük bir değer girerse uyarı versin 1 ila 7 arasında değer giriniz diye.

        //basla://verdiğim değerdeki yapı 23. satıra konuşlansın  eğer bir hata durumunda bu satıra yönlen
        //Console.WriteLine("Haftanın hangi günü");
        //int gun = Convert.ToInt32(Console.ReadLine());
        //if (gun < 1 || gun > 7)
        //{
        //    Console.WriteLine("Lütfen 1 ila 7 arasında bir değer giriniz");
        //    goto basla;
        //}
        //else if (gun == 1)
        //{
        //    Console.WriteLine("Pazartesi");
        //}
        //else if (gun == 2)
        //{
        //    Console.WriteLine("Salı");
        //}
        //else if (gun == 3)
        //{
        //    Console.WriteLine("Çarşamba");
        //}
        //else if (gun == 4)
        //{
        //    Console.WriteLine("Perşembe");
        //}
        //else if (gun == 5)
        //{
        //    Console.WriteLine("Cuma Mübarek gün camiye git");
        //}
        //else if (gun == 6)
        //{
        //    Console.WriteLine("Cumartesi");
        //}
        //else
        //{
        //    Console.WriteLine("Pazar");
        //}
        #endregion

        //kullanıcıdan değer alacağız kullanıcının girdiği değer pozitifse sayı değerini göstereceğiz
        //Eğer 0 ise tekrardan kullanıcıya soru soracağız bir sayı girin diye
        //negatif durumda ise kullanıcıya negatif değeri göstereceğiz
            don:
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                Console.WriteLine($"Girdiğiniz sayı Pozitiftir sayınız: {sayi}");
            }
            else if (sayi == 0)
            {
                goto don;//döngülerden sonra kullanılmayacak.
            }
            else
            {
                Console.WriteLine($"Girilen sayı Negatiftir sayınız: {sayi}");
            }
            //https://www.w3schools.com/cs/index.php pratik için
        }
    }
}
