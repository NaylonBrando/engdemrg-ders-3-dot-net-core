﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı!");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
