﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RaushKN.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            int i = 0;
            value = value.Trim(new char[] {'"'});
            if (int.TryParse(value, out i)) { return true; }
            return false;
        }
    }
}
