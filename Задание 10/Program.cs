namespace Задание_10
{
    using System;

    public class FixedLengthStringArray
    {
        private string[] array;

        public FixedLengthStringArray(int length)
        {
            array = new string[length];
        }

        public void FillArray()
        {
            Console.WriteLine($"Введите {array.Length} строк:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
        }

        public void DisplayArray()
        {
            Console.WriteLine("Массив строк:");
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }

        public void SearchArray(string searchString)
        {
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchString)
                {
                    Console.WriteLine($"Строка найдена в ячейке {i}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Строка не найдена");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите длину массива:");
            int length = int.Parse(Console.ReadLine());

            FixedLengthStringArray array = new FixedLengthStringArray(length);

            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Заполнить массив");
                Console.WriteLine("2 - Вывести массив на экран");
                Console.WriteLine("3 - Найти строку в массиве");
                Console.WriteLine("0 - Выйти из программы");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        array.FillArray();
                        break;
                    case 2:
                        array.DisplayArray();
                        break;
                    case 3:
                        Console.WriteLine("Введите строку для поиска:");
                        string searchString = Console.ReadLine();
                        array.SearchArray(searchString);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор операции");
                        break;
                }
            }
        }
    }
}
