using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CoorporateCustomer:Customer //Miras, kalıtım, inhertince vs. BireyselMüsteri bir müsteridir. 
    { //kalıtımın esas olayı, ana sınıfın özelliklerini de almaktır, ortakları oraya atarız.
        
        public string CompanyName { get; set; }
        public string TaxId { get; set; }
    }
}
