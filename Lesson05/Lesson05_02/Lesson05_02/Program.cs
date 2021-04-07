// Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

using System.IO;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateTime GetNowTime = DateTime.Now;
            string stringTime = Convert.ToString(GetNowTime);
            string fileName = "startup.txt";
            
            File.AppendAllLines(fileName, new[] {stringTime});
        }
    }
}
