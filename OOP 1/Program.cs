using System;

namespace OOP_1
{
    class Program
    {
        //classları ikiye arıyabiliriz
        //1 özellik barındılaranlar
        //metod barındıranlar
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 1, CategoryId=2, 
                ProductName ="Koltuk", UnitInStock = 2, UnitPrice = 750};
            //bu işi öğrenmeye çalıştıgımız için manuel yazıyoruz

            //case sensitive : kücük büyük harf duyarlıgı
            //PascalCase   //CamelCase  //İsimlendirmelere dikkat edin!
            ProductManager productManager = new ProductManager();
            //stack                         //heap --- heapte bir adresi var
            //referans tipleri olusturabilmek için, heap için olusturmak için newlemek gerekiyor
            //productManager yeni refrans numarası almıs ProductManager'dir'
            productManager.Add(product1);
            


        }
        
    }
}
