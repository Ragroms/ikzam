namespace Задание_7
{
    using System;

    class Program
    {
        static void Main()
        {
            string str = "Hello world! This is a sample string.";
            char ch = '.';

            int count = CountWordsEndingWith(str, ch);

            Console.WriteLine($"Количество слов, оканчивающихся на символ '{ch}': {count}");
        }

        static int CountWordsEndingWith(string str, char ch)
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            foreach (string word in words)
            {
                if (word.EndsWith(ch.ToString()))
                {
                    count++;
                }
            }

            return count;
        }
    }
}