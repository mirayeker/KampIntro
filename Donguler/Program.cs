using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Python";
            string kurs2 = "Java";
            string kurs3 = "C#";
            string kurs4 = "React";

            string[] kurslar = new string[] { "Python", "Java", "ZıkkımınDibi", "Bıktım" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
