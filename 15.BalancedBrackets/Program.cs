using System;

namespace _15.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = byte.Parse(Console.ReadLine());
            var openingBraket = "(";
            var closingBraket = ")";
            var openingBraketCount = 0;
            var closingBraketCount = 0;

            for (int i = 0; i < lines; i++)
            {
                 var input = Console.ReadLine();


                if ((input == closingBraket && openingBraketCount == closingBraketCount) || (input == openingBraket && closingBraketCount < openingBraketCount))
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

                if (input == openingBraket)
                {
                    openingBraketCount++;
                }
                else if (input == closingBraket)
                {
                    closingBraketCount++;
                }
            }

            if (openingBraketCount == closingBraketCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            
        }
    }
}
    

