//	Написать программу, выводящую элементы двухмерного массива по диагонали.

using System;

namespace Lesson03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[7, 7];

            array2D[0, 0] = 1;
            array2D[1, 1] = 1;
            array2D[2, 2] = 1;
            array2D[3, 3] = 1;
            array2D[4, 4] = 1;
            array2D[5, 5] = 1;
            array2D[6, 6] = 1;

            for (int m = 0; m < array2D.GetLength(0); m++)
            {
                for (int n = 0; n < array2D.GetLength(1); n++)
                {
                    Console.Write($" {array2D[m, n]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
