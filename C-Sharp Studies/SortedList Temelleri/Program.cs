using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama

            var list = new SortedList()
            {
                {1,"Bir"},
                 {3,"Üç"},
                 {8,"Sekiz"},
                 {5,"Beş"},
                 {4,"Dört"},
                 {7,"Yedi"}
            };

            list.Add(2, "İki");
            list.Add(6,"Altı");

            //Dolaşma

            //Keyleri sıraya dizerek verdi

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key,-5} " + $"{item.Value,-10} ");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Count listedeki eleman sayısını verir
            //capacity listenin alabileceği maksimum eleman sayısını verir
            //trim to size listenin kapasitesini listenin eleman sayısı kadar yapar

            Console.WriteLine("Listedeki Eleman Sayısı    : {0}", list.Count);
            Console.WriteLine("Listenin Kapasitesi        : {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin Kapasitesi        : {0}", list.Capacity);

            Console.ReadKey();
            Console.WriteLine();

            //Erişme Key Yoluyla

            Console.WriteLine("Key Yoluyla Erişilen");
            Console.WriteLine(list[4]);

            Console.ReadKey();
            Console.WriteLine();

            //Index yoluyla keye erişme

            Console.WriteLine("İndex yoluyla erişilen");
            Console.WriteLine(list.GetByIndex(0)); ;

            Console.ReadKey();
            Console.WriteLine();

            //Get Key İle

            Console.WriteLine("Get Key ile erişilen");
            Console.WriteLine(list.GetKey(1));

            Console.ReadKey();
            Console.WriteLine();

            //Listenin sonundaki elemana erişme

            Console.WriteLine("Listenin sonundaki elemanın değeri");
            Console.WriteLine(list.GetByIndex(list.Count-1));

            Console.ReadKey();
            Console.WriteLine();

            //Anahtarları ekrana yazdırma

            Console.WriteLine("KeysList");
            var anahtarlar = list.Keys;

            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Değerleri ekrana yazdırma

            Console.WriteLine("ValuesList");
            ICollection değerler = list.Values;

            foreach (var item in değerler)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.WriteLine();

            //anahtarlar kontrol edip değiştirme

            if (list.ContainsKey(1)) ;
            {
                list[1] = "One";
            }

            Console.WriteLine();

            Console.WriteLine("Düzenlenmiş Liste");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key,-5} " + $"{item.Value,-10} ");
            }

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}