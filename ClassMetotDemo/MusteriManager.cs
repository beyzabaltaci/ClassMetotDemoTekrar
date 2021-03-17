using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi!");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi!");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi!");
        }

    }
}
