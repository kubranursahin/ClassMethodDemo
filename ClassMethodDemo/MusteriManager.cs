using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
//    Projeniz şunu yapacak.

//Bir bankada müşteri takibi yapmak istiyorsunuz.
//Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.

    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi.");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi.");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgisi Güncellendi.");
        }
    }
}
