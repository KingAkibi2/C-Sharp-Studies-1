using System;
using System.Collections.Generic;

namespace Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //List yapısı System.Collections.Generic sınıfında yer alır
            //List yapsına belirlenen veri tipi dışında başka veri tipi atayamayız

            //Tanımlama

            List<int> sayılar = new List<int>();

            int x = 80;
            int[] seri = new int[] { 90, 100, 110 };

            //Eleman Ekleme

            sayılar.Add(10);        
            sayılar.Add(20);
            sayılar.Add(30);
            sayılar.Add(40);
            sayılar.Add(50);
            sayılar.Add(60); 
            sayılar.Add(70);
            sayılar.Add(x);

            //AddRange ifadesi kullanarak da diziyi listeye ekleyebiliriz.

            sayılar.AddRange(seri);
            //foreach döngüsü ile de listeye diziyi ekleyebiliriz.

            foreach (var a in seri)
            {
                sayılar.Add(a);
            }
         
            //Dolaşma

            foreach (var s in sayılar)
            {
                Console.Write($"{s,-5}");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Araya Eleman Ekleme
            //Insert ifadesi ile verilen indise girilen elemanı ekler (3,0) 3.elemana 0 değerini ekler
            //Insert Range ifadesi verilen indisten itibaren girilen koleksiyonu ekler.

            sayılar.Insert(3,0);
            sayılar.InsertRange(5,new int[] {120,130});


            foreach (var s in sayılar)
            {
                Console.Write($"{s,-5}");
            }

            Console.ReadKey();

            //Listeden Eleman Çıkarma
            //RemoveAt verilen indisteki değeri siler

            sayılar.RemoveAt(9);

            foreach (var s in sayılar)
            {
                Console.Write($"{s,-5}");
            }
            Console.ReadKey();
            Console.WriteLine();

            //Indexof ifadesi verilen değerin indisini dinamik olarak bulup siler

            sayılar.RemoveAt(sayılar.IndexOf(20));

            foreach (var s in sayılar)
            {
                Console.Write($"{s,-5}");
            }

            Console.ReadKey();
            
        }
    }
}