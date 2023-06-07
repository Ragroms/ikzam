namespace Задание_8 // Разработать программу, реализующую работу со структурой Аптека. В программе необходимо создать базу данных(массив структур) из N записей(N– определяется при работе программы), выполнить просмотр и поиск записи позаданному критерию(вводится при работе программы). Поля структуры: название лекарства, дата изготовления, срок годности.
{
    using System;

    struct Medicine
    {
        public string Name;
        public DateTime ManufactureDate;
        public DateTime ExpirationDate;
    }

    class Pharmacy
    {
        private Medicine[] Database;

        public void CreateDatabase()
        {
            Console.Write("Введите количество записей: ");
            int n = int.Parse(Console.ReadLine());
            Database = new Medicine[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите название лекарства {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Введите дату изготовления лекарства {i + 1} (ГГГГ-ММ-ДД): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                Console.Write($"Введите срок годности лекарства {i + 1} (в месяцах): ");
                int expirationMonths = int.Parse(Console.ReadLine());
                DateTime expirationDate = manufactureDate.AddMonths(expirationMonths);
                Database[i] = new Medicine
                {
                    Name = name,
                    ManufactureDate = manufactureDate,
                    ExpirationDate = expirationDate
                };
            }
        }

        public void ViewDatabase()
        {
            Console.WriteLine("Название лекарстваtДата изготовленияtСрок годностиt");
            foreach (Medicine medicine in Database)
            {
                Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
            }
        }

        public void SearchByCriteria()
        {
            Console.Write("Введите критерий поиска (1 - название лекарства, 2 - дата изготовления, 3 - срок годности): ");
            int criteria = int.Parse(Console.ReadLine());
            switch (criteria)
            {
                case 1:
                    Console.Write("Введите название лекарства: ");
                    string name = Console.ReadLine();
                    foreach (Medicine medicine in Database)
                    {
                        if (medicine.Name == name)
                        {
                            Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
                        }
                    }
                    break;
                case 2:
                    Console.Write("Введите дату изготовления (ГГГГ-ММ-ДД): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    foreach (Medicine medicine in Database)
                    {
                        if (medicine.ManufactureDate == manufactureDate)
                        {
                            Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
                        }
                    }
                    break;
                case 3:
                    Console.Write("Введите срок годности (в месяцах): ");
                    int expirationMonths = int.Parse(Console.ReadLine());
                    DateTime expirationDate = DateTime.Now.AddMonths(expirationMonths);
                    foreach (Medicine medicine in Database)
                    {
                        if (medicine.ExpirationDate >= expirationDate)
                        {
                            Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Некорректный критерий поиска.");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Создать базу данных");
                Console.WriteLine("2. Просмотреть базу данных");
                Console.WriteLine("3. Поиск по базе данных");
                Console.WriteLine("4. Вы ход");
                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        pharmacy.CreateDatabase();
                        break;
                    case 2:
                        pharmacy.ViewDatabase();
                        break;
                    case 3:
                        pharmacy.SearchByCriteria();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }

}