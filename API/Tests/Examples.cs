using AutomationAPI.API;
using AutomationAPI.API.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace AutomationAPI
{
    [TestClass]
    public class Examples
    {
        #region Smoke Test
        [TestMethod]
        public async Task GetTenEpisodes()
        {
            HttpRequestManager mockRequestManager = new HttpRequestManager("https://rickandmortyapi.com/api");
            HttpResponseMessage response = await mockRequestManager.MakeRequest("GET", "episode");
            var content = await response.Content.ReadAsStringAsync();
            Episodes episodes = JsonSerializer.Deserialize<Episodes>(content);
            IEnumerable<Episode> result = episodes.results
                .Where(episode => episode.id <= 10)
                .OrderBy(episode => episode.name);
            Assert.AreEqual(result.Count(), 10);
        }

        [TestMethod]
        public async Task GroupByName()
        {
            HttpRequestManager mockRequestManager = new HttpRequestManager("https://rickandmortyapi.com/api");
            HttpResponseMessage response = await mockRequestManager.MakeRequest("GET", "episode");
            var content = await response.Content.ReadAsStringAsync();
            Episodes episodes = JsonSerializer.Deserialize<Episodes>(content);
            var result = episodes.results.Where(e => e.name.StartsWith("A")).GroupBy(e => e.name);
        }

        [TestMethod]
        public async Task SingleOrDefault()
        {
            HttpRequestManager mockRequestManager = new HttpRequestManager("https://rickandmortyapi.com/api");
            HttpResponseMessage response = await mockRequestManager.MakeRequest("GET", "episode");
            var content = await response.Content.ReadAsStringAsync();
            Episodes episodes = JsonSerializer.Deserialize<Episodes>(content);
            var result = episodes.results.SingleOrDefault(e => e.name == "A Rickle in Time");
        }
        #endregion
    }
}