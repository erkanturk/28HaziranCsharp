namespace _10_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayar tarafından rasgele sayi üretmesini istiyorum
            Random random = new Random();//Bir sınıftan nesne üretiyoruz (instace/örneklem)
            int rastgele = random.Next(0, 100);//hangi aralıklarda sayı üretmek istiyorsak bunu belirtmeliyiz Next'in içinde

            Console.WriteLine(rastgele);
        }
    }
}
