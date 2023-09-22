using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint1.Task3.V15.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task3.V15
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
            Console.WriteLine("* Задание #3                                                                    *");
            Console.WriteLine("* Вариант #15                                                                   *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,       *");
            Console.WriteLine("* выполняет указанные расчёты и находит расстояние через t часов                *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            double v1, v2, S, T;
            Console.WriteLine("Введите скорость первого автомобиля V1 =");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля V2 =");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние на котором они первоначально находились S =");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время T =");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine($"Расстояние между автомобилями через {T} часов = {ds.DistanceOverTime(v1, v2, S, T)}");

            Console.ReadKey();

        }
    }
}
