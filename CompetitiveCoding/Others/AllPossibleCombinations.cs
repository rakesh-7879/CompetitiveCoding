using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding.Others
{
    public class AllPossibleCombinations
    {
        public static void Start()
        {
            GetCombination(new List<int> { 1, 2, 3, 4, 5 });
        }

        static void GetCombination(List<int> list)
        {
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        Console.Write(list[j]);
                    }
                }
                Console.WriteLine();
            }
        }

        //static void GetCombination(List<int> list)
        //{
        //    double count = Math.Pow(2, list.Count);
        //    for (int i = 1; i <= count - 1; i++)
        //    {
        //        string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
        //        for (int j = 0; j < str.Length; j++)
        //        {
        //            if (str[j] == '1')
        //            {
        //                Console.Write(list[j]);
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
