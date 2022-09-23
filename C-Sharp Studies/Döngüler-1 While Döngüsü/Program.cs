namespace Döngüler_1_While_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int sayaç = 0;

            //while döngüsü koşul sağlandığı müddetçe çalışmaya devam eder 0 her zaman 10 dan küçük olduğu için sonsuza kadar çalışır.

            while (i < 10)
            {

                Console.WriteLine("Sonsuz Döngü.");

            }

            Console.ReadKey();
            Console.WriteLine();

            //Bu kez de i ye dokunmayıp sadece sayacı artırdığımız için sayacın sonsuza dek artışını gözlemledik

            while (i < 10)
            {
                sayaç++;

                Console.WriteLine(sayaç);

            }

            Console.ReadKey();
            Console.WriteLine();

            //Bu kez i'ye müdahale ettiğimiz için döngü kırılabildi.

            while (i<10)
            {
                sayaç++;
                Console.WriteLine(sayaç);
                i++;
            }
            Console.WriteLine("Döngü Sonlandı.");

            Console.ReadKey();
            

        }
    }
}