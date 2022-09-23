using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Kitapiçeriği = new SortedList();

            Kitapiçeriği.Add(1,"Önsöz");
            Kitapiçeriği.Add(30, "Classlar");
            Kitapiçeriği.Add(50, "Değişkenler");
            Kitapiçeriği.Add(40, "İf-Else Yapısı");
            Kitapiçeriği.Add(70, "HashTable");
            Kitapiçeriği.Add(65, "Listeler");
            Kitapiçeriği.Add(32, "Döngüler");

            Console.WriteLine("Kitap İçeriği");
            Console.WriteLine(new string('-',55));
            Console.WriteLine($"{"Sayfalar",-5}{"Konular",48}");

            foreach (DictionaryEntry i in Kitapiçeriği)
            {
                Console.WriteLine($"{i.Key,-5}" + $"{i.Value,50}");
            }

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}