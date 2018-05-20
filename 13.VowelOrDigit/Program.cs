using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var num = 0;
            if (int.TryParse(input, out num))
            {
                Console.WriteLine("digit");
            }
            else if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
