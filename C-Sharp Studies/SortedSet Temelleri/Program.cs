using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedSet_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Tanımlama
            var list = new SortedSet<string>();

            //Ekleme

            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi");
            }
            else
            {
                Console.WriteLine("Ekleme Başarısız.");
            }

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("{0}", list.Add("Ahmet") ==true ? "Ahmet Eklendi" : "Ekleme Başarısız."); 

            Console.ReadKey();
            Console.WriteLine();

            //Elemanlar benzersiz olmak zorunda olduğu için tekrar ekleme yapamadık.

            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi");
            }
            else
            {
                Console.WriteLine("Ekleme Başarısız.");
            }

            Console.ReadKey();
            Console.WriteLine();

            list.Add("Şule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            Console.WriteLine("İsimler Listesi");

            Console.WriteLine();

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

             //startswith verilen harfle başlayan elemanları siler 

            list.Remove("Şule");
            list.RemoveWhere(değer => değer.StartsWith("F")); ;

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}