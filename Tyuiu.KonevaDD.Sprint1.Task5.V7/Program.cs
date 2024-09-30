using Tyuiu.KonevaDD.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KonevaDD.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите f (угол в градусах):");
            double f = Convert.ToDouble(Console.ReadLine());

            if (f <= 0 || f >= 360)
            {
                Console.WriteLine("Значение угла должно быть в пределах от 0 до 360 градусов.");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.AngleToHoursMinutes(f);
            Console.WriteLine($"Прошло: {result} часов");
            Console.ReadKey();
        }
    }
}
