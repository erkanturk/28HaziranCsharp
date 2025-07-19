namespace _19_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Diziler(Array) string ifadeler aslında birer dizidir. Erkan =>içinde birden çok eleman taşır.
            Dizilerde birden çok yapıyı içinde barındıran collection(kolleksiyon) yapılarıdır.
            Dizileri tanımlarken eleman sayısını belirttiğimiz ve belirtmediğimiz durumlar vardır.(Uzunluğu mutlaka belli olmalıdır.)
            Dizi elemanları çağırılırken yada set(güncelleme) durumunda index numarasına göre işlem yapılır.
            !!!!İndexler her zaman '0' dan başlar!!!!!!
            Dizi tanımlama yapısı int[] dizi = new int[uzunluk] =>  new instance(örneklem/nesneleme)
            

             */
            #region Diziler
            //Boş bir dizi tanımlama
            //string[] isimler = new string[5];// 5 elemanlı bir dizi tanımladık

            //isimler[0] = "Erkan";//boş diziyi doldurma işlemi index değerini belirtip o indexe eleman atama işlemi yapıyoruz.
            //isimler[1] = "Ahmet";
            //isimler[2] = "Mehmet";
            //isimler[3] = "Ayşe";
            //isimler[4] = "Fatma";
            ////isimler[5] = "Fatma";//Hata verir:System.IndexOutOfRangeException: İndex aşımı hatası verir.
            ////Console.WriteLine(isimler);//bu şekilde bize dizinin elemanını getirmez bu bir dizidir der.
            ////Console.WriteLine(isimler[0]);//[0] index numarasını belirtir ve o indexteki elemanı getirir.
            //for (int i = 0; i < isimler.Length; i++)//isimler.Length dizinin uzunluğunu verir.
            //{
            //    Console.WriteLine(isimler[i]);//dizinin elemanlarını tek tek yazdırır.
            //}

            //string[] adlar = { "Ali", "Tahsin", "Onur", "Ebru", "Ceylan", "Erkan", "Kadir" };
            ////dolu dizi tanımlama

            //Console.WriteLine(adlar[4]);

            //int[] sayilar = new int[5];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[3] = 40;
            //sayilar[4] = 50;

            //Console.WriteLine(sayilar[3]);
            //int[] sayi = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine(sayi[i]);
            //}
            //Console.WriteLine("*****************************************");
            //int index = 0;
            //while (index < sayi.Length)//while döngüsü ile dizinin elemanlarını yazdırma
            //{
            //    Console.WriteLine(sayi[index]);
            //    index++;
            //}
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            //foreach (int sayidondur in sayi)// foreach döngü çeşididir bu yapı  bir collection yapısının içinde dolaşmak için kullanılır.
            //{
            //    Console.WriteLine(sayidondur);
            //}
            //Console.WriteLine("***************************");
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion

            #region Kullanıcıya kaç personeli olduğunu soralım
            //verilen cevapdan sonra her personelin adını sorup diziye ekleyelim
            //dizi tamamlandıktan sonra personel isimlerini ekrana yazdıralım
            //Console.WriteLine("Personel sayınızı giriniz");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());
            //string[] personel = new string[personelSayisi];
            //for (int i = 0; i < personel.Length; i++)//Boş diziye ekleme yapan döngü
            //{
            //    Console.WriteLine("Personel Adınız");
            //    string ad = Console.ReadLine();
            //    personel[i] = ad;//dizinin i indexine ad değerini atıyoruz.
            //}
            //Console.WriteLine("Personeller");//Dizinin elemanlarını yazdıran döngü
            //foreach (string p in personel)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
            #region Array
            ////int[] ints = { "A","B" };//Hata verir çünkü int[] dizisi sadece int değerleri alabilir.
            //object[] objects = { 20, 33.6, 'A', "Metin", DateTime.Now };//Her veri tipini alabilen bir dizi tanımladık.
            //foreach (object item in objects)//foreach döngüsü ile object dizisinin elemanlarını yazdırıyoruz.
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Array Metotları
            //*********Clear*********
            //string[] adlar = { "Erkan", "Ahmet", "Mehmet", "Ayşe", "Fatma" };
            ////Array.Clear(adlar);//Adlar dizisinin tüm elemanlarını temizler.
            //Array.Clear(adlar, 1, 2); //Adlar dizisinin 1. indexinden başlayarak 2 elemanı temizler.

            //foreach (var ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}

            //********Copy*********
            //string[] adlar = { "Erkan", "Ahmet", "Mehmet", "Ayşe", "Fatma" };

            //string[] adlar2 = new string[10];
            ////Array.Copy(adlar, adlar2, 3);//Var olan bir diziden başka bir diziye kopyalama işlemi yapar.
            //Array.Copy(adlar, 1, adlar2, 2, 3);//adlar dizisinin 1. indexinden başlayarak 3 elemanı adlar2 dizisinin 2. indexine kopyalar.
            //foreach (string ad in adlar2)
            //{
            //    Console.WriteLine(ad);
            //}
            //*********IndexOf*********
            // string[] adlar = { "Erkan", "Ahmet", "Mehmet", "Erkan", "Ayşe", "Fatma", "Erkan", "Ahmet" };
            //int index = Array.IndexOf(adlar, "Erkan");//indexOf
            //Console.WriteLine(index);//bize dizide bulduğu ilk elemanın index numarasını verir.
            //Console.WriteLine(adlar[index]);

            //int index2 = Array.LastIndexOf(adlar, "Erkan");//LastIndexOf sonda bulduğu elemanın index numarasını verir.
            //Console.WriteLine(index2);
            //Console.WriteLine(adlar[index2]);
            //int index3 = Array.IndexOf(adlar, "Erkan", 2);//Bakmasını istediğimiz index numarasından başlayarak arama yapar.
            //Console.WriteLine(index3);
            //************************
            //Yukarıdaki dizi  elemanlarından Erkan  olanların indexlerini ekrana yazdıran döngü
            //for (int i = 0; i < adlar.Length; i++)//Aradığımız value yani değerin indexini bulma
            //{
            //    int index = Array.IndexOf(adlar, "Erkan", i);//index değerine  adlar dizisindeki aradığım value nun index numarasını atıyoruz
            //    //i değeride her seferinde arttığı için indexdeki değerle i değeri eşit olarak artıyor ve koşula uyanları ekrana yazdırıyor.
            //    if (index == i)
            //    {
            //        Console.WriteLine(index);

            //    }
            //}
            //int i = 0;
            //while (i<adlar.Length)
            //{
            //    int index = Array.IndexOf(adlar, "Erkan", i);
            //    if (index == i)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //    index++;
            //}

            //*********Sort&&Reverse*********
            //string[] sehirler = { "Zonguldak", "İstanbul", "Ankara", "İzmir", "Bursa", "Adana", "Çanakkale" };
            //Array.Sort(sehirler);//Alfabetik olarak sıralar.
            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] sayi = { 100, 25, 99, 35, 44, 22, 10, 21, 15 };
            ////Array.Sort(sayi);Küçükten büyüğe sıralar.
            //Array.Reverse(sayi);//Dizinin elemanlarını tersine çevirir ve yazdırır eğer sort ile kullanırsak büyükten küçüğe sıralar.
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine(sayi[i]);
            //}
            //int[] sayi = new int[5];
            //sayi[0] = 10;
            //sayi[1] = 20;
            //sayi[2] = 30;
            //sayi[3] = 40;
            //sayi[4] = 50;
            ////sayi[5] = 60;//Hata verir çünkü dizinin boyutu 5 olarak tanımlandı ve index numarası 0'dan başladığı için 5. index numarası yoktur.
            //Array.Resize(ref sayi, 8);//Dizinin yeni boyutunu belirtiriz bu işlemde ref (referans) olarak dizinin kendisini gösteririz.
            ////sonrasında ise dizinin yeni boyutunu belirleyip yeni elemanlar ekleyebiliriz.
            //sayi[5] = 60;
            //foreach (int item in sayi)
            //{
            //    Console.WriteLine(item);
            //}

            //ref:Daha önce tanımlanmış bir değeri revize etmek için kullanılır.
            //out:Daha önce tanımlanmamış bir değeri null olan değişkene aktarmak için kullanılır.
            //Console.WriteLine("Bir sayı giriniz");
            //string sayi = Console.ReadLine();

            //int s;
            //int sayi2 = 20;
            //if (int.TryParse(sayi, out s))
            //{
            //    Console.WriteLine(s + sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Sayıya çevrilemedi: "+sayi);
            //}
            #endregion

            #region Array Örnek
            Console.WriteLine("Kelime giriniz:");
            string kelime = Console.ReadLine();
            char[] kelimeDizi = new char[kelime.Length];
            int i = 0;
            foreach (char harf in kelime)
            {
                kelimeDizi[i] = kelime[i];
                Array.Reverse(kelimeDizi);
                Console.WriteLine(harf);
                i++;
            }
            Console.WriteLine("****************");
            Array.Sort(kelimeDizi);
            Array.Reverse(kelimeDizi);
            foreach (var item in kelimeDizi)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("/*\\/*\\/*\\/");
            //for (int i = 0; i < kelimeDizi.Length; i++)
            //{

            //    //Array.Sort(kelimeDizi);

            //    //Console.WriteLine(kelime[i]);
            //    //Console.WriteLine("*/*/*/*/*/*/");
            //    Console.WriteLine(kelimeDizi[i]);
            //}

            #endregion
        }



    }
}
