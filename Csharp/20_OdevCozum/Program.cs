namespace _20_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Emekli Odev
            /*
           kullanıcıdan alınan cinsiyet bilgisine göre
        ==> ERKEK ise
           yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
          ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
          6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
            yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
          yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
          maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 
          altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */
            //try
            //{
            //    Console.WriteLine("Cinsiyet:");
            //    string cinsiyet = Console.ReadLine().ToLower();
            //    switch (cinsiyet)
            //    {
            //        case "erkek":
            //            Console.WriteLine("Yaş:");
            //            int yas = Convert.ToInt32(Console.ReadLine());
            //            if (yas > 59)
            //            {
            //                Console.WriteLine("Maas:");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 10));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim Gün Sayısı:");
            //                int gunSayisi = Convert.ToInt32(Console.ReadLine());
            //                if (gunSayisi >= 6000)
            //                {
            //                    Console.WriteLine("Maas:");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik hayal çalışmaya devam");
            //                }

            //            }
            //            break;
            //        case "kadın":
            //            Console.WriteLine("Yaş:");
            //            int yKadin = Convert.ToInt32(Console.ReadLine());
            //            if (yKadin > 57)
            //            {
            //                Console.WriteLine("Maaş:");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 10));

            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim Gün Sayısı:");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim >= 5600)
            //                {
            //                    Console.WriteLine("Maaş:");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik hayal çalışmaya devam");
            //                }
            //            }
            //            break;
            //        default: Console.WriteLine("Hatalı işlem"); break;

            //    }
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hatal işlem");
            //}
            #endregion

            #region While Ödev
            int sayac = 0;
            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0 && sayac == 0)
                {
                    Console.WriteLine("İlk değer 0 girilemez lütfen bir değer giriniz");
                    continue;
                }
                if (sayi == 0)
                {
                    break;
                }
                if (sayi < 0)
                {
                    Console.WriteLine("Lütfen Pozitif sayı giriniz");
                    continue;
                }
                toplam += sayi;
                sayac++;

            }
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Ortalama: " + (toplam / sayac));
            Console.WriteLine("Sayaç toplamı:"+sayac);
            #endregion
        }
    }
}
