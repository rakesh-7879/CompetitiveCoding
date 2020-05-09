using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Counting_Road_Networks
    {
        //TODO
        static long CountWays(int n)
        {
            return 1;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\counting_road_networks.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int q = Convert.ToInt32(streamReader.ReadLine());

                for (int qItr = 0; qItr < q; qItr++)
                {
                    int n = Convert.ToInt32(streamReader.ReadLine());
                    Console.WriteLine(CountWays(n));
                }
            }
        }
    }
}
