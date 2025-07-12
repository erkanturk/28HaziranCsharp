namespace _06_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region scopesuz kullanım
            //if (true)//{Scope} olarak kullanılır 
            //    Console.WriteLine("Scopesuz if kullanımı");//if yapısı ile çalışan yapı




            //Console.WriteLine("Scope dışı");//if yapısından bağımsız yapı
            #endregion
            #region birden fazla if kullanımı
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı büyüktür 0 dan");
            //}
            //if (sayi < 0)
            //{
            //    Console.WriteLine("Sayı küçüktür sıfırdan");
            //}
            //if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı eşittir 0 a");
            //}
            //if (sayi != 0)
            //{
            //    Console.WriteLine("Sayı sıfıra eşit değil");
            //}
            #endregion

            #region iç içe if
            //string kullaniciAdi = "Erkan";
            //string password = "1453";

            //Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz");
            //string kad = Console.ReadLine();

            //if (kad == kullaniciAdi)
            //{
            //    Console.WriteLine("Lütfen parolanızı giriniz");
            //    string pass = Console.ReadLine();

            //    if (pass == password)
            //    {
            //        Console.WriteLine("Sisteme giriş başarılı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Parola hatalı ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}
            #endregion


            #region kullanıcı giriş
            //string kad = "erkan";
            //string pass = "1453";
            //Console.WriteLine("Kullanıcı Adınızı giriniz");
            //string kAdi = Console.ReadLine();
            //Console.WriteLine("Parolanızı giriniz");
            //string password = Console.ReadLine();

            //if ((kad == kAdi || kAdi == "e") && password == pass)
            //{
            //    Console.WriteLine("Sisteme giriş başarılı");
            //}
            //else
            //{
            //    if (kad != kAdi)//clean kod 
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalıdır");
            //    }
            //    if (pass != password)
            //    {
            //        Console.WriteLine("Parola hatalıdır.");
            //    }
            //    //if (kAdi != kad)//altarnatif örnek
            //    //{
            //    //    Console.WriteLine("Kullanıcı adı yanlıştır");
            //    //    if (pass != password)
            //    //    {
            //    //        Console.WriteLine("Parola hatalıdır");
            //    //    }

            //    //}
            //    //else if (pass != password)
            //    //{
            //    //    Console.WriteLine("Parola yanlıştır");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Hatalı işlem");
            //    //}


            //}
            #endregion
            //Kullanıcının girdiği sayı değerinin öncelikle 0 dan büyük olup olmadığını kontrol edin. Eğer sıfırdan büyükse
            //100 den büyük mü küçük mü olduğunu kontrol edin
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                if (sayi >= 100)
                {
                    if (sayi > 100)
                    {
                        Console.WriteLine("sayı büyüktür yüzden "+sayi);
                    }
                    else if (sayi < 100)
                    {
                        Console.WriteLine("sayı küçüktür 100den "+sayi);
                    }
                    else
                    {
                        Console.WriteLine("sayı 100 dür "+sayi);
                    }
                }
                else
                {
                    Console.WriteLine("Sayı 100 den küçük "+sayi);
                }
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı 0 dan küçüktür " + sayi);
            }
            else
            {
                Console.WriteLine("Sayı 0 a eşittir. " + sayi);
            }
        }
    }
}
