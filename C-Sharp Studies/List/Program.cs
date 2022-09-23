using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //System.Collections.Generic sınıfında yer alır 
            //Tip güvenliği sağlanır.

            //Tanımlama

            var list = new List<int>() { 4, 8, 15, 16, 23, 42 };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item;
            }

            Console.ReadKey();

            Console.WriteLine();

           
            
        }
    }
}