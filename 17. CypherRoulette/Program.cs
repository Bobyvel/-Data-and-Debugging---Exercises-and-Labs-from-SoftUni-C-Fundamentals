using System;
using System.Text;

namespace _17._CypherRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var cypherString = new StringBuilder();
            var lastText = string.Empty;
            var spinCount = 0;

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                
                if (lastText == input)
                {
                    cypherString.Clear();
                    if (lastText == "spin")
                    {
                        i--;
                    }
                    continue;
                }

                lastText = input;

                if (input == "spin")
                {
                    spinCount++;
                    i--;
                    continue;
                }

                if (spinCount % 2 == 1)
                {
                    cypherString.Insert(0, input);
                }
                else
                {
                    cypherString.Append(input);
                }
                
            }

            Console.WriteLine(cypherString);
        }
    }
}
