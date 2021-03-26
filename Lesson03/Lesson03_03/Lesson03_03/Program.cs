/* Написать программу, выводящую введенную пользователем 
   строку в обратном порядке (olleH вместо Hello). */

using System;

namespace Lesson03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст:");
            string source = Convert.ToString(Console.Read());

            //string source = "abcd";
            for (int index = source.Length - 1; index >= 0; --index)
            {
                Console.Write(source[index]);
            }
            // выведет dcba


        }
    }
}