using System;
using System.Text;

namespace _11.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimeter = Console.ReadLine();
            var evenOrOdd = Console.ReadLine() == "even" ? 0 : 1;
            var lines = int.Parse(Console.ReadLine());

            var sentence = new StringBuilder();

            for (int i = 1; i <= lines; i++)
            {
                var word = Console.ReadLine();
                 
                    if (i % 2 == evenOrOdd)
                    {
                        sentence.Append(word + delimeter);
                    }
                
            }

            sentence.Remove(sentence.Length -1, 1);
            Console.WriteLine(sentence);

            

        }
    }
}
