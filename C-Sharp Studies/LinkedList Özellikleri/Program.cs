using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList_Özellikleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic sınıfında yer alır.
            //Non Generictir
            //doğrusal veri yapısıdır.

            var şehirler = new LinkedList<string>();

            //addfirst listenin başına ekleme yapar
            //addlast listenin sonu ekleme yapar
            //addafter verilen elemandan sonra istediğimiz elemanı ekler
            //addbefore bulunan bir eleamın öncesine istediğimiz elemanı ekler.


            şehirler.AddFirst("Ordu");
            şehirler.AddFirst("Trabzon");
            şehirler.AddLast("İstanbul");
            şehirler.AddAfter(şehirler.Find("Ordu"), "Samsun") ;
            şehirler.AddBefore(şehirler.First.Next.Next,"Giresun");
            şehirler.AddAfter(şehirler.Last.Previous,"Sinop");
            şehirler.AddAfter(şehirler.Find("Sinop"),"Zonguldak");

            foreach (string s in şehirler)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Elemanları  baştan yazdırdık

            Console.WriteLine("Gidiş Güzergahı");
            var eleman = şehirler.First;

            while (eleman!=null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.ReadKey();
            Console.WriteLine();

            //Elemanları Tersine Çevirdik.

            Console.WriteLine("Dönüş Güzergahı");
            var geçici = şehirler.Last;

            while (geçici != null)
            {
                Console.WriteLine(geçici.Value);
                geçici = geçici.Previous;
            }

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}