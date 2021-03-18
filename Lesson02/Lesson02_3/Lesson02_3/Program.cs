//Определить, является ли введённое пользователем число чётным.

using System;

namespace Lesson02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("Введеное число четное");
            }
            else
            {
                Console.Write("Введеное число нечетное");
            }
        }
    }
}