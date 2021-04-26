using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0005SmallestMultiple
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Enumerable.Range(1, n).Aggregate(lcm));
            }
        }

        static int lcm(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
