namespace Dictionary_Uygulama
{
    public class Personel
    {
        public Personel(string adı, string soyadı, int maaş)
        {
            Adı = adı;
            Soyadı = soyadı;
            Maaş = maaş;
        }

        public int SicilNo { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public int Maaş { get; set; }

        public override string ToString()
        {
            return $"{Adı,-10} {Soyadı,-15} {Maaş,-10}";
        }
    }
}