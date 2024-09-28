using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevaDD.Sprint1.Task3.V17.Lib;

namespace Tyuiu.KonevaDD.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test_ZeroCheck_WithZeroInFraction()
        {
            DataService ds = new DataService();
            double number = 12.034;

            bool result = ds.ZeroCheck(number);

            Assert.IsTrue(result);
        }

     

      
        
    }
}
