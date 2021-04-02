/* Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод,
 * принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, 
 * весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название 
 * времени года. Если введено некорректное число, вывести в консоль текст «Ошибка: 
 * введите число от 1 до 12».
 */

using System;

namespace Lesson04_03
{
    enum Seasons
    {
        Winter = 1,
        Spring,
        Summer,
        Autumn
    }

    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            string month_string;
            int month_num;

            Console.Write("Введите номер месяца: ");
            month_string = Console.ReadLine();

            month_num = Convert.ToInt16(month_string);
            if (month_num < 1 || month_num > 12)
                Console.WriteLine("Введите значение от 1 до 12");
            else
                switch (month_num)
                {
                    case 1:
                        Console.WriteLine("Сейчас зима");
                        break;
                    case 2:
                        Console.WriteLine("Сейчас зима");
                        break;
                    case 3:
                        Console.WriteLine("Сейчас зима");
                        break;
                    case 4:
                        Console.WriteLine("Сейчас весна");
                        break;
                    case 5:
                        Console.WriteLine("Сейчас весна");
                        break;
                    case 6:
                        Console.WriteLine("Сейчас весна");
                        break;
                    case 7:
                        Console.WriteLine("Сейчас лето");
                        break;
                    case 8:
                        Console.WriteLine("Сейчас лето");
                        break;
                    case 9:
                        Console.WriteLine("Сейчас лето");
                        break;
                    case 10:
                        Console.WriteLine("Сейчас осень");
                        break;
                    case 11:
                        Console.WriteLine("Сейчас осень");
                        break;
                    case 12:
                        Console.WriteLine("Сейчас осень");
                        break;
                }
        }

    }
}