using System;
using System.Numerics;

namespace _03.BigPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var number = BigInteger.Pow(n, n);

            Console.WriteLine(number);
        }
    }
}
