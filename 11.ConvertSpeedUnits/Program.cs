using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceM = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int secondsConverted = ((hours * 60) * 60) + (minutes * 60) + seconds;
            float mPs = (float)distanceM / secondsConverted;

            double hoursConverted = hours + ((double)minutes / 60) + (((double)seconds / 60) / 60);
            float kmH = ((float)distanceM / 1000) / (float)hoursConverted;

            float mpH = (float)((double)distanceM / 1609) / (float)hoursConverted;

            Console.WriteLine($"{mPs}\n{kmH}\n{mpH}");
        }
    }
}
