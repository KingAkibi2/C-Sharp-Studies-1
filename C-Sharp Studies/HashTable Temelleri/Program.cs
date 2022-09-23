using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tanımlama Yaptık
            var şehirler = new Hashtable();

            //Eleman Ekleme
            //Key Value Çiftinden Bahsetmniştik eleman eklerken hem bir key hem de bir value eklemiş olduk.

                     //Keys    Values
            şehirler.Add(6, "Ankara");
            şehirler.Add(19, "Çorum");
            şehirler.Add(35, "İzmir");
            şehirler.Add(34, "İstanbul");

            //Dolaşma

            foreach (var s in şehirler)
            {
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.WriteLine();

            //çıktı alamadık key value iftine ulaşamadık 
            //buradan türünü var olarak değil dictionary entry olarak seçmeliyiz

            foreach (DictionaryEntry item in şehirler)
            {
                Console.WriteLine($"{item.Key,-5} " +$"{item.Value,-10 } ");
            }
            
            Console.ReadKey();
            Console.WriteLine();

            //Sadece anahtarları yazdırma

            Console.WriteLine("Keys");
            var anahtarlar = şehirler.Keys;

            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Sadece değerleri Yazdırma
            //değerler dizisinin türünü bildiğimiz için var kullanmak zorunda değiliz

            Console.WriteLine("Values");
            ICollection değerler = şehirler.Values;

            foreach (var item in değerler)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.WriteLine();

            //İstediğimiz elemanı konsola yazdırma

            Console.WriteLine("Elemana Erişmek");
            Console.WriteLine(şehirler[19]);

            Console.ReadKey();
            Console.WriteLine();

            //Eleman Silme
            Console.WriteLine("Eleman Silmek");
            şehirler.Remove(6);

            foreach (DictionaryEntry item in şehirler)
            {
                Console.WriteLine($"{item.Key,-5} " + $"{item.Value,-10} ");
            }

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}