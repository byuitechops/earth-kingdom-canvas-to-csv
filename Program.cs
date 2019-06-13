using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace first_C__project
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string token = System.Environment.GetEnvironmentVariable("CANVAS_API_TOKEN");
            string api_call = args[0];
            string url = "https://byui.instructure.com/api/v1/courses/20414/quizzes";
            string result = await HTTPHelper.MakeHTTPRequest(url, token);
            System.IO.File.WriteAllText("res.json", result);

        }
    }
}