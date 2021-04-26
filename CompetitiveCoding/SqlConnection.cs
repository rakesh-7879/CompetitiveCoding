using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class SqlConnection
    {
        public static void GetList()
        {
            List<City> cities = new List<City>();
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\citylist.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                
                for (int qItr = 0; qItr < 41758; qItr++)
                {
                    string line = streamReader.ReadLine();
                    var arr = line.Split(',');
                    cities.Add(new City
                    {
                        Name = arr[0],
                        StateCode = arr[1],
                        ZipCode = arr[3]
                    });
                }

                var citiesOnly = from c in cities
                                 group c by c.StateCode into g
                                 select new
                                 {
                                     StateCode = g.Key,
                                     Cities = g.Select(x=>x.Name).Distinct()
                                 };


                StringBuilder stringBuilder = new StringBuilder();

                foreach(var city in citiesOnly)
                {
                    if (string.Join("?", city.Cities).Contains(","))
                    {
                        Console.WriteLine(city.StateCode);
                    }

                    var finalObj = $"{{\"StateCode\":\"{city.StateCode}\",\"Cities\": \"{ string.Join(",", city.Cities) }\"}} , ";
                    stringBuilder.Append(finalObj);
                }

                using (FileStream fs = File.Create(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\citylistjson.txt"))
                {
                    byte[] author = new UTF8Encoding(true).GetBytes(stringBuilder.ToString());
                    fs.Write(author, 0, author.Length);
                }

            }
        }

        class City
        {
            public string Name { get; set; }
            public string ZipCode { get; set; }
            public string StateCode { get; set; }
        }
    }
}
