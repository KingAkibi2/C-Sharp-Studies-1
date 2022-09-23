using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Yapısı
{
    public class ÖğretimElemanı2
    {
        public int SicilNo { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public bool Cinsiyeti { get; set; }


        public ÖğretimElemanı2(int sicilno, string adı, string soyadı, bool cinsiyet)
        {


            SicilNo = sicilno;
            Adı = adı;
            Soyadı = soyadı;
            Cinsiyeti = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5} " + $"{Adı,-10} " + $"{Soyadı,-10} " + string.Format("{0,-5}", Cinsiyeti == true ? "Erkek" : "Kız");
        }

    }

    public class ÖğretimElemanı
    {
        //classımıza prop yani özellik tanımladık.

        public int SicilNo { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public bool Cinsiyeti { get; set; }


        //ctor yazıp çift tıkladığımızda default constructor çalışır
        //public ÖğretimElemanı()
        //{
        //   System.Console.WriteLine("Otomatik Çalıştı.");
        //}

        //ctor metodu ile daha kolay tanımlama yapmak için bu yolu kullandık.

       
        public override string ToString()
        {
            return $"{SicilNo,-5} " + $"{Adı,-10} " + $"{Soyadı,-10} " + string.Format("{0,-5}", Cinsiyeti == true ? "Erkek" : "Kız");
        }


    }
}
