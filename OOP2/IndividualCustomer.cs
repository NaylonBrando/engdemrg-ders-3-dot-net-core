using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer: Customer //Miras, kalıtım, inhertince vs. TüzelMüsteri bir müsteridir. Türeyen sınıf
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
