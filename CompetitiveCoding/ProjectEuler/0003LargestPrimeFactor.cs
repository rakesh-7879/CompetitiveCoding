using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0003LargestPrimeFactor
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                long k = 2;
                while (k * k <= n)
                {
                    if (n % k == 0)
                        n /= k;
                    else
                        ++k;
                }
                Console.WriteLine(n);
            }
        }
    }
}
