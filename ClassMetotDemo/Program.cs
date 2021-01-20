using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "deniz";
            musteri1.Soyad = "al";
            musteri1.TelNo = "05380000000";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "memet";
            musteri2.Soyad = "eryılmaz";
            musteri2.TelNo = "05380000001";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(2, "memet", "eryılmaz", "05380000001");
            musteriManager.Listele(musteriler);


        }
    }
}
