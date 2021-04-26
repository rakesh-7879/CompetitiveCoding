using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0002EvenFibonacciNumbers
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                long result = 0,ord1 = 0, ord2 = 0, ord3 = 0;
                for (long i = 0; ; i++)
                {
                    ord1 = i == 1 ? 0 : ord2;
                    ord2 = i == 1 ? 1 : ord3;
                    ord3 = i == 1 ? 0 : ord1 + ord2;
                    if (ord3 > n)
                        break;
                    else if (ord3 % 2 == 0)
                        result += ord3;
                }
                Console.WriteLine(result);
            }
        }
    }
}
