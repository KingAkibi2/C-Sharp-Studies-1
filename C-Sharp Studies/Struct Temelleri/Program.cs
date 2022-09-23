using System;
using System.Collections.Generic;


namespace Struct_Temelleri
{
    //struct yapsısı namespace ile sınıf arasında tanımlanır.
    //prop yazıp tab tuşuna iki defa basınca structa özellik tanımlarız.
    //yapılandırıcı metodu ctrl. tuşlarına bastıktan sonra class olarak başka bir sınıfa taşımamız mümkün
    public struct Öğrenci
    {
        public int Numara { get; set; }
        public string  Adı { get; set; }
        public string Soyadı { get; set; }
        public bool Cinsiyeti { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Yeni Öğrenci Tanımladık.

            Öğrenci2 öğr = new Öğrenci2();
            öğr.Numara = 10;
            öğr.Adı = "Ahmet";
            öğr.Soyadı = "Yılmaz";
            öğr.Cinsiyeti = true;

            //Alternatif Öğrenci Tanımlama

            var öğr2 = new Öğrenci2()
            {
                Numara = 20,
                Adı = "Fatma",
                Soyadı = "Dağ",
                Cinsiyeti = false
            };
            //Bir Başka Alternatif Kullanım (Bu kullanım Öğrenci2 olarak yapılandırıcı metot uyguladığımız metot olmadan kullanamayız.).

            var öğr3 = new Öğrenci2(30, "Mehmet", "Avşar", true);

            Console.WriteLine($"{öğr.Numara} " + $"{öğr.Adı} " + $"{öğr.Soyadı} " + $"{öğr.Cinsiyeti} ");
            Console.WriteLine($"{öğr2.Numara} " + $"{öğr2.Adı} " + $"{öğr2.Soyadı} " + $"{öğr2.Cinsiyeti} ");
            Console.WriteLine($"{öğr3.Numara} " + $"{öğr3.Adı} " + $"{öğr3.Soyadı} " + $"{öğr3.Cinsiyeti} ");

            Console.ReadKey();
            Console.WriteLine();

            //override metodu kısaca bizi yazma zahmetinden kurtardı.

            Console.WriteLine(öğr);
            Console.WriteLine(öğr2);
            Console.WriteLine(öğr3);

            Console.ReadKey();
            Console.WriteLine();

            //Öğrencileri Liste olarak depolayabiliriz.

            var ÖğrenciListesi = new List<Öğrenci2>()
            {
             new Öğrenci2(10, "Ahmet", "Yılmaz", true),
             new Öğrenci2(20, "Fatma", "Dağ", false),
             new Öğrenci2(30, "Mehmet", "Avşar", true)

            };

            //artık öğrencileri listelediğimize göre foreach döngüsü kullanabiliriz.

            foreach (Öğrenci2 o in ÖğrenciListesi)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();

        }
    }
}