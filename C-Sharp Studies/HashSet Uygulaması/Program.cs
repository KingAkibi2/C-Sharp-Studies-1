using System;
using System.Collections;
using System.Collections.Generic;


namespace HashSet_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var sesilharfler = new HashSet<char>() {

                'e','i','ı','o','ö','u','ü','b'                            
            
            };

            sesilharfler.Add('a');

            Console.WriteLine();

            foreach (var k in sesilharfler)
            {
                Console.Write($"{k,-5}");
            }

            Console.WriteLine();

            Console.WriteLine("Eleman Sayısı :  {0}", sesilharfler.Count);

            Console.ReadKey();



        }

    }
}