namespace ÇokBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dizi Boyutunu Giriniz.");
            int boyut =Convert.ToInt32(Console.ReadLine());
            
            int[] sayılar = new int[boyut];

            //Random sayı atadık

            var r = new Random();

            for (int i = 0; i < sayılar.Length; i++)
            {
               sayılar[i] = r.Next(1,31);
            }

            //sonra diziyi yazdırdık.

            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.WriteLine();

            foreach (var s in sayılar)
            {
                Console.WriteLine($"{s,5} {s*s,5}");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Çok boyutlu dizi tanımladık

            double[,] matris = new double[,] { { 1, 2, 3 }, { 4, 5, 6 } , { 7, 8, 9 } };

            /*toplam ifadesiyle her satırdaki indisleri topladık*/

            double toplam = 0;

            for (int a = 0; a <matris.GetLength(0); a++)
            {
                for (int b = 0; b < matris.GetLength(1); b++)
                {
                    if (a==b)
                    {
                        matris[a, b] = -1;
                    }
                    if (matris[a,b]%2==0)
                    {
                        matris[a, b] = 0;
                    }
                    Console.Write($"{matris[a,b],5}");
                    toplam = toplam + matris[a,b];
                }
                Console.WriteLine();

                Console.WriteLine($"Toplam: {toplam}");

                Console.ReadKey();

            }
        }
    }
}