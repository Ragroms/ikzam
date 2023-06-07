namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку S:");
            string S = Console.ReadLine();
            Console.WriteLine("Введите строку S1:");
            string S1 = Console.ReadLine();
            Console.WriteLine("Введите строку S2:");
            string S2 = Console.ReadLine();

            string result = S.Replace(S1, S2);
            Console.WriteLine("Результат замены: " + result);
        }
    }
}