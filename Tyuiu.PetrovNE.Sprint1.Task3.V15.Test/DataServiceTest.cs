using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint1.Task3.V15.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 30, v2 = 30, S0 = 0, T = 2;
            double res = ds.DistanceOverTime(v1, v2, S0, T);
           // double sum = T * (v1 + v2);
           // double S1 = S0 + sum;
            Assert.AreEqual(120, res);

        }
    }
}
