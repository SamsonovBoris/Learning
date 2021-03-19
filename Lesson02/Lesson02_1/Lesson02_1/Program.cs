//Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

using System;

namespace Lesson02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите, минимальную температуру за сутки: ");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите, максимаьную температуру за сутки: ");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            int Temp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Средняя температура: {Temp}");
        }
    }
}