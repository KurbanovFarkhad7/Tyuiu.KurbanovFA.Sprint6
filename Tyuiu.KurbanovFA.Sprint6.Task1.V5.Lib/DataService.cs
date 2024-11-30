using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task0V5
    {
        public double Calculate(int x)
        {
            DataService ds = new DataService();
            double numerator = Math.Cos(2 * x);
            double denominator = 2;
            // Проверка на деление на ноль (хотя в данном случае деление на 2 невозможно, но для примера)
            if (denominator == 0)
            {
                return 0;
            }

            return Math.Sin(x) + numerator / denominator - 1.5 * x;
        }
    }
}
