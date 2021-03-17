using System;

namespace Learning2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}! Сегодня [{DateTime.Now}]");
        }
    }
}
