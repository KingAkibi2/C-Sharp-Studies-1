namespace Metotlar_4
{
    internal class Program
    {
        //Girilen Ürün Fİyatının  KDV dahil fiyatını hesaplayan metot tasarımı
        static void Main(string[] args)
        {
            Console.WriteLine("Ürün Fiyatını Giriniz");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double ÖdenecekMiktar = SatışYap(x);
            Console.WriteLine("KDV dahil Ödeyeceğiniz Fiyat");
            Console.WriteLine(ÖdenecekMiktar);

            Console.WriteLine();

            //"{0,5:0.##}" ifadesi virgülden sonraki devirli ifadeyi silen özel bir ifadedir.
            //.30 ifadesi yüzde 30 alması gerektiğini ifade eder

            var ÖdenecekMiktar2 = SatışYap(x, .30);
            Console.WriteLine(" %30 İndirimli Olarak Ödeyeceğiniz Miktar");
            Console.WriteLine("{0,5:0.##}",ÖdenecekMiktar2);

            Console.ReadKey();
        }

        private static double SatışYap(double miktar)
        {
            return miktar * 1.18;
        }

        //Metodun Aşırı Yüklenmesi Olayı

        private static double SatışYap(double miktar, double indirim)
        {
            return (miktar * (1.0-indirim) * 1.18);
        }




    }
}