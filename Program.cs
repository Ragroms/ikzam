using System;
using System.IO;

struct KindergartenChild
{
    public string name;
    public DateTime dateOfBirth;
    public string address;
    public int level;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать!♥");
        Console.WriteLine("Базза данных Десского сада☺");
        Console.WriteLine("Введите кол-во записи в базе данных:");
        string x = Console.ReadLine();
        int N = Convert.ToInt32(x); // количество записей в базе данных
        KindergartenChild[] database = new KindergartenChild[N];

        // заполнение базы данных
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Введите информацию о ребенке {i + 1}:");
            Console.Write("ФИО: ");
            database[i].name = Console.ReadLine();
            Console.Write("Дата рождения (в формате дд.мм.гггг): ");
            database[i].dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            Console.Write("Адрес проживания: ");
            database[i].address = Console.ReadLine();
            Console.Write("Уровень подготовки (от 1 до 5): ");
            database[i].level = int.Parse(Console.ReadLine());
        }

        // запись данных в файл
        using (StreamWriter writer = new StreamWriter("Ded_sadik.txt"))
        {
            for (int i = 0; i < N; i++)
            {
                writer.WriteLine($"{database[i].name};{database[i].dateOfBirth.ToShortDateString()};{database[i].address};{database[i].level}");
            }
        }

        // чтение данных из файла
        using (StreamReader reader = new StreamReader("Ded_sadik.txt"))
        {
            for (int i = 0; i < N; i++)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split(';');
                database[i].name = fields[0];
                database[i].dateOfBirth = DateTime.ParseExact(fields[1], "dd.MM.yyyy", null);
                database[i].address = fields[2];
                database[i].level = int.Parse(fields[3]);
            }
        }

        // меню с выбором действий
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Просмотреть все записи");
            Console.WriteLine("2. Найти запись по ФИО");
            Console.WriteLine("3. Найти запись по дате рождения");
            Console.WriteLine("4. Найти запись по адресу");
            Console.WriteLine("5. Найти запись по уровню подготовки");
            Console.WriteLine("6. Выход");
            Console.Write("Введите номер действия: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    for (int i = 0; i < N; i++)
                    {
                        Console.WriteLine($"{i+1} - {database[i].name}, {database[i].dateOfBirth.ToShortDateString()}, {database[i].address}, {database[i].level}");
                    }
                    break;
                case 2:
                    Console.Write("Введите ФИО: ");
                    string name = Console.ReadLine();
                    for (int i = 0; i < N; i++)
                    {
                        if (database[i].name == name)
                        {
                            Console.WriteLine($"{database[i].name}, {database[i].dateOfBirth.ToShortDateString()}, {database[i].address}, {database[i].level}");
                        }
                    }
                    break;
                case 3:
                    Console.Write("Введите дату рождения (в формате дд.мм.гггг): ");
                    DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
                    for (int i = 0; i < N; i++)
                    {
                        if (database[i].dateOfBirth == dateOfBirth)
                        {
                            Console.WriteLine($"{database[i].name}, {database[i].dateOfBirth.ToShortDateString()}, {database[i].address},{ database[i].level}");
                        }
                    }
                    break;
                case 4:
                    Console.Write("Введите адрес: ");
                    string address = Console.ReadLine();
                    for (int i = 0; i < N; i++)
                    {
                        if (database[i].address == address)
                        {
                            Console.WriteLine($"{database[i].name}, {database[i].dateOfBirth.ToShortDateString()}, {database[i].address}, {database[i].level}");
                        }
                    }
                    break;
                case 5:
                    Console.Write("Введите уровень подготовки: ");
                    int level = int.Parse(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        if (database[i].level == level)
                        {
                            Console.WriteLine($"{database[i].name}, {database[i].dateOfBirth.ToShortDateString()}, {database[i].address}, {database[i].level}");
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Всего доброго!☺");
                    return;
                default:
                    Console.WriteLine("Неверный номер действия!");
                    break;
            }
        }
    }
}