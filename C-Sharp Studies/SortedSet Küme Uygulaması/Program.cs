using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedSet_Küme_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var A = new SortedSet<int>() { 1, 2, 3,4 };
            var A = new SortedSet<int>(rastgelesayıüret(10));
            //var B = new SortedSet<int>() { 1,2,5,6 };
            var B = new SortedSet<int>(rastgelesayıüret(10));
            //Kümeleri Yazdırma

            Console.WriteLine("A Kümesi");

            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("B Kümesi");

            foreach (var s in B)
            {
                Console.Write($"{s,5}");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Kümeleri Birleştirme

            A.UnionWith(B);

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Kümelerin Birleşimi");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }

            static List<int >rastgelesayıüret(int n)
             {
                var list = new List<int>();
                var r = new Random();

                for (int i = 0; i < n; i++)
                {
                    list.Add(r.Next(0, 50));
                }
                return list;
              }

            Console.ReadKey();
            Console.WriteLine();

            //Kümelerin Kesişimi

            A.IntersectWith(B);

            Console.WriteLine("Kümelerin Kesişimi");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }

        }
    }
}