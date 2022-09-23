namespace Döngüler_3_For_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for döngüsü girilen koşullara göre döngü yürütür.

            for (int i = 0; i < 100; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.WriteLine();

            //forr döngüsü for döngüsünün tersten kurgulanmış halidir.

            for (int i = 100; i >= 0; i -= 5)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.WriteLine();

            //farklı bir yazım şekli uyguladık. Sayının kendisiyle karesini yan yana getirdik.

            for (int i = 0; i < 10; i += 1)
            {
                Console.WriteLine("{0,3} {1,3}", i, i * i);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Konsoldan değer alarak döngü kurguladık  

            Console.WriteLine("a değerini giriniz");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b değerini giriniz");

            int b = Convert.ToInt32(Console.ReadLine());

            //continue ifadesi koşul sağlandığında sıçrama yaparak es geçer 
            //break ifadesi koşul sağlandığında döngüyü kırar.

            for (int i = a; i < b; i += 1)
            {
                if (i % 3 == 0)
                {
                    continue;
                }

                if (i == 100)
                {
                    break;
                }

                Console.Write("{0,3}", i);
            }

            Console.ReadKey();
            Console.WriteLine();

            //iç içe for döngüleri
            //her döngüyü kendi sayısı kadar dolaşır 5*5 = 25 kere dolaşmış olur

            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" * ");
                }
            }

            Console.ReadKey();
            Console.WriteLine();

            //farklı bir örnek

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0},{1}", i + 1, j + 1);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.WriteLine();

            //parse ifadesi integere çevirmek için kullanılır

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

        }
    }
}