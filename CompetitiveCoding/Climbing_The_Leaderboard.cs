﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Climbing_The_Leaderboard
    {
        // Complete the climbingLeaderboard function below.
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int[] result = new int[alice.Length];
            int[] scoresDis = scores.Distinct().ToArray();
            var length = scoresDis.Length;
            for (int x=0;x<alice.Length;x++)
            {
                if (scoresDis.Last() > alice[x])
                {
                    result[x] = scoresDis.Length+1;
                    continue;
                }
                if(x!=0 && alice[x-1] == alice[x])
                {
                    result[x] = result[x-1];
                    continue;
                }
                var i = 0; var j = length;
                while (i < j)
                {
                    var mid = (int) (j + i) / 2;
                    if (scoresDis[mid] > alice[x])
                    {
                        i = mid+1;
                    }
                    else
                    {
                        j = mid;
                    }
                }
                result[x] = j+1;
                length = j;
            }
            return result;
        }

        public static void Start(string[] args)
        {
            int scoresCount = Convert.ToInt32(200000);

            ;
            int aliceCount = Convert.ToInt32(100000);

            ;
            int[] result = climbingLeaderboard(scores, alice);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}