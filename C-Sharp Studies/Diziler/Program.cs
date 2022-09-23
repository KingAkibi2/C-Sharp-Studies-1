namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tanımlama

            int[] numaralar;

            //başlatma

            numaralar = new int[3];

            //diziye eleman atama 

            numaralar[0] = 3;
            numaralar[1] = 5;
            numaralar[2] = 7;

            //Dizi elemanlarını yazdırdık.

            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine($"numaralar[{i}] = " + $"{numaralar[i]}");
            }

            Console.ReadKey();
            Console.WriteLine();

            //pratik tanımlama işlemi

            int[] dizi = new int[] { 3, 5, 7,8,10};

            //Foreach dizi elemanlarını gezdiren döngüdür

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}