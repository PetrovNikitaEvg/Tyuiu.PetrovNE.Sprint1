using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint1.Task5.V7.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                     *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                    *");
            Console.WriteLine("* Задание #5                                                                    *");
            Console.WriteLine("* Вариант #7                                                                    *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                          *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток              *");
            Console.WriteLine("* до того момента(в первой половине дня), когда часовая стрелка повернулась     *");
            Console.WriteLine("* на f градусов(0 < f < 360, f – вещественное число).                           *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            double f;
            Console.WriteLine("Введите значение F =");
            f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine(ds.AngleToHoursMinutes(f));

            Console.ReadKey();


        }
    }
}
