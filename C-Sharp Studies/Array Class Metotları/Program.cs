using System;
using System.Collections;

namespace Array_Class_Metotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Array.CreateInstance(typeof(int), 5);

            numbers.SetValue(9, 0);
            numbers.SetValue(6, 1);
            numbers.SetValue(17, 2);
            numbers.SetValue(80, 3);
            numbers.SetValue(31, 4);


            int[] sayılar = new int[] { 3, 5, 7, 10, 12 };

            var arr = new ArrayList(sayılar);

            //arr.Sort Dizinin elemanlarını küçükten büyüğe sıralar.

            Array.Sort(sayılar);
            arr.Sort();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.WriteLine();

            //clear metodu verilen indis aralığındaki sayıları 0 yapar
            //copy to metodu verilen referanstaki sayıya verilen nesne kopyalanır

            sayılar.CopyTo(numbers,0);
            Array.Clear(numbers,2,2);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}