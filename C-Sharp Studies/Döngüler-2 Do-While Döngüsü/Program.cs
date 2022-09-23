namespace Döngüler_2_Do_While_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayaç = 1;

            //Console.Write ifadesi ifadelerin alt alta değil de yan yana yazılmasını sağlar
            //{ 0,-5} 1.ci ifade sayıyı 2. ifade kaç boşluk bırakılacağını gösterir

            while (sayaç<=10)
            {
                Console.Write(sayaç + " ");
                Console.WriteLine("{0,-5} {1,-3}",sayaç,sayaç*sayaç);
                sayaç++;
            }

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Bir Sayı Giriniz.");

            int n = Convert.ToInt32(Console.ReadLine());
            int m = 2;

            //do-while Döngüsü  koşul sağlandığı müddetçe verilen komutu uygulamaya geçirir.

            do
            {
                Console.Write("{0,3}",m);

                m = m + 2;

            } while (m<=n);

            Console.ReadKey();

        }
    }
}