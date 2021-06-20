using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CompetitiveCoding.RestApi
{
    public class RestApiIntermediateCompetitionWInnerGoals
    {

        public static int getWinnerTotalGoals(string competition, int year)
        {
            var comResponse = Get($"https://jsonmock.hackerrank.com/api/football_competitions?year={year}&name={competition}");
            JObject comJoResponse = JObject.Parse(comResponse);
            JArray comArray = (JArray)comJoResponse["data"];
            if(comArray.Count > 0)
            {
                var team = comArray.SingleOrDefault()["winner"];
                var result = 0;
                {
                    var asResponse1 = Get($"https://jsonmock.hackerrank.com/api/football_matches?competition={competition}&year={year}&team1={team}&page=1");
                    JObject asJoResponse1 = JObject.Parse(asResponse1);
                    int asTotalNumberOfPages1 = (int)asJoResponse1["total_pages"];
                    JArray asTeam1 = (JArray)asJoResponse1["data"];
                    result += asTeam1.Sum(x => (int)x["team1goals"]);
                    for (var i = 2; i <= asTotalNumberOfPages1; i++)
                    {
                        var asResponse = Get($"https://jsonmock.hackerrank.com/api/football_matches?competition={competition}&year={year}&team1={team}&page={i}");
                        JObject asJoResponse = JObject.Parse(asResponse);
                        int asTotalNumberOfPages = (int)asJoResponse["total_pages"];
                        JArray asTeam = (JArray)asJoResponse["data"];
                        result += asTeam.Sum(x => (int)x["team1goals"]);
                    }
                }
                {
                    var asResponse2 = Get($"https://jsonmock.hackerrank.com/api/football_matches?competition={competition}&year={year}&team2={team}&page=1");
                    JObject asJoResponse2 = JObject.Parse(asResponse2);
                    int asTotalNumberOfPages2 = (int)asJoResponse2["total_pages"];
                    JArray asTeam2 = (JArray)asJoResponse2["data"];
                    result += asTeam2.Sum(x => (int)x["team2goals"]);
                    for (var i = 2; i <= asTotalNumberOfPages2; i++)
                    {
                        var asResponse = Get($"https://jsonmock.hackerrank.com/api/football_matches?competition={competition}&year={year}&team2={team}&page={i}");
                        JObject asJoResponse = JObject.Parse(asResponse);
                        int asTotalNumberOfPages = (int)asJoResponse["total_pages"];
                        JArray asTeam = (JArray)asJoResponse["data"];
                        result += asTeam.Sum(x => (int)x["team2goals"]);
                    }
                }
                return result;
            }
            else
            {
                return 0;
            }
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
            Console.WriteLine(getWinnerTotalGoals("UEFA Champions League", 2011));
        }
    }
}
