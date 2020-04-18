using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Migratory_Birds.Start(args);
            watch.Stop();
            Console.WriteLine(TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds).TotalSeconds);
        }
    }
}
