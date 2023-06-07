using System.Globalization;

namespace ПР12_1 // Разработать класс, инкапсулирующий двумерный массив. Класс должен содержать поля и методы, необходимые для реализации индивидуальногозадания в соответствии с вариантом.Среди столбцов целочисленной квадратной матрицы порядка 5 найдите столбец с максимальной суммой элементов.
{
    class Matrix
    {
        private int[,] matrix;

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int FindColumnWithMaxSum()
        {
            int numRows = matrix.GetLength(0);
            int numCol = matrix.GetLength(1);
            int maxSum = int.MinValue;
            int maxSumCol = -1;

            for (int j = 0; j < numCol; j++)
            {
                int sum = 0;
                for (int i = 0; i < numRows; i++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Сумма {0} столбца: {1}", j + 1, sum);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxSumCol = j;
                }
            }

            return maxSumCol;
        }
    }
    class Program
    {
        static void Main()
        {
            int[,] array = new int[5, 5];

            Console.WriteLine("Добро пожаловать!♥");
            Console.WriteLine("Введите матрицу:");
            Matrix matrix = new Matrix(array);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[{i}, {j}] = ");
                    array[i, j] = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine();
            }

            int maxSumCol = matrix.FindColumnWithMaxSum();
            Console.WriteLine($"Столбец с максимальной суммой элементов: {maxSumCol + 1}");
        }
    }
}