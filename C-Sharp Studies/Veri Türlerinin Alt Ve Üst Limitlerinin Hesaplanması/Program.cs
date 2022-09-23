namespace Veri_Türlerinin_Alt_Ve_Üst_Limitlerinin_Hesaplanması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //nameof girilen veri türünü ekrana yazdırdı
            //maxvalue girilen veri türünün tutabileceği maksimum değeri verir.
            //minvalue girilen veri türünün tutabileceği minimum değeri verir.
            //sizeof girilen veri türünün bellekte ne kadar yer kapladığını gösterir
            //başında U olan Veri Tipleri yani işaretsiz ifadeler negatif sayıları tutmaz
            
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt Limit       : {SByte.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {SByte.MaxValue,20}");
            Console.WriteLine($"Boyut       : {sizeof(SByte),23}");

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt Limit       : {Byte.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {Byte.MaxValue,20}");
            Console.WriteLine($"Boyut       : {sizeof(Byte),23}");     

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt Limit       : {Int16.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {Int16.MaxValue,20}");
            Console.WriteLine($"Boyut       : {sizeof(Int16),23}");
           
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt Limit       : {UInt16.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut       : {sizeof(UInt16),23}");

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt Limit       : {Int32.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {Int32.MaxValue,20}");
            Console.WriteLine($"Boyut       : {sizeof(Int32),23}");

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt Limit       : {UInt32.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {UInt32.MaxValue,20}");
            Console.WriteLine($"Boyut       : {sizeof(UInt32),23}");

            Console.ReadKey();

        }
    }
}