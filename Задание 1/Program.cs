namespace Задание_1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, k = 0, sum = 0;
            bool isExit = false;

            while (!isExit)
            {
                Console.WriteLine("Меню программы:");
                Console.WriteLine("1 - Ввод данных");
                Console.WriteLine("2 - Обработка");
                Console.WriteLine("3 - Просмотр результатов");
                Console.WriteLine("4 - Выход");

                Console.Write("Выберите пункт меню: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите значение n: ");
                        n = int.Parse(Console.ReadLine());

                        Console.Write("Введите значение k: ");
                        k = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        sum = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            sum += (int)Math.Pow(i, k);
                        }
                        Console.WriteLine("Обработка завершена.");
                        break;

                    case 3:
                        Console.WriteLine($"Результат: {sum}");
                        break;

                    case 4:
                        isExit = true;
                        break;

                    default:
                        Console.WriteLine("Ошибка! Неверный пункт меню.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}