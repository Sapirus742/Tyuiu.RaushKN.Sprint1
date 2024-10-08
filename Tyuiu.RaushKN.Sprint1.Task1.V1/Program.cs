﻿using Tyuiu.RaushKN.Sprint1.Task1.V1.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #1                                                               #");
            Console.WriteLine("# Тема: Организация ввода\\вывода в консольных приложениях                 #");
            Console.WriteLine("# Задание #1                                                              #");
            Console.WriteLine("# Вариант #1                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу, которая запрашивает у пользователя исходные данные, #");
            Console.WriteLine("# вычисляет рузультат по формуле x/3/y+6*a и печатает его на экрене.      #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            double x, y, a;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine(ds.Calculate(x, y, a));
            Console.ReadLine();
        }
    }
}
