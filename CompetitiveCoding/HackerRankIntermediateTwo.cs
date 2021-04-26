using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class HackerRankIntermediateTwo
    {
        public static long taskOfPairing(List<long> freq)
        {
            var remain = false;
            long result = 0;
            for(int i = 1; i <= freq.Count(); i++)
            {
                var num = freq[i - 1];
                if (remain && num > 0)
                {
                    remain = false;
                    num--;
                    result++;
                }
                if (num % 2 != 0 && num > 1)
                {
                    remain= true;
                    result += (num - 1) / 2;
                }
                else if(num >1)
                {
                    result += num / 2;
                }
            }
            return result;
        }

        public static void Start()
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\hacker-rank-intermediate-two.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int q = Convert.ToInt32(streamReader.ReadLine());

                var freq = new List<long>();
                for (int qItr = 0; qItr < q; qItr++)
                {
                     freq.Add(long.Parse(streamReader.ReadLine()));
                }
                Console.WriteLine(taskOfPairing(freq));

            }
        }
    }
}
