using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint1.Task7.V9.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0, y = 1;
            Assert.AreEqual(0.875, ds.Calculate(x, y));

        }
    }
}
