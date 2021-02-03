using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //generic class demek çalışacağınız özel tip demek. ne diye tanımlarsak o olur. Yani her nesne olustururken değer tipi parametre veririz. sınıf buna göre tanımlanır
    class MyList<T> //Ben mylistimde t ile çalısacagım. bu da tip demek. çalşışacagım tipi tanımlarken veya new'lerken o olsun

    {

        //Aslında MyList<string> a = new .... dedigimizde, T tipi string olur.
        
        //Peki isimleri vs nasıl tutacagız ? = Listteki gibi
        T[] items; //Tip üzerinde çalıştıgımız için T tipinde tanımladık! MyList<....> ... = new .....diye nesne olusturdugumda tanımlamam gerekir. O yüzden metod içinde değilde class içinde yazdık
        //yani MyList<string> ... = new .....diye nesne olusturgumuzda bu "string[] items;" olacak.  //Not :Her olusturdugumuzda yeni bir referans adresinde olacak.
        public MyList() //Buna constructor, Bu Kurucu metod denir. Class new denirken oto çalışır.
        {               //Manası classtan her nesne olusturdugumuz vakit otomatik calisan metod.

            items = new T[0]; //Bu sınıfımız için her nesne oluşturdugumuzda verileri tutmak için array sınıfından nesne tanımlamak gerekir. Her nesne için kurucu metoddan bir array nesnesi
        }
        public void Add(T item) //parametre tipi yani string item vs gibi tanımlamak yerine generic oldugu için bu sınıftan nesne olustururken tanımladıgımız türden parametre türü belli olur.
        {
            T[] tempArray = items; //alltaki kodu yazdık ama her kod blogu calıstıgında referans numrası değişir. o yüzden newlenmeden refransı tutmak için bunu yazdık. tempArray items'in referansını tutuyor
            items = new T[items.Length + 1]; //Yukarıda 0 elemanlı diye tanımlamıstık. Çünkü list gibi dizimizin uzunlugunu belirlemeyecegiz. Dizinin eleman sayısını önce her seferinde 1 arttırmak gerekir.
                                             //Dizinin eleman sayısını hacmini 1 attırmak zorundayız. Bunun için sürekli new diye yeniden tanımlıyoruz. Sonra tempArray'de eski items'in adresini tutuyoruz.
            
            for (int i = 0; i < tempArray.Length; i++) //emanet verileri geri almak için döngüyü olusturduk
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //Nesnemize en son ekleyecegimiz verinin kodu
        
        
        }


    }
}
