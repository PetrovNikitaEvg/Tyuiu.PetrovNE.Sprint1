using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint1.Task0.V11.Lib;

//Задание
//Написать программу, которая вычисляет выражение 4 * 5 / 2 - 18 / 2 / 3 и печатает результат на экране.

namespace Tyuiu.PetrovNE.Sprint1.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Базовые навыки в работе в C#                                   *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #11                                                          *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 4*5/2-18/2/3         *");
            Console.WriteLine("* и печатает результат на экране.                                      *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* 4*5/2-18/2/3                                                         *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
