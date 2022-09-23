using System;
using System.Collections;
using System.Collections.Generic;

namespace Sorted_Dictionary_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var kitapindeks = new SortedDictionary<string, List< int >> ()
            {

              {"HTML",new List<int>() {8,10,12 } },
              {"CSS",new List<int>() {70,80,90 } },
               {"JQuerry",new List<int>() {3,5,15 } },
               {"SQL",new List<int>() {70,80} },
            };

          kitapindeks.Add( "FTP",new List<int>() { 3,5,7} );
          kitapindeks.Add("ASP.NET", new List<int>() { 50,60 });

            foreach (var kavram in kitapindeks)
            {
                Console.WriteLine(kavram.Key);
                kavram.Value.ForEach(s => Console.WriteLine($"t >"+ s));
                
            }

            Console.ReadKey();

        }
    }
}