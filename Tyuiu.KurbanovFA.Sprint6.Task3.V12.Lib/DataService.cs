using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KurbanovFA.Sprint6.Task3.V12.Lib
{
    public class DataService : ISprint6Task3V12
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] resultMatrix = new int[,] { };
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[y, x] == 0 && y <= 1)
                    {
                        resultMatrix[y,x] = 0;
                    }
                    else
                    {
                        resultMatrix[y,x] = matrix[y, x];
                    }
                }
            }
            return resultMatrix;
        }
    }
}
