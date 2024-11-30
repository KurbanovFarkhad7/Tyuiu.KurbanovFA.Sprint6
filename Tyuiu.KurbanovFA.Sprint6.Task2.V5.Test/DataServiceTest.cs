using Tyuiu.KurbanovFA.Sprint6.Task2.V5.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5; int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { -32.26, -27.5, -22.8, -17.95, -12.97, -9, -0.31, 3.77, 8.57, 13.42, 18.28 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}