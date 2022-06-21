using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen fiyatı, %18 kdv ekleyerek kdvli fiyatını ekrana yazdıran
           
           


            double fiyat, kdvliFiyat;
            Console.WriteLine("Fiyat giriniz : ");
            fiyat = Convert.ToDouble(Console.ReadLine());

            kdvliFiyat = fiyat * 1.18;

            Console.WriteLine("Girdiğiniz ürünün kdv dahil fiyatı = " + kdvliFiyat);

            // Klavyeden kullanıcı tarafından dik kenarları girilen bir üçgenin alanını hesaplayan program.

            int alan, kenar1, kenar2;

            Console.WriteLine("Lütfen üçgenin dik kenarlarını giriniz");
            kenar1 = Convert.ToInt32(Console.ReadLine());
            kenar2 = Convert.ToInt32(Console.ReadLine());

            alan = kenar1 * kenar2 / 2;

            Console.WriteLine("Üçgenin alanı = " + alan);

            // Klavyeden kullanıcı tarafından TL cinsinden para miktarını, yine kullanıcı tarafından girilen Euro ve Dolar kuruna göreTL'nin kaç Euro ve kaç Dolar olduğunu bulan programı yazınız.

            double para, euro, dolar;
            Console.WriteLine("Tl olarak paranızı giriniz");
            para = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Euro kurunu giriniz");
            euro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dolar kurunu giriniz");
            dolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Girdiğiniz TL para biriminin euro karşılığı = " + (para / euro) + " dolar karşılığı = " + ( para / dolar));

            // Kullanıdan alınan değerleri 3. bir değişken kullanmadan değiştirip ilk ve son değerleri ekrana yazan program.

            double sayi1, sayi2;

            Console.WriteLine("Birinci sayıyı giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Birinci sayıyı giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            sayi1 = sayi1 + sayi2;
            sayi2 = sayi1 - sayi2;
            sayi1 = sayi1 - sayi2;

            Console.WriteLine("A: " + sayi2 + " B: " + sayi1 + " A : " + sayi1 + " B : " + sayi2);


            /* Console ekranının arkaplan rengi ve yazı rengini değiştirme için hangi kodlar kullanılmalıdır? 
             örnek kod ve açıklama yapınız.
            */



        }
    }
}
