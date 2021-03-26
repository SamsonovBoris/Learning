//Определить, является ли введённое пользователем число чётным.

using System;

namespace Lesson02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

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