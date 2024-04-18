using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDIC = new MyDictionary<string, int>();
            myDIC.Add("hundred", 100);
            myDIC.Add("two hundred", 200);
            myDIC.Add("three hundred", 300);

            foreach (var smalkey in myDIC)
            {
                Console.WriteLine($"key{smalkey.Key} +value{smalkey.Value}");

            }
        }
    }
}
