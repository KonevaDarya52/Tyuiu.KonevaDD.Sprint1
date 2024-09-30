using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonevaDD.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Sqrt(Math.Abs(x + y)) / Math.Abs(3 - x), 3);

        }
    }
}