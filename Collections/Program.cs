using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "a", "b", "c", "d" };
            isimler = new string[5];
            isimler[0] = "f";
            
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); //nesne olustururken new dedigimiz anda heapta yeni bir adres oluşur
                                           //yeni adreste 0. indexe bir şey atamadıgımız için boş
                                           //genelde c# kullanırken array(dizi) yerine koleksiyonlar kullanırız
                                           //sınırı tanımlanan diziye eleman ekleyemezsiniz. aynı adla yeni dizi olsutrursanız. heap adresi farklı olur
            Console.WriteLine("-------------------");
            List<string> isimler2 = new List<string>() {"a", "b", "c", "d" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("e");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
