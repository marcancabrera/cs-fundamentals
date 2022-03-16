using AutomationAPI.API;
using AutomationAPI.API.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
            HttpRequestManager mockRequestManager = new HttpRequestManager("https://rickandmortyapi.com/api");
            HttpResponseMessage response = await mockRequestManager.MakeRequest("GET", "episode");
            var content = await response.Content.ReadAsStringAsync();
            Episodes episodes = JsonSerializer.Deserialize<Episodes>(content);
            Assert.AreEqual((int)response.StatusCode, 200);
        }

        [TestMethod]
        public async Task GetEpisode51Succeeded()
        {
            HttpRequestManager mockRequestManager = new HttpRequestManager("https://rickandmortyapi.com/api");
            HttpResponseMessage response = await mockRequestManager.MakeRequest("GET", "episode/51");
            var content = await response.Content.ReadAsStringAsync();
            Episode episode = JsonSerializer.Deserialize<Episode>(content);
            Assert.AreEqual((int)response.StatusCode, 200);
            Assert.IsNotNull(episode.episode);
        }
        #endregion
    }
}