using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("a");

            List<string> deneme = new List<string>();
            Console.WriteLine(deneme.Count); //0 dönecektir. Buradan aslında Liste sınıfının dayanagının aslında array sınıfı oldugunu görebiliriz. List arraydan daha gelişmiş versiyon
        }   


    }
}
