using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Price = 15.5;
            urun1.Name = "Pringles";
            urun1.Info = "Pahalı Cips";

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Price = 15.5;
            urun2.Name = "Dr.Pepper Cola";
            urun2.Info = "Pahalı kola";

            Product[] products = new Product[] { urun1, urun2 }; //cok ilginc, yeni öğrendim bunu

            foreach (var yazdır in products)
            {
                Console.WriteLine(yazdır.Id);
                Console.WriteLine(yazdır.Name);
                Console.WriteLine(yazdır.Price);
                Console.WriteLine(yazdır.Info);
            }
            //İnstance, class örneği olusturup cagırmak
            BasketManager sepetManager = new BasketManager();
            sepetManager.Add(urun1); //altı kırmızı cizgili. yaptıgımız metod parametre istiyor, şimdilik parametre vermedik!
            sepetManager.Add(urun2);
            //sepetManager.Add(a); //buna syntax hatası verir cünkü parametre class türündnen alabilir
            Console.WriteLine("----------------------------------------");
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Ref ve out keywordü nedir 
            
            //REF
            
            //değer ve referans
            //atamalara tamamen değerin kendisi ile ilgilidir.
            int number1 = 20; //değer tipidir.
            int number2 = 100; // "    "
            var result = topla(number1, number2); //burda number1'in kendisi değilde değeri gider. number1 yerine 20 yazsakta olur 
            Console.WriteLine(number1);              //atamalr tamamen değerin kendisiyle ilgilidir.
            Console.WriteLine("Sonuç: {0}", result);
            static int topla(int number1, int number2) //isimleri aynı olsa bile alakaları yoktur
            {
                number1 = 30; //yandaki 30 üstteki number 1 i bağlamaz
                return number1 + number2;
            }

            //Peki ben metodun içinde number1 e değer ataması yapmak istiyorsam;
            //number 3 ü sadece değeriyle değilde, kendisiyle de göndermek istersem ref key ile gönderirim. Aynı isimle olan parametre sayesinde
            //refli değişkenin değeri parametre çalıştığında değişecektir.
            Console.WriteLine("////////////////////////////");
            int number3 = 20; //değer tipidir.
            int number4 = 100; // "    "
            var result2 = topla2(ref number3, number4); //burda number değilde değeri gider. number1 yerine 20 yazsakta olur 
            Console.WriteLine("Referans ile yeni Değer " + number3);
            Console.WriteLine("Refli Sonuç: {0}", result);
            static int topla2(ref int number3, int number4) //ben metodun içinde değiştirirken temelde tanımladıgımız değerdede değiştirilen kısım
            {
                number3 = 30;
                return number3 + number4;
            }

            //OUT

            //Ref keywordünün alternatifidir.
            //out'un ne farkı var: ref'te mutlaka başta değişkeni örn yukarıdaki number3 ü belirtirken değer atamamız gerekiyor
            //outta değer atamadan da kullanabiliriz
            Console.WriteLine("////////////////////////////");
            //int number5; //değer tipidir.
            //int number6 = 100; // "    "
            //var result3 = topla2(out number5, number6); //burda number değilde değeri gider. number1 yerine 20 yazsakta olur 
            //Console.WriteLine("Referans ile yeni Değer " + number3);
            //Console.WriteLine("Refli Sonuç: {0}", result);
            //static int topla3(out int number5, int number6) //ben metodun içinde değiştirirken temelde tanımladıgımız değerdede değiştirilen kısım
            //{
            //    number5 = 30;
            //    return number5 + number6;
            //}






        }
    }
}
