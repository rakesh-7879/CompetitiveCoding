using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class UnexpectedDemand
    {
        public static int Demand()
        {
            var order = new List<int>(); int k;
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\unexpected_demand.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int q = Convert.ToInt32(streamReader.ReadLine());

                for (int qItr = 0; qItr < q; qItr++)
                {
                    order.Add(Convert.ToInt32(streamReader.ReadLine()));
                }

                k = Convert.ToInt32(streamReader.ReadLine());

                var result = 0;

                var filteredOrder = order.Where(x => x < k).OrderBy(x=>x).ToArray();
                
                if(filteredOrder.Count() != 0)
                {
                    var counter = 0;
                    for(var i = 0; i < filteredOrder.Count(); i++)
                    {
                        counter += filteredOrder[i];
                        if(counter < k)
                        {
                            result++;
                            continue;
                        }
                        break;
                    }
                    return result;
                }
                else
                {
                    return result;
                }


            }
        }
    }
}
