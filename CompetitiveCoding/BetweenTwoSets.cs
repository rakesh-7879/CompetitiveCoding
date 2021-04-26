using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class BetweenTwoSets
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            if(a.Last() > b.First())
            {
                return 0;
            }
            var lcm = a.Aggregate(LCM);
            return Enumerable.Range(a.Last(), b.First() - a.Last() + 1).Where(x=>x % lcm == 0).Where(x=>b.All(y=>y % x == 0)).Count();
        }

        public static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public static void Start()
        {
            List<int> arr = new List<int>
            {
                100,99,98,97,96,95,94,93,92,91
            };

            List<int> brr = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10
            };

            int total = GetTotalX(arr, brr);
            Console.WriteLine(total);
        }
    }
}
