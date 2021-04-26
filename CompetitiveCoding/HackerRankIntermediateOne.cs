using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class HackerRankIntermediateOne
    {
        public static List<long> GetMaxArea(int w, int h, List<bool> boundaryType, List<int> boundaryDist)
        {
            var bountriesW = new List<int>() { 0,w };
            var bountriesH = new List<int>() { 0,h};
            var result = new List<long>();
            var wIndex = 1;var hIndex = 1;

            for(int count=0;count < boundaryType.Count(); count++)
            {
                if (boundaryType[count])
                {
                    bountriesW.Insert(wIndex++, boundaryDist[count]);
                }
                else
                {
                    bountriesH.Insert(hIndex, boundaryDist[count]);
                }

                var maxW = w;
                if (bountriesW.Count()>2)
                {
                    var wDif = new List<int>();
                    for(var i = 1; i < bountriesW.Count(); i++)
                    {
                        wDif.Add(bountriesW[i] - bountriesW[i - 1]);
                    }
                    maxW = wDif.Max();
                }
                var maxH =  h ;
                if (bountriesH.Count() > 2)
                {
                    var hDif = new List<int>();
                    for (var i = 1; i < bountriesH.Count(); i++)
                    {
                        hDif.Add(bountriesH[i] - bountriesH[i - 1]);
                    }
                    maxH = hDif.Max();
                }
                result.Add(maxW * maxH);
            }

            return result;
        }
        public static void Start()
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\hacker-rank-intermediate-one.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int w = Convert.ToInt32(streamReader.ReadLine());
                int h = Convert.ToInt32(streamReader.ReadLine());

                int n1 = Convert.ToInt32(streamReader.ReadLine());
                var boundaryType = new List<bool>();
                for (int qItr = 0; qItr < n1; qItr++)
                {
                    bool n = Convert.ToBoolean(Convert.ToInt32(streamReader.ReadLine()));
                    boundaryType.Add(n);
                }

                int n2 = Convert.ToInt32(streamReader.ReadLine());
                var boundaryDist = new List<int>();
                for (int qItr = 0; qItr < n2; qItr++)
                {
                    int n = Convert.ToInt32(streamReader.ReadLine());
                    boundaryDist.Add(n);
                }

                var results = GetMaxArea(w, h, boundaryType, boundaryDist);
                foreach(var result in results)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
