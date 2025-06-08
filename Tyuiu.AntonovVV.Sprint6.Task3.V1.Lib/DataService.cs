using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovVV.Sprint6.Task3.V1.Lib
{
    public class DataService : ISprint6Task3V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] firstRow = new int[5];
            for (int i = 0; i < firstRow.Length; i++)
            {
                firstRow[i] = matrix[i, 2];
            }
            Array.Sort(firstRow);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 2] = firstRow[i];
            }
            return matrix;
        }
    }
}

