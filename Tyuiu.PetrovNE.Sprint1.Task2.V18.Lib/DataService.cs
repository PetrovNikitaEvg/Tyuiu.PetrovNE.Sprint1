﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PetrovNE.Sprint1.Task2V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int CalculateSideSquareParallelepiped(int value, int valueTwo, int valueThree)
        {
            return 2 * (value * valueThree + valueTwo * valueThree);
        }
    }
}
