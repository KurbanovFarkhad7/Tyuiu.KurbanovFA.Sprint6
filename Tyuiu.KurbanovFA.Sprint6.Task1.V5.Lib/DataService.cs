using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            DataService ds = new DataService();
            double[] massive = new double[11];
            int count = 0;
            for (double i = startValue; i <= stopValue; i++)
            {
                double x = -5 + i;
                double result = CalculateFunction(x);
                // Вычисляем значение функции, добавляем проверку на деление на 0
                massive[count] = Math.Round(result, 2);
                count++;
            }
            return massive;
        }
        static double CalculateFunction(double x)
        {
            return Math.Sin(x) + Math.Cos(2 * x) / 2 - 1.5 * x;
        }
    }
}
