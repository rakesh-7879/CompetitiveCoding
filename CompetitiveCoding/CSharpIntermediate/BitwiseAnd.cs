using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.CSharpIntermediate
{
    public class BitwiseAnd
    {
        public static long countPairs(List<int> arr)
        {
            var res = 0;
            for(var i =0; i < arr.Count() + 1 ; i++)
            {
                for(var j = i + 1; j < arr.Count(); j++)
                {
                    if(arr[i] >= arr[j] && isPowerOfTwo(arr[i] & arr[j]))
                    {
                        res++;
                    }
                }
            }
            return res;
        }

        static bool isPowerOfTwo(int n)
        {

            if (n == 0)
                return false;

            return (int)(Math.Ceiling((Math.Log(n) /
                                       Math.Log(2)))) ==
                   (int)(Math.Floor(((Math.Log(n) /
                                      Math.Log(2)))));
        }

        public static void Start()
        {
            Console.WriteLine(countPairs(new List<int> { 10, 7, 2, 8, 3 }));
            Console.WriteLine(countPairs(new List<int> { 1, 2, 1, 3 }));
            Console.WriteLine(countPairs(new List<int> { 0, 2, 4 }));
        }
    }
}
