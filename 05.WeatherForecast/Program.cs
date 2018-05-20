using System;

namespace _05.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var weather = string.Empty;

            if (sbyte.TryParse(input, out sbyte numSbyte))
            {
                weather = "Sunny";
            }else if (int.TryParse(input, out int numInt))
            {
                weather = "Cloudy";
            }else if (long.TryParse(input, out long numLong))
            {
                weather = "Windy";
            }
            else
            {
                weather = "Rainy";
            }

            Console.WriteLine(weather);
        }
    }
}
