using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CreditApplicationManager //Krediye basvuru alınacagında kullanılan ...
    {

        //Buna Method injection 
        public void BasvuruYap(ICreditManager creditManager, IloggerService ıloggerService) 
                                //parametre olarak hangi krediye göre yapılmasını istersem,
        {                       //bu parametreye interfaceyi implement eden sınıflardan herhangi birini parametre olarak verebilirim. 
                                //Hangisini parametre verirsem onun calculatesi calisir.
                                //Hangi kredi türünü gönderirsem onun calculate metodu calısacaktır.
                                //Bu da interfacenin kendisine implement edilen sınıfların referans adresini tutmaktan kaynaklanıyor.
            //-------------------------------------
            //Basvuran bilgilerini değerlendirme
            //...
            //...
            //önce bir değerlendirme sonra hesaplama


            //creditApplicationManager.BasvuruYap(ihtiyacKrediManager); bunu dediğimizde cıktı: ihtiyaç kredisi hesaplandı!
            creditManager.Calculate(); //Metodumuz burada gönderilen implement türünde ne varsa ona göre çalışır.
                                       //ev, taşıt, ihtiyaç. Buraya hangisini gönderirsem bellekte o refeans calısır.     
            
            ıloggerService.Log();  //burda ya veritananı ya file türü. örnek databasellogerservice.Log(); gibi
        
        }

        public void CreditPreNotification(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }


    }
}
