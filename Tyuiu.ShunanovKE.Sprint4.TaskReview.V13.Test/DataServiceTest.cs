using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint4.TaskReview.V13.Lib;

namespace Tyuiu.ShunanovKE.Sprint4.TaskReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3, m = 3;
            string value = "159357246";
            int res = ds.Calculate(n, m, value);
            int wait = 3;
            Assert.AreEqual(res, wait);
        }
    }
}
