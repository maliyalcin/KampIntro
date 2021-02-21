using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yalçın";
            musteri1.TcNo = "54646545";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54654";
            musteri2.SirketAdi = "SolarEnergy";
            musteri2.VergiNo = "4545555";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}
