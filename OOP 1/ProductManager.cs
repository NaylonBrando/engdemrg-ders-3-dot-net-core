using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class ProductManager
    {
        //bu şekilde isim gördüyseniz, anlayınki CRUD yapacagımız yerdir
        //operasyonlar içerir

        //encapsulation.
        //bin tane parametre ekleyip, sonra Product class'ının özelliklerine eşittir
        //demek yerine direkt Product'un parametre olarak kullandık.
        public void Add(Product product) //parametre olarak Product özellikleridir
        {                                //sen bana product sınıfından nesne yolla 
            Console.WriteLine(product.ProductName + " ürün eklendi!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " ürün güncellendi!");
        }
    }
}
