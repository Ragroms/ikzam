namespace ПР11_Задание2
{
    internal class Program // Разработать консольное приложение для обработки матриц в соответствии с вариантом задания.В каждом варианте задания исходным является файл с элементами матрицы.Необходимосчитать исходные данные, вывести их на экран для просмотра и выполнить обработку. Результат обработки вывести на экран и в файл. Задан массив X(N). Расположить элементы в нем в обратном порядке. Найти сумму элементов с нечетными индексами.

    {
            static void Main()
            {
            Console.WriteLine("Добро пожаловать!♥");
            int[] x;

            // Читаем данные из файла
            using (StreamReader sr = new StreamReader("Массив11.1.txt"))
            {
                string line = sr.ReadLine();
                string[] numbers = line.Split(' ');
                x = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    x[i] = int.Parse(numbers[i]);
                }
            }

            // Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            foreach (int num in x)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Реверс массива
            Array.Reverse(x);

            // Выводим результат
            Console.WriteLine("Результат:");
            foreach (int num in x)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Находим сумму элементов с нечетными индексами
            int sum = 0;
            for (int i = 1; i < x.Length; i += 2)
            {
                sum += x[i];
            }

            // Выводим результат на экран и в файл
            Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
            using (StreamWriter sw = new StreamWriter("Массив11.2.txt"))
            {
                sw.WriteLine("Сумма элементов с нечетными индексами: " + sum);
            }

            Console.ReadKey();
            }
        }
    }
