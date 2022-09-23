using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen Bir sayı giriniz.");
            int sayı = Convert.ToInt32(Console.ReadLine());

            var sayıyığını = new Stack<int>();

            //Basamak değeri hesaplayıcı yaptık
            //sayının 10 ile kalanı basamak bulmamıza yardımcı oldu.
            
            while (sayı>0)
            {
                int k = sayı % 10;
                sayıyığını.Push(k);
                sayı = sayı / 10;

            }

            //dinamik olarak yığın büyüklüğü olarak tanımladık

            int i = 0;
            int n = sayıyığını.Count-1;

            foreach (var item in sayıyığını)
            {
                Console.WriteLine($"{item} x {Math.Pow(10,n-i)} = {item*Math.Pow(10,n-i)}");
                i++;
            }

            Console.ReadKey();


        }
    }
}