using System;

namespace Lesson04_01
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] array = { "One", "Two", "Three" };
            string[] replacedByRef = ReplaceArrayByRef(ref array);
            string[] replaced = ReplaceArray(array);

            Console.WriteLine("array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"- {array[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("replaced: ");
            for (int i = 0; i < replaced.Length; i++)
            {
                Console.Write($"{replaced[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("replacedByRef: ");
            for (int i = 0; i < replacedByRef.Length; i++)
            {
                Console.Write($"{replacedByRef[i]} ");
            }
            Console.WriteLine();
        }

        static string[] ReplaceArray(string[] data)
        {
            data = new[] { "replaced", "replaced", "replaced" };
            return data;
        }

        static string[] ReplaceArrayByRef(ref string[] data)
        {
            data = new[] { "ref", "ref", "ref" };
            return data;
        }


    }

}

