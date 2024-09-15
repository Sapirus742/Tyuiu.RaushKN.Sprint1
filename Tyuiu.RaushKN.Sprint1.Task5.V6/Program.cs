using Tyuiu.RaushKN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #1                                                               #");
            Console.WriteLine("# Тема: Создание итогового решения по спринту                             #");
            Console.WriteLine("# Задание #5                                                              #");
            Console.WriteLine("# Вариант #6                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2, #");
            Console.WriteLine("# ...,7 в зависимости от того, на какой день недели (понедельник, вторник #");
            Console.WriteLine("# ,..., воскресенье) приходится k-й день невисокосного года.              #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int k;
            Console.WriteLine("Введите к(день невысокосного года): ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("День недели: "+ds.Calculate(k));
            Console.ReadKey();
        }
    }
}
