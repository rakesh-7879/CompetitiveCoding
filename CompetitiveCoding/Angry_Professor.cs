using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompetitiveCoding
{
    class Angry_Professor
    {
        // Complete the angryProfessor function below.
        static string angryProfessor(int k, int[] a)
        {

            return "";
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\determining_dna_health.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int t = Convert.ToInt32(streamReader.ReadLine());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    string[] nk = streamReader.ReadLine().Split(' ');

                    int n = Convert.ToInt32(nk[0]);

                    int k = Convert.ToInt32(nk[1]);

                    int[] a = Array.ConvertAll(streamReader.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                    ;
                    string result = angryProfessor(k, a);

                    Console.WriteLine(result);

                }
            }
        }
    }
}
