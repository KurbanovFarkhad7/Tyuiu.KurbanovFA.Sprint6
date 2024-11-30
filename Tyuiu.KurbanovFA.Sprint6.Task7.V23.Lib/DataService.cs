using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            // Чтение всех строк из файла
            string[] lines = File.ReadAllLines(path);

            // Создаем двумерный массив для хранения данных
            int[,] array = new int[10, 10];

            // Заполнение массива из CSV
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split('\t'); // Если значения разделены запятыми, используйте ',' вместо '\t'
                for (int j = 0; j < values.Length; j++)
                {
                    array[i, j] = int.Parse(values[j]);
                }
            }
            // Изменение значений в последнем столбце
            for (int i = 0; i < 10; i++)
            {
                if (array[i, 9] < 2)  // Индекс 9 - это последний столбец
                {
                    array[i, 9] = 2;
                }
            }
            return array;
        }
    }
}
