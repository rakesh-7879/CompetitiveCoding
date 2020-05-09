using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Find_Strings
    {
        static string[] findStrings(string[] w, int[] queries)
        {
            var list = new List<string>();var result = new List<string>();
            foreach(var word in w)
            {
                for(var i = 1; i <= word.Length; i++)
                {
                    for(var j= 0;j<=word.Length -i; j++)
                    {
                        list.Add(word.Substring(j, i));
                    }
                }
            }
            list = list.Distinct().OrderBy(x => x).ToList();
            foreach(var query in queries)
            {
                if(query <= list.Count())
                {
                    result.Add(list[query-1]);
                }
                else
                {
                    result.Add("INVALID");
                }
                
            }
            return result.ToArray();
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\find_strings.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                int wCount = Convert.ToInt32(streamReader.ReadLine());

                string[] w = new string[wCount];

                for (int wItr = 0; wItr < wCount; wItr++)
                {
                    string wItem = streamReader.ReadLine();
                    w[wItr] = wItem;
                }

                int queriesCount = Convert.ToInt32(streamReader.ReadLine());

                int[] queries = new int[queriesCount];

                for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++)
                {
                    int queriesItem = Convert.ToInt32(streamReader.ReadLine());
                    queries[queriesItr] = queriesItem;
                }

                string[] result = findStrings(w, queries);

                Console.WriteLine(string.Join("\n", result));

            }
        }
    }
}
