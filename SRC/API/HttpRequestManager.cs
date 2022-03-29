using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutomationAPI.API
{
    internal class HttpRequestManager
    {
        private static HttpClient client = new HttpClient();

        public static async Task<HttpResponseMessage> Request(HttpRequestMessage httpRequestMessage)
        {
            var request = await client.SendAsync(httpRequestMessage);
            return request;
        }
    }
}
