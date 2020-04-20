using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Electronics_Shop
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var res = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] <= b)
                        res = new int[] { res, keyboards[i] + drives[j] }.Max();
                }
            }
            return res;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\electronics_shop.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string[] bnm = streamReader.ReadLine().Split(' ');

                int b = Convert.ToInt32(bnm[0]);

                int n = Convert.ToInt32(bnm[1]);

                int m = Convert.ToInt32(bnm[2]);

                int[] keyboards = Array.ConvertAll(streamReader.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
                ;

                int[] drives = Array.ConvertAll(streamReader.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
                ;
                /*
                 * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
                 */

                int moneySpent = getMoneySpent(keyboards, drives, b);

                Console.WriteLine(moneySpent);
            }
        }
    }
}
