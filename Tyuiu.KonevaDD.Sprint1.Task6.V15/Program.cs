using Tyuiu.KonevaDD.Sprint1.Task6.V15.Lib;

namespace Tyuiu.KonevaDD.Sprint1.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckLettersCount(str);

            if (result)
            {
                Console.WriteLine("В строке больше букв, чем знаков.");
            }
            else
            {
                Console.WriteLine("В строке больше знаков, чем букв.");
            }
        }
    }
}
