using System;
using System.Numerics;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());
            var years = centuries * 100;
            var days = (int)(years * 365.2422);
            var hours = days * 24;
            var minutes = (ulong)hours * 60;
            var seconds = minutes * 60;
            var milliseconds = seconds * 1000;
            var microseconds = BigInteger.Multiply(milliseconds, 1000);
            var nanoseconds = BigInteger.Multiply(microseconds, 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
