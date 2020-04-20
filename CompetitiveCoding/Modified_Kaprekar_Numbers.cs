using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Modified_Kaprekar_Numbers
    {
        // Complete the kaprekarNumbers function below.
        static void kaprekarNumbers(int p, int q)
        {
            // TODO
            List<int> result = new List<int>();
            while (p <= q)
            {
                var numArr = p.ToString().Select(x => int.Parse(x.ToString())).ToArray();
                var squreArr = (p * p).ToString().Select(x => int.Parse(x.ToString())).ToArray();
                if (2 * numArr.Length == squreArr.Length || (2 * numArr.Length) - 1 == squreArr.Length)
                {
                }
                p++;
            }
            Console.WriteLine(string.Join(" ",result));
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\modified_kaprekar_numbers.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int p = Convert.ToInt32(streamReader.ReadLine());

                int q = Convert.ToInt32(streamReader.ReadLine());

                kaprekarNumbers(p, q);
            }
        }
    }
}
