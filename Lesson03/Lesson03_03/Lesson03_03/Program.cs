/* Написать программу, выводящую введенную пользователем 
   строку в обратном порядке (olleH вместо Hello). */

using System;

namespace Lesson03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            for (int x = text.Length - 1; x >= 0; x--)
            {
                Console.Write(text[x]);
            }
        }
    }
}