using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 123;
            musteri.Name = "Kübranur";
            musteri.Soyad = "Şahin";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri);

        }
    }
}
