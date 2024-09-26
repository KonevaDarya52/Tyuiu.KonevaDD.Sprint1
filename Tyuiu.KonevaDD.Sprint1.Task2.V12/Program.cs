using System;

namespace Tyuiu.KonevaDD.Sprint1.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Ввод данных от пользователя
            int x, y, z;
            Console.WriteLine("Длина параллелепипеда X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ширина параллелепипеда Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Высота параллелепипеда Z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

          
            Console.WriteLine("Объём параллелепипеда = " + CalculateParallelepipedVolume(x, y, z));
            Console.ReadLine();
        }

       
        static int CalculateParallelepipedVolume(int x, int y, int z)
        {
            return x * y * z;
        }
    }
}
