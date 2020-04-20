using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitiveCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Modified_Kaprekar_Numbers.Start(args);
            watch.Stop();
            Console.WriteLine(TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds).TotalSeconds);
        }
    }
}
