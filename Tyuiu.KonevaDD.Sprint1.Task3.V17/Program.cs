using System;
using Tyuiu.KonevaDD.Sprint1.Task3.V17.Lib;

namespace Tyuiu.KonevaDD.Sprint1.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите вещественное число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            bool result = ds.ZeroCheck(number);

            if (result)
            {
                Console.WriteLine("Среди первых трёх цифр дробной части есть 0.");
            }
            else
            {
                Console.WriteLine("Среди первых трёх цифр дробной части нет 0.");
            }
        }
    }
}
