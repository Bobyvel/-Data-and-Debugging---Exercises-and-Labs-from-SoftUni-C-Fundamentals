using System;
using System.Text;

namespace _09.MakeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var word = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();

                word.Append(input);
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
