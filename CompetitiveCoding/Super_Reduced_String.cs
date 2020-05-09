using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Super_Reduced_String
    {
        // Complete the superReducedString function below.
        static string superReducedString(string s)
        {
            var count = 0;
            var stringList = s.Select(x => x).ToList();
            do
            {
                count = 0;
                var temp = '-';
                for(var i= 0;i < stringList.Count();i++)
                {
                    if (temp == '-')
                    {
                        temp = stringList[i];
                    }
                    else if (temp == stringList[i])
                    {
                        temp = '-';
                        stringList.RemoveAt(i - 1);
                        stringList.RemoveAt(i -1);
                        count++;
                    }
                    else if(temp != stringList[i]) 
                    {
                        temp = stringList[i];
                    }
                }
            } while (count > 0);
            
            if(stringList.Count() == 0)
            {
                return "Empty String";
            }
            return string.Join("", stringList);
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\super_reduced_string.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                string s = streamReader.ReadLine();

                string result = superReducedString(s);

                Console.WriteLine(result);
            }
        }
    }
}
