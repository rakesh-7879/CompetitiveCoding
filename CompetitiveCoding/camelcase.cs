using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class camelcase
    {
        // Complete the superReducedString function below.
        static int camelCase(string s)
        {
            return s.Where(x => (int)x >= 65 && x <= 90).Count()+1;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\camelcase.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                string s = streamReader.ReadLine();

                int result = camelCase(s);

                Console.WriteLine(result);
            }
        }
    }
}
