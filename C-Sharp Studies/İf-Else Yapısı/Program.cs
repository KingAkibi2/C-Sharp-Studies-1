namespace İf_Else_Yapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bir Sayının Tek Ya Da Çift Olduğunu Bulma Örneği

            Console.WriteLine("Bir sayı giriniz: ");

            //Convert.ToInt32 ifadesi stringi inte çevirir .Console.ReadLine() ifadesi string yapıdadır.

            int sayı = Convert.ToInt32(Console.ReadLine());

            //if bloğunu çalıştırmak için çift tab kullanılır

            if (sayı % 2 == 0)
            {
                Console.WriteLine(sayı + " " + "çift bir sayıdır.");
            }

            else
            {
                Console.WriteLine(sayı + " " + "tek bir sayıdır.");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Mutlak Değer Bulma Örneği

            Console.WriteLine("Bir Sayı Giriniz.");
            int n= Convert.ToInt32(Console.ReadLine());

            if (n<0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }

            else if (n>0)
            {
                Console.WriteLine($"|{n}| = {n}");
            }

            else
            {
                Console.WriteLine("0'ın Mutlak Değeri 0 dır");
            }

            Console.ReadKey();
            Console.WriteLine();

            //Karakter Buldurma Örneği

            //(char) ifadesi Console.Read(); den gelen tam sayı değerini char klavye karakterlerine dönüştürür.

            Console.WriteLine("Bir Karakter Giriniz");
            var k = (char)Console.Read();

            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır!");
            }

            else if (char.IsUpper(k))
            {
                Console.WriteLine("Büyük Harftir.");
            }

            else if (char.IsLower(k))
            {
                Console.WriteLine("Küçük Harftir!");
            }

            else
            {
                Console.WriteLine("Bilinmeyen Karakter!");
            }

            Console.ReadKey();

        }
    }
}