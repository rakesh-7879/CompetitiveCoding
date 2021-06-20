using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.CSharpIntermediate
{
    public class LargestArea
    {

        public static List<long> getMaxArea(int w,int h,List<bool> isVertical,List<int> distance)
        {
            var result = new List<long>();
            for(var i = 0; i < isVertical.Count(); i++)
            {
                
            }
            return result;
        }

        public static void Start()
        {
            var result = getMaxArea(4, 4, new List<bool> { false, true }, new List<int> { 3, 1 });

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
