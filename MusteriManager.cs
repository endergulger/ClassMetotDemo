using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine(musteriler.Id + " " + musteriler.Ad + " " + musteriler.Soyad + " " + " " + musteriler.Bakiye);
            Console.WriteLine("Müşterisi Eklendi. \n");
        }
        public void Sil(Musteri musteriler)
        {
            Console.WriteLine(musteriler.Id + " " + musteriler.Ad + " " + musteriler.Soyad + " " + " " + musteriler.Bakiye);
            Console.WriteLine(musteriler.Id + " Id sine sahip müşteri hesabı silindi. \n");
        }
        public void Listele(Musteri musteriler)
        {
            Console.WriteLine("Id:" + musteriler.Id);
            Console.WriteLine("Ad:" + musteriler.Ad);
            Console.WriteLine("Soyad:" + musteriler.Soyad);
            Console.WriteLine("Hesap Bakiyesi:" + musteriler.Bakiye);
            Console.WriteLine("\n");
        }
    }
}
