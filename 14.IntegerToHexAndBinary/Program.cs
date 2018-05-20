using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var hex = Convert.ToString(number, 16).ToUpper();
            var binary = Convert.ToString(number, 2).ToUpper();

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
