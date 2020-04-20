using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Big_Sorting
    {
        // Complete the bigSorting function below.
        static string[] bigSorting(string[] unsorted)
        {
            // or we can only return unsorted.OrderBy(x => x.Length).ThenBy(x=>x).ToArray();
            var sortByLength = unsorted.OrderBy(x => x.Length).ToArray();
            int start = 0, end = 0;
            while (end < unsorted.Length)
            {
                var unsortingSubArray = sortByLength.Where(x => x.Length == sortByLength[start].Length).ToArray();
                end = start + unsortingSubArray.Length;
                for (int i = start; i < end; i++)
                {
                    for (int j = start + 1; j < end; j++)
                    {
                        if (sortByLength[j - 1].CompareTo(sortByLength[j]) == 1)
                        {
                            var temp = sortByLength[j];
                            sortByLength[j] = sortByLength[j - 1];
                            sortByLength[j - 1] = temp;
                        }
                    }
                }
                start = end;
            }
            return sortByLength;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\big_sorting.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int n = Convert.ToInt32(streamReader.ReadLine());

                string[] unsorted = new string[n];

                for (int i = 0; i < n; i++)
                {
                    string unsortedItem = streamReader.ReadLine();
                    unsorted[i] = unsortedItem;
                }

                string[] result = bigSorting(unsorted);

                Console.WriteLine(string.Join("\n", result));
            }
        }
    }
}
