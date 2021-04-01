/* Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
   и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и 
   вывести результат на экран. */

using System;

namespace Lesson04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите набор чисел, разделенных пробелом: ");
            string input = Console.ReadLine();

            string[] array = input.Split();
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array2.Length; i++)
                 array2[i] = int.Parse(array[i]);

            int sum = 0;
            foreach (int value in array2)
            {
                sum += value;
            }
            
            Console.WriteLine($"Сумма введенных чисел: {sum}");
        }
    }
}
