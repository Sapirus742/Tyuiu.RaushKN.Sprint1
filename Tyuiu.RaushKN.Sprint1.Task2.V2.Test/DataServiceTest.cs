using Tyuiu.RaushKN.Sprint1.Task2.V2.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(0.017, Math.Round(res,3));
        }
    }
}