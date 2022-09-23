using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var KarakterYığını = new Stack<char>();

            //Eleman Ekleme
            //peek ifadesi yığının tepesindeki ifadeyi gösterir

            KarakterYığını.Push('a');
            Console.WriteLine(KarakterYığını.Peek()); 
            KarakterYığını.Push('b');
            Console.WriteLine(KarakterYığını.Peek());
            KarakterYığını.Push('c');
            Console.WriteLine(KarakterYığını.Peek());

            Console.ReadKey();
            Console.WriteLine();

            //Yığından eleman çıkartma

            Console.WriteLine(KarakterYığını.Pop() + " yığından çıkarıldı");
            Console.WriteLine(KarakterYığını.Pop() + " yığından çıkarıldı");
            Console.WriteLine(KarakterYığını.Pop() + " yığından çıkarıldı");

            Console.ReadKey();
            Console.WriteLine();

            //elemanları dinamik olarak ekledik.

            for (int i = 65; i <90; i++)
            {
                KarakterYığını.Push((char)i);
                Console.WriteLine($"{KarakterYığını.Peek()} yığına eklendi");
            }

            Console.WriteLine($"{KarakterYığını.Peek()} yığına eklendi" );

            Console.ReadKey();
            Console.WriteLine();

            //dinamik olarak yığından çıkarma

            Console.WriteLine("Yığından çıkarmak için bir tuşa basınız.");

            Console.ReadKey();
            Console.WriteLine();

            while (KarakterYığını.Count>0)
            {
                Console.WriteLine($"{KarakterYığını.Pop()} yığından çıkarıldı");
                Console.WriteLine($"Yığındaki eleman sayısı : {KarakterYığını.Count}");
            }

            Console.ReadKey();

        }
    }
}