using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    
            internal class Generic<T> where T : IComparable
            {
                public T[] values;
                public Generic(T[] values)
                {
                    this.values = values;
                }
                public T[] Sort(T[] values)
                {
                    Array.Sort(values);
                    return values;
                }
                public T MaxValue(T[] values)
                {
                    var SortedValues = Sort(values);
                    return SortedValues[this.values.Length - 1];

                }
                public T MaxMethod()
                {
                    var max = MaxValue(this.values);
                    return max;
                }
                public void PrintMaxValue()
                {
                    var max = MaxValue(this.values);
                    Console.WriteLine("Maximum value is: " + max);
                }

            }
        }
    
