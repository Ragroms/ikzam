namespace Задание_3 // Создать матрицу вещественных элементов А(n,n) и выполнить сортировку элементов, расположенных под главной диагональю методом «пузырька». Отсортированную последовательность вывести на экран.
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = 4; // размерность матрицы
            double[,] A = new double[n, n]; // создаем матрицу вещественных элементов А(n,n)
            Random rnd = new Random();
            for (int i = 0; i < n; i++) // заполняем матрицу случайными значениями
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.NextDouble() * 10;
                    Console.Write("{0:F2}t", A[i, j]); // выводим элементы матрицы на экран
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // сортировка элементов, расположенных под главной диагональю методом «пузырька»
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (A[j + 1, j] < A[j, j + 1])
                    {
                        double temp = A[j + 1, j];
                        A[j + 1, j] = A[j, j + 1];
                        A[j, j + 1] = temp;
                    }
                }
            }

            // вывод отсортированной последовательности на экран
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0:F2}t", A[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}