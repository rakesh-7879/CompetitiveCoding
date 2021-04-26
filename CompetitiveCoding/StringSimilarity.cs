using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    class StringSimilarity
    {
        static int stringSimilarity(string s)
        {
            int length = s.Length;
            int count = length;
            for (int i = 1; i < length; i++)
            {
                var len = length - i;
                var result = s.Where((x, index) => index < len && x == s[index + i]).Count();
                Console.Write(result);
                count += result;
            }
            return count;

        }

        public static void Start()
        {

            int t = 2;

            string s = "ababaa";

            int result = stringSimilarity(s);

            Console.WriteLine(result);

        }
    }
}
