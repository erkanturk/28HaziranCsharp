namespace _03_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ekran çıktıları
            /*Ekrana çıktı alma yapıları*/
            //Console.WriteLine(20);
            //Console.WriteLine("Merhaba");
            //Console.WriteLine('A');
            //Console.WriteLine(true);
            //Console.WriteLine(20.5);
            //string text = "10";
            //string metin = "Merhaba";
            //int sayi = 10;
            //Console.WriteLine(text + metin);
            //Console.WriteLine(text + sayi);//metin değeri ile sayı + operatörü ile birleştirilir toplama işlemi yapmaz.
            #endregion

            //Operatörler
            #region Aritmatik Operatorler
            /*
                +,-,*,/,%
                 % Mod alma bir sayının bölümünden kalan değeri bize verir Örneğin 10 sayısının 3 e bölümünden kalan değer 1 dir.
            */
            //int sayi = 10;//değisken isimleri sadece bir defa tanımlanır bir değişken ismi verdiğimizde aynı isimde ikinci bir değişken oluşturmayız
            //double sayi2 = 3;
            //double sonuc = sayi / sayi2;
            //Console.WriteLine(sonuc);
            //int s1 = 10;
            //int s2 = 3;
            //int sonuc2 = s1 % s2;//Bir sayının bölümünden kalanı bize verir.
            //Console.WriteLine(sonuc2);
            #endregion

            #region atama ve işlemli atama operatörleri
            /*Atama Operatörleri
            = Atama operatörü sağdeğeri soldaki değişkene aktarır
            += artırma operatörü 
            -= azaltma operatörü
            *= Çarpma operatörü
            /= bölme operatörü
            .Erişim operatörü
            ++ 1 artırma
            -- 1 azaltma

            
            
            //*/
            //int s1 = 10;
            //int s2 = 20;
            //s2 += s1;//artırma işlemi
            //s2 *= s1;//bu alanda yaptığımız işlem var olan bir değeri değiştirme işlemi 
            //s2 /= s1;
            //s2 -= s1;

            //Console.WriteLine(s2);
            #endregion

            #region Karşılaştırma operatörleri
            /* karşılaştırma operatörleri true veya false olarak değer dönderirler.
            >
            <
            <=
            >=
            == eşit mi ?
            != eşit değil mi ?
            */
            //int sayi = 10;
            //int sayi2 = 5;
            //bool sonuc = sayi > sayi2;//T
            //bool sonuc2 = sayi < sayi2;//F
            //bool sonuc3 = sayi >= sayi2;//T
            //bool sonuc4 = sayi <= sayi2;//F
            //bool sonuc5 = sayi == sayi2;//F
            //bool sonuc6 = sayi != sayi2;//T

            ////Console.WriteLine("Sonuc: " + sonuc);//string yazım biçimi
            ////Console.WriteLine("Sonuc2 {0}", sonuc2);// index yazım biçimi
            //Console.WriteLine($"Sonuc3 {sonuc3}");//string interpolation
            ////Console.WriteLine("Sonuc4: " + sonuc4);
            ////Console.WriteLine("Sonuc5: " + sonuc5);
            ////Console.WriteLine("Sonuc6: " + sonuc6);
            ////Console.WriteLine("Sonuclar {0}-{1} ", sonuc, sonuc2);// 0 yapısı hangi değişkenin geleceğini bildirdiğimiz yer

            #endregion

            #region Mantıksal operatörler
            /* And (ve) && or (Veya) || 
            //Birden fazla koşul belirtilmesi durumunda koşulun kontrol edilmesi durumunda kullanılan yapıdır
            True 1 false 0
            Ve &&  matematik de çarpma işlemine benzer
            başlangıç bitiş sonuc
                0       1     0
                1       0     0
                0       0     0
                1       1     1

            Veya || matematik de toplama işlemine benzer
            başlangıç bitiş sonuc
                1       0     1
                0       1     1
                0       0     0
                1       1     1

            
            
            */
            //Console.WriteLine();//. erişim operatörü olarak kullanılır.
            #endregion

        }
    }
}
