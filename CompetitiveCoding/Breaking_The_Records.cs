using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompetitiveCoding
{
    public class Breaking_The_Records
    {
        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int[] result = new int[2];
            var max = scores[0]; var min = scores[0];
            for(int i = 0; i < scores.Length; i++)
            {
                if (max < scores[i])
                {
                    max = scores[i];
                    result[0]++;
                }
                if (min > scores[i])
                {
                    min = scores[i];
                    result[1]++;
                }
            }
            return result;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\breaking_the_records.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int n = Convert.ToInt32(streamReader.ReadLine());

                int[] scores = Array.ConvertAll(streamReader.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
                ;
                int[] result = breakingRecords(scores);

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
