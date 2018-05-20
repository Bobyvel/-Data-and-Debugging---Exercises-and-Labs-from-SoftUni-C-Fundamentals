using System;

namespace _04.FloatOrInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            // one way
            if (int.TryParse(input, out var num))
            {
                Console.WriteLine(num);
            }
            else
            {
                var number = double.Parse(input);
                Console.WriteLine(Math.Round(number));
            }

            //second way
            try
            {
                var number = int.Parse(input);
                Console.WriteLine(number);
            }
            catch (Exception)
            {
                var number = double.Parse(input);
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
