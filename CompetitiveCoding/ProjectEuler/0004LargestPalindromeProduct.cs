using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0004LargestPalindromeProduct
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int upper_limit = 999;
                int lower_limit = 100;

                int max_product = 101101;

                for (int i = upper_limit; i >= lower_limit; i--)
                {
                    for (int j = i; j >= lower_limit; j--)
                    {
                        int product = i * j;
                        if (product < max_product)
                            break;
                        int number = product;
                        int reverse = 0;

                        
                        while (number != 0)
                        {
                            reverse = reverse * 10 + number % 10;
                            number /= 10;
                        }

                        if (product == reverse && product < n)
                            max_product = product;
                    }
                }
                Console.WriteLine(max_product);
            }
        }
    }
}
