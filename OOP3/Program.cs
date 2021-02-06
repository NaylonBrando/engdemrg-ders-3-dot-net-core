using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bunlar şubedeki arkadaşın secebileceği kredi seçenekleri 
            ICreditManager ihtiyacKrediManager = new İhtiyacKrediManager(); //İnterfaceler, o interfaceyi implemente eden classin referans numarasını tutabilir.  
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
           
            
            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService(); //aslında alternatif olarak alt satırdaki kodda parametreye "new DatabaseLoggerService()" girilebilir. 
            creditApplicationManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService); //çıktı ihtiyac kredisi hesaplandı!
            
            //ICreditManager'de bir veri tipidir.
            List<ICreditManager> credits = new List<ICreditManager>() { ihtiyacKrediManager, mortgageCreditManager, transportCreditManager };
            Console.WriteLine("Liste tipinde birden çok kredi türünü hesaplama!: ");
            creditApplicationManager.CreditPreNotification(credits);

            Console.WriteLine("---------------------");
            MortgageCreditManager mortgageCreditManager1 = new MortgageCreditManager();
            creditApplicationManager.BasvuruYap(mortgageCreditManager1, new FileLoggerService());

        }


    }
}
