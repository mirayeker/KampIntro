using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool girisYapildiMi = true  ;
            double dolarDun = 5.45;
            double dolarBugun = 8.47;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Dolar arttı");

            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Dolar azaldı");
            }
            else
            {
                Console.WriteLine("dolar değişmedi");
            }
            if (girisYapildiMi==true)
            {
                Console.WriteLine("Kullanici ayarları butonu");
            }
            else
            {
                Console.WriteLine("Kullanıcı giriş yap butonu");
            }
        }
    }
}
