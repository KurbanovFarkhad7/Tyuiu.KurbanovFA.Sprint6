using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            int[,] array = new int[10, 10];

            using (StreamReader sr = new StreamReader(path))
            {
                int row = 0;

                // Читаем построчно
                while (!sr.EndOfStream && row < 10)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split('\t'); // Используем табуляцию или пробел как разделитель

                    // Преобразуем строку в целые числа и заполняем массив
                    for (int col = 0; col < 10; col++)
                    {
                        array[row, col] = int.Parse(values[col].Trim());
                    }
                    row++;
                }
                return array;
            }
        }
    }
}
