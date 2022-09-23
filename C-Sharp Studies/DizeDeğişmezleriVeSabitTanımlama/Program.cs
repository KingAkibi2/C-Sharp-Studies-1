using System.Diagnostics.Metrics;

namespace DizeDeğişmezleriVeSabitTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine(); ifadesi klavyeden girilen karakteri tutar

            var ifade = Console.ReadLine();

            Console.ReadKey();

            //.Key ifadesi kalvyeden girilen karakteri büyük harf yapar
            //.KeyChar ifadesi ise klavyeden gelen karakteri olduğu gibi yazdırır.

            var ifade2 = Console.ReadKey();
            Console.WriteLine(ifade2.Key);
            Console.WriteLine(ifade2.KeyChar);

            Console.ReadKey();


            //Length ifadesi girilen ifadenin uzunluğunu verir
            //ToUpper ifadesi girilen ifadenin tüm karakterlerini büyük harf yapar.
            //ToLower ifadesi girilen ifadenin tüm karakterlerini küçük harf yapar.
            //TrimStart ifadesi girilen ifadenin baştaki boşluklarını keser.
            //TrimEnd ifadesi girilen ifadenin sondaki boşluklarını keser.
            //Trim ifadesi girilen ifadenin verilen indisdeki karakterini siler.
            //Trim Lenght -1 ifadesi ise girilen ifadenin sondaki karakterini siler.

            var ifade3 = "merhaba programlama dünyası.";
            Console.WriteLine(ifade3);
            Console.WriteLine(ifade3.Length);
            Console.WriteLine(ifade3.ToUpper());
            Console.WriteLine(ifade3.ToLower());
            Console.WriteLine(ifade3.TrimStart());
            Console.WriteLine(ifade3.TrimEnd());
            Console.WriteLine(ifade3.Trim(ifade3[0]));
            Console.WriteLine(ifade3.Trim(ifade3[1]));
            Console.WriteLine(ifade3.Trim(ifade3[ifade3.Length-1]));

            Console.ReadKey();

        }
    }
}