using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Generic
    {
        class Comparison
        {
            public static string FindMaxFloatNumber(string first, string second, string third)
            {
                if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
                {
                    return first;
                }
                else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
                {
                    return second;
                }
                else if ((third.CompareTo(second) > 0) && (third.CompareTo(first) > 0))
                {
                    return third;
                }
                else
                {

                    return default;
                }
            }
        }

        internal static string FindMaxFloatNumber(string word1, string word2, string word3)
        {
            throw new NotImplementedException();
        }
    }
}