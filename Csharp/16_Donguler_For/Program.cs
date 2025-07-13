namespace _16_Donguler_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Döngüler (Loops) => Tekrar eden yapılar
            //Döngüler belli bir işi tekrar tekrar yaptırmak için veya  dizi yapısı yada collection yapısı gibi 
            içinde birden fazla eleman barındıran  yapıların içinde gezmek için kullandığımız bloklardır.
            =>For Döngüsü => While döngüsü => Do-While döngüsü => Foreach döngüsü
            
            */
            #region for örneği
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");

            // for(veri tipi değişken adı ; koşul;artış azalış)
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Erkan");
            //}
            //for (int i = 5; i >= 0; i--)// koşul tarafı false olduğunda döngü biter.
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region kullanıcıdan alınan bir saynının faktöriyelini hesaplama
            //5 =>1*2*3*4*5 = 120

            //Console.WriteLine("faktoriyel hesaplanacak sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int fak = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    fak *= i;
            //}
            //Console.WriteLine("Faktoriyel: " + fak);
            //Console.WriteLine("Faktoriyel: {0}", fak);
            //Console.WriteLine($"Faktoriyel: {fak}");
            #endregion
            #region Carpim Tablosu
            //for (int i = 1; i < 11; i++)// dıştaki döngü daima son biten kısımdır. bu alandaki kısım false olduğunda döngü biter.
            //{
            //    for (int j = 1; j < 10; j++)//içteki döngü daima ilk biten kısımdır.
            //    {
            //        Console.WriteLine($"{j} * {i} = {i * j}\t");// \t tab boşluk bırakır    
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= 10; i += 2)// istediğimiz değer artışıyla sayıyı artırma yöntemi.
            //{
            //    Console.WriteLine(i);
            ////}
            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 0; i < 10;)//Sonsuz döngü i ++ yok
            //{
            //    Console.WriteLine(i);

            //}
            //for (; ; )//Sonsuz döngü
            //{
            //    Console.WriteLine("test");
            //}
            // break ve continue kullanımı;
            //break kırmak scope dışına çıkmak için kullanılır.
            //Continue ise döngüdeki bir sonraki adıma geçmek için kullanılır.
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        Console.WriteLine("Sayı 5 e ulaştı: " + i);
            //        continue;
            //    }
            //    if (i == 7)
            //    {
            //        Console.WriteLine("Sayı 7 ye ulaştı döngü sonlandı: " + i);
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Döngü sonlandı");

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine("7 ye tam bölünen sayı");
            //        break;//belli bir koşul sağlandığında döngüden çıkmasını istiyorsak eğer bu alanda break kullanmalıyız.
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion
            //int a = 5;
            //int b = ++a;
            //int c = a++;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(a);

            //int tekToplam = 0;
            //int ciftToplam = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam += i;
            //    }
            //    else
            //    {
            //        tekToplam += i;
            //    }
            //}
            //Console.WriteLine("Tek toplam: " + tekToplam);
            //Console.WriteLine("Çift toplam: "+ciftToplam);

            //char metin = 'z';
            //for (char i = 'A'; i <= metin; i++)//Ascii table da rakamsal karşılıkları bulunduğu için char karakterler döngüde koşul olarak kullanılabilir.
            //{
            //    Console.WriteLine(i);
            //}

            //for (string i = "A"; i < 10; i++) döngülerde metinsel bir değerle karşılaştırma yapılamaz bu yapıda rakamsal değer taşıyan veri tipi olmalıdır.
            //{

            //}

            //100 ila 1 arasında 3 e tam bölünen sayıları ekrana yazdıran döngüyü yazınız 100 den başlayarak 1 e kadar gelecek ve 
            //3 ün katları ekrana yazılacak.

            //int toplam = 0;
            //for (int i = 100; i >= 1; i--)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);
        }
    }
}
