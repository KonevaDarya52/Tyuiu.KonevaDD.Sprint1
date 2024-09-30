using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonevaDD.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            if (f <= 0 || f >= 360)
            {
                throw new ArgumentOutOfRangeException("Угол должен быть в диапазоне от 0 до 360 градусов.");
            }


            double hours = f / 30;


            return (int)Math.Floor(hours);
        }
    }
}