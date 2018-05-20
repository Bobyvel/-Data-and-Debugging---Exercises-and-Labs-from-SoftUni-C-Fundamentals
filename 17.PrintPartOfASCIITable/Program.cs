using System;

namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            var startChar = int.Parse(Console.ReadLine());
            var endChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
