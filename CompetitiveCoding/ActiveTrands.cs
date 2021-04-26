using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    class ActiveTrands
    {
        public static void Trands()
        {
            List<string> customer = new List<string>();
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\active_trands.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                var count = int.Parse(Console.ReadLine());
                for(var i = 0; i < count; i++)
                {
                    customer.Add(streamReader.ReadLine());
                }

                 var minCount = Convert.ToDecimal(count * .05);

                Console.WriteLine(minCount);


                var customerResult = (from c in customer
                                      group c by c into g
                                      where g.Count() >= minCount
                                      select new { C = g.Key, Count = g.Count() }).OrderBy(x=>x.C).ToList();
                foreach(var c in customerResult)
                {
                    Console.WriteLine(c.C + " " + c.Count);
                }

            }
        }
    }
}
