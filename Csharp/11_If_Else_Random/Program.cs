namespace _11_If_Else_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sansliSayi = random.Next(1, 20);
        basla:
            Console.WriteLine("Lütfen şanslı sayınızı giriniz");
            int kullaniciSayisi = Convert.ToInt32(Console.ReadLine());

            if (kullaniciSayisi == sansliSayi)
            {
                Console.WriteLine("Tebrikler Şanslınız " + sansliSayi);
            }
            else
            {
                Console.WriteLine("Lütfen Tekrar deneyiniz");
                goto basla;
            }
        }
    }
}
