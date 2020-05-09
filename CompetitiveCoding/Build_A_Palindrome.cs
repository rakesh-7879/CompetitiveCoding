using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Build_A_Palindrome
    {
        static string buildPalindrome(string a, string b)
        {
            var subStr1 = (from i in Enumerable.Range(0, a.Length)
                         from j in Enumerable.Range(0, a.Length - i + 1)
                         where j >= 1
                         select a.Substring(i, j)).Distinct();

            var subStr2 = (from i in Enumerable.Range(0, b.Length)
                           from j in Enumerable.Range(0, b.Length - i + 1)
                           where j >= 1
                           select b.Substring(i, j)).Distinct();
            Console.WriteLine(string.Join(",", subStr1));
            Console.WriteLine(string.Join(",", subStr2));
            return "";

        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\build_a_palindrome.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int t = Convert.ToInt32(streamReader.ReadLine());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    string a = streamReader.ReadLine();

                    string b = streamReader.ReadLine();

                    string result = buildPalindrome(a, b);

                    Console.WriteLine(result);
                }
            }
        }
    }
}
