using System;
using System.Collections.Generic;
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
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;
        }
    }
}
