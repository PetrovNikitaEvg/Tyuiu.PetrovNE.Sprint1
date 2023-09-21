﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint1.Task2V18.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task2V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            int z = 4;
            var res = ds.CalculateSideSquareParallelepiped(x, y, z);
            Assert.AreEqual(40, res);
        }
    }
}
