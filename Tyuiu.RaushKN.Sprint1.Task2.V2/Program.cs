using Tyuiu.RaushKN.Sprint1.Task2.V2.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task2.V2
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
            Console.WriteLine("# Задание #2                                                              #");
            Console.WriteLine("# Вариант #2                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Известен угол в градусах. Перевести угол в радианы.                     #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int x;

            Console.WriteLine("Введите угол в градусах:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            Console.WriteLine("Угол в радианах = "+ Math.Round(ds.ConvertAngleToRad(x), 3));
            Console.ReadKey();
        }
    }
}
