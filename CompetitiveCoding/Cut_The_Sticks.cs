using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Cut_The_Sticks
    {
        // Complete the cutTheSticks function below.
        static int[] cutTheSticks(int[] arr)
        {
            var result = new List<int>();
            while(arr.Where(x=>x > 0).Count() > 0)
            {
                var count = 0;
                var min = arr.Where(x=>x !=0).Min();
                result.Add(arr.Where(x => x > 0).Count());
                Console.WriteLine(arr.Where(x => x > 0).Count());
                arr = arr.Where(x=>x > 0).Select(x => x - min).ToArray();
            }
            return result.ToArray();
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\cut_the_sticks.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                int n = Convert.ToInt32(streamReader.ReadLine());

                int[] arr = Array.ConvertAll(streamReader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
                int[] result = cutTheSticks(arr);

                Console.WriteLine(string.Join("\n", result));

            }
        }
    }
}
