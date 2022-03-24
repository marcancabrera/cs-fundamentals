using AutomationAPI.API;
using AutomationAPI.API.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace AutomationAPI
{
    [TestClass]
    public class Examples
    {
        #region Smoke Test
        [TestMethod]
        public async Task GetTenEpisodes()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://rickandmortyapi.com/api/episode"));
            HttpResponseMessage response = await HttpRequestManager.Request(request);
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
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://rickandmortyapi.com/api/episode"));
            HttpResponseMessage response = await HttpRequestManager.Request(request);
            var content = await response.Content.ReadAsStringAsync();
            Episodes episodes = JsonSerializer.Deserialize<Episodes>(content);
            var result = episodes.results.Where(e => e.name.StartsWith("A")).GroupBy(e => e.name);
        }

        [TestMethod]
        public async Task SingleOrDefault()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://rickandmortyapi.com/api/episode"));
            HttpResponseMessage response = await HttpRequestManager.Request(request);
            var content = await response.Content.ReadAsStringAsync();
            Episodes episodes = JsonSerializer.Deserialize<Episodes>(content);
            var result = episodes.results.SingleOrDefault(e => e.name == "A Rickle in Time");
        }
        #endregion
    }
}