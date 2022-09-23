using System;
using System.Collections.Generic;

namespace ListeUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Şehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Ordu",
                "Van",
                "Samsun"
            };

            foreach (string s in Şehirler)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Lambda İfadeleri

            Şehirler.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();
            Console.WriteLine();

            //Yeni bir dizi tanımladık eski dizi ile aynı olarak

            var İller = Şehirler;

            İller.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
            Console.WriteLine();

            //Diziye Eleman Ekledik.

            Şehirler.Add("Sinop");

            //Elemanı Şehirler Disine Eklememize Rağmen İller Dizisine De Eklendi

            foreach (var s in İller)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

            //İllerden sildiğimiz eleman şehirlerden de silinmiş oldu.

            İller.Remove("Ankara");

            foreach (var s in Şehirler)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Yani aslında iki dizinin de birbirinin aynısı olduğunu görüyoruz.

        }
    }
}