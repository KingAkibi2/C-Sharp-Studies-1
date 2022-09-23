using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTabke_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable Uygulaması

            //Başlığı okumak

            Console.WriteLine("Başlık Giriniz.");
            string başlık = Console.ReadLine();

            //Küçültme

            başlık = başlık.ToLower();

            //Hashtable

            //neyin ney ile değiştirileceğini seçtik aslında

            var KarakterSeti = new Hashtable()
            {
                {'ç', 'c'},
                 {'ı' ,'i'},
                  {'ö','o'},
                  {'ü','u'},
                  {' ','-'},
                  {'m','b'},
                  { 'ğ','g'},
                  {'.','-'},

            };

            foreach  (DictionaryEntry i in KarakterSeti)
            {
                başlık = başlık.Replace((char)i.Key,(char)i.Value);
            }

            Console.WriteLine(başlık);
        }
    }
}