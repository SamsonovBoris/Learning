/*	Написать метод GetFullName(string firstName, string lastName, string patronymic),  
    принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
    Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.  */

using System;

namespace Lesson04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите вашу фамилию: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите ваше имя: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Введите ваше отчество: ");
                string patronymic = Console.ReadLine();

                string fio = GetFullName(lastName, firstName, patronymic);
                Console.WriteLine($"Полное имя пользователя {fio}");
            }
        }
        static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}