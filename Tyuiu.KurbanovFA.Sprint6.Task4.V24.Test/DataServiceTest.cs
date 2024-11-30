using Tyuiu.KurbanovFA.Sprint6.Task4.V24.Lib;

namespace Tyuiu.KurbanovFA.Sprint6.Task4.V24.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int startValue = -5; int stopValue = 5;
        double[] res = ds.GetMassFunction(startValue, stopValue);
        double[] wait = { 7.83, 6.22, 6.36, 6.96, -0.52, 0.0, -3.3, -5.53, -6.25, -6.63, -8.24 };
        CollectionAssert.AreEqual(wait, res);
    }
}