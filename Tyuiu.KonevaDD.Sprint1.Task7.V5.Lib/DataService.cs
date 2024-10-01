using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonevaDD.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double numerator = Math.Log(Math.Abs(Math.Cos(x))); 
            double denominator = Math.Log(1 + x * x); 

            double res = numerator / denominator;

            return Math.Round(res, 3);
        }
    }
}