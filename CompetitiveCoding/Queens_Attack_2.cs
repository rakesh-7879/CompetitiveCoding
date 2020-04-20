using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompetitiveCoding
{
    class Queens_Attack_2
    {
        // Complete the queensAttack function below.
        static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {
            int d11, d12, d21, d22, r1, r2, c1, c2;

            d11 = Math.Min(r_q - 1, c_q - 1);
            d12 = Math.Min(n - r_q, n - c_q);
            d21 = Math.Min(n - r_q, c_q - 1);
            d22 = Math.Min(r_q - 1, n - c_q);

            r1 = c_q - 1;
            r2 = n - c_q;
            c1 = r_q - 1;
            c2 = n - r_q;

            for (int i = 0; i < k; i++)
            {
                if (r_q > obstacles[i][0] && c_q > obstacles[i][1] &&
                        r_q - obstacles[i][0] == r_q - obstacles[i][1])
                    d11 = Math.Min(d11, r_q - obstacles[i][0] - 1);

                if (obstacles[i][0] > r_q && obstacles[i][1] > c_q &&
                        obstacles[i][0] - r_q == obstacles[i][1] - c_q)
                    d12 = Math.Min(d12, obstacles[i][0] - r_q - 1);

                if (obstacles[i][0] > r_q && c_q > obstacles[i][1] &&
                        obstacles[i][0] - r_q == c_q - obstacles[i][1])
                    d21 = Math.Min(d21, obstacles[i][0] - r_q - 1);

                if (r_q > obstacles[i][0] && obstacles[i][1] > c_q &&
                            r_q - obstacles[i][0] == obstacles[i][1] - c_q)
                    d22 = Math.Min(d22, r_q - obstacles[i][0] - 1);

                if (r_q == obstacles[i][0] && obstacles[i][1] < c_q)
                    r1 = Math.Min(r1, c_q - obstacles[i][1] - 1);

                if (r_q == obstacles[i][0] && obstacles[i][1] > c_q)
                    r2 = Math.Min(r2, obstacles[i][1] - c_q - 1);

                if (c_q == obstacles[i][1] && obstacles[i][0] < r_q)
                    c1 = Math.Min(c1, r_q - obstacles[i][0] - 1);

                if (c_q == obstacles[i][1] && obstacles[i][0] > r_q)
                    c2 = Math.Min(c2, obstacles[i][0] - r_q - 1);
            }
            Console.WriteLine(d11 + " " + d12 + " " + d21 + " " + d22 + " " + r1 + " " + r2 + " " + c1 + " " + c2);
            return d11 + d12 + d21 + d22 + r1 + r2 + c1 + c2;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\Queens_Attack_2.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                string[] nk = streamReader.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                string[] r_qC_q = streamReader.ReadLine().Split(' ');

                int r_q = Convert.ToInt32(r_qC_q[0]);

                int c_q = Convert.ToInt32(r_qC_q[1]);

                int[][] obstacles = new int[k][];

                for (int i = 0; i < k; i++)
                {
                    obstacles[i] = Array.ConvertAll(streamReader.ReadLine().Split(' '), obstaclesTemp => Convert.ToInt32(obstaclesTemp));
                }

                int result = queensAttack(n, k, r_q, c_q, obstacles);

                Console.WriteLine(result);
            }
        }
    }
}
