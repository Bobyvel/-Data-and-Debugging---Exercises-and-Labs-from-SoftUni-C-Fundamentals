using System;

namespace _02.CirclePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            var perimeter = 2 * r * Math.PI;

            Console.WriteLine($"{perimeter:F12}");
        }
    }
}
