using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Product
    {
        //entity --- varlık
        //intellisensede prop yazarken önerilenler kısmında sol tarafta cıkan kutucuk
        //snippet'tir. Bu hazır kodlar demektir.
        public int Id { get; set; } //primary key
        public int CategoryId { get; set; } //foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //CRUD, Eklemek, güncellemek, sistelemek gibi işlemlere denir.
        //Otomasyon projelerinde veritabanı programlama yaparız.

    }
}
