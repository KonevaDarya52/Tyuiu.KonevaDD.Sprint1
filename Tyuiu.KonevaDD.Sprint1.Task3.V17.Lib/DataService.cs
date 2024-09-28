using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonevaDD.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        
        public bool ZeroCheck(double number)
        {

            double fractionalPart = number - Math.Truncate(number);
            string fractionalStr = fractionalPart.ToString("0.000000").Substring(2);
            return fractionalStr.Substring(0, 3).Contains('0');
        }
    }
}
