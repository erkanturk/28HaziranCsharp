namespace _08_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else örnek 1
            //Kullanıcıdan iki ürün fiyatı isteyin ürün fiyatlarının toplamları 2500 tl yi geçerse ucuz ürüne %25 indirim
            //uygulayan programı yazınız.

            //Console.WriteLine("Lütfen 1.Ürün Fiyatını giriniz.");
            //double f1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen 2.Ürünün Fiyatını giriniz");
            //double f2 = Convert.ToDouble(Console.ReadLine());
            //double toplam = f1 + f2;

            //if (toplam > 2500)
            //{
            //    if (f1 < f2)
            //    {
            //        f1 = f1 * 0.75;
            //    }
            //    else
            //    {
            //        f2 = f2 * 0.75;
            //    }
            //}
            //toplam = f1 + f2;
            //Console.WriteLine($"Ödenecek miktar: {toplam}");
            #endregion

            //Kullanıcıdan aylık geliri istenecek  eğer geliri 40000 üstünde ise %12 lik vergi kesilecek
            //40000 tl ve altında ise %9 vergi kesilecek  kullanıcıya yeni gelirini
            //bu hesaplamalar sonucunda göstereceğiz
            #region Örnek
            //Console.WriteLine("Lütfen maaşınızı giriniz");
            //double maas = Convert.ToDouble(Console.ReadLine());

            //if (maas > 40000)
            //{
            //    Console.WriteLine("%12 Vergi kesilmiş maaşınız: " + maas * 0.88);
            //}
            //else
            //{
            //    Console.WriteLine("%9 Vergi kesilmiş maaşınız:" + maas * 0.91);
            //}

            //Console.WriteLine("Maaşınızı giriniz");
            //double tutar = Convert.ToDouble(Console.ReadLine());

            //double vergi;
            //double yenitutar;
            //if (tutar > 40000)
            //{
            //    vergi = 0.12;
            //}
            //else
            //{
            //    vergi = 0.09;
            //}
            //double tax = tutar * vergi;
            //yenitutar = tutar - tax;
            //Console.WriteLine(yenitutar);
            #endregion

            /* Kullanıcıdan harcadığı tutar istenecek eğer kullanıcı 0 ila 1000 arası harcamışsa 0.35 
            1001-2500 0.38 üzerinden hesaplanacak
            2510-4000 0.41 üzerinden hesaplanacak
            4100-6000 0.42
            6000 ve üstü ise 1200 tl indirim yapılacak ve 0.43 üzerinden işlem yapılacak             
            */
            #region Örnek 4
            //Console.WriteLine("Harcama:");
            //double harcama = Convert.ToDouble(Console.ReadLine());

            //if (harcama > 0 && harcama < 1001)
            //{
            //    Console.WriteLine(harcama * 0.35);
            //}
            //else if (harcama > 1000 && harcama < 2510)
            //{
            //    Console.WriteLine(harcama * 0.38);
            //}
            //else if (harcama > 2500 && harcama < 4100)
            //{
            //    Console.WriteLine(harcama * 0.41);
            //}
            //else if (harcama > 4000 && harcama < 6001)
            //{
            //    Console.WriteLine(harcama * 0.42);
            //}
            //else
            //{
            //    Console.WriteLine((harcama * 0.43) - 1200);
            //}
            #endregion
            #region örnek 5
           // 1 - 100 arasındaki sayılar içinde 7 ye tam bölünenleri ekrana teker teker yazdırın.

        //    int sayi = 1;
        //don:
        //    if (sayi % 7 == 0)
        //    {
        //        Console.WriteLine(sayi);
        //    }
        //    sayi++;
        //    if (sayi <= 100)
        //    {
        //        goto don;
        //    }
            #endregion

            //kullanıcıdan isim , yaş, maaş ve çocuk sayısı istenecek 
            //eğer kullanıcı 45 yaşının altında ise çocuk sayısına bakılacak
            //ve çocuk sayısı 3'ten az ise çocuk başına 2500₺ 3'ten fazla ise çocuk başına 2000₺ maaş eklemesi yapılacak
            //45 in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak
            //Son olarak ekrana :Erkan Türk Maaşınız 40000₺ yazılacak.

            //Console.WriteLine("Adınız");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Yaşınız");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Maaşınız");
            //double maas = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Çocuk sayısı");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (yas > 0 && yas < 45)
            //{
            //    if (sayi > 3)
            //    {
            //        maas = maas + (sayi * 2000);
            //    }
            //    else
            //    {
            //        maas = maas + (sayi * 2500);
            //    }
            //}
            //else
            //{
            //    maas += 5000;
            //}//\n ifadesi enter yani bir alt satırdan devam et yazmaya demek .
            //Console.WriteLine($"Adınız:{ad} Yaşınız: {yas} Maaşınız: {maas}");
            //Console.WriteLine("**********************************************");
            //Console.WriteLine($"Adınız:{ad}\nYaşınız: {yas}\nMaaşınız: {maas}");

        }
    }
}
