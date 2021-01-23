using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 230192;
            musteri1.Ad = "Selin";
            musteri1.Soyad = "Pak";
            musteri1.Bakiye = 1907;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 231356;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Tok";
            musteri2.Bakiye = 2007;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 232212;
            musteri3.Ad = "Melis";
            musteri3.Soyad = "Pont";
            musteri3.Bakiye = 2107;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            foreach (var musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
            }

                musteriManager.Sil(musteri3);

            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.Listele(musteriler[i]);
                Console.WriteLine(musteriManager);
            }
        }
    }    
}
