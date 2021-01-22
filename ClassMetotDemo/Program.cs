using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123456;
            musteri1.NameSurname = "Ayşe Çalış";
            musteri1.Quantity = 15250;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 246801;
            musteri2.NameSurname = "Ali Taşır";
            musteri2.Quantity = 85962;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Add(musteri);

            }
            musteriManager.Delete(musteri2);
            musteriManager.List(musteriler);
        }

    }
}
