using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint1.Task6.V2.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Hello World!";
            bool res = ds.CheckHello(value);
            Assert.AreEqual(true, res);
        }
    }
}
