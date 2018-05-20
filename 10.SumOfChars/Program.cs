using System;
using System.Text;

namespace _10.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < lines; i++)
            {
                var chars = char.Parse(Console.ReadLine());

                sum += chars; //към int

            }

            Console.WriteLine($"The sum equals: {sum}");
        
        }
    }
}
