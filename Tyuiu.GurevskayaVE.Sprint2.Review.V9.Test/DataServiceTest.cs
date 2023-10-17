using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint2.Review.V9.Lib;

namespace Tyuiu.GurevskayaVE.Sprint2.Review.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCheck()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double y = 0.4;

            bool res = ds.Check(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
