using AutomationAPI.API;
using AutomationAPI.API.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using AutomationAPI.Fundamentals;

namespace AutomationAPI
{
    [TestClass]
    public class AbstractTest
    {
        #region Abstract
        [TestMethod]
        public void AbstractExecution()
        {
            Tester tester = new Tester("Jane", 7654321, 5);
            Assert.AreEqual(tester.ReturnData(), "Jane has 7654321 as C.I.");
        }

        [TestMethod]
        public void AbstractImplementation()
        {
            Dev dev = new Dev("John", 1234567, 3);
            Assert.AreEqual(dev.ShowYourWork(), $"I have to fix this quantity of bugs: 3");
        }       
        #endregion


    }
}