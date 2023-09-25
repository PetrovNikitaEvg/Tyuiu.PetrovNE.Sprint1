using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint1.Task4.V17.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 50, y = 5;
            double res = 0.2;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}
