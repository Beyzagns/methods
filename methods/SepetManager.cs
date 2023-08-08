using System;
using System.Collections.Generic;
using System.Text;
//manager operasyon tutar
namespace methods
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi" + urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi" + urunAdi);
        }
    }
}
