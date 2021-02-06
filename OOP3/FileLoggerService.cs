using System;

namespace OOP3
{
    class FileLoggerService : IloggerService //Sen, IloggerService alternatifisin.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı!");
        }
    }
}
