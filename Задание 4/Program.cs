namespace Задание_4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int N = 4; // размерность матрицы
            int[,] A = new int[N, N]; // создаем матрицу A[N, N]
            Random rnd = new Random();
            for (int i = 0; i < N; i++) // заполняем матрицу случайными значениями
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(-10, 11); // случайное число от -10 до 10
                    Console.Write("{0}", A[i, j]); // выводим элементы матрицы на экран
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // заменяем отрицательные элементы матрицы на нули, а положительные - на единицы
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        A[i, j] = 0;
                    }
                    else if (A[i, j] > 0)
                    {
                        A[i, j] = 1;
                    }
                }
            }

            // выводим на печать нижнюю треугольную матрицу в общепринятом виде
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("{0}", A[i, j]);
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}