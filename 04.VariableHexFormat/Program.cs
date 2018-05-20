using System;

namespace _04.VariableHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexadecimal = Console.ReadLine();

            var converted = Convert.ToInt32(hexadecimal, 16);

            Console.WriteLine(converted);
        }
    }
}
