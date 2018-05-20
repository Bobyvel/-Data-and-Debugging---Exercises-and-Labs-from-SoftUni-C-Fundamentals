using System;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    var metricUnits = "kilometers";
                    var toConvert = 1.6;
                    Console.WriteLine($"{value} {unit} = {(value * toConvert):F2} {metricUnits}");
                   break;
                case "inches":
                    metricUnits = "centimeters";
                    toConvert = 2.54;
                    Console.WriteLine($"{value} {unit} = {(value * toConvert):F2} {metricUnits}");
                    break;
                case "feet":
                    metricUnits = "centimeters";
                    toConvert = 30;
                    Console.WriteLine($"{value} {unit} = {(value * toConvert):F2} {metricUnits}");
                    break;
                case "yards":
                    metricUnits = "meters";
                    toConvert = 0.91;
                    Console.WriteLine($"{value} {unit} = {(value * toConvert):F2} {metricUnits}");
                    break;
                case "gallons":
                    metricUnits = "liters";
                    toConvert = 3.8;
                    Console.WriteLine($"{value} {unit} = {(value * toConvert):F2} {metricUnits}");
                    break;
            }
        }
    }
}
