using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.ProjectEuler
{
    public class _0014LongestCollatzSequence
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var numbers = new List<int>();
            for (int a0 = 0; a0 < t; a0++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var preProcess = new List<Step>();

            for (var i = 1; i <= numbers.Max(); i++)
            {
                var temp = i;
                var steps = 0;
                while (temp != 1)
                {
                    temp = temp % 2 == 0 ? temp / 2 : (3 * temp) + 1;
                    steps++;
                }
                preProcess.Add(new Step { Number = i, Steps = steps });
            }

            foreach (var number in numbers)
            {
                var subSet = preProcess.Take(number);
                var max = subSet.Max(x => x.Steps);
                Console.WriteLine(subSet.Where(x => x.Steps == max).LastOrDefault().Number);
            }
        }

        public class Step
        {
            public int Number { get; set; }
            public int Steps { get; set; }
        }
    }
}
