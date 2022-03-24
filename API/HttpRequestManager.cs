using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutomationAPI.API
{
    internal class HttpRequestManager
    {
        private static string url;
        private static HttpClient client = new HttpClient();

        public static async Task<HttpResponseMessage> Request(HttpRequestMessage httpRequestMessage)
        {
            var request = await client.SendAsync(httpRequestMessage);
            return request;
        }

        public static async Task<HttpResponseMessage> MakeRequest(string verb, string endpoint, HttpContent? data = null)
        {
            url = $"{url}/{endpoint}";
            HttpResponseMessage response;
            switch (verb)
            {
                case "GET":
                    response = await client.GetAsync(url);
                    break;
                case "POST":
                    response = await client.PostAsync(url, data);
                    break;
                case "PUT":
                    response = await client.PutAsync(url, data);
                    break;
                case "DELETE":
                    response = await client.DeleteAsync(url);
                    break;
                default:
                    throw new Exception("Verb doesn't exist");
            }
            return response;
        }
    }
}
