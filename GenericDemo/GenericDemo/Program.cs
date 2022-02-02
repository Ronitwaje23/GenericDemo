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
            Console.WriteLine("Enter three words:");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();


            string maxString = Generic.FindMaxFloatNumber(word1, word2, word3);

            if (maxString == null)
            {
                Console.WriteLine("All three numbers are equal!!!");
            }
            else
            {
                Console.WriteLine("Maximum among three:" + maxString);
            }
        }
    }
}