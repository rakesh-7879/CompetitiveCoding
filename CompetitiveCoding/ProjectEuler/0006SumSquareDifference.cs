using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0006SumSquareDifference
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var range = Enumerable.Range(1, n);
                Console.WriteLine((long)Math.Pow(range.Sum(), 2) - (long)range.Sum(x => Math.Pow(x, 2)));
            }
        }
    }
}
