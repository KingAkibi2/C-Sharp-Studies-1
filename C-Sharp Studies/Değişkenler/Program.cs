namespace Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değişken Tipleri

            //int tam sayılar için kullanılır.
            //double ondalıklı sayılar için kullanılır.
            //char klavyedeki karakterler için kullanılır.
            //string normal metinler için kullanılır.
            //bool doğru yanlış olarak tanımlamak için kullanılır.

            int sayı1 = 3;
            double pi = 3.14;
            char seçim = 'e';
            string isim = "akif";
            bool doğrumu = false;

            Console.WriteLine(sayı1);
            Console.WriteLine(pi);
            Console.WriteLine(seçim);
            Console.WriteLine(isim);
            Console.WriteLine(doğrumu);

            Console.ReadKey();

            //Kodlar sırayla okunduğu için isim2 2.ci tanımlamada mehmet oldu

            string isim2 = "ahmet";           
            Console.WriteLine("merhaba " + isim2);
            isim2 = "mehmet";
            Console.WriteLine("merhaba " + "sayın " +isim2);

            Console.ReadKey();

            int sayı3 = 5;
            Console.WriteLine(sayı3);
            Console.WriteLine(sayı3+2);
            Console.WriteLine(sayı3*sayı3);
            Console.WriteLine(sayı3-5);

        }    
    }
}