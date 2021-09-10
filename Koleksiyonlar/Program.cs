using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ayşe", "Miray", "Simge", "Enes" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //ctrl+k+ctr+c -> ctrl+kctrl+u (toplu comment alıp almama

            List<string> isimler2 = new List<string>() { "Murat", "Halil", "Kerem" };
            isimler2.Add("Engin");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            
        
        }
    }
}
