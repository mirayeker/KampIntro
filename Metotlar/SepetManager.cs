using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {  
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " Sepete eklendi.");
        }

        public void Ekle2(string urunAdi,string aciklama , double fiyat)
        {
            Console.WriteLine("tebrikler. Sepete Eklendi.. " + urunAdi);
        }
    }
}
