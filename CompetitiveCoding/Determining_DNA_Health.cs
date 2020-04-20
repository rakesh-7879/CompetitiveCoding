using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CompetitiveCoding
{
    public class Determining_DNA_Health
    {
        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\determining_dna_health.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int n = Convert.ToInt32(streamReader.ReadLine());

                string[] genes = streamReader.ReadLine().Split(' ');

                int[] health = Array.ConvertAll(streamReader.ReadLine().Split(' '), healthTemp => Convert.ToInt32(healthTemp));
                int s = Convert.ToInt32(streamReader.ReadLine());

                long[] results = new long[s];



                for (int sItr = 0; sItr < s; sItr++)
                {
                    long totalHealth = 0;
                    string[] firstLastd = streamReader.ReadLine().Split(' ');

                    int first = Convert.ToInt32(firstLastd[0]);

                    int last = Convert.ToInt32(firstLastd[1]);

                    string d = firstLastd[2];

                    for (var i = first; i <= last; i++)
                    {
                        totalHealth += health[i] * CountSubstring(d, genes[i]);
                    }
                    results[sItr] = totalHealth;
                }
                Console.WriteLine(results.Min() + " " + results.Max());
            }
        }

        static long CountSubstring(string text, string value)
        {
            long count = 0;int minIndex = text.IndexOf(value, 0);
            while (minIndex != -1)
            {
                minIndex = text.IndexOf(value, minIndex + 1);
                count++;
            }
            return count;
        }

    }
}
