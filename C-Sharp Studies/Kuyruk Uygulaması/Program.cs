using System;
using System.Collections;
using System.Collections.Generic;

namespace Kuyruk_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var sesliharfler = new List<char>()
            {
            
                'a','e','ı','i','ı','ö','u','ü'        
            
           };
            
            var kuyruk = new Queue<char>();

            ConsoleKeyInfo seçim;

            foreach (char o in sesliharfler)
            {
                Console.WriteLine($"{o,-5} kuyruğa eklensinmi ? [e/h]");
                seçim = Console.ReadKey();
                Console.WriteLine();

                if (seçim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(o);
                }
                Console.WriteLine($"\n {o,-5}  kuyruğa eklendi.");
                Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");

            }

            Console.WriteLine();
            Console.WriteLine("Kuyruktan eleman kaldırılması için esc tuşuna basınız.");
            Console.WriteLine();

            while (kuyruk.Count>0)
            {
                Console.WriteLine();
                Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                Console.WriteLine($"{kuyruk.Dequeue(),5}) kuyruktan çıkartıldı.");
                Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
            }

            Console.WriteLine("kuyruktan çıkarma işlemi tamamlandı");

            Console.ReadKey();

        }
    }
}