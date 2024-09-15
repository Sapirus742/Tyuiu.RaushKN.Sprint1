using Tyuiu.RaushKN.Sprint1.Task7.V20.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 8;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(48.289,res);

        }
    }
}