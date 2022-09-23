namespace Class_Yapısı
{
    //classlar referans tiplidir.

    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama

            ÖğretimElemanı ÖğrGör = new ÖğretimElemanı();

            //Atama

            ÖğrGör.SicilNo = 101;
            ÖğrGör.Adı = "Ahmet";
            ÖğrGör.Soyadı = "Yalçın";
            ÖğrGör.Cinsiyeti = true;

            //Pratik Tanımlama Yöntemi

            ÖğretimElemanı ÖğrGör2 = new ÖğretimElemanı()
            {
                SicilNo = 102,
                Adı = "Akif",
                Soyadı = "Akbalık",
                Cinsiyeti = true

            };

            //ctor tanımladığımız için kolayca görevli tanımlayabildik.

            ÖğretimElemanı2 ÖğrGör3 = new ÖğretimElemanı2(103, "Ayşe", "Akbalık", false);

            //ÖğretimElemanı görevlilerimizi listeye aktardık

            var Liste1 = new List<ÖğretimElemanı2> {

                  new ÖğretimElemanı2(104, "Kerem", "Akbalık", true),
                  new ÖğretimElemanı2(105, "Merve", "Akbalık", false),
                  new ÖğretimElemanı2(106, "Zeynep", "Akbalık", false),
                  new ÖğretimElemanı2(107, "Ramazan", "Akbalık", true),
                  new ÖğretimElemanı2(108, "Mehmet", "Kalemoğlu", true),
                  new ÖğretimElemanı2(109, "Ali", "Karpuzcu", true)

               };

            //foreach ile döndük.

            Console.WriteLine("Lİste1");

            foreach (var s in Liste1)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Liste1 i Liste2 yE Eşitledik.
            List < ÖğretimElemanı2 > Liste2 = Liste1;

            Console.WriteLine("Liste2");

            foreach (var s in Liste2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Liste2 ye eleman ekleyince liste 1 ede eklenmiş olacak

            Liste2.Add(new ÖğretimElemanı2(110, "Mahmut", "Toptaş", true));
            Console.WriteLine("Liste2 ekleme yapıldı");
            Liste1.RemoveAt(0);

            Console.WriteLine();

            Console.WriteLine("Liste1");
            foreach (var o in Liste1)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();
            Console.WriteLine();


        }
    }
}