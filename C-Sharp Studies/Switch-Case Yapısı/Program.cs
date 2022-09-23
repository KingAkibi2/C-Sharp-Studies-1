namespace Switch_Case_Yapısı
{
    internal class Program
    {
        enum İşlemler
        {
            Toplama = 1,
            Çıkarma = 2,
            Çarpma = 3,
            Bölme = 4,
        }
        static void Main(string[] args)
        {
            int a = 31;
            int b = 13;

            //new istenen nesne üretmek için kullanılan bir anahtar sözcüktür
            //parantez içine aldığımız işlemler ifadesi ile cast işlemi yaptık

            İşlemler seçim = (İşlemler) (new Random().Next(1, 4));

            switch (seçim)
            {
                case İşlemler.Toplama:
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    break;
                case İşlemler.Çıkarma:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case İşlemler.Çarpma:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case İşlemler.Bölme:
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("\aGeçersiz İşlem!");
                    break;
            }

            Console.ReadKey();























        }
    }
}