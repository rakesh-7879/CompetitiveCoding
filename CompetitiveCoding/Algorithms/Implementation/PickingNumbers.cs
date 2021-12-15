using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.Algorithms.Implementation
{
    public class PickingNumbers
    {
        public static int pickingNumbers(List<int> a)
        {
            var ans = 0;
            for(var i = 0; i < a.Count() -1; i++)
            {
                if(a[i] - a[i+1] > 0)
                {
                    ans = a[i] + a[i + 1];
                }
            }
            return ans;
        }


        public static void Start()
        {
            var result = pickingNumbers(new List<int> { 4, 6, 5, 3, 3, 1 });
            Console.WriteLine(result);
        }
    }
}
