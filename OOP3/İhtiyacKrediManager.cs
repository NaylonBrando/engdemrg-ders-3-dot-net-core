using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacKrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı!");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
