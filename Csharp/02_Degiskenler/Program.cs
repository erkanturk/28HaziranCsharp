namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programlama dilleri büyük küçük duyarlılığı vardır  Örneğin 'A' 'a' ya hiçbir zaman eşit olamaz.
            //Programlama dilinde kullanıcıdan gelen değerler daima metinseldir.
            string ad = "Erkan";//string metinsel değerleri belirten bir veri tipidir
                                //ad kısmı ise içine gelecek metinsel değeri taşıyacak bir yapıdır
                                //"" çift tırnak bizim metinsel değerimizi temsil eder metinsel değerlerde cift tırank kullanılır.
                                // string ad1 = Erkan; hatalı yazım biçimi 
            Console.WriteLine(ad);//Console.WritleLine Bizim konsol tarafına değerleri yazdırmak için kullandığımız yapı.
            char harf = 'A';//Char tek bir karakter alır örneğin Cinsiyet E K gibi değerleri barındırır.
            Console.WriteLine(harf);
            //Sayısal veri tipleri 
            //$ string interpolition {} süslü parantezler içerisinde csharp kodlarını tanımlamamızı sağlar.
            // Console.WriteLine("byte veri tipi {byte.MinValue}");
            Console.WriteLine($"byte veri tipi {byte.MinValue} max değeri:{byte.MaxValue}");
            //byte tam sayı tutan en küçük veri tipidir
            Console.WriteLine($"int veri tipi {int.MinValue} max değeri: {int.MaxValue}");
            //int tam sayı tipinde 10 haneye kadar veri tutan veri yapısıdır
            Console.WriteLine($"long veri tipi {long.MinValue} max değeri: {long.MaxValue}");
            //Long en büyük tam sayı tipidir.
            Console.WriteLine($"double veri tipi {double.MinValue} max değeri: {double.MaxValue}");
            //Ondalıklı sayılar için veri tipidir.
            Console.WriteLine($"decimal veri tipi {decimal.MinValue} max değeri: {decimal.MaxValue}");
            //Ondalıklı sayılar için veri tipidir.
            Console.WriteLine($"float veri tipi {float.MinValue} max değeri: {float.MaxValue}");
            //En küçük ondalıklı değer tutan veri tipidir.
            bool deger = true;//true veya false olarak mantıksal değerleri tutar.


            int sayi = 10;
            double sayi2 = 10.5;
            decimal sayi3 = 10.5m;
            float sayi4 = 10.5f;
            byte sayi5 = 10;



            var degisken = "merhaba";//Var gelen veriye göre şekillenen bir veri tipidir.
            var degisken2 = 10;
            var degisken3 = 10.5;

            object obje = 10;//Değerleri obje olarak tutar ve her yapıyı içerisinde barındırır.
            object obje2 = "merhaba";

            Console.WriteLine('A'+":"+(char)65);//Char karakterler ascii numaraya göre bize değerler gösterir char karakterler ile rakamsal işlem de yapıla bilir.
            Console.WriteLine('A'+":"+(int)'~');//bu alanda verdiğimiz karakterin ascii olarak karşılığını ekrana yazdırdık

        }
    }
}
