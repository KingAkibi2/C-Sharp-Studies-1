namespace Metotlar_2
{
    internal class Program
    {
        //Girdiğimiz sayının karesini alan metot tasarımı

        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz"); 
           double y = Convert.ToDouble(Console.ReadLine());
            double x = KareAl(y);
            Console.WriteLine(x);
        }

        public static double KareAl(double sayı)
        {
            double kare = sayı * sayı;
            return kare;
        }     




    }
}