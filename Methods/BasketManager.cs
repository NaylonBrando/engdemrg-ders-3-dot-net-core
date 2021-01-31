using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //menager görürsesiniz operasyon tutuyor.
        //naming convention
        //parantez görürseniz metod görürsünüz.
        public void Add(Product add) //class olarak değişken tanımladıgımız için burada galiba classın özelliklerini cekiyoruz
        {
            Console.WriteLine("Sepete Eklendi!");
            Console.WriteLine("Eklenen Ürün:" + add.Name);

        }
        //Peki parametre olarak neden class kullandık?
        //onun yyerine string urun adı, açıklama, fiyat vs parametre almadık
        //yarın öbür gün yeni parametre eklersek patlamasın die
        //buna encapsulation denir
    }
}
