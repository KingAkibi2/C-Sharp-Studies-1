namespace KarakterSabitleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // \n ifadesi ilgili metni bir alt satıra yollar.
            // \t ifade ilgili ifadeyi 6-7 satır ileri kaydırır.
            // \a ifadesi alarm sesi üretir.

            string ifade = "\abtk \nakademi \nprogramlama \töğreniyorum";
            Console.WriteLine(ifade);

            Console.ReadKey();



        }
    }
}