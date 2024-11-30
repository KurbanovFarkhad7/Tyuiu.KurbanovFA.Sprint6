using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task5.V13.Lib
{
    public class DataService : ISprint6Task5V13
    {
        public double[] LoadFromDataFile(string path)
        {
            string pathTransfer = File.ReadAllText(path); //взяли путь
            string stringValues = pathTransfer.Replace(".", ","); //определили как строку, сменили .
            string[] valueArray = stringValues.Split(); // Разделяем строку на отдельные элементы (по пробелам)
            double[] result = new double[valueArray.Length];

            for (int i = 0; i < valueArray.Length; i++)
            {
                if (Convert.ToDouble(valueArray[i]) < 10)
                {
                    result[i] += Math.Round(Convert.ToDouble((valueArray[i])), 3);
                }
                Console.WriteLine(valueArray[i]);
            }
            return result;
        }
    }
}
