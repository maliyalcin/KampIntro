using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string,int> ilPlaka = new Dictionary<string,int>();

            ilPlaka.Add("Artvin",08);
            ilPlaka.Add("İstanbul",34);
            ilPlaka.Add("Ankara",06);

            foreach (var item in ilPlaka)
            {
                Console.WriteLine(item);
            }

            if (ilPlaka.ContainsKey("Artvin")) // İstediğimiz ilin plaka numarası için...
            {
                string il = "Artvin";
                int value = ilPlaka["Artvin"];
                Console.WriteLine(il + "ilinin plakası :" + value);
            }

            if (ilPlaka.ContainsValue(34)) // ContainsValue kullanımı...
            {
                Console.WriteLine(true);
            }

            Console.WriteLine(ilPlaka.Count); // Listedeki eleman sayısı için...
        }

    }
}
