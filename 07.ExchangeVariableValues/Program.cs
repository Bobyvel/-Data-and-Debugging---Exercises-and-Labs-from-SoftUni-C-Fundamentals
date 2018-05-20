using System;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\na = {a}\nb = {b}");

        }
    }
}
