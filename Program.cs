using MyDictionary20Ocak2021Odev;
using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "batuhan");
            myDictionary.Add(2, "kaan");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
