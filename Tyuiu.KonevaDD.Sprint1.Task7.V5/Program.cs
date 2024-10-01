using System;
using Tyuiu.KonevaDD.Sprint1.Task7.V5.Lib;

namespace Tyuiu.KonevaDD.Sprint1.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("           ln|cos x|                  ");
            Console.WriteLine("           --------            ");
            Console.WriteLine("                    5         ");
            Console.WriteLine("   z =      ln(1 + x )          ");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            double result = ds.Calculate(x);
            Console.WriteLine($"Результат: {Math.Round(result, 3)}");
        }
    }
}
