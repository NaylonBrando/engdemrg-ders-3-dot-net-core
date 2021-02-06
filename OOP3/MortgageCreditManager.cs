using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICreditManager
    {
        //İnterface derki eğer biri bu interfaceyi kullanırsa,
        //o arkdaş kullanılan interfacedeki metod veya metodları içermelidir.
        //O yüzden altta interfacedeki metodları yazdık.
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı!");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
