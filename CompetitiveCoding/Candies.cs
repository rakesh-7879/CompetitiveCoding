using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding
{
    public class Candies
    {
        static long candies(int n, int[] arr)
        {
            if (n == 0)
                return 0;

            int[] leftToRight = new int[n];
            int[] rightToLeft = new int[n];
            long sum;

            leftToRight[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                    leftToRight[i] = leftToRight[i - 1] + 1;
                else
                    leftToRight[i] = 1;
            }

            sum = leftToRight[n - 1];
            rightToLeft[n - 1] = 1;

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                    rightToLeft[i] = rightToLeft[i + 1] + 1;
                else
                    rightToLeft[i] = 1;
                sum += (leftToRight[i] > rightToLeft[i] ? leftToRight[i] : rightToLeft[i]);
            }

            foreach(var i in leftToRight)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            foreach (var i in rightToLeft)
            {
                Console.Write(i + ",");
            }

            return sum;
        }

        public static void Start()
        {
            int[] arr= { 2,4,2,6,1,7,8,9,2,1 };

            long result = candies(10, arr);

            Console.WriteLine(result);
        }
    }
}
