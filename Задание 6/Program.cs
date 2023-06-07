using System;
using System.Collections.Generic;
using System.IO;

    class Program // Исходная информация содержится в файле. Определить, сколько слов текста имеют длину 1,2,3,…, 10 и более 10 символов. Вывести эти слова в последовательности возрастания их длины. Слова очередной длины вывести с новой строки.
    {
        static void Main()
        {
            // Считываем содержимое файла в строку
            string text = File.ReadAllText("input.txt");

            // Разбиваем строку на слова и переводим в нижний регистр
            string[] words = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
            }

            // Создаем словарь для подсчета количества слов каждой длины
            Dictionary<int, int> wordLengths = new Dictionary<int, int>();
            for (int i = 1; i <= 10; i++)
            {
                wordLengths[i] = 0;
            }
            wordLengths[11] = 0;

            // Подсчитываем количество слов каждой длины
            foreach (string word in words)
            {
                int length = word.Length;
                if (length <= 10)
                {
                    wordLengths[length]++;
                }
                else
                {
                    wordLengths[11]++;
                }
            }

            // Выводим слова по длинам в порядке возрастания
            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine("{0} символов: {1}", i, wordLengths[i]);
            }
        }
    }

