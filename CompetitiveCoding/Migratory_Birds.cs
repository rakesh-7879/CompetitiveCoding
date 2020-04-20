using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class BirdCount
    {
        public int BirdID { get; set; }
        public int Count { get; set; }
    }
    public class Migratory_Birds
    {
        static int migratoryBirds(List<int> arr)
        {
            var birds = arr.Distinct().Select(x => new BirdCount
            {
                BirdID = x,
                Count = 0
            }).ToList();
            foreach (var bird in birds)
            {
                bird.Count = arr.Where(x => x == bird.BirdID).Count();
            }
            birds = birds.OrderByDescending(x => x.Count).ToList();
            return birds.Where(x => x.Count == birds.Select(x => x.Count).Max()).Select(x => x.BirdID).Max();
        }
        public static void Start(string[] args)
        {
            int arrCount = Convert.ToInt32(6);

            List<int> arr = "1 4 4 4 5 3".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }
    }
}
