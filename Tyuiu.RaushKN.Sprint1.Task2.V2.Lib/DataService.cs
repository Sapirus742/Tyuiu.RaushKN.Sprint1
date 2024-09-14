using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RaushKN.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {
        public double ConvertAngleToRad(int value)
        {
            return value * (Math.PI / 180);
        }
    }
}

