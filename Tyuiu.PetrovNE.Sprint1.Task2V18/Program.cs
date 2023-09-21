using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint1.Task2V18.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.

//Расчёты: Известны длины стороны параллелепипеда.
//Вычислить площадь боковой поверхности параллелепипеда.

//Ввод:
//Длина параллелепипеда (целое число), Ширина параллелепипеда (целое число),Высота параллелепипеда (целое число)

//Вывод: Площадь боковой поверхности параллелепипеда (целое число)

namespace Tyuiu.PetrovNE.Sprint1.Task2V18
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
            Console.WriteLine("* Задание #2                                                                    *");
            Console.WriteLine("* Вариант #18                                                                   *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,       *");
            Console.WriteLine("* выполняет указанные расчёты и печатает площадь боковой поверхности на экране. *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            int x, y, z;
            Console.WriteLine("Введите значение X =");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y =");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Z =");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine("Площадь боковой поверхности параллелепипеда = " + ds.CalculateSideSquareParallelepiped(x, y, z));

            Console.ReadKey();

        }
    }
}
