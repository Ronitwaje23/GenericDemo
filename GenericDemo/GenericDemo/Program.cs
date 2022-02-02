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
            
            {
                

                GenericMaximum<int> first = new GenericMaximum<int>();
                first.FindMax(1, 2, 5);



                Console.ReadLine();
            }
        }

    }
}