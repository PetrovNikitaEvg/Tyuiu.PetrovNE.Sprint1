using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint1.Task4.V17.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в c#                                              *");
            Console.WriteLine("* Задание #4                                                                    *");
            Console.WriteLine("* Вариант #17                                                                   *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,       *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране                       *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X =");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y =");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine($"1 / (sqrt(x - 5*y)) = {ds.Calculate(x, y)}");

            Console.ReadKey();


        }
    }
}
