using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding
{
    public class DrawingBook
    {
        /*
     * Complete the pageCount function below.
     */
        static int pageCount(int n, int p)
        {
            n /= 2;
            p /= 2;

            return Math.Min(p,n-p) >= 0 ? Math.Min(p, n- p) : Math.Min(p, n-p);
        }

        public static void Start()
        {

            int n = 6;

            int p = 2;

            int result = pageCount(n, p);

            Console.WriteLine(result);

        }
    }
}
