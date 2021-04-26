using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0008LargestProductInASeries
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string num = Console.ReadLine();
                var arr = GetArr(num, k);
                var res = 0;
                foreach (var item in arr)
                {
                    var digitArr = item.Select(x => (int)x -'0').OrderBy(x => x);
                    var multi = digitArr.FirstOrDefault();
                    foreach (var digit in digitArr.Skip(1))
                    {
                        multi *= digit;
                    }
                    if (multi > res)
                    {
                        res = multi;
                    }
                }
                Console.WriteLine(res);
            }
        }

        public static List<string> GetArr(string number,int k)
        {
            List<string> arr=new List<string>();
            var numStr = number.ToString();
            for(int i =0;i <= numStr.Length - k; i++)
            {
                arr.Add(numStr.Substring(i, k));
            }
            return arr;
        }

    }
}
