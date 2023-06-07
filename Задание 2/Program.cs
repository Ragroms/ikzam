﻿namespace Задание_2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // исходный массив
            int flag = arr[0] % 2; // флаг, который показывает, четное или нечетное число должно следовать
            int i = 1;
            while (i < arr.Length && arr[i] % 2 != flag)
            {
                i++;
            }
            if (i == arr.Length)
            {
                Console.WriteLine(0); // если чередуются, то выводим 0
            }
            else
            {
                Console.WriteLine(i); // если не чередуются, то выводим порядковый номер первого элемента, нарушающего закономерность
            }
        }
    }
}