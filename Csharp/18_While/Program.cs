namespace _18_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* While koşul true olduğu sürecede işlemi yapmaya devam eder 
            
            */
            #region While Ödev
            //Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            //Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.

            //* *Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin While
            // **kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.

            #endregion
            #region Örnek1 While
            //bool durum = true;
            //while (durum)//Sonsuz döngü 
            //{
            //    Console.WriteLine(durum);
            //    Console.WriteLine("Devam etmek istiyor musunuz");
            //    string cevap = Console.ReadLine().ToLower();//KULLANICININ GİRDİĞİ HER DEĞERİ KÜÇÜLTÜR.ToUpper() ise her karakteri büyültür.
            //    if (cevap == "e")
            //    {
            //        durum = true;
            //    }
            //    else if (cevap == "h")
            //    {
            //        durum = false;
            //    }
            //}
            #endregion
            #region While örnek 2
            //int counter = 0;
            //while (counter <= 10)
            //{
            //    counter++;
            //    if (counter == 5 || counter == 6)
            //    {

            //        continue;
            //    }
            //    if (counter == 8)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(counter);


            //}
            #endregion
            #region While örnek
            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Başlangıç değerini giriniz");
            //    int basla = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bitiş değerini giriniz");
            //    int bitis = Convert.ToInt32(Console.ReadLine());

            //    if (basla > bitis)
            //    {
            //        Console.WriteLine("Başlangış değeri bitiş değerinden küçük olmalıdır.");
            //        int deger = basla;
            //        basla = bitis;//basla=30 bitiş=20
            //        bitis = deger;//bitiş 20
            //    }
            //    for (int i = basla; i < bitis; i++)
            //    {
            //        if (i % 13 == 0)
            //        {
            //            sum += i;
            //        }
            //        //break; break hangi döngünün içinde ise o döngüyü sonlandırır. yani for  içinde olan bir break while döngüsünü kıramaz.
            //    }
            //    break;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Kullanıcı giriş ve bekletme While
            //string userName = "erkan";
            //string password = "1453";

            //int hak = 3;
            //while (hak > 0)
            //{
            //    Console.WriteLine("Kullanıcı adınızı giriniz");
            //    string kad = Console.ReadLine();
            //    Console.WriteLine("Şifreniz:");
            //    string pass = Console.ReadLine();
            //    hak--;
            //    if (kad == userName && pass == password)
            //    {
            //        Console.WriteLine("Sisteme giriş başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız kalmadı");
            //        Console.WriteLine("Sistem kitlendi");
            //        Thread.Sleep(5000);//sistemi bekletmek için bir zaman aşımı süresi belirtiriz milisaniye cinsinden 
            //        Console.WriteLine("Sistem açıldı.");
            //        Console.Clear();//Konsol yapısını temizle.
            //        hak = 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş başarısız");
            //        Console.WriteLine("Tekrar deneyiniz!!");
            //    }
            //}

            #endregion

            #region While örnek 5
            //int i = 200;
            //while (i > 0)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i--;
            //}
            //Console.WriteLine("---------*********-----------");
            //for (int j = 200; j > 0; j--)
            //{
            //    if (j % 3 == 0)
            //    {
            //        Console.WriteLine(j);
            //    }

            //}

            #endregion


        }
    }
}
