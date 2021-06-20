using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CompetitiveCoding.RestApi
{
    public class RestApiIntermediateNumberOfDrawnMatches
    {
        public static int getNumDraws(int year)
        {
            var result = 0;
            var response = Get($"https://jsonmock.hackerrank.com/api/football_matches?year={year}&page=1&team1goals=0&team2goals=0");
            JObject joResponse = JObject.Parse(response);
            result += (int)joResponse["total"];

            for (var i = 1; i <= 10; i++)
            {
                var asResponse = Get($"https://jsonmock.hackerrank.com/api/football_matches?year={year}&page=1&team1goals={i}&team2goals={i}");
                JObject asJoResponse = JObject.Parse(asResponse);
                result += (int)asJoResponse["total"];
            }
            return result;
        }

        public static string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static void Start()
        {
            Console.WriteLine(getNumDraws(2011));
        }
    }
}
