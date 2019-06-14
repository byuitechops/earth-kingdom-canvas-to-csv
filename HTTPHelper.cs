using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace first_C__project
{
    public class HTTPHelper
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<string> MakeHTTPRequest(string url, string token)
        {
            using (client)
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                // Call asynchronous network methods in a try/catch block to handle exceptions
                try
                {
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