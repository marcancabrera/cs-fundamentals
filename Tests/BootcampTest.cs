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
    public class BootcampTest
    {
        #region Smoke Test
        //[TestMethod]
        //public async Task GetBootcampWith200StatusCode()
        //{
        //    HttpRequestManager httpRequestManager = new HttpRequestManager();
        //    HttpResponseMessage response = await httpRequestManager.MakeRequest("GET", "bootcamp");
        //    Assert.AreEqual((int)response.StatusCode, 200);
        //}

        //[TestMethod]
        //public async Task GetContentBootcampSucceded()
        //{
        //    HttpRequestManager httpRequestManager = new HttpRequestManager();
        //    HttpResponseMessage response = await httpRequestManager.MakeRequest("GET", "bootcamp");
        //    var content = await response.Content.ReadAsStringAsync();
        //    List<Bootcamp>? bootcamps = JsonSerializer.Deserialize<List<Bootcamp>>(content);
        //    Assert.AreEqual((int)response.StatusCode, 200);
        //    Assert.AreEqual(bootcamps.Count, 2);
        //}
        #endregion
    }
}