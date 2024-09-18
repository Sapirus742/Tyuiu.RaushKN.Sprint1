using Tyuiu.RaushKN.Sprint1.Task6.V18.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #1                                                               #");
            Console.WriteLine("# Тема: Работа со строками класс String                                   #");
            Console.WriteLine("# Задание #6                                                              #");
            Console.WriteLine("# Вариант #18                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу: пользователь вводит текст. Проверить, что строка    #");
            Console.WriteLine("# является символьным представлением натурального числа (\"122\", \"34\"  #");
            Console.WriteLine("#  и т.д.).                                                               #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string value;
            Console.WriteLine("Введите строковое представление натурального числа: ");
            value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            Console.WriteLine(ds.CheckNumber(value));
            Console.ReadKey();
        }
    }
}
