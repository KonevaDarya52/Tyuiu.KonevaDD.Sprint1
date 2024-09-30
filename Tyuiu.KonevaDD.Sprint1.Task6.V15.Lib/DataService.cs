using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KonevaDD.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            value = value.ToLower().Trim();

            int letterCount = 0;
            int symbolCount = 0;

            foreach (char c in value)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
                else if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    symbolCount++;
                }
            }

            return letterCount > symbolCount;
        }
    }
}
