using AutomationAPI.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutomationAPI
{
    [TestClass]
    public class HttpRequestManagerTests
    {
        #region Smoke Test
        [TestMethod]
        public async Task GetEpisodesWith200StatusCode()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://rickandmortyapi.com/api/episode"));
            HttpResponseMessage response = await HttpRequestManager.Request(request);
            Assert.AreEqual((int)response.StatusCode, 200);
        }

        [TestMethod]
        public async Task GetEpisodeWith200StatusCode()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://rickandmortyapi.com/api/episode/51"));
            HttpResponseMessage response = await HttpRequestManager.Request(request);
            Assert.AreEqual((int)response.StatusCode, 200);
        }
        #endregion
    }
}