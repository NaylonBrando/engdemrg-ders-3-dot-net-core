using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;


            //değer tipleri: int, decimal, flood, double, bool(0,1 tutar)...
            //sayılsal görüntüler.
            
            //referans tip: array, class, interface

            //bellekte stack ve heap bölümleri var
            //değer tipleri stackte gerçekleşir. sayi1=10 dediğinde orada gerceklesir
            //sayi1 in değeri 10 diye okuruz
            //sayi1 in değeri sayi2nin değeridir. sayi2'nin kendisiyle alakası yokk
            //sadece değeriyle alakası var

            //peki referans tipler
            //new demek belleğin heap bölümünde bir adres(refrans no) oluştur
            //örneğin 17 ve 18. satıda sayilar1'in referans nosu 101, sayılar2nin 102
            //sayılar1'in referans numarası sayılar2'nin referans numarasına eşittir
            //sayilar1'in yeni referans nosu 102
            //c gibi dillerde pointer olarak karsımıza cıkar
            //peki 101. adrese ne oldu. - silindi!

        }
    }
}
