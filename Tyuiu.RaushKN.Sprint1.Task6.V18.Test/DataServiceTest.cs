using Tyuiu.RaushKN.Sprint1.Task6.V18.Lib;

namespace Tyuiu.RaushKN.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string Test = "458";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(Test);
            Assert.AreEqual(true, res );
        }
    }
}