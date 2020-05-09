using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Ashton_And_String
    {
        static char ashtonString(string s, int k)
        {
            var list = new  List<string>();
            for (int i = 1; i < s.Length; i++)
            {
                for (int start = 0; start <= s.Length - i; start++)
                {
                    list.Add(s.Substring(start, i));
                }
            }
            var query = list.Distinct().OrderBy(x=>x);
            var str = string.Concat(query);
            return str[k - 1];
        }

        static char ashtonString2(string s, int k)
        {
            var query = (from i in Enumerable.Range(0, s.Length)
                         from j in Enumerable.Range(0, s.Length - i + 1)
                         where j >= 1
                         select s.Substring(i, j)).Distinct().OrderBy(x => x);
            Console.WriteLine(string.Join(",", query));
            var str = string.Concat(query);
            return str[k - 1];
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\ashton_and_string.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int t = Convert.ToInt32(streamReader.ReadLine());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    string s = streamReader.ReadLine();

                    int k = Convert.ToInt32(streamReader.ReadLine());

                    char res = ashtonString(s, k);

                    Console.WriteLine(res);
                }
            }
        }
    }
}
