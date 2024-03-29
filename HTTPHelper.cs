using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace first_C__project
{
    public class HTTPHelper
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<string> MakeHTTPRequest(string queryString, string api_token)
        {
            using (client)
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", api_token);
                // Call asynchronous network methods in a try/catch block to handle exceptions
                try
                {
                    if (queryString[0] != '/')
                    {
                        queryString = "/" + queryString;
                    }
                    string url = "https://byui.instructure.com" + queryString;
                    // HttpResponseMessage response = await client.GetAsync(url);
                    // response.EnsureSuccessStatusCode();
                    // string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    string responseBody = await client.GetStringAsync(url);

                    return responseBody;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("There was an error: " + e.Message);
                    throw;
                }
            }
        }
    }
}