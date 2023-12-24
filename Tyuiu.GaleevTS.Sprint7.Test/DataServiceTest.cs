using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint7.Lib;

namespace Tyuiu.GaleevTS.Sprint7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void GetCostTest()
        {
            string length = "512 мин";
            string cost = ds.GetCost(length);
            string wait = "1690 руб.";
            Assert.AreEqual(wait, cost);
        }
        [TestMethod]
        public void GetAllSumTest()
        {
            string[] costArray = {"237 руб", "581 руб", "694 руб", "349 руб", "826 руб" };
            string cost = ds.GetAllSum(costArray);
            string wait = "2687 руб.";
            Assert.AreEqual(wait, cost);
        }
        [TestMethod]
        public void GetAllLengthTest()
        {
            string[] lengthArray = { "123 мин", "456 мин", "789 мин", "321 мин", "654 мин" };
            string cost = ds.GetAllLength(lengthArray);
            string wait = "2343 мин.";
            Assert.AreEqual(wait, cost);
        }

    }
}
