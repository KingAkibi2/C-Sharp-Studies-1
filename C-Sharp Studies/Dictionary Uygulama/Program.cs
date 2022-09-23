using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary_Uygulama
{
    public class Program
    {
        static void Main(string[] args)
        {

            var personellistesi = new Dictionary<int, Personel>()
            {
                {110,new Personel("Mehmet","Cansız",6000)},
                {120,new Personel("Mustafa","Canlı",7000)}
            }
            ;

            personellistesi.Add(100,new Personel("Zeynep","Coşkun",500));

            foreach (var p in personellistesi)
            {
                Console.WriteLine(p);
            }

        }
    }
}