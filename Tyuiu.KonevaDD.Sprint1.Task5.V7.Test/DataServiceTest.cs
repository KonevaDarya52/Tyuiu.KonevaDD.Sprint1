using Tyuiu.KonevaDD.Sprint1.Task5.V7.Lib;


namespace Tyuiu.KonevaDD.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 90; 
            DataService ds = new DataService();
            int result = ds.AngleToHoursMinutes(x);
            int expected = 3; 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidExpressionWithMinutes()
        {
            double x = 75; 
            DataService ds = new DataService();
            int result = ds.AngleToHoursMinutes(x);
            int expected = 2; 
            Assert.AreEqual(expected, result);
        }
    }
}
