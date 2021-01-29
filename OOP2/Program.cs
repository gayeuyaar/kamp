using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "554545";
            musteri1.Adi = "Gaye Nur";
            musteri1.Soyadi = "Uyar";
            musteri1.TcNo = "51544545455";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "26565";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "6565665656";



               
        }
    }
}
