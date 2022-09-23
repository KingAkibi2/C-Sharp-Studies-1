namespace Metotlar_3
{
    internal class Program
    {
        //Elemanları Dinamik Olarak Toplayan Metot Tasarımı

        static void Main(string[] args)
        {

            double toplam = Seritoplamı(5.5,10.5,15.5,3.14,4.12);
            Console.WriteLine("{0,5:0.##}",toplam);

        }

        //Params ifadesi parametre sayısını dinamik olarak ayarlanmasını sağlar.

        private static double Seritoplamı(params double[] seri)
        {
            double toplam = 0;

            foreach (double s in seri)
            {
                toplam += s;
            }

            return toplam;
        }
    }
}