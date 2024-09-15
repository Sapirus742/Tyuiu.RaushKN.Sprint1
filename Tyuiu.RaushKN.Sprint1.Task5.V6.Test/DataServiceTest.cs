using Tyuiu.RaushKN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TValidExpression()
        {
            DataService ds = new DataService();
            int k = 17;
            int res = ds.Calculate(k);
            Assert.AreEqual(3, res);
        }
    }
}