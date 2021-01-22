using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi:" + musteri.Id + " " + musteri.NameSurname);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri portföyden silindi:" + musteri.Id + " " + musteri.NameSurname);
        }
        public void List(Musteri[] musteriler)
        {
            Console.WriteLine("----------Kayıtlı Müşteriler---------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + "-----" + musteri.NameSurname + "-----" + musteri.Quantity);

            }
        }

    }
}
