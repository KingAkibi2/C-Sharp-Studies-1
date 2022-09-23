using System;
using System.Collections.Generic;

namespace Struct_Temelleri
{
    //Özelliklerin hepsini seçip ctrl . tuşuyla yapılandırıcı metodu seçip dönüştürdük.
    public struct Öğrenci2
    {
        public Öğrenci2(int numara, string adı, string soyadı, bool cinsiyeti) : this()
        {
            this.Numara = numara;
            this.Adı = adı;
            this.Soyadı = soyadı;
            this.Cinsiyeti = cinsiyeti;
        }

        public int Numara { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public bool Cinsiyeti { get; set; }

        //Bir Metodu Ezmek Geçersiz Kılmak.
        //override yazıp to string seçeneğini seçip gereken oluşturulur.

        public override string ToString()
        {
            return $"{Numara,-5} " + $"{Adı,-10} " + $"{Soyadı,-10} " + string.Format("{0,-5}", Cinsiyeti == true ? "Erkek" : "Kız");

        }




    }
}