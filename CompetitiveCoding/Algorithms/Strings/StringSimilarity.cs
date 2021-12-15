using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.Algorithms.Strings
{
    public class StringSimilarity
    {
        static int stringSimilarity(string s)
        {
            var result = 0;
            // Method 1 8-failed 
            //var subStrs = from i in Enumerable.Range(0, s.Length)
            //              where s[i]== s[0]
            //select s.Substring(i, s.Length - i);

            //foreach(var subStr in subStrs)
            //{
            //    result += (from j in Enumerable.Range(0, subStr.Length)
            //    where  subStr[j] == s[j] && s.StartsWith(subStr.Substring(0,j))
            //    select j).Count();
            //}

            // method 2 4-failded
            var i = 0;
            while (i < s.Length)
            {
                var j = 0;
                while (j < s.Length - i && s[i + j] == s[j])
                {
                    result++;
                    j++;
                }
                var nextIndex = s.IndexOf(s[0], i + 1);
                i = nextIndex != -1 ? nextIndex : i + 1;
            }

            // method 3 5-failed
            //var indexs = s.Select((x, i) => x == s[0] ? i : -1)
            //    .Where(x => x > -1);
            //foreach (var i in indexs)
            //{
            //    for (var j = 0; j < s.Length - i; j++)
            //    {
            //        if (s[i + j] == s[j])
            //        {
            //            result++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            return result;
        }

        public static void Start()
        {
            int result = stringSimilarity("ababaa");
            Console.WriteLine(result);
        }
    }
}
