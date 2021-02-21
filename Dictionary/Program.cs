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
        }
    }
}
