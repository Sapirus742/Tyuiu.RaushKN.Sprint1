using Tyuiu.RaushKN.Sprint1.Task1.V1.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 1.0;
            double a = 1.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(7, res);
        }
    }
}