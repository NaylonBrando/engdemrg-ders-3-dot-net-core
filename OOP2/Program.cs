using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soyutlama
            //gerçek ve tüzel müşterileri birbirinin yerine kullanmamalıyız.
            //gidipte müsteritipi diye de özellik koymak da hatalıdır!
            //Bu dediklerimiz SOLID yazılım geliştirme prensiplerinden gelir

            //OOP2 projesinde verilmek istenen mesaj: Base sınıf referans tutucudur.



            //Bireysel
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 2;
            customer1.CustomerNo = "100";
            customer1.Name = "Erhan Rohat";
            customer1.Surname = "Turuncu";
            customer1.TcNo = "666";
            

            //Tüzel
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "101";
            customer2.CompanyName = "ABC";
            customer2.TaxId = "237";


            Customer customer3 = new IndividualCustomer(); //Referans No
            Customer customer4 = new CoorporateCustomer(); //"        "

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1); //base sınıfın, türeyen sınıfların refrans adresini tutabilmesi
            customerManager.Add(customer3);



        }
    }
}
