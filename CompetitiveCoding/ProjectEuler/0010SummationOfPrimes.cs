using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0010SummationOfPrimes
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int sum = 0;
                var numArr = Enumerable.Range(2, n - 1 ).Where(x =>( x % 2 != 0 && x % 3 != 0 && x % 5 != 0) || x == 2 || x == 3 || x == 5);
                foreach (var num in numArr)
                {
                    if (checkPrime(num))
                    {
                        sum += num;
                    }
                }
                Console.WriteLine(sum);
            }
        }

        public static bool checkPrime(int n)
        {
            int range = n;
            for (int i = 2; i < range; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                range = n / i;
            }
            return true;
        }

    }
}
