using System;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = int.Parse(Console.ReadLine());

            var capacity = 24;

            var courses = Math.Ceiling(persons / (double)capacity);

            Console.WriteLine(courses);
        }
    }
}
