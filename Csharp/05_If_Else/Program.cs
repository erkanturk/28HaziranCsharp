namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karar Yapısı (Conditions) if else,switch case  
            //If else blokları senkronize olarak çalışır bu yapıda bir if bir else bulunurken birden fazla else if yapısı bulunabilir
            //bu yapılardan sadece birtanesi çalışır ve geri kalan yapıyı kontrol etmez true sonucu bulduğu bloğun içindeki kodları çalıştırır.
            //bu yapılarda if yapısı olmazsa olmazdır else yada else if yapısı if olmadan çalışmaz.
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı Sıfırdan Büyüktür");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı sıfırdan küçüktür");
            }
            else
            {
                Console.WriteLine("Sayı sıfıra eşittir.");
            }
        }
    }
}
