using System;

namespace _01.IntegerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = byte.Parse(Console.ReadLine());
            var num2 = uint.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = long.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} {num2} {num3} {num4}");

           
        }
    }
}
