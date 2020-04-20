using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Extra_Long_Factorials
    {
        //TODO
        static void extraLongFactorials(int n)
        {
            List<List<int>> results = new List<List<int>>()
            {
                new List<int>(),
                new List<int>(),
                new List<int>(),
                new List<int>(),
                new List<int>()
            };
            results[0].Add(1);
            for(int a = 1; a <= n; a++)
            {
                var arrForA = a.ToString().Split("").Select(x => int.Parse(x)).ToArray();
                for(int b = 0; b < arrForA.Length; b++)
                {
                    var tempList = new List<int>();
                    for(int c = 0; c < b; c++)
                    {
                        tempList.Add(0);
                    }
                    var remainder = 0; 
                    for(int c = 0; c < results[0].Count(); c++)
                    {
                        var tempMul = arrForA[b] * results[0][c] + remainder;
                        tempList.Add(tempMul % 10);
                        remainder = tempMul / 10;
                    }
                    results[b + 1] = tempList;
                }
                var countList = new List<int>();
                for(int c = 0; c < arrForA.Length; c++)
                {
                    countList.Add(results[c + 1].Count());
                }
                for(int c = 0; c < countList.Max(); c++)
                {
                    var sum = 0;
                    for(int d = 0; d < arrForA.Length; d++)
                    {
                        sum += results[d][c];
                    }
                    var sumArr = sum.ToString().Split("").Select(x => int.Parse(x)).ToArray();
                }
            }


            foreach(var result in results)
            {
                foreach(var item in result)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }

        public static void Start(string[] args)
        {
            int n = Convert.ToInt32(100);

            extraLongFactorials(n);
        }
    }
}
