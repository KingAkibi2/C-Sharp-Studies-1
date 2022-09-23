using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tanımlama

            var telefonkodları = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Artvin" }
            };

            //Eleman Ekleme

            telefonkodları.Add(322, "Adana");
            telefonkodları.Add(212, "İstanbul");
            telefonkodları.Add(216,"İstanbul");
            telefonkodları.Add(114, "İzmir");

            //Dolaşma

            foreach (var s in telefonkodları)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

            //ContainsKey

            if (!telefonkodları.ContainsKey(312))
            {
                Console.WriteLine("\a Ankaranın Kod Bilgisi Tanımlı Değil");
                telefonkodları.Add(312,"Ankara");
                Console.WriteLine("Yeni Kod Eklendi.");
            }

            Console.ReadKey();
            Console.WriteLine();

            //ContainsValue

            if (!telefonkodları.ContainsValue("Malatya"))
            {
                Console.WriteLine("\a Malatyanın Kod Bilgisi Tanımlı Değil");
                telefonkodları.Add(512, "Malatya");
                Console.WriteLine("Yeni Kod Eklendi.");
            }

            telefonkodları.Remove(322);

            Console.ReadKey();
            Console.WriteLine();

            foreach (var s in telefonkodları)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

           
        }
    }
}