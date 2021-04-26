using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class CommonChild
    {

        static int commonChild(string s1, string s2)
        {
            var memo = new int[s2.Length + 1];

            for (int i = 1; i <= s1.Length; i++)
            {
                int prev = 0;
                for (int j = 1; j <= s2.Length; j++)
                {
                    int temp = memo[j];
                    if (s1[i - 1] == s2[j - 1])
                    {
                        memo[j] = prev + 1;
                    }
                    else
                    {
                        memo[j] = Math.Max(memo[j], memo[j - 1]);
                    }
                    prev = temp;
                }
            }
            return memo[s2.Length];

        }

        public static void Start()
        {
            
            string s1 = "ABCDEF";

            string s2 = "FBDAMN";

            int result = commonChild(s1, s2);

            Console.WriteLine(result);
        }
    }
}
