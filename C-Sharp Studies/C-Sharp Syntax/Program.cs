namespace C_Sharp_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basit bir şekilde y'nin x'e bağlı değerini bulduk/*.*/

            int x = 2;
            int y = 2 * x;
            Console.WriteLine(y);

            Console.ReadKey();

            //Console.ReadKey(); Program kapanmadan önce tuşa basılmasını bekler

            // var (tipi karşıdakine göre belirlenir) kullanarak örtülü değişken tanımı yaptık.

            var z = 3.1;
            Console.WriteLine(z.GetType());

            Console.ReadKey();


            //Çift tırnak içinde Yazılan şeyleri derleyici string(düzyazı) olarak algılar.

            var a = "2";
            var b = "3";
            var c = a + b;
            Console.WriteLine(c);

            Console.ReadKey();









        }
    }
}