using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding
{
    public class DayOfTheProgrammer
    {
        public static string DayOfProgrammer(int year)
        {
            var date = 0;
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                date = 13;
            }
            else
            {
                //date = 12;
            }
            return $"{date}.09.{year}";
        }

        public static void Start()
        {
            var total = DayOfProgrammer(1800);
            Console.WriteLine(total);
        }
    }
}
