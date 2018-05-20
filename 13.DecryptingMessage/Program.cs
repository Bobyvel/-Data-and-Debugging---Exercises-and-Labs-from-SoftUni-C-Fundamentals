using System;
using System.Text;

namespace _13.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = byte.Parse(Console.ReadLine());
            var lines = byte.Parse(Console.ReadLine());
            var word = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                word.Append((char)(letter + key));
            }

            Console.WriteLine(word);
        }
    }
}
