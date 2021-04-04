// Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

using System;
using System.IO;

namespace Lesson05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите произвольный набор сиволов: ");
            string symbolString = Console.ReadLine();

            string filename = "/Users/b.samsonov/Documents/test.txt";
            File.WriteAllText(filename, symbolString); // записываем в файл строку
        }
    }
}