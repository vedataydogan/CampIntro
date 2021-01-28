using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            Console.WriteLine(isimler.Length);

            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            //Hata veriyor.
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("----------------");

            List<string> list = new List<string>();
            list.Add("Ahmet");
            list.Add("Mehmet");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
