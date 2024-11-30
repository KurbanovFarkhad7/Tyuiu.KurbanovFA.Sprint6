using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task2.V5.Lib
{
    public class DataService : ISprint6Task2V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            DataService ds = new DataService();
            double[] massive = new double[11];
            int count = 0;
            double result = 0;
            for (double x = startValue; x <= stopValue; x++)
            {
                result = Math.Cos(2 * x) != 0 ? ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6 : 0;
                massive[count] = Math.Round(result, 2);
                count++;
            }
            return massive;
        }
    }
}
