namespace Diziler_Ve_Alternatif_Dizi_Tanımları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array-Dizi Normal Tanım

            int[] sayılar = new int[] { 3, 5, 7, 10, 12 };
            
            //Array Sınıfı ile de tanımlama yapmak mümkün 
            //CreateInstance metodu kullanılarak dizinin değerlerinin tiplerini int string vb belirleyip de dizi oluşturulabilir.

            var numbers = Array.CreateInstance(typeof(int), 5);

            numbers.SetValue(3,0);
            numbers.SetValue(5, 1);
            numbers.SetValue(7, 2);
            numbers.SetValue(10, 3);
            numbers.SetValue(12, 4);

            //Dolaşma

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("sayılar[{0}] = {1} - numbers[{1}] = {2}", i, sayılar[i], numbers.GetValue(i));
            }

            Console.ReadKey();
        }
    }
}