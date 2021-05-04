using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding
{
    public class DayOfTheProgrammer
    {
        static bool IsLeap(int year)
        {
            if (year % 4 != 0) return false;
            if (year > 1918 && year % 100 == 0 && year % 400 != 0) return false;
            return true;

        }

        public static string DayOfProgrammer(int year)
        {
            if (year == 1918) return "26.09.1918";
            if (IsLeap(year)) return "12.09." + year;
            else return "13.09." + year;
        }

        public static void Start()
        {
            var total = DayOfProgrammer(2100);
            Console.WriteLine(total);
        }
    }
}
