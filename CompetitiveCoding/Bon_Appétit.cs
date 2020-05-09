using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Bon_Appétit
    {
        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            if ((bill.Sum()-bill[k]) / 2 == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - (bill.Sum() - bill[k]) / 2);
            }

        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\Bon Appétit.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string[] nk = streamReader.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                List<int> bill = streamReader.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

                int b = Convert.ToInt32(streamReader.ReadLine().Trim());

                bonAppetit(bill, k, b);
            }
        }
    }
}
