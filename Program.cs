using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace first_C__project
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string api_token = System.Environment.GetEnvironmentVariable("CANVAS_API_TOKEN");
            string queryString = args.Length != 0 ? args[0] : "/api/v1/courses/80/users";
            string result = await HTTPHelper.MakeHTTPRequest(queryString, api_token);
            dynamic data = JsonConvert.DeserializeObject(result);
            List<dynamic> json = new List<dynamic>();
            if (data is Array)
            {
                foreach (var prop in data)
                {
                    json.Add(prop);
                }
            }
            else
            {
                json.Add(data);
            }
            json.ForEach(i => Console.Write(i));
            // Processor.CsvFileProcessor(json);
            //System.IO.File.WriteAllText("res.json", json);
        }
    }
}