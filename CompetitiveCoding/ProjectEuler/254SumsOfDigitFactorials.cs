using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _254SumsOfDigitFactorials
    {
        public static void Start()
        {
            var q = Int32.Parse(Console.ReadLine());
            for(int cs = 0; cs < q; cs++)
            {
                var query = Console.ReadLine();
                var n = Int64.Parse(query.Split(" ").FirstOrDefault());
                var m = Int64.Parse(query.Split(" ").LastOrDefault());

                long result = 0;
                for(int i = 1; i <= n; i++)
                {
                    var g_of_i = G(i);
                    var sg_of_i = Sum(g_of_i);
                    result += sg_of_i;
                    Console.Write(" > " + result);
                }
                Console.WriteLine(result);
            }
        }

        public static long Factorial(long num)
        {
            long fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public static long Sum(long num)
        {
            long sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public static long G(long num)
        {
            long res = 1;
            long temp = 1;
            long s_f_of_num = 0;
            while(s_f_of_num != num)
            {
                var f_of_N = Factorial(temp);
                s_f_of_num = Sum(f_of_N);
                if(s_f_of_num == num)
                {
                    res = temp;
                    break;
                }
                temp += 1;
            }
            return res;
        }
    }
}
