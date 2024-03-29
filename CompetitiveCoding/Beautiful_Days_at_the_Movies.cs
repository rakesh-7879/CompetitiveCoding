﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Beautiful_Days_at_the_Movies
    {
        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            var count = 0;
            for(int start = i; start <= j; start++)
            {
                var result = (decimal) (start - GetReverse(start)) / k;
                if(result == (int)result)
                {
                    count++;
                }
            }
            return count;
        }

        static int GetReverse(int num)
        {
            var reverse = 0;
            while (num > 0)
            {
                var remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            return reverse;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\beautiful_days_at_the_movies.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string[] ijk = streamReader.ReadLine().Split(' ');

                int i = Convert.ToInt32(ijk[0]);

                int j = Convert.ToInt32(ijk[1]);

                int k = Convert.ToInt32(ijk[2]);

                int result = beautifulDays(i, j, k);

                Console.WriteLine(result);
            }
        }
    }
}
