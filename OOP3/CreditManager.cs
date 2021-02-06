using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager //Okunurlugu arttırmak için interface isimlerinin basına I konulur.
    {
        //Her türemiş sınıf bu metodu farklı ele alıyor
        //Bu metod tek basına bir şey ifade etmiyorsa.
        //Bu tip, alternatif, imzasının aynı oldugu(calculate metodu kastediyor)
        //Şablon olarak kullanılan durumlar oldugunda baseyi class değilde, interface olarak olustururuz.
        //İnterface derki eğer biri bu interfaceyi kullanırsa,
        //o arkdaş kullanılan interfacedeki metod veya metodları içermelidir kendi sınıfının içinde tanımlamalıdır. 
        //Yani kendisinde de bu metod tanımlamalarını yazmak zorundadır. 
        //örnek sınıf : ICreditManager yazıp, şak diye burada tanımlanan metodları kullanamaz!

        //Ek olarak bu interface kendisinden kalıtım alan türemiş sınıfların referans adresini tutabilir!
        // Örnek: ICreditManager ihtiyacKrediManager = new İhtiyacKrediManager()


        //Özet olarak interface:
        //1: kendisine implement edilen operasyon sınıfların refrans numarasın
        //2: kendisine implement edilen operasyon sınıflara kendi metodlarını o sınıfta tanımlamasını zorunlu tutar.

        //Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        //tüm kredi türlerinde ortak calculate vardır. Ama kodları farklıdır.
        public void Calculate();
        public void DoAnything();
    }
}
