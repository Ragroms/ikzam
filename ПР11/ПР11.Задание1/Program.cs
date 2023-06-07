namespace Пр11
{
    internal class Program // Определить и вывести: количество предложений и слов каждого предложения; тексткаждого предложения в отдельной строке. Даны 2 слова. Определить, есть ли они в тексте и сколько раз каждое из них встречается в тексте.Если их в тексте нет, дать соответствующее сообщение.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!♥");
            string filePath = "ПР11 блакнот.txt";

            // Считываем текст из файла
            string text = File.ReadAllText(filePath);

            // Заданные слова
            Console.WriteLine("Ввудите первое слово: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Ввудите второе слово: ");
            string word2 = Console.ReadLine();

            // Поиск и подсчет вхождений слов в текст
            int resultWord1 = text.Split(' ','.',',','!',';','♥','☻','/',':','?').Count(w => w == word1);
            int resultWord2 = text.Split(' ','.',',','!',';','♥','☻','/',':','?').Count(w => w == word2);

            // Вывод результата
            if (resultWord1 == 0 && resultWord2 == 0)
            {
                Console.WriteLine($"Слова '{word1}' и '{word2}' не найдены в тексте.");
            }
            else
            {
                Console.WriteLine($"Слово '{word1}' встречается в тексте {resultWord1} раз(а).");
                Console.WriteLine($"Слово '{word2}' встречается в тексте {resultWord2} раз(а).");
            }

            Console.ReadKey();
        }
    }
}