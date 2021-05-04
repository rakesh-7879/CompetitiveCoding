using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0009SpecialPythagoreanTriplet
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var res = GetPythagoreanProduct(n);
                Console.WriteLine(res);
            }
        }

        public static int GetPythagoreanProduct(int n)
        {
            for (int i = n / 3; i >=1 ; i--)
            {
                for (int j = n / 2 ;
                         j >= i + 1; j--)
                {
                    int k = n - i - j;
                    if (i * i + j * j == k * k)
                    {
                        return i * j * k;
                    }
                }
            }
            return -1;
        }
    }
}
