using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedSet_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sayılar = new List<int>();
            var r = new Random();

            Console.WriteLine();

            //0 ile 10 arasında rastgele 100 tane değer atadık.

            for (int i = 0; i < 1000; i++)
            {
                sayılar.Add(r.Next(0,33));
                Console.Write($"{sayılar[i],-3}");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Benzersiz olan sayıları yazdırdık

            var benzersizsayılistesi = new SortedSet<int>(sayılar);
            Console.WriteLine("Benzersiz Sayılar Listesi");

            foreach (var s in benzersizsayılistesi)
            {
                Console.Write($"{s,-3}");
            }

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Benzersiz {0} tane sayı var",benzersizsayılistesi.Count);

        }
    }
}