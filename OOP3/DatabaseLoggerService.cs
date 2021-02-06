using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : IloggerService //Sen, IloggerService alternatifisin.
    {                             //yapılan şey şablon oluşturmak, ilgili classlari implemente etmek!
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı!");
        }
    }
}
