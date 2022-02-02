using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Generic<int> obj = new Generic<int>(arr);
            obj.PrintMaxValue();
            string[] Stringarr = { "abc", "efg", "hij" };

            Generic<string> obj1 = new Generic<string>(Stringarr);
            obj1.PrintMaxValue();
            char[] Chararr = { 'a', 'b', 'c', };
            Generic<char> obj2 = new Generic<char>(Chararr);
            obj2.PrintMaxValue();
            Console.ReadLine();
        }
        }
    }
