using System;
using System.Collections;
using System.Collections.Generic;

namespace Kuyruk_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama

            var karakterkuyruğu = new Queue<char>();

            //Kuyruğa Ekleme

            karakterkuyruğu.Enqueue('a');
            karakterkuyruğu.Enqueue('b');
            karakterkuyruğu.Enqueue('c');
            karakterkuyruğu.Enqueue('d');
            karakterkuyruğu.Enqueue('e');

            Console.WriteLine($"Kuyruktaki Eleman sayısı : {karakterkuyruğu.Count}");

            //Kuyruktan Eleman Çıkarma

            Console.WriteLine($"Kuyruğun Başındaki Eleman : {karakterkuyruğu.Peek()}");
            Console.WriteLine($"{karakterkuyruğu.Dequeue()} kuyruktan çıkarıldı ");
            Console.WriteLine($"Kuyruktaki Eleman sayısı : {karakterkuyruğu.Count}");
            Console.WriteLine($"Kuyruğun Başındaki Eleman : {karakterkuyruğu.Peek()}");

            //Kuyruğu bir diziye aktardık.

            var dizi = karakterkuyruğu.ToArray();



        }
    }
}