using Tyuiu.KonevaDD.Sprint1.Task7.V5.Lib;


namespace Tyuiu.KonevaDD.Sprint1.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double expected = Math.Round(Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + x * x), 3);

            double result = ds.Calculate(x);

            Assert.AreEqual(expected, result);
        }
    }
}