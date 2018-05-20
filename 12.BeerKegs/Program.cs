using System;

namespace _12.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var bigestKegVolume = 0d;
            var modelOfBiggestKeg = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                var volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > bigestKegVolume)
                {
                    bigestKegVolume = volume;
                    modelOfBiggestKeg = model;
                }
            }

            Console.WriteLine(modelOfBiggestKeg);
        }
    }
}
