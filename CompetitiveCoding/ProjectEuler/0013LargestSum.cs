using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0013LargestSum
    {
        public static void Start()
        {
            int t = 5;
            var inputNumbers = new List<string>()
            {
                "37107287533902102798797998220837590246510135740250",
                "46376937677490009712648124896970078050417018260538",
                "74324986199524741059474233309513058123726617309629",
                "91942213363574161572522430563301811072406154908250",
                "23067588207539346171171980310421047513778063246676"
            };

            var sum = new List<int>();
            var remainder = 0;
            var reverseNumbers = new List<List<int>>();
            foreach(var item in inputNumbers)
            {
                var arr = item.Select(x => int.Parse(x.ToString())).Reverse();
                reverseNumbers.Add(arr.ToList());
            }

            for (var i = 0; i < 50; i++)
            {
                var subTotal = reverseNumbers.Sum(x => x.ElementAt(i)) + remainder;
                sum.Add(subTotal % 10);
                remainder = (int)subTotal / 10;
            }
            sum.AddRange(remainder.ToString().Select(x => int.Parse(x.ToString())).Reverse().ToList());
            sum.Reverse();
            Console.WriteLine(string.Join("", sum.Take(10)));
        }
    }
}
