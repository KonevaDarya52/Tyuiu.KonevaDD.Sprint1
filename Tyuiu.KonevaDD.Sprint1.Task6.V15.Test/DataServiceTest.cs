using Tyuiu.KonevaDD.Sprint1.Task6.V15.Lib;
namespace Tyuiu.KonevaDD.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString_MoreLetters()
        {
            string strTest = "abc * 123";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strTest);
            Assert.IsTrue(res); 
        }

        [TestMethod]
        public void ValidString_MoreSymbols()
        {
            string strTest = "*&^% 123";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strTest);
            Assert.IsFalse(res); 
        }
 
        
    }
}
