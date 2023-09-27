using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint1.Task6.V2.Lib;

namespace Tyuiu.PetrovNE.Sprint1.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                     *");
            Console.WriteLine("* Тема: Работа со строками класс String                                         *");
            Console.WriteLine("* Задание #6                                                                    *");
            Console.WriteLine("* Вариант #2                                                                    *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                          *");
            Console.WriteLine("* пользователь вводит текст. Проверить, есть ли в строке слово Hello.           *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            string value;
            Console.WriteLine("Введите строку:");
            value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine(ds.CheckHello(value));

            Console.ReadKey();

        }
    }
}
