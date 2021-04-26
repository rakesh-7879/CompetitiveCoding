using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class SubarrayDivision
    {

        static int birthday(List<int> s, int d, int m)
        {
            var result = 0;
            for(var i = 0; i < s.Count() - m +1; i++)
            {
                if(s.Skip(i).Take(m).Sum() == d)
                {
                    result++;
                }
            }
            return result;
        }

        public static void Start()
        {
            List<int> s = new List<int>
            {
                4
            };

            int d = 4;
            int m = 1;

            int result = birthday(s, d, m);
            Console.WriteLine(result);
        }
    }
}
