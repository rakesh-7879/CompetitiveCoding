using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class PickingNumbers
    {
        static bool Compare(int a,int b)
        {
            if (a == b || a - b == 1 || b - a == 1)
                return true;
            else
                return false;
        }
        public static int pickingNumbers(List<int> a)
        {
            var subCount =new List<int>();
            var temp = 0;var prev=a[0];
            for (int i = 0; i < a.Count()-1; i++)
            {
                if (Compare(prev, a[i + 1]))
                {
                    prev = a[i];
                    temp++;
                }
                
            }
            return temp;
        }

        public static void Start()
        {
            var result =pickingNumbers(new List<int> { 4, 6, 5, 3, 3, 1 });
            Console.WriteLine(result);
        }
    }
}
