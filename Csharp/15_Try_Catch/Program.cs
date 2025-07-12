namespace _15_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Try-Catch (Dene-Yakala)
            **Hata ayıklama işlemi için kullanılır.
            ** Programın çalışması sırasında oluşabilecek hataları yakalayarak programın çökmesini engeller. 
            Kullanıcı veya sistem kaynaklı hataları yakalayarak programın akışını bozmadan devam etmesini sağlar.
            try
            {
                Çalışmasını istediğimiz kodları tanımlarız.
                Eğer bir hata alısak catch bloğu çalışır.
            }
            catch(Exception) tüm hataların genel yapısı
                eğer try kısmında bir hata oluşursa bu blok çalışır.

                            
            */
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Sayı: " + sayi);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Hata:"+e.Message);

            //}

            //Console.WriteLine("try catch tarafında program çalışmaya devam eder.");
            #region Try-Catch örneği
            //try
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2.Sayıyı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    double sonuc = sayi1 / sayi2;
            //    Console.WriteLine(sonuc);
            //}
            //catch (DivideByZeroException e)// Sıfıra bölme hatası
            //{
            //    Console.WriteLine("Hata: Bir sayı sıfıra bölünemez"+e.Message);
            //}
            //catch (FormatException e)//formata uygun olmayan giriş hatası
            //{
            //    Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz"+e.Message);
            //}
            //catch (OverflowException e)// Sayının çok büyük veya çok küçük olması durumunda oluşan hata
            //{
            //    Console.WriteLine("Hata: Girilen sayı çok büyük veya çok küçük"+e.Message);
            //}
            //catch (Exception e)// Diğer tüm hatalar için genel bir yakalama
            //{

            //    Console.WriteLine("Diğer tüm hatalar"+e.Message);
            //}
            #endregion
            #region Try-Catch-Finally örneği
            try
            {
                int sayi = 0;
                int sonuc = 10 / sayi;
                Console.WriteLine(sonuc);
                
            }
            catch (Exception)
            {

                Console.WriteLine("Hata");
            }
            finally//Finally bloğu her durumda çalışır, hata olsa da olmasa da 
            {
                Console.WriteLine("Her durumda çalışırım");
            }
            //Kod hata versede vermesede çalıştırmamız gereken bir kod varsa finally bloğu içinde yazılır.
            #endregion



        }
    }
}
