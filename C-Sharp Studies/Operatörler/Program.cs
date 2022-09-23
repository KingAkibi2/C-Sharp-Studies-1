namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = 31;
            int b = 13;

            //Aritmetik Operatörler

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.ReadKey();
            Console.WriteLine();

            //İlişkisel Operatörler

            Console.WriteLine(a>b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);      /*== ikisi birbirine eşittir ifade eder.*/
            Console.WriteLine(a != b);      /* !=  Eşit Değildir ifade eder*/

            Console.ReadKey();
            Console.WriteLine();

            //Mantıksal Operatörler

            Console.WriteLine(a>b && a>5);     /*&& Ve bağlacını ifade eder*/
            Console.WriteLine(a<b ||  b>5);   /* || veya bağlacını ifade eder*/

            Console.ReadKey();

        }
    }
}