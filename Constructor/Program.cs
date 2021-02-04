using System;

namespace Constructor //Türkçesi Kurucu Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, Name = "Erhan" }; //Default construcotrun çalıştığı metod.
            Customer customer2 = new Customer(2,"Rohat"); //Parametreli constructorun calistiği metod. Overloading  

            Console.WriteLine(customer1);
            Console.WriteLine(customer1.Id + " " + customer1.Name);
            Console.WriteLine(customer2.Id + " " + customer2.Name);
        }


        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Customer() //Default Constructor metod. 
            {

            }

            public Customer(int id, string name) //parametreli overloading Constructor.
            {
                Id = id;
                Name = name;
            }



        }
    }
}
