using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Miray";
            kurs1.IzlenmeOranı = 5200;
            
            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mert";
            kurs2.IzlenmeOranı = 200;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Kamil";
            kurs3.IzlenmeOranı = 3500;
            Kurs[] kurslar = new Kurs[] {kurs1 ,kurs2 } ;

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
       
        public string Egitmen { get; set; }
        
        public int IzlenmeOranı { get; set; }
    }
}
