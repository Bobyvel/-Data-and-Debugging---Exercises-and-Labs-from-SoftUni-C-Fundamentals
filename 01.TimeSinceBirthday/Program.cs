using System;

namespace _01.TimeSinceBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            var days = year * 365;
            var hours = days * 24;
            var minutes = hours * 60;

            Console.WriteLine($"{year} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}
