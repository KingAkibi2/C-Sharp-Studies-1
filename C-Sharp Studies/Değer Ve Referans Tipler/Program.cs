namespace Değer_Ve_Referans_Tipler
{
    internal class Program
    {
        //Verilen Parametrelerin Yerlerini Değiştiren Metot Tasarımı

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("{0},{1}",x,y);
            Değiştir(x,y);

            //Kodlar Alt Alta Okunduğu için metotu geçtikten sonra konsola değer olduğu gibi yazdırıldı.

            Console.WriteLine("{0},{1}", x, y);

            Console.ReadKey();  
        }

        private static void Değiştir(int x, int y)
        {
            int geçici = x;
            x = y;
            y = geçici;
            Console.WriteLine("{0},{1}", x, y);
        }
    }
}