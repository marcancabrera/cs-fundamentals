using AutomationAPI.API;
using AutomationAPI.API.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutomationAPI
{

    [TestClass]
    public class EpisodeTest
    {
        #region Smoke Test
        [TestMethod]
        public async Task GetEpisodesWith200StatusCode()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://rickandmortyapi.com/api/episode"));
            HttpResponseMessage response = await HttpRequestManager.Request(request);
            var content = await response.Content.ReadAsStringAsync();
            Episodes episodes = JsonSerializer.Deserialize<Episodes>(content);
            Assert.AreEqual((int)response.StatusCode, 200);
        }

        [TestMethod]
        public async Task GetEpisode51Succeeded()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://rickandmortyapi.com/api/episode/51"));
            HttpResponseMessage response = await HttpRequestManager.Request(request);
            var content = await response.Content.ReadAsStringAsync();
            Episode episode = JsonSerializer.Deserialize<Episode>(content);
            Assert.AreEqual((int)response.StatusCode, 200);
            Assert.IsNotNull(episode.episode);
        }
        #endregion
    }
}