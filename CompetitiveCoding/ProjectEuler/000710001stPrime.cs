using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _000710001stPrime
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var result = 0;
                for (int num = 1; n > 0; num++)
                {
                    if (CheckPrime(num))
                    {
                        result = num;
                        n--;
                    }
                }
                Console.WriteLine(result);
            }
        }

        static bool CheckPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number == 3) return true;
            var numbers = Enumerable.Range(2, (number / 2));
            return !numbers.Any(x => number % x == 0);
        }
    }
}
