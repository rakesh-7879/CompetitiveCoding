using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0001MultipliesOf3And5
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                n = n - 1;
                var S3 = Sum(n,3);
                var S5 = Sum(n,5);
                var S15 = Sum(n,15);
                Console.WriteLine(S3 + S5 - S15);
            }
        }

        static long Sum(long n, int k)
        {
            return k * ((n / k) * ((n / k) + 1)) / 2;
        }
    }
}
