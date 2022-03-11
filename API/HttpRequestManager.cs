using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutomationAPI.API
{
    internal class HttpRequestManager
    {
        private string url = "http://localhost:9093";

        public async Task<HttpResponseMessage> MakeRequest(string verb, string endpoint, HttpContent? data = null)
        {
            HttpClient client = new HttpClient();
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
