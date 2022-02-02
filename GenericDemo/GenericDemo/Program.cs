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
            Console.WriteLine("Enter three float numbers:");
            float firstfloat = Convert.ToSingle(Console.ReadLine());

            float secondfloat = Convert.ToSingle(Console.ReadLine());
            float thirdfloat = Convert.ToSingle(Console.ReadLine());
            float maxfloat = Generic. FindMaxFloatNumber(firstfloat, secondfloat, thirdfloat);
            if (maxfloat == 0)
            {
                Console.WriteLine("All three numbers are equal!!!");
            }
            else
            {
                Console.WriteLine("Maximum among three:" + maxfloat);
            }
        }
    }
}
