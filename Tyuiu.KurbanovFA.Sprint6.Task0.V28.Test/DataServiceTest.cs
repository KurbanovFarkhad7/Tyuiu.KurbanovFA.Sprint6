using Tyuiu.KurbanovFA.Sprint6.Task0.V28.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 169.89;
            Assert.AreEqual(res, wait);
        }
    }
}