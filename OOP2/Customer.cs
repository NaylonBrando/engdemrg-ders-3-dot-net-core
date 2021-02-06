using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer
    {
        //Classlarda özellik ve operasyon tutarız.
        //Özellik tututlan yerde operasyon tutulmamalı, operasyon tutulan yerde özellik tutulmamalı.
        //Özellik tutulan Classlar varlıktır.
        public int Id { get; set; }
        public string CustomerNo { get; set; } //Not: eğer veri sayısal işleme tabi tutmayacaksanız, string tutmak daha iyidir
                                               //Farklı sistemlerle veri uyumsuzluğu olmasın diye böyle tutarız!
                                               //Bir nesnede bir değeri kullanmak zorunda gibi görmüyorsam, o nesneye ait görmüyorsam soyutlama hatası yapmısız deriz.
        //public string TcNo { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string CompanyName { get; set; }
        //public string VergiNo { get; set; }

        //gerçek ve tüzel müşterileri birbirinin yerine kullanmamalıyız.
        //gidipte müsteritipi diye de özellik koymak da hatalıdır!
        //Bu dediklerimiz SOLID yazılım geliştirme prensiplerinden gelir


    }

}
