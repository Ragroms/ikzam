using System;
using System.Collections.Generic;
using System.IO;

namespace прак_14 // Разработать программу, реализующую работу с линейным списком. В программе необходимо создать базу данных(список) из N записей(N – определяется приработе программы), выполнить просмотр, поиск записи по заданному критерию(вводится при работе программы), вставка записи в любое место списка(до илипосле записи с заданным критерием), удаление элемента из списка.* Данные можно считывать из текстового файла (на оценку - 5). Детский сад. Информация о дошкольниках: ФИО ребёнка, дата рождения,адрес проживания, уровень подготовки(значение 1-5). 
{
    class ListItem
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Adres { get; set; }
        public int Level { get; set; }
        public ListItem New { get; set; }
    }
    class LinkedList
    {
        private ListItem nachalo;
        public void AddItem(ListItem item)
        {
            if (nachalo == null)
            {
                nachalo = item;
            }
            else
            {
                ListItem current = nachalo;
                while (current.New != null)
                {
                    current = current.New;
                }
                current.New = item;
            }
        }
        public void RemoveItem(ListItem item)
        {
            if (nachalo == null)
            {
                return;
            }
            if (nachalo == item)
            {
                nachalo = nachalo.New;
                return;
            }
            ListItem current = nachalo;
            while (current.New != null)
            {
                if (current.New == item)
                {
                    current.New = current.New.New;
                    return;
                }
                current = current.New;
            }
        }
        public ListItem FindItem(string name)
        {
            ListItem current = nachalo;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return current;
                }
                current = current.New;
            }
            return null;
        }
        public void InsertItem(ListItem newItem, ListItem afterItem)
        {
            if (nachalo == null)
            {
                nachalo = newItem;
                return;
            }
            if (afterItem == null)
            {
                newItem.New = nachalo;
                nachalo = newItem;
                return;
            }
            ListItem current = nachalo;
            while (current != null)
            {
                if (current == afterItem)
                {
                    newItem.New = current.New;
                    current.New = newItem;
                    return;
                }
                current = current.New;
            }
        }
        public void PrintList()
        {
            ListItem current = nachalo;
            while (current != null)
            {
                Console.WriteLine("Найден элемент: ФИО: {0}, Дата рождения: {1}, Адрес: {2}, Уровень подготовки (1-5): {3}", current.Name, current.Date.ToShortDateString(), current.Adres, current.Level); ;
                current = current.New;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Добро пожаловать!♥");
                LinkedList list = new LinkedList();
                string[] lines = File.ReadAllLines("Data_Sad14.txt");
                foreach (string line in lines)
                {
                    string[] fields = line.Split(';');
                    ListItem item = new ListItem();
                    item.Name = fields[0];
                    item.Date = DateTime.Parse(fields[1]);
                    item.Adres = fields[2];
                    item.Level = int.Parse(fields[3]);
                    list.AddItem(item);
                }
                while (true)
                {                    
                    Console.WriteLine("Меню:\n1) Просмотр списка\n2) Поиск\n3) Вставка\n4) Удаление\n5) Выход");
                    Console.Write("Выбор: ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            list.PrintList();
                            break;
                        case 2:
                            Console.WriteLine("Введите ФИО ребенка для поиска:");
                            string name = Console.ReadLine();
                            ListItem item = list.FindItem(name);
                            if (item != null)
                            {
                                Console.WriteLine("Найден элемент: ФИО: {0}, Дата рождения: {1}, Адрес: {2}, Уровень подготовки (1-5): {3}", item.Name, item.Date.ToShortDateString(), item.Adres, item.Level);
                            }
                            else
                            {
                                Console.WriteLine("Элемент не найден");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Введите данные для нового элемента (ФИО, Дата рождения (дд.мм.гггг), Адрес, Уровень подготовки (1-5)) через запятую:");
                            string[] fields = Console.ReadLine().Split(',');
                            ListItem newItem = new ListItem();
                            newItem.Name = fields[0];
                            newItem.Date = DateTime.Parse(fields[1]);
                            newItem.Adres = fields[2];
                            newItem.Level = int.Parse(fields[3]);
                            Console.WriteLine("Введите ФИО ребенка, после которой нужно вставить новый элемент (или оставьте пустым, чтобы вставить в начало списка):");
                            string aftername = Console.ReadLine();
                            ListItem afterItem = null;
                            if (!string.IsNullOrEmpty(aftername))
                            {
                                afterItem = list.FindItem(aftername);
                            }
                            list.InsertItem(newItem, afterItem);
                            break;
                        case 4:
                            Console.WriteLine("Введите имя ребенка для удаления:");
                            string nameToRemove = Console.ReadLine();
                            ListItem itemToRemove = list.FindItem(nameToRemove);
                            if (itemToRemove != null)
                            {
                                list.RemoveItem(itemToRemove);
                                Console.WriteLine("Запись удалена");
                            }
                            else
                            {
                                Console.WriteLine("Запись не найдена");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Всего хорошего!");
                            return;
                        default:
                            Console.WriteLine("Неверный выбор");
                            break;
                    }
                }
            }
        }
    }
}
