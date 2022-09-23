using System;
    using System.Collections;

namespace ArrayListesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //ArrayList System.Collections sınıfında yer alır.

            //Tanımlama

            var arraylist = new ArrayList();

            //Eleman Ekleme

            arraylist.Add(10);
            arraylist.Add(true);
            arraylist.Add("akibi");
            arraylist.Add('e');

            //Dolaşma

            foreach (var s in arraylist)
            {
                Console.Write($"{s} ");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Tanımlama esnasında da pratik olarak eleman ekleyebiliriz.

            var arraylistesi = new ArrayList() { true, 'a', 30,"zeyno" };

            foreach (var item in arraylistesi)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
            Console.WriteLine();

            //AddRange ifadesi arrayliste koleksiyon eklemek için kullanılır          

            int[] sayılar = new int[] { 23, 44, 55,66,77 };
            arraylistesi.AddRange(sayılar);

            foreach (var i in arraylistesi)
            {
                Console.Write($"{$"{i} "} ");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Array listin istediğimiz elemanını konsola yazdırabiliriz.
            //indislerde elemanlar 0 dan başlar

            Console.Write(arraylistesi[4]);

            Console.ReadKey();
            Console.WriteLine();

            //Elemana Erişme Ve Atama
            //Arraylist elemanları obje olarak tutar bu yüzden parantez içinde int kullanarak objeden inte dönüştürdük

            var x = (int)arraylistesi[2]; /*kutudan çıkarma yaptık*/
            Console.WriteLine(x+10);

            Console.ReadKey();

            //Eleman Silme
            //Remove ifadesi ile verilen objeyi siler

            arraylistesi.Remove(30);

            foreach (var i in arraylistesi)
            {
                Console.Write($"{$"{i} "} ");
            }

            Console.ReadKey();
            Console.WriteLine();
            
            //RemoveAt İfadesi Verilen indisdeki objeyi siler

            arraylistesi.RemoveAt(2);

            foreach (var i in arraylistesi)
            {
                Console.Write($"{$"{i} "} ");
            }

            Console.ReadKey();
            Console.WriteLine();

            //RemoveRange verilen indisten itibaren verilen sayı kadar eleman siler (4,3 ) 4.elemandan itibaren 3 eleman siler.

            arraylistesi.RemoveRange(4,3);

            foreach (var i in arraylistesi)
            {
                Console.Write($"{$"{i} "} ");
            }

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}