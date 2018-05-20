using System;
using System.Numerics;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var parsedNumber = BigInteger.Parse(input);

            if (parsedNumber > long.MaxValue || parsedNumber < long.MinValue)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{parsedNumber} can fit in:");
                if (parsedNumber >= sbyte.MinValue && parsedNumber <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }

                if (parsedNumber >= byte.MinValue && parsedNumber <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }

                if (parsedNumber >= short.MinValue && parsedNumber <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }

                if (parsedNumber >= ushort.MinValue && parsedNumber <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }

                if (parsedNumber >= int.MinValue && parsedNumber <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }

                if (parsedNumber >= uint.MinValue && parsedNumber <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }

                if (parsedNumber >= long.MinValue && parsedNumber <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
        }
    }
}
