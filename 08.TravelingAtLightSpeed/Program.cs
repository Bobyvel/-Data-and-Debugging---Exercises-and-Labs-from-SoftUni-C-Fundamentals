using System;

namespace _08.TravelingAtLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            var lightYears = decimal.Parse(Console.ReadLine());

            var lightYearInKm = 9450000000000M;
            var speedOfLight = 300000M;

            var total = (lightYearInKm / speedOfLight) * lightYears;

            var span = (TimeSpan.FromSeconds((double)total));

            var weeks = span.Days / 7;
            var days = span.Days % 7;
            var hours = span.Hours;
            var minutes = span.Minutes;
            var seconds = span.Seconds;


            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{seconds} seconds");
        }
    }
}
