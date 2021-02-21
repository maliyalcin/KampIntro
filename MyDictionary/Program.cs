using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Ali",23);
            myDictionary.Add("Fatih", 20);
            myDictionary.Add("Yasin",25);
        }
    }
}
