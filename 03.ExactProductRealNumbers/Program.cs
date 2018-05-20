using System;

namespace _03.ExactProductRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var product = 1M;
            for (int i = 0; i < lines; i++)
            {
                var number = decimal.Parse(Console.ReadLine());
                product *= number;
            }

            Console.WriteLine(product);
        }
    }
}
