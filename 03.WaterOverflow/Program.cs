using System;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var tankCapacity = 255;
            var allLitters = 0;

            for (int i = 0; i < lines; i++)
            {
                var toPour = int.Parse(Console.ReadLine());
                if (tankCapacity < toPour)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankCapacity -= toPour;
                    allLitters += toPour;
                }

               
            }
            Console.WriteLine(allLitters);
        }
    }
}
