using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PetrovNE.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            return Math.Round( Math.Pow(Math.E, x) - ( ( Math.Pow(y, 2) + Math.Cos( Math.Pow(x, 3) ) + 12 * x * y - 3 * Math.Pow(x, 2) ) / ( Math.Cos( Math.Pow(x, 3) + 3) + 18 * y - 1) ), 3 );
        }
    }
}

//             2      3                    2
//     x     y + cosx + 12 * x * y - 3 * x
//z = e   -   -----------------------------------------
//                         3
//                   cos (x + 3) +18 * y - 1