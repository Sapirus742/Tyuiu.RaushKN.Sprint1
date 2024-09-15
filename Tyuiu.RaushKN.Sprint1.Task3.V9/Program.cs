﻿using Tyuiu.RaushKN.Sprint1.Task3.V9.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #1                                                               #");
            Console.WriteLine("# Тема: JОператоры составного присваивания                                #");
            Console.WriteLine("# Задание #3                                                              #");
            Console.WriteLine("# Вариант #9                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу пересчета величины временного интервала, заданного в #");
            Console.WriteLine("# минутах, в величину, выраженную в часах и минутах и печатает рузельтат  #");
            Console.WriteLine("# на экране                                                               #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int x;
            Console.WriteLine("Введите временной интервал (в минутах):");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            Console.WriteLine($"{x} минут — это " + ds.ConvertMinutesToHours(x) + " ч. "+ (x%60) + " мин.");
            Console.ReadKey();
        }
    }
}
