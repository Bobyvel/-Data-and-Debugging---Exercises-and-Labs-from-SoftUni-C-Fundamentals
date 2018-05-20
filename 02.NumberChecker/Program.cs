using System;
using System.Runtime.InteropServices;

namespace _02.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            // first way
            try
            {
                var integer = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");

            }

            //second way
            var input = Console.ReadLine();
            var integer1 = 0l;

            if (long.TryParse(input, out integer1))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }

            //third way

            var number = double.Parse(Console.ReadLine());

            var parsed = (long) number;

            if (parsed == number)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
