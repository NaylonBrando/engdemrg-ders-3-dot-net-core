using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İş sınıfları //business classes
    class CustomerManager
    {
        //Müsteri üzerind ekleme, silme, güncelleme vs yapılan operasyon sınıfı.

        public void Add(Customer customer) //coorprate ve indivuali bu parametreye nasıl gönderebiliriz ?
        {                                  //Cevap: kalıtım alarak. o kisi sınıfa base sınıfının etkietini koyarak
                                           //Buna Polimorfinzm denir. Base sınıf üzerinden gittiğin için cocuk sınıfları da dahil edebiliyoruz

        }
    }
}
