using System;

namespace BankApp
{
    public class Kullanici
    {
        private static int  Id;
        private string Isim;
        private string Soyisim;
        private string Iban;
        private double Money;

        
        public int Id1 { get => ++Id;}
        public string Isim1 { get => Isim; set => Isim = value; }
        public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
        public string Iban1 { get => Iban; set => Iban = value; }
        public double Money1 { get => Money; set => Money = value; }
    }
}