
using Tyuiu.KonevaDD.Sprint1.Task2.V12.Lib;

namespace Tyuiu.KonevaDD.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            
            int x = 1;
            int y = 2;
            int z = 3;

            var res = ds.CalculateParallelepipedVolume(x, y, z);
            Assert.AreEqual(6, res);
        }
    }
}
