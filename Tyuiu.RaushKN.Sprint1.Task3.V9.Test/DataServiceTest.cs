using Tyuiu.RaushKN.Sprint1.Task3.V9.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 130;
            int wait = 2;
            var res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(wait, res);
        }
    }
}