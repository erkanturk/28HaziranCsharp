namespace _04_Turdonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Yazım biçimleri
                 SnakeCase=ad_soyad;
                 CamelCase=adSoyad;
                 KebabCase=ad-soyad;
                 UpperCase=ADSOYAD;
                 lowerCase=adsoyad;
                 Yazılım dillerinde ingilizce karakterler kullanılır türkçe karakterlerle tanımlama yapıldığında 
                 hataya sebebiyet verebilir.
            Kullanmamamız gereken karakterler
            ı,İ,ü,ö,ğ,ş,ç vb.
            2sayi, ?sayi,ad soyad, ad!soyad, adsoyad?
            Doğru tanımlar
            sayi,sayi2 ad_soyad,_soyad,sayi_
            */
            #region Kullanıcıdan değer alma
            //Console.WriteLine("Girmek istediğiniz sayıyı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());//Console.ReadLine() kullanıcının girdiği değeri tutan kısım 
            //Console.WriteLine("İkinci Bir sayı giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi + sayi2);//Sayi değeri ve sayı iki değerini topla ekrana yazdır.

            //Console.WriteLine("Adınızı giriniz");
            //string ad = Console.ReadLine();//Kullanıcının klavyeden girdiği değerleri tutar
            //Console.WriteLine("Soyadınız giriniz");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınızı giriniz");
            //int yas = Convert.ToInt32(Console.ReadLine());
            ////Convert.ToInt32 tür dönüşümünü sağlar kullanıcının girdiği tüm değerler metinsel olduğu için bu alanda
            ////Tür dönüşümü sağlamamız gerekir girilen metinsel tipi sayısal değere dönüştür deriz.
            //Console.WriteLine($"Adı {ad} Soyadı {soyad} Yaşı {yas}");
            #endregion

            //string metin = "10";
            //int sayi = 0;
            ////sayi = metin; metinsel bir değer sayısal bir tipe çevrilemez
            //sayi = Convert.ToInt32(metin);

            //Console.WriteLine(sayi);
            //Console.WriteLine(double.MaxValue + " double uzunluğu " + int.MaxValue);
            //double s1 = 50.5;
            //int s2 = (int)s1;//casting işlemi 

            //Console.WriteLine(s2);

            //char deger = 'A';

            //int s3 = (int)deger;//casting işlemi ile bu alandaki değeri matematiksel işleme tabi tutuyoruz.
            //int s4 = 5;

            //int sonuc = s3 + s4;
            //Console.WriteLine(s3 + s4);
            //char deger2 = Convert.ToChar(sonuc);//Tür dönüşümü

            //Console.WriteLine(deger2);

            //Console.WriteLine("Sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            ////Convert işlemi yapar varsayılan olarak ToInt32 değeri ile tür dönüşümü yapar.
            //Console.WriteLine("2.Sayıyı giriniz");
            //double sayi2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("3. sayıyı giriniz");
            //double sayi3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(sayi*sayi2*sayi3);

            //Kullanıcıdan 2 kardeşin yaşını alın ve iki kardeşin yaşının toplamını ekrana yazdırın.
            //Console.WriteLine("Birinci yaş değeri");
            //double yas = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("ikinci yaş değeri");
            //double yas2 = Convert.ToDouble(Console.ReadLine());
            //double sonuc = (yas + yas2) / 2.0;
            //Console.WriteLine("Ortalama değer: " + sonuc);
            //string ad;
            //Console.Write("adınızı");//Console.Write tek satırda işlem yapmak için kullanırız aynı satırda değerleri tutar.
            //ad = Console.ReadLine();

            /*DateTime*/
            DateTime zaman = DateTime.Now;// şimdiki zaman
            Console.Write(zaman);
            Console.Write(zaman.Year);//sadece yılını al
            Console.Write(zaman.Month);//sadece ayı alır
            Console.Write(zaman.Day);//günü alır
            Console.Write(zaman.Minute);//dakika
            Console.Write(zaman.Hour);//saat
            Console.Write(zaman.Second);//saniye

            /*
                cw + tab Console.WriteLine ı getirir.
                Ctrl+D imlecin olduğu satırı bir alt satıra kopyalar
                Ctrl+L bulunduğu satırı siler
                ctrl+k+c seçilen yeri yorum satırına çevirir
                ctrl+k+u    seçilen yeri yorum satırından çıkarır.
                Ctrl+z geri alma
                Shift + alt + yön tuşu birden fazla satır seçmemizi sağlar.
                Ctrl + k + d düzenleme
            
            */


        }
    }
}
