using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task5.V13.Lib
{
    public class DataService : ISprint6Task5V13
    {
        public double[] LoadFromDataFile(string path)
        {
            string stringValues = File.ReadAllText(path); //взяли путь
            stringValues = stringValues.Replace(".", ","); //определили как строку, сменили .
            string[] stringArray = stringValues.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // Преобразуем строковый массив в массив чисел типа double
            // Разделим строку на элементы по символу новой строки
            double[] numbers = Array.ConvertAll(stringArray, s => double.Parse(s.Trim()));
            double[] result = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 10)
                {
                    result[i] = numbers[i];
                }
            }
            return result;
        }
    }
}
