using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=? 999


            //değer tipleri: int, decimal, flood, double, bool(0,1 tutar)...
            //sayılsal görüntüler.

            //referans tip: array, class, interface

            //bellekte stack ve heap bölümleri var
            //değer tipleri stackte gerçekleşir. sayi1=10 dediğinde orada gerceklesir
            //sayi1 in değeri 10 diye okuruz
            //sayi1 in değeri sayi2nin değeridir. sayi2'nin kendisiyle alakası yokk
            //sadece değeriyle alakası var

            //peki referans tipler
            //new demek belleğin heap bölümünde bir adres(refrans no) oluştur
            //örneğin 17 ve 18. satıda sayilar1'in referans nosu 101, sayılar2nin 102
            //sayılar1'in referans numarası sayılar2'nin referans numarasına eşittir
            //sayilar1'in yeni referans nosu 102
            //c gibi dillerde pointer olarak karsımıza cıkar
            //peki 101. adrese ne oldu. - silindi!
            //deneme 1234


            //////////////////////////////////////////////////////////

            Person personel1 = new Person();
            Person personel2 = new Person();

            personel1.Name = "A";
            personel2 = personel1; //personel2'nin referans numrasını(adresi) personel1 ile aynı

            Console.WriteLine("Personel 2'nin ismi: " + personel2.Name);


            Customer customer = new Customer();
            customer.Name = "XYZ";

            Person person3 = customer;
            // Customer = Employee; bunları hop atayamazsınız. int ile string gibi
            //peki az önce Customer = Employee'yi birbirine atayamıyorken neden person3 = customer atayabildim ? Cevap: Customer Persondan miras almıstır. Person miras verdiği için referans alabilir.
            //Base sınıfına(Personel), yavru sınıflardan(Alt sınıf, kalıtım yoluyla atanan sınıf vs) referans atayabilirsiniz
            Console.WriteLine(person3.Name);
            
            //person class'i miras alan sınıfların adresini tutabilir. ---- asagıdaki personmanager class'indan görebilirsiniz
            Employee employee1 = new Employee();
            employee1.Name = "Erhan";
            PersonManager personManager = new PersonManager();
            personManager.Add(employee1); //parametresi Person olan metoda employee sınıfından nesne gönderdik xd.






        }
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }

        }

        public class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        public class Employee : Person
        {
            public int EmploeyeeNumber { get; set; }
        }


        public class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.Name);
            }
        }
        



    }
}
