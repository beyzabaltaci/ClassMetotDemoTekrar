using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    { //MÜŞTERİ TAKİBİ, EKLENMESİ, LİSTELENMESİ, SİLİNMESİ
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Ad = "Beyza";
            musteri1.Soyad = "Baltacı";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1234;
            musteri2.Ad = "Belgin";
            musteri2.Soyad = "Kaya";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id); 
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            Console.ReadLine();


        }
    }
}
