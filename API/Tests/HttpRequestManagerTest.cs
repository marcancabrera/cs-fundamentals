﻿using AutomationAPI.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            HttpRequestManager mockRequestManager = new HttpRequestManager("https://rickandmortyapi.com/api");
            HttpResponseMessage response = await mockRequestManager.MakeRequest("GET", "episode");
            Assert.AreEqual((int)response.StatusCode, 200);
        }

        [TestMethod]
        public async Task GetEpisodeWith200StatusCode()
        {
            HttpRequestManager mockRequestManager = new HttpRequestManager("https://rickandmortyapi.com/api");
            HttpResponseMessage response = await mockRequestManager.MakeRequest("GET", "episode/51");
            Assert.AreEqual((int)response.StatusCode, 200);
        }
        #endregion
    }
}