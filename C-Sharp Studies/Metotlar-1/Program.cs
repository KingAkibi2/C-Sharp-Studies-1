using System;
using System.Collections.Generic;


namespace Metotlar_1
{
    public class Program
    {
        //Girdiğimiz İki Tam Sayıyı Karşılaştıran Metot Tasarımı

        static void Main(string[] args)
        {
            //metotlar veri tiplerinde değişken olarak saklanıp konsola yazdırılabilir.
           
            Console.WriteLine("1.sayıyı giriniz.");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz.");
            var n = Convert.ToInt32(Console.ReadLine());

           int x = Karşılaştır(m,n);

            Console.Write("Büyük Olan Sayı :");
            Console.Write(x);

            Console.ReadKey();
        }
        
        //public ifadesi herkese açık yani her classta kullanılabilir
        //private ifadesi sadece geçerli yerde kullanılabilir.
        //void ifadesi değer döndürmeden kullanılacak metotlar için kullanılır
        //return fifadesi metodu(fonksiyonu)döndürme işine yarar
        //static işlevi referans göstermeden kullanılacak nesneler için kullanılır.
        //metodun içine metodun kullanacağı parametreler yazılır.
        //decimal ifadesi hassas ondalıklı işlemler için kullanılır.

        public static int Karşılaştır(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                return a = b;
            }

            //Farklı kullanım

            return a>b ? a : b;

            
        }
    }
}
